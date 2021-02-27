---
title: Environment Configuration
type: docs
weight: 10
aliases: /net/environment-configuration/
description: Sandboxing, Sandbox.Scripts, User Agent Service, User Style Sheet, Runtime Service, Character Set, FontsSettings property, Network Service, Message Handlers
---
<link href="./../style.css" rel="stylesheet" type="text/css" />

It is often helpful to have different configurations based on the environment where the application is running. For example, you may wish to configure the scripts policy, override document style applying a custom user stylesheet, or handle any web requests from the application. Aspose.HTML provides the [**Configuration**](https://apireference.aspose.com/net/html/aspose.html/configuration) class that can be used exactly for these purposes.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  
## **Sandboxing**
A *sandboxing flag* set is a set of zero or more of the flags, which are used to restrict the abilities that potentially untrusted resources. The sandbox attribute allows you to set a number of restrictions on the content loaded in the frame, for example, block forms and scripts. This improves the security of the current document, especially when a document is loaded into the frame from an unverified source.

The following example demonstrates how to mark ‘Scripts’ as an untrusted resource. As a result, 'Scripts' will be disabled during the application execution.
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare HTML code and save it to a file
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
            Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "sandboxing_out.pdf"));
        }
    }
{{< /highlight >}}

## **Services**
All important functional is grouped into separated services for usability purpose and located into [**Aspose.Html.Services**](https://apireference.aspose.com/net/html/aspose.html.services/) namespace.
### **User Agent Service**
The **User Agent Service** allows you to specify a custom user stylesheet, a primary character set for the document, language and fonts settings. You can specify your custom style information for a particular document and provide as little or as much environment configuration changes as needed. The [**IUserAgentService**](https://apireference.aspose.com/html/net/aspose.html.services/iuseragentservice) interface describes a user agent environment.
#### **User Style Sheet**
The user is able to specify a custom style information for a particular document. This information applies to the document according to the [cascading rules](https://www.w3.org/TR/css-cascade-3/#cascading-origins) and may affect the presentation of the document. The next code snippet shows how to use the **UserStyleSheet** property:
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Services;
...
    // Prepare HTML code and save it to a file
    var code = "<h1>User Agent Service </h1>\r\n" +
               "<p>The User Agent Service allows you to specify a custom user stylesheet, a primary character set for the document, language and fonts settings.</p>\r\n";               

    File.WriteAllText(Path.Combine(OutputDir, "user-agent-stylesheet.html"), code);
    
    // Create an instance of Configuration
    using (var configuration = new Configuration())
    {
        // Get the IUserAgentService
        var userAgentService = configuration.GetService<IUserAgentService>();
    
        // Set the custom style parameters for the "h1" and "p" elements
        userAgentService.UserStyleSheet = "h1 { color:#a52a2a;; font-size:2em;}\r\n" +
                                          "p { background-color:GhostWhite; color:SlateGrey; font-size:1.2em; }\r\n";
                        
        // Initialize the HTML document with specified configuration
        using (var document = new HTMLDocument(Path.Combine(OutputDir, "user-agent-stylesheet.html"), configuration))
        {                   
            // Convert HTML to PDF
            Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "user-agent-stylesheet_out.pdf"));                   
        }
    }
{{< /highlight >}}


{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  

#### **Character Set**
The **CharSet** property sets the primary character-set for a document. In order to parse and display an HTML document correctly, the application must know what character-set (encoding) is used for the document. If the character encoding is not directly specified in the header of the document, Aspose.HTML uses UTF-8, which is defined as the default for HTML5 specification. However, if you are sure that your HTML document is written using different from UTF-8 encoding, you can specify it manually, as it follows.
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Services;
...
    // Prepare HTML code and save it to a file
    var code = "<h1>Character Set</h1>\r\n" +
               "<p>The <b>CharSet</b> property sets the primary character-set for a document.</p>\r\n";

    File.WriteAllText(Path.Combine(OutputDir, "user-agent-charset.html"), code);
    
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
        using (var document = new HTMLDocument(Path.Combine(OutputDir, "user-agent-charset.html"), configuration))
        {
            // Convert HTML to PDF
            Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "user-agent-charset_out.pdf"));           
        }
    }
{{< /highlight >}}

In the example above, we have used **CharSet** and  **UserStyleSheet** properties for a setting of ISO-8859-1 encoding and a user style.

####  **FontsSettings property**
The **FontsSettings** property is used for configuration of fonts handling. For a situation when you need to use the custom fonts instead of the fonts installed on OS, you can set the path to your custom folder, as it is shown in the following code snippet.
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Services;
...
    // Prepare HTML code and save it to a file
    var code = "<h1>FontsSettings property</h1>\r\n" +
               "<p>The FontsSettings property is used for configuration of fonts handling.</p>\r\n";

    File.WriteAllText(Path.Combine(OutputDir, "user-agent-fontsetting.html"), code);
    
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
        using (var document = new HTMLDocument(Path.Combine(OutputDir, "user-agent-fontsetting.html"), configuration))
        {
            // Convert HTML to PDF
            Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "user-agent-fontsetting_out.pdf"));
        }
    }
{{< /highlight >}}

The figure illustrates the result of the **FontsSettings** and **UserStyleSheet** properties applying (b) to the source “user-agent-fontsetting.html” file (a).

![Text "FontsSettings property"](font-setting.png#center)
### **Runtime Service**
This service gives you control over the lifetime of the internal processes. For instance, using [**IRuntimeService**](https://apireference.aspose.com/net/html/aspose.html.services/iruntimeservice) you can specify timeouts for JavaScripts. It is important to have such a timeout in case if a script contains an endless loop. The next code snippet demonstrates how to use timeouts.
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Services;
...
    // Prepare HTML code and save it to a file
    var code = "<h1>Runtime Service</h1>\r\n" +
               "<script> while(true) {} </script>\r\n" +
               "<p>The Runtime Service optimizes your system by helping it start apps and programs faster.</p>\r\n";

    File.WriteAllText(Path.Combine(OutputDir, "runtime-service.html"), code);
    
    // Create an instance of Configuration
    using (var configuration = new Configuration())
    {
        // Limit JS execution time to 5 seconds
        var runtimeService = configuration.GetService<IRuntimeService>();
        runtimeService.JavaScriptTimeout = TimeSpan.FromSeconds(5);
    
        // Initialize an HTML document with specified configuration
        using (var document = new HTMLDocument(Path.Combine(OutputDir, "runtime-service.html"), configuration))
        {
            // Convert HTML to PNG
            Converter.ConvertHTML(document, new ImageSaveOptions(), Path.Combine(OutputDir, "runtime-service_out.png"));
        }        
    }            
{{< /highlight >}}
### **Network Service**
Aspose.HTML for .Net offers the [**INetworkService**](https://apireference.aspose.com/net/html/aspose.html.services/inetworkservice)  that allows you to control all incoming/outcoming traffic and implement your custom message handlers. It can be used for different purposes, such as: create custom caching mechanism, trace/logging request messages, etc.
#### **Message Handlers**
The following example demonstrates how to use message handlers to log information about unreachable resources. First of all, you need to create a custom message handler:
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using System.Net;
using Aspose.Html.Net;
using System.Collections.Generic;
...
    // This message handler logs all failed requests to the console
	private class LogMessageHandler : MessageHandler
    {
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
{{< /highlight >}}

#### **Network Service Using**


The next code snippet demonstrates how to use the **LogMessageHandler** class for logging information about unreachable resources.
{{< highlight java >}}
using System;
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Net;
using Aspose.Html.Saving;
using Aspose.Html.Services;
...
    // Prepare HTML code and save it to a file
    var code = "<img src=\"https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/park.jpg\" >\r\n" +
               "<img src=\"https://docs.aspose.com/html/net/missing1.jpg\" >\r\n" +
			   "<img src=\"https://docs.aspose.com/html/net/missing2.jpg\" >\r\n";                                      

    File.WriteAllText(Path.Combine(OutputDir, "network-service.html"), code);
    
    // Create an instance of Configuration
    using (var configuration = new Configuration())
    {
        // Add the LogMessageHandler to the chain of existing message handlers
        var networkService = configuration.GetService<INetworkService>();
    
        var logHandler = new LogMessageHandler();
        networkService.MessageHandlers.Add(logHandler);
    
        // Initialize an HTML document with specified configuration
        using (var document = new HTMLDocument(Path.Combine(OutputDir, "network-service.html"), configuration))
        {
            //Convert HTML to PNG
            Converter.ConvertHTML(document, new ImageSaveOptions(), Path.Combine(OutputDir, "network-service_out.png"));
    
            // Print the List of ErrorMessages
            foreach (string errorMessage in logHandler.ErrorMessages)
            {
                Console.WriteLine(errorMessage);
            }            
        }        
    }
{{< /highlight >}}
After the example run:

 - the created file “network-service.html” will be converted to PNG. Only one image is in the PNG file;
 - the List of ErrorMessages will be printed:

`File 'https://docs.aspose.com/html/net/missing1.jpg' Not Found`

`File 'https://docs.aspose.com/html/net/missing2.jpg' Not Found`
{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  