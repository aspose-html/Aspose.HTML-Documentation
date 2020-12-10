using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Net;
using Aspose.Html.Saving;
using Aspose.Html.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests
{
    public class LogMessageHandler : MessageHandler
    {
        private List<string> errors = new List<string>();

        public List<string> ErrorMessages
        {
            get { return errors; }
        }

        public override void Invoke(INetworkOperationContext context)
        {
            // Check whether response is OK
            if (context.Response.StatusCode != HttpStatusCode.OK)
            {
                // Set error information
                errors.Add(string.Format("File '{0}' Not Found", context.Request.RequestUri));
            }

            // Invoke the next message handler in the chain
            Next(context);
        }
    }
    public class EnvironmentConfigurationTests : TestsBase
    {
        public EnvironmentConfigurationTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("configurations");
        }
        [Fact(DisplayName = "Sandboxing")]
        public void SandboxingTest()
        {
            // Prepare an HTML code and save it to a file
            var code = "<span>Hello World!!</span> " +
                       "<script>document.write('Have a nice day!');</script>";

            File.WriteAllText(Path.Combine(OutputDir, "sandboxing.html"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Mark 'scripts' as an untrusted resource
                configuration.Security |= Sandbox.Scripts;

                // Initialize an HTML document with specified configuration
                using (var document = new HTMLDocument(Path.Combine(OutputDir, "sandboxing.html"), configuration))
                {
                    // Convert HTML to PDF
                    Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "sandboxing.pdf"));

                    Assert.True(document.QuerySelectorAll("script").Length > 0);
                }
                Assert.True(File.Exists(Path.Combine(OutputDir, "sandboxing.pdf")));
            }            
        }
            [Fact(DisplayName = "User Agent Service StyleSheet")]
        public void UserAgentServiceStyleSheetTest()
        {
            // Prepare an HTML code and save it to a file
            var code = "<h1>User Agent Service </h1>\r\n" +
                       "<p>The <b>User Agent Service</b> allows you to specify a custom user stylesheet, <br>a primary character set for the document, language and fonts settings.</p>\r\n";
                       
            File.WriteAllText(Path.Combine(OutputDir, "user-agent.html"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Get the IUserAgentService
                var userAgentService = configuration.GetService<IUserAgentService>();

                // Set the custom style parameters for the "h1" and "p" elements
                userAgentService.UserStyleSheet = "h1 { color:#a52a2a;; font-size:2em;}\r\n" +
                                                  "p { background-color:GhostWhite; color:SlateGrey; font-size:1.2em; }\r\n";
                                
                // Initialize the HTML document with specified configuration
                using (var document = new HTMLDocument(Path.Combine(OutputDir, "user-agent.html"), configuration))
                {                   
                    // Convert HTML to PDF
                    Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "user-agent.pdf"));

                    Assert.Equal("HTML", document.DocumentElement.TagName);
                }
            }
        }
        [Fact(DisplayName = "User Agent Service Character Set")]
        public void UserAgentServiceCharacterSetTest()
        {
            // Prepare an HTML code and save it to a file
            var code = "<h1>Character Set</h1>\r\n" +
                       "<p>The <b>CharSet</b> property sets the primary character-set for a document.</p>\r\n";

            File.WriteAllText(Path.Combine(OutputDir, "charset.html"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Get the IUserAgentService
                var userAgentService = configuration.GetService<IUserAgentService>();

                // Set the custom style parameters for the "h1" and "p" elements
                userAgentService.UserStyleSheet = "h1 { color:salmon; }\r\n" +
                                                  "p { background-color: #f0f0f0; color:DarkCyan; font-size:1.2em; }\r\n";

                // Set ISO-8859-1 encoding to parse the document
                userAgentService.CharSet = "ISO-8859-1";
                                
                // Initialize the HTML document with specified configuration
                using (var document = new HTMLDocument(Path.Combine(OutputDir, "charset.html"), configuration))
                {
                    // Convert HTML to PDF
                    Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "charset.pdf"));

                    Assert.Equal("HTML", document.DocumentElement.TagName);
                }
                Assert.True(File.Exists(Path.Combine(OutputDir, "charset.pdf")));
            }
        }
        [Fact(DisplayName = "User Agent Service Font Setting")]
        public void UserAgentServiceFontSettingTest()
        {
            // Prepare an HTML code and save it to a file
            var code = "<h1>FontsSettings property</h1>\r\n" +
                       "<p>The FontsSettings property is used for configuration of fonts handling.</p>\r\n";

            File.WriteAllText(Path.Combine(OutputDir, "font-setting.html"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Get the IUserAgentService
                var userAgentService = configuration.GetService<IUserAgentService>();

                // Set the custom style parameters for the "h1" and "p" elements
                userAgentService.UserStyleSheet = "h1 { color:#a52a2a; }\r\n" +
                                                  "p { color:grey; }\r\n";
                          
                // Set custom font folder path
                userAgentService.FontsSettings.SetFontsLookupFolder(Path.Combine(DataDir + "fonts"));

                // Initialize the HTML document with specified configuration
                using (var document = new HTMLDocument(Path.Combine(OutputDir, "font-setting.html"), configuration))
                {
                    // Convert HTML to PDF
                    Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "font-setting.pdf"));
                }
                Assert.True(File.Exists(Path.Combine(OutputDir, "font-setting.pdf")));
            }
        }
        [Fact(DisplayName = "Runtime Service Test")]
        public void RuntimeServiceTest()
        {
            // Prepare an HTML code and save it to a file
            var code = "<h1>Runtime Service</h1>\r\n" +
                       "<script> while(true) {} </script>\r\n" +
                       "<p>The Runtime Service optimizes your system by helping it start apps and programs faster.</p>\r\n";

            File.WriteAllText(Path.Combine(OutputDir, "runtime.html"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Limit JS execution time to 5 seconds
                var runtimeService = configuration.GetService<IRuntimeService>();
                runtimeService.JavaScriptTimeout = TimeSpan.FromSeconds(5);

                // Initialize an HTML document with specified configuration
                using (var document = new HTMLDocument(Path.Combine(OutputDir, "runtime.html"), configuration))
                {
                    // Convert HTML to PNG
                    Converter.ConvertHTML(document, new ImageSaveOptions(), Path.Combine(OutputDir, "runtime.png"));
                }
                Assert.True(File.Exists(Path.Combine(OutputDir, "runtime_1.png")));
            }            
        }
        [Fact(DisplayName = "Network Service Test")]
        public void NetworkServiceTest()
        {
            // Prepare an HTML code and save it to a file
            var code = "<img src=\"https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/park.jpg\" >\r\n" +
                       "<img src=\"https://docs.aspose.com/html/net/missing1.jpg\" >\r\n" +
                       "<img src=\"https://docs.aspose.com/html/net/missing2.jpg\" >\r\n";

            File.WriteAllText(Path.Combine(OutputDir, "network service.html"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Add LogMessageHandler to the chain of existing message handlers
                var networkService = configuration.GetService<INetworkService>();

                var logHandler = new LogMessageHandler();
                networkService.MessageHandlers.Add(logHandler);

                // Initialize an HTML document with specified configuration
                using (var document = new HTMLDocument(Path.Combine(OutputDir, "network service.html"), configuration))
                {
                    //Convert HTML to PNG
                    Converter.ConvertHTML(document, new ImageSaveOptions(), Path.Combine(OutputDir, "network.png"));

                    // Print the List of ErrorMessages
                    foreach (string errorMessage in logHandler.ErrorMessages)
                    {
                        Output.WriteLine(errorMessage);
                    }
                    Assert.False(document.QuerySelectorAll("img").Length > 3);
                }               
            }
        }
    }
}
