---
title: Web Request Execution Time | C# example
linktitle: Web Request Execution Time
type: docs
weight: 30
url: /net/message-handlers/web-request-execution-time/
description: The article provides information on creating a custom message handler for a web request time logging using Aspose.HTML for .NET.   
keywords: message handler, custom message handler, web request, time logging
lastmod: 2021-10-21
changefreq: weekly
priority: 0.7
---

{{% alert color="primary" %}} 
In this article, you find a simple example of how to create a custom message handler for a Web request execution time logging.
{{% /alert %}}

Sometimes, to optimize the performance, you may need to find out the Web request execution time. For example, you want to know how much time is taken to read a file in the file system or download data from a remote server.

## **C# Example. Message Handler for Logging the Time of File Loading**

### **Creating a TimeLoggerMessageHandler for a Web Request Execution Time Logging**

The following code snippet shows how to create a TimeLoggerMessageHandler to log the time taken for reading a file from the file system.

{{< highlight java >}}
using System;
using System.Diagnostics;
using Aspose.Html;
using Aspose.Html.Net;
...	

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
			Console.WriteLine("Request: " + context.Request.RequestUri);
	        Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + "ms");
	    }
	}
{{< /highlight >}}

Use the Stopwatch class in the System.Diagnostics Namespace to accurately measure the time it takes to execute the Web request. The StartNew() method starts to log time for completing the Web request until the Stop() method is called. 

### **Adding the TimeLoggerMessageHandler to the Pipeline and Implement the Example**

The Configuration() constructor initializes an instance of the [Configuration](https://apireference.aspose.com/html/net/aspose.html/configuration) class. After the configuration is created, the GetService &lt;INetworkService&gt;() and MessageHandlers.Insert() methods are invoked. The Insert() method adds the TimeLoggerMessageHandler at the first place in the collection of message handlers. 

Use the [HTMLDocument(`address, configuration`)](https://apireference.aspose.com/html/net/aspose.html/htmldocument/constructors/11) constructor to initialize an HTML Document and implement the example for logging the document's loading time.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Services;
...

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
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}



