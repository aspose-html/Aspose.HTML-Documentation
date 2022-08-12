---
title: Creating a Custom Message Handler | Basic Information
linktitle: Creating a Custom Message Handler
type: docs
weight: 10
description: The article provides general information on creating custom message handlers using Aspose.HTML for .NET.   
keywords: message handler, custom message handler, web request
lastmod: "2021-11-17"
sitemap:
    changefreq: "weekly"
    priority: 0.8
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
In traditional client-server calls, the client sends a Web request to the server, waits for the result, then gets a response. There are message handlers both server-side and client-side, and sometimes you have to configure custom message handlers. In this article, we consider the concept of a *message handler* and create a custom message handler to do a specific task.
{{% /alert %}}

## **What is a Message Handler?** 

By definition, a **message handler** is a class that receives a Web request and returns a response. In other words, a message handler is used to process a Web service request during input and/or to process the response during output.   The chain of handlers is a pipeline, which will all have the chance to process an outgoing Web request before it is sent or process a Web response.

 Handlers behavior is governed by a set of protocols that describe what action message handlers can take in a given situation. The handlers, their protocols and their place in the chain may be defined by a system or by a user. 

## **Custom Message Handler**

People like customization, and sometimes they need to perform a custom logic in a request and response. You can add custom handlers to the pipeline. Each handler has a choice of actions that it can achieve. For example, the handler can be invoked only for request processing or only for response processing.

One or more custom message handlers can be created and organized in a chain of message handlers that get called with every request and response. Each Web request goes through a message handler pipeline, and we can create custom message handlers and extend the behavior of an existing pipeline. Graphically, the result looks something like this:

![Pipeline with a custom message handler](custom-message-handler.png#center)

A message handler can return a response immediately. For example, you could create a handler that checks if a header is present on outgoing requests. If the header is missing, it doesn’t pass the request along to the next handler and generates an error response which it returns to the caller. 

![Custom message handler return a response](custom-mh-response.png#center)

You can define the handler chain as a pipeline that will be able to process the outgoing Web request before sending it. For example, these handlers may check the request's body or log some information about the request.
Consider an example of a message handler creating to show the key concepts.

## **Create a Custom Message Handler**

 Aspose.HTML for .NET offers functionality for custom message handlers creating. Let's develop a simple custom handler that prints a message when a request starts and finishes. Take the following steps:

1.	Use the necessary Namespace, which is the [Aspose.Html.Net](https://reference.aspose.com/html/net/aspose.html.net/). This Namespace is presented by classes and interfaces which are responsible for helping easy network processing. 

2. To create a custom Message Handler, you need to define your own class that will be derived from the [MessageHandler](https://reference.aspose.com/html/net/aspose.html.net/messagehandler/) class. The MessageHandler class represents a base type for message handlers.

{{< highlight java >}}
using Aspose.Html.Net;
...

	public class LogMessageHandler : MessageHandler
	{
		
	}
{{< /highlight >}}

So, you have defined your own LogMessageHandler class, now you need to do some operation within it.

3. Override the [Invoke()](https://reference.aspose.com/html/net/aspose.html.net/messagehandler/invoke/) method of the MessageHandler class to implement the custom message handler behaviour. 

{{< highlight java >}}	
using System;
using Aspose.Html.Net;
...
	
	// This message handler prints a message about start and finish processing request
	public class LogMessageHandler : MessageHandler
	{
		// Override the Invoke() method
		public override void Invoke(INetworkOperationContext context)
		{
			Console.WriteLine("Start processing request: " + context.Request.RequestUri);
			
			// Invoke the next message handler in the chain
			Next(context);
			
			Console.WriteLine("Finish processing request: " + context.Request.RequestUri);
		}
	}	
{{< /highlight >}} 

4. Add the LogMessageHandler to the pipeline of existing message handlers. Use Insert() method to append LogMessageHandler at the first place in the collection of message handlers.

The following code snippet demonstrates how to add the LogMessageHandler to the pipeline and use it for a simple operation.

{{< highlight java >}}	
using System;
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Services;
...	

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
{{< /highlight >}} 

{{% alert color="primary" %}} 
So, in this article, you have got the idea behind the custom Message Handler and have seen the simple example of its implementation. 

In the [Popular Use Cases for Message Handlers](/html/net/message-handlers/popular-use-cases/) article, you will learn how to create message handlers to implement a custom schema, work with a ZIP archive, and log a Web request execution time.
{{% /alert %}}

