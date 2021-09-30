using System;
using System.Diagnostics;
using System.IO;
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Services;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Message_Handlers
{
   public class WebRequestExecutionTimeTests : TestsBase
    {
        public WebRequestExecutionTimeTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("message-handler");
        }

        // Define the TimeLoggerMessageHandler class that is derived from the MessageHandler class
        public class TimeLoggerMessageHandler : MessageHandler
        {
            // Override the Invoke() method
            public override void Invoke(INetworkOperationContext context)
            {
                // Start the stopwatch
                var stopwatch = Stopwatch.StartNew();

                // Invoke the next message handler in the chain
                Next(context);

                // Stop the stopwatch
                stopwatch.Stop();

                // Print the result
                Debug.WriteLine("Request: " + context.Request.RequestUri);
                Debug.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + "ms");
            }
        }

       
        [Fact(DisplayName = "Web Request Execution Time")]
        public void WebRequestExecutionTimeTest()
        {
            // Create an instance of the Configuration class
            using var configuration = new Configuration();

            // Add the TimeLoggerMessageHandler to the chain of existing message handlers
            var service = configuration.GetService<INetworkService>();
            var handlers = service.MessageHandlers;
           
            handlers.Insert(0, new TimeLoggerMessageHandler());

            // Prepare path to a source document file
            string documentPath = Path.Combine(DataDir, "input.htm");

            // Initialize an HTML document with specified configuration
            using var document = new HTMLDocument(documentPath, configuration);

            Assert.True(File.Exists(documentPath));
        }
        
    }
}
