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
    
    
    public class LogMessageHandlerTests : TestsBase
    {
        public LogMessageHandlerTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("message-handler");
        }

        // This message handler prints a message about start and finish processing request
        public class LogMessageHandler : MessageHandler
        {
            // Override the Invoke() method
            public override void Invoke(INetworkOperationContext context)
            {
                Debug.WriteLine("Start processing request: " + context.Request.RequestUri);

                // Invoke the next message handler in the chain
                Next(context);

                Debug.WriteLine("Finish processing request: " + context.Request.RequestUri);
            }
        }

        [Fact(DisplayName = "Create a Custom Message Handler")]
        public void CreateACustomMessageHandlerTest()
        {
            // Create an instance of the Configuration class
            using var configuration = new Configuration();

            // Add the LogMessageHandler to the chain of existing message handlers
            var service = configuration.GetService<INetworkService>();
            var handlers = service.MessageHandlers;
                    
            handlers.Insert(0, new LogMessageHandler());

            // Prepare path to a source document file
            string documentPath = Path.Combine(DataDir, "input.htm");

            // Initialize an HTML document with specified configuration
            using var document = new HTMLDocument(documentPath, configuration);

            Assert.Contains("<html>", document.DocumentElement.OuterHTML);
        }
    }
}
