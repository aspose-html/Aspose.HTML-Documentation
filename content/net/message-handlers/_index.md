---
title: Message Handlers | C#
linktitle: Message Handlers
type: docs
weight: 50
description: The section provides general information on creating custom message handlers using Aspose.HTML for .NET. and examples of their implementation for various user tasks.  
keywords: message handler, web request, time logging, web request
lastmod: 2021-10-21
changefreq: weekly
priority: 0.7
---
<link href="./../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
By definition, a **message handler** is a class that receives a Web request and returns a Web response. In other words, a message handler is used to process a Web service request during input and/or to process the response during output.

In this chapter, we consider several **popular cases of message handlers usage**:

- message handler for a Web request execution time logging,

- message handler for a custom scheme implementation,

- message handler for working with a ZIP archive.
{{% /alert %}}

 [Creating a Custom Message Handler](/html/net/message-handlers/custom-message-handler/) - You will get the idea behind the custom message handler and find information on how to implement a custom message handler using Aspose.HTML for .NET.

[Popular Use Cases for Message Handlers](/html/net/message-handlers/popular-use-cases/) -  You will learn how to create  message handlers to implement a custom schema, work with a ZIP archive, and log a Web request execution time.



## **What is Message Handlers?** 

Message handlers are a sequence of classes that are part of a process of a Web request and response through a pipeline. The key concept of message handlers work is chaining them together. The first handler receives a Web request, does some processing, and passes the request on to the next handler. At some point, the response is created and returned along the chain. This pattern is called a **delegating** handler.

 Looking at the Figure, the sequence begins with the Request, then continues through the chain of message handlers. Once the message reaches the server, the Response is sent back through the chain of handlers in reverse order.

![Pipeline of message handlers](message-handlers.png#center)

The request message goes through each handler in turn, reaching the last handler. This handler is also the first to receive the response. At this point, this response goes back through the chain of handlers in reverse order, and each handler can check or use the response as needed.

Handlers behavior is governed by a set of protocols that describe what action message handlers can take in a given situation. The handlers, their protocols and their place in the chain may be defined by a system or user.  For example, a message handler might: change the processing sequence of a pipeline, check requests or responses for errors, log the duration of an operation or other diagnostic information, etc.

