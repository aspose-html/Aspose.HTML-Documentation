using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Services;
using Aspose.Zip;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Message_Handlers
{
    public class ZiptoPDFTimeLoggingTests : TestsBase
    {
        public ZiptoPDFTimeLoggingTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("message-handler");
        }

        // Define the RequestDurationLoggingMessageHandler class that is derived from the MessageHandler class
        abstract class RequestDurationLoggingMessageHandler : MessageHandler
        {
            private static ConcurrentDictionary<Url, Stopwatch> requests = new ConcurrentDictionary<Url, Stopwatch>();

            protected void StartTimer(Url url)
            {
                requests.TryAdd(url, Stopwatch.StartNew());
            }

            protected TimeSpan StopTimer(Url url)
            {
                var timer = requests[url];
                timer.Stop();
                return timer.Elapsed;
            }
        }

        class StartRequestDurationLoggingMessageHandler : RequestDurationLoggingMessageHandler
        {
            // Override the Invoke() method
            public override void Invoke(INetworkOperationContext context)
            {
                // Start the stopwatch
                StartTimer(context.Request.RequestUri);

                // Invoke the next message handler in the chain
                Next(context);
            }
        }

        class StopRequestDurationLoggingMessageHandler : RequestDurationLoggingMessageHandler
        {
            // Override the Invoke() method
            public override void Invoke(INetworkOperationContext context)
            {
                // Stop the stopwatch
                var duration = StopTimer(context.Request.RequestUri);

                // Print the result
                Debug.WriteLine($"Elapsed: {duration:g}, resource: {context.Request.RequestUri.Pathname}");

                // Invoke the next message handler in the chain
                Next(context);
            }
        }

        // Define the CustomSchemaMessageFilter class that is derived from the MessageFilter class
        class CustomSchemaMessageFilter : MessageFilter
        {
            private readonly string schema;
            public CustomSchemaMessageFilter(string schema)
            {
                this.schema = schema;
            }
            // Override the Match() method
            public override bool Match(INetworkOperationContext context)
            {
                return string.Equals(schema, context.Request.RequestUri.Protocol.TrimEnd(':'));
            }
        }

        // Define the CustomSchemaMessageHandler class that is derived from the MessageHandler class
        abstract class CustomSchemaMessageHandler : MessageHandler
        {
            // Initialize an instance of the CustomSchemaMessageHandler class
            protected CustomSchemaMessageHandler(string schema)
            {
                Filters.Add(new CustomSchemaMessageFilter(schema));
            }
        }

        // Define the ZipFileSchemaMessageHandler class that is derived from the CustomSchemaMessageHandler class
        class ZipFileSchemaMessageHandler : CustomSchemaMessageHandler
        {
            private readonly Archive archive;

            public ZipFileSchemaMessageHandler(Archive archive) : base("zip-file")
            {
                this.archive = archive;
            }

            // Override the Invoke() method
            public override void Invoke(INetworkOperationContext context)
            {
                var pathInsideArchive = context.Request.RequestUri.Pathname.TrimStart('/').Replace("\\", "/");
                var stream = GetFile(pathInsideArchive);

                if (stream != null)
                {
                    // If a resource is found in the archive, then return it as a Response
                    var response = new ResponseMessage(HttpStatusCode.OK);
                    response.Content = new StreamContent(stream);
                    response.Headers.ContentType.MediaType = MimeType.FromFileExtension(context.Request.RequestUri.Pathname);
                    context.Response = response;
                }
                else
                {
                    context.Response = new ResponseMessage(HttpStatusCode.NotFound);
                }

                // Invoke the next message handler in the chain
                Next(context);
            }

            Stream GetFile(string path)
            {
                var result = archive
                    .Entries
                    .FirstOrDefault(x => x.Name == path);
                return result?.Open();
            }
        }

        [Fact(DisplayName = "ZIP to PDF - Execution Time Logging")]
        public void ZIPtoPDFTimeLoggingTest()
        {
            // Prepare path to a source zip file
            string documentPath = Path.Combine(DataDir, "test.zip");

            // Prepare path for converted file saving
            string savePath = Path.Combine(OutputDir, "zip-to-pdf-duration.pdf");

            // Create an instance of the Configuration class
            using var configuration = new Configuration();
            var service = configuration.GetService<INetworkService>();
            var handlers = service.MessageHandlers;

            // Custom Schema: ZIP. Add ZipFileSchemaMessageHandler to the end of the pipeline
            handlers.Add(new ZipFileSchemaMessageHandler(new Archive(documentPath)));

            // Duration Logging. Add the StartRequestDurationLoggingMessageHandler at the first place in the pipeline
            handlers.Insert(0, new StartRequestDurationLoggingMessageHandler());

            // Add the StopRequestDurationLoggingMessageHandler to the end of the pipeline
            handlers.Add(new StopRequestDurationLoggingMessageHandler());

            // Initialize an HTML document with specified configuration
            using var document = new HTMLDocument("zip-file:///test.html", configuration);

            // Create the PDF Device
            using var device = new PdfDevice(savePath);

            // Render ZIP to PDF
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }
    }
}
