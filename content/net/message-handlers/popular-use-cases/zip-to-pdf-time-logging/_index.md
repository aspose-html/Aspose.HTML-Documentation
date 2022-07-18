---
title: Convert ZIP to PDF - Execution Time Logging | C# example
linktitle: Convert ZIP to PDF - Execution Time Logging
type: docs
weight: 40
url: /net/message-handlers/zip-to-pdf-time-logging/
description: In this article, you find an example of custom message handlers to convert ZIP to PDF and log the execution time of this conversion using Aspose.HTML for .NET.  
keywords: zip to pdf, convert zip to pdf, message handler, custom message handler, web request, time logging, ZIP archive
lastmod: "2021-11-17"
sitemap:
    changefreq: "weekly"
    priority: 0.8
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
In this article, you will find an example of using custom message handlers to convert ZIP to {{%PDF%}} and log the execution time of this conversion.
{{% /alert %}}

Sometimes, in order to optimize the performance, you may need to find out the web request execution time. For example, you want to know how much time is taken to convert ZIP to {{%PDF%}}.

## **C# Example. Convert ZIP to PDF - Execution Time Logging**

### **Creating a Message Handler for a Custom Schema Implementation**

Let's create a custom handler that you can use for custom schema (protocol) implementation. Take the next steps:

1. Use the necessary Namespace, which is the [Aspose.Html.Net](https://reference.aspose.com/html/net/aspose.html.net).
2. Define your own CustomSchemaMessageHandler class that will be derived from the [MessageHandler](https://reference.aspose.com/html/net/aspose.html.net/messagehandler) class.
3. Initialize an instance of the CustomSchemaMessageHandler class and define a Filter property for it. 
4. Create the CustomSchemaMessageFilter class that is derived from the [MessageFilter](https://reference.aspose.com/html/net/aspose.html.net/messagefilter) class.
5. Override the [Match()](https://reference.aspose.com/html/net/aspose.html.net/messagefilter/methods/match) method of the MessageFilter class to implement the custom message handler behaviour.

The following code snippet shows how to create the CustomSchemaMessageHandler class:

{{< highlight java >}}
using Aspose.Html.Net;
...

    // Define the CustomSchemaMessageHandler class that is derived from the MessageHandler class
    abstract class CustomSchemaMessageHandler : MessageHandler
    {
        protected CustomSchemaMessageHandler(string schema)
        {
            Filters.Add(new CustomSchemaMessageFilter(schema));
        }
    }
    
    // Define the CustomSchemaMessageFilter class that is derived from the MessageFilter class
    class CustomSchemaMessageFilter : MessageFilter
    {
        private readonly string schema;
        public CustomSchemaMessageFilter(string schema)
        {
            this.schema = schema;
        }       
    
    	// Override the Match() method
    	public override bool Match(INetworkOperationContext context)
        {
            return string.Equals(schema, context.Request.RequestUri.Protocol.TrimEnd(':'));
        }
    }
{{< /highlight >}}

The CustomSchemaMessageHandler(`schema`) constructor instantiates the CustomSchemaMessageHandler object and takes the `schema` as a parameter. The Add() method append the CustomSchemaMessageFilter object at the end of the collection. The Match() method tests whether a `context` satisfies the filter criteria. 

### **Creating the ZipFileSchemaMessageHandler for Working with ZIP archives**

The following code snippet shows how to create the ZipFileSchemaMessageHandler class for working with ZIP archives:

{{< highlight java >}}
using System.IO;
using System.Linq;
using System.Net;
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Services;
using Aspose.Zip;
...

	// Define the ZipFileSchemaMessageHandler class that is derived from the CustomSchemaMessageHandler class
	class ZipFileSchemaMessageHandler : CustomSchemaMessageHandler
	{
	    private readonly Archive archive;
	
	    public ZipFileSchemaMessageHandler(Archive archive) : base("zip-file")
	    {
	        this.archive = archive;
	    }
	
	    // Override the Invoke() method
	    public override void Invoke(INetworkOperationContext context)
	    {
	        var pathInsideArchive = context.Request.RequestUri.Pathname.TrimStart('/').Replace("\\", "/");
	        var stream = GetFile(pathInsideArchive);
	
	        if (stream != null)
	        {
	            // Checking: if a resource is found in the archive, then return it as a Response
	            var response = new ResponseMessage(HttpStatusCode.OK);
	            response.Content = new StreamContent(stream);
	            response.Headers.ContentType.MediaType = MimeType.FromFileExtension(context.Request.RequestUri.Pathname);
	            context.Response = response;
	        }
	        else
	        {
	            context.Response = new ResponseMessage(HttpStatusCode.NotFound);
	        }
	
	        // Invoke the next message handler in the chain
	        Next(context);
	    }
	
	    Stream GetFile(string path)
	    {
	        var result = archive
	            .Entries
	            .FirstOrDefault(x => x.Name == path);
	        return result?.Open();
	    }
	}
 {{< /highlight >}}

In the above example, searching for a resource (zip archive) at its URI is realized. If a resource is found, [FromFileExtension()](https://reference.aspose.com/html/net/aspose.html/mimetype/methods/fromfileextension) method returns the [MimeType](https://reference.aspose.com/html/net/aspose.html/mimetype) of the resource.

### **Message Handler for a Web Request Execution Time Logging**

The following code snippet shows how to create StartRequestDurationLoggingMessageHandler and StopRequestDurationLoggingMessageHandler to log the time taken for web request execution.

{{< highlight java >}}
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using Aspose.Html;
using Aspose.Html.Net;
...

	// Define the RequestDurationLoggingMessageHandler class that is derived from the MessageHandler class
	abstract class RequestDurationLoggingMessageHandler : MessageHandler
	{
	    private static ConcurrentDictionary<Url, Stopwatch> requests = new ConcurrentDictionary<Url, Stopwatch>();
	
	    protected void StartTimer(Url url)
	    {
	        requests.TryAdd(url, Stopwatch.StartNew());
	    }
	
	    protected TimeSpan StopTimer(Url url)
	    {
	        var timer = requests[url];
	        timer.Stop();
	        return timer.Elapsed;
	    }
	}
	
	// Create StartRequestDurationLoggingMessageHandler that starts the timer
	class StartRequestDurationLoggingMessageHandler : RequestDurationLoggingMessageHandler
	{
	    // Override the Invoke() method
	    public override void Invoke(INetworkOperationContext context)
	    {
	        // Start the stopwatch
	        StartTimer(context.Request.RequestUri);
	
	        // Invoke the next message handler in the chain
	        Next(context);
	    }
	}
	
	// StopRequestDurationLoggingMessageHandler stops the timer
	class StopRequestDurationLoggingMessageHandler : RequestDurationLoggingMessageHandler
	{
	    // Override the Invoke() method
	    public override void Invoke(INetworkOperationContext context)
	    {
	        // Stop the stopwatch
	        var duration = StopTimer(context.Request.RequestUri);
	
	        // Print the result
	        Console.WriteLine($"Elapsed: {duration:g}, resource: {context.Request.RequestUri.Pathname}");
	
	        // Invoke the next message handler in the chain
	        Next(context);
	    }
	}
{{< /highlight >}}

### **Adding the Message Handlers to the Pipeline**

The key concept of message handlers work is chaining them together. We have created several message handlers and should add them to the pipeline in a specific order to implement the example of ZIP to PDF conversion time logging. Let's perform the following steps:

1. Create an instance of the Configuration class. 
2. Realize ZIP Custom Schema. Use the Add() method to append ZipFileSchemaMessageHandler to the end of the pipeline.
3. Execute Duration Logging. Use the Insert() method to add the StartRequestDurationLoggingMessageHandler first in the pipeline, and the Add() method to append the StopRequestDurationLoggingMessageHandler to the end of the pipeline.
4. Initialize an HTML document with specified configuration.
5. Create the PDF Device and render ZIP to PDF.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Services;
using Aspose.Zip;
...

​    // Prepare path to a source zip file
​    string documentPath = Path.Combine(DataDir, "test.zip");

    // Prepare path for converted file saving
    string savePath = Path.Combine(OutputDir, "zip-to-pdf-duration.pdf");
    
    // Create an instance of the Configuration class
    using var configuration = new Configuration();
    var service = configuration.GetService<INetworkService>();
    var handlers = service.MessageHandlers;
    
    // Custom Schema: ZIP. Add ZipFileSchemaMessageHandler to the end of the pipeline
    handlers.Add(new ZipFileSchemaMessageHandler(new Archive(documentPath)));
    
    // Duration Logging. Add the StartRequestDurationLoggingMessageHandler at the first place in the pipeline
    handlers.Insert(0, new StartRequestDurationLoggingMessageHandler());
    
    // Add the StopRequestDurationLoggingMessageHandler to the end of the pipeline
    handlers.Add(new StopRequestDurationLoggingMessageHandler());
    
    // Initialize an HTML document with specified configuration
    using var document = new HTMLDocument("zip-file:///test.html", configuration);
    
    // Create the PDF Device
    using var device = new PdfDevice(savePath);
    
    // Render ZIP to PDF
    document.RenderTo(device);
{{< /highlight >}}

The Configuration() constructor creates an instance of the [Configuration](https://reference.aspose.com/html/net/aspose.html/configuration) class. After the configuration is created, the GetService&lt;INetworkService&gt;(), MessageHandlers.Add()  and MessageHandlers.Insert() methods are invoked. The Insert() and Add() methods append the custom message handlers in the collection of existing message handlers. The figure shows the chain of message handlers for this example:

![The chain of message handlers](message-handlers-chain.png#center)

**Note:** The [HTMLDocument(`address, configuration`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/constructors/11) constructor takes the absolute path to the ZIP archive. But all related resources have relative paths in the HTML document and in the example’s code.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}



