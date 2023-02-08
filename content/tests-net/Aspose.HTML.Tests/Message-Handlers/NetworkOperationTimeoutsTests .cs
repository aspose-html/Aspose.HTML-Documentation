using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Net;
using Aspose.Html.Saving;
using Aspose.Html.Services;
//using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Message_Handlers
{
    public class NetworkOperationTimeoutsTests : TestsBase
    {
        public NetworkOperationTimeoutsTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("message-handler");
        }

        public class TimeoutMessageHandler : MessageHandler
        {
            public override void Invoke(INetworkOperationContext context)
            {
                context.Request.Timeout = TimeSpan.FromSeconds(1);
                Next(context);
            }
        }


        [Fact(DisplayName = "Network Operation Timeouts - Open a File")]
        public void NetworkTimeoutsOpenTest()
        {
            // Create an instance of the Configuration class
            using var configuration = new Configuration();

            // Call the INetworkService which contains the functionality for managing network operations
            var network = configuration.GetService<INetworkService>();

            // Add the TimeoutMessageHandler to the top of existing message handler chain
            network.MessageHandlers.Insert(0, new TimeoutMessageHandler());

            // Prepare path to a source document file
            string documentPath = Path.Combine(DataDir, "document.html");            

            // Create an HTML document with a custom configuration
            using var document = new HTMLDocument(documentPath, configuration);

            Assert.True(File.Exists(documentPath));
        }


        [Fact(DisplayName = "Network Operation Timeouts - Conversion")]
        public void NetworkTimeoutsConvertTest()
        {
            // Create an instance of the Configuration class
            using var configuration = new Configuration();

            // Call the INetworkService which contains the functionality for managing network operations
            var network = configuration.GetService<INetworkService>();

            // Add the TimeoutMessageHandler to the top of existing message handler chain
            network.MessageHandlers.Insert(0, new TimeoutMessageHandler());

            // Prepare path to a source document file
            string documentPath = Path.Combine(DataDir, "document.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "document.pdf");

            // Convert HTML to PDF with customized configuration
            Converter.ConvertHTML(documentPath, configuration, new PdfSaveOptions(), savePath);

            Assert.True(File.Exists(savePath));
        }
    }    
}
