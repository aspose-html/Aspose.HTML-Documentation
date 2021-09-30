﻿using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Net.MessageFilters;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Services;
using Aspose.Zip;
using System;
using System.IO;
using System.Linq;
using System.Net;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Message_Handlers
{
    public class ConvertZIPtoPDFTests : TestsBase
    {
        public ConvertZIPtoPDFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("message-handler");
        }

        // This message handler prints a message about start and finish processing request
        class ZipArchiveMessageHandler : MessageHandler, IDisposable
        {
            private string filePath;
            private Archive archive;

            // Initialize an instance of the ZipArchiveMessageHandler class
            public ZipArchiveMessageHandler(string path)
            {
                this.filePath = path;
                Filters.Add(new ProtocolMessageFilter("zip"));
            }

            // Override the Invoke() method
            public override void Invoke(INetworkOperationContext context)
            {
                // Call the GetFile() method that defines the logic in the Invoke() method
                var buff = GetFile(context.Request.RequestUri.Pathname.TrimStart('/'));
                if (buff != null)
                {
                    // Checking: if a resource is found in the archive, then return it as a Response
                    context.Response = new ResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new ByteArrayContent(buff)
                    };
                    context.Response.Headers.ContentType.MediaType = MimeType.FromFileExtension(context.Request.RequestUri.Pathname);
                }
                else
                {
                    context.Response = new ResponseMessage(HttpStatusCode.NotFound);
                }

                // Call the next message handler
                Next(context);
            }

            byte[] GetFile(string path)
            {
                path = path.Replace(@"\", @"/");
                var result = GetArchive().Entries.FirstOrDefault(x => path == x.Name);
                if (result != null)
                {
                    using (var fs = result.Open())
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        return ms.ToArray();
                    }
                }
                return null;
            }

            Archive GetArchive()
            {
                return archive ??= new Archive(filePath);
            }

            public void Dispose()
            {
                archive?.Dispose();
            }
        }


        [Fact(DisplayName = "Convert Zip to PDF")]
        public void ConvertZIPtoPDFTest()
        {
            // Prepare path to a source zip file
            string documentPath = Path.Combine(DataDir, "test.zip");

            // Prepare path for converted file saving
            string savePath = Path.Combine(OutputDir, "zip-to-pdf.pdf");

            // Create an instance of ZipArchiveMessageHandler
            using var zip = new ZipArchiveMessageHandler(documentPath);

            // Create an instance of the Configuration class
            using var configuration = new Configuration();

            // Add ZipArchiveMessageHandler to the chain of existing message handlers
            configuration
                .GetService<INetworkService>()
                .MessageHandlers.Add(zip);            

            // Initialize an HTML document with specified configuration
            using var document = new HTMLDocument("zip:///test.html", configuration);

            // Create the PDF Device  
            using var device = new PdfDevice(savePath);

            // Render ZIP to PDF
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));

        }        
    }
}
