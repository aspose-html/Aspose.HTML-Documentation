---
title: Network Timeouts - How to Set in C# examples
linktitle: Network Timeouts
type: docs
weight: 30
url: /net/message-handlers/network-timeouts/
description: Learn how to set network timeouts in C#. Create a custom message handler for network operation timeouts using Aspose.HTML for .NET.   
keywords: message handler, connect timeout, network timeouts, network operation, network connection timeout, network operation timeout, network request
lastmod: "2023-02-08"
sitemap:
    changefreq: "monthly"
    priority: 0.8
---

{{% alert color="primary" %}} 
Network timeouts can occur when a network connection is not able to be established or a server is taking too long to respond. When a network timeout occurs, it can impact the functionality of a software application and cause a range of problems. This article will discuss how to set network timeouts in C# with practical examples. You find simple C# examples of how to create a custom message handler for network operation timeouts.
{{% /alert %}}

## **Network Timeouts**

The network timeout refers to the amount of time a client, such as a software application, waits for a response from a server after sending a request. A timeout value is set to avoid waiting indefinitely for a response in case the server is unavailable or unresponsive.<br>
A network timeout is a time limit for completing a network operation, such as sending a request or waiting for a response. If the network operation exceeds the timeout, it is considered to have failed. Network timeout affects the performance and reliability of network communications by determining the maximum amount of time allowed for a request to be completed successfully. When the timeout is reached, the operation may be terminated, resulting in an error or failure. Network timeout is an essential factor to consider when designing network applications because it can affect the responsiveness, speed, and availability of network communication.

## **Message Handler for Network Operation Timeouts**

In order to set the maximum network operation timeout, you will need to define your own network request handler and register it at the top of the queue of such handlers. Thus, all network requests will pass through it.<br>
The following example shows how to use this functionality. First, let's create our own network operation handler TimeoutMessageHandler that will set the maximum network timeout to 1 second and simply pass the message further down the chain.

{{< highlight java >}}
using System;
using Aspose.Html.Net;
...	

	// Define the TimeoutMessageHandler class that is derived from the MessageHandler class
	public class TimeoutMessageHandler : MessageHandler
    {
        // Override the Invoke() method
		public override void Invoke(INetworkOperationContext context)
        {
            context.Request.Timeout = TimeSpan.FromSeconds(1);
            Next(context);
        }
    }
{{< /highlight >}}

In the C# code snippet above, we define a custom `TimeoutMessageHandler` class. The class inherits from the [MessageHandler](https://reference.aspose.com/html/net/aspose.html.net/messagehandler/) class and overrides its [Invoke()](https://reference.aspose.com/html/net/aspose.html.net/messagehandler/invoke/) method. In the Invoke() method, a timeout of 1 second is set for the Request property of the [INetworkOperationContext](https://reference.aspose.com/html/net/aspose.html.net/inetworkoperationcontext/) object passed in as a parameter. The Next() method is then called to continue the execution of the pipeline. This custom message handler can set a specific timeout value for network operations in an application.

## **Network Timeout to Open HTML File**

When making network requests, a network timeout is a crucial aspect to consider. HTML documents may include resources that are in the cloud or another server. Sometimes requests to a remote resource take a very long time or do not respond, then opening a document can take an infinitely long time. If you set an operation timeout, you will avoid long waits, but the document may open without some "problematic" resources.<br>
 Here is an example of how you can use the `TimeoutMessageHandler` class to set a timeout for opening an HTML file using the Aspose.HTML library:

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Services;
using System.IO;
...

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

{{< /highlight >}}

In this example, we create an instance of the `TimeoutMessageHandler` class and insert it at the top of the list of message handlers in the network service. Finally, we create an instance of the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class, passing in the path to the HTML file and the configuration object. The HTMLDocument class will use the network service from the configuration object to make the necessary network requests.

## **Network Timeout to Convert HTML**

Let's look at the C# code that sets a timeout value of 1 second for requests made through the `TimeoutMessageHandler` class in a .NET application. The following example shows how to set a timeout for an HTML conversion operation. As a result, all network operations that will occur during the conversion and last more than one second will be interrupted.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Services;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System.IO;
...

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
{{< /highlight >}}

In this example, the `TimeoutMessageHandler` is added to the MessageHandlers collection of the INetworkService, and the timeout value is set to 1 second. The HTMLDocument class is then used to load the HTML file and perform the conversion.

By using the TimeoutMessageHandler class and handling network timeouts properly, you can ensure a reliable and efficient experience for the user when converting HTML files.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}



