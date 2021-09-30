---
title: Convert ZIP to JPG | C# example
linktitle: Convert ZIP to JPG
type: docs
weight: 20
url: /net/message-handlers/convert-zip-to-jpg/
description: In the article, the example of a message handler creating for working with zip archives is considered. The implementation of converting zip to jpg is shown.
keywords: message handler, zip to jpg, convert zip to jpg
lastmod: 2021-09-29
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
In this article, we create a custom Message Handler to do a specific task - convert ZIP to JPG.

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

Aspose.HTML offers a free online [**ZIP to JPG Converter**](https://products.aspose.app/html/en/conversion/zip-to-jpg) that converts ZIP to JPG with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

<a href="https://products.aspose.app/html/en/conversion/zip-to-jpg" target="_blank">![Text "Banner ZIP to JPG Converter"](zip-to-jpg.png#center)</a>

There are many reasons why would you require to convert ZIP to {{%JPG%}} format. For example, if you want to convert an HTML(XHTML) document containing linked resources to JPG, you should pack all these resources along with the document into a single ZIP archive and convert ZIP to JPG. Aspose.HTML for .NET provides functionality for creating custom message handlers for working with ZIP archives.

## **Create a Custom Message Handler for ZIP to JPG Conversion**

 Aspose.HTML for .NET offers functionality for a custom message handler creating. Let's design the custom handler that we can use to work with ZIP archives. Take the following steps:

1.	Use the necessary Namespace, which is the [Aspose.Html.Net](https://apireference.aspose.com/html/net/aspose.html.net). This Namespace is presented by classes and interfaces which are responsible for helping easy network processing. 

2.	To create a custom Message Handler, you need to define your own class that will be derived from the [MessageHandler](https://apireference.aspose.com/html/net/aspose.html.net/messagehandler) class. The MessageHandler class represents a base type for message handlers. 

{{< highlight java >}}
using Aspose.Html.Net;
...

	class ZipArchiveMessageHandler : MessageHandler
	{
	}
{{< /highlight >}}

3. Initialize an instance of the ZipArchiveMessageHandler class and define a Filter property for it. 

4. Override the [Invoke()](https://apireference.aspose.com/html/net/aspose.html.net/messagehandler/methods/invoke) method of the MessageHandler class to implement the custom message handler behaviour. 

{{< highlight java >}}	
using System.Net;
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Net.MessageFilters;
using Aspose.Zip;
...	

	// Define ZipArchiveMessageHandler class that is derived from the MessageHandler class
	class ZipArchiveMessageHandler : MessageHandler, IDisposable
	{
	    private string filePath;
	    private Archive archive;
	
	    // Initialize an instance of the ZipArchiveMessageHandler class
		public ZipArchiveMessageHandler(string path)
	    {
	        this.filePath = path;
	        Filters.Add(new ProtocolMessageFilter("zip"));
	    }
	
	    // Override the Invoke() method
		public override void Invoke(INetworkOperationContext context)
	    {
	        // Call the GetFile() method that defines the logic in the Invoke() method
			var buff = GetFile(context.Request.RequestUri.Pathname.TrimStart('/'));
	        if (buff != null)
	        {
	            // Checking: if a resource is found in the archive, then return it as a Response
	            context.Response = new ResponseMessage(HttpStatusCode.OK)
	            {
	                Content = new ByteArrayContent(buff)
	            };
	            context.Response.Headers.ContentType.MediaType = MimeType.FromFileExtension(context.Request.RequestUri.Pathname);
	        }
	        else
	        {
	            context.Response = new ResponseMessage(HttpStatusCode.NotFound);
	        }
	        
	        // Call the next message handler in the chain
			Next(context);
	    }
	}	
{{< /highlight >}} 

Let's consider closer the code snippet:

- The custom ZipArchiveMessageHandler needs to inherit from the base MessageHandler class. It has two variables: the archive and the string representation of the path to the archive. Inheriting from IDisposable is necessary to provide a mechanism for the deterministic release of unmanaged resources.

- The message handler has the concept of filtering. In this case, a protocol (schema) filter is added, this message handler will only work with the `"zip"` protocol.

   Filtering messages by resource protocol is implemented using the [ProtocolMessageFilter](https://apireference.aspose.com/html/net/aspose.html.net.messagefilters/protocolmessagefilter) class. The ProtocolMessageFilter() constructor initializes a new instance of the ProtocolMessageFilter class. It takes the `"zip"` protocols as a parameter.

- The  [Invoke()](https://apireference.aspose.com/html/net/aspose.html.net/messagehandler/methods/invoke)  method implements the message handler behaviour. It is called for each handler in the pipeline and takes a `context` as a parameter. The GetFile() method defines the logic in the Invoke() method. It implements the chain of duties, after which the next Next(`context`) handler is called. 

  The GetFile() method realizes a search for data as a byte array in a zip archive based on Request and forms Response.

- `context` provides contextual information for network services, the entity of the operation is passed through it, and the result of the operation is returned. In Aspose.HTML, the `context` is realized by [INetworkOperationContext](https://apireference.aspose.com/html/net/aspose.html.net/inetworkoperationcontext)  interface that has two properties (parameters) - [Request](https://apireference.aspose.com/html/net/aspose.html.net/inetworkoperationcontext/properties/request) and [Response](https://apireference.aspose.com/html/net/aspose.html.net/inetworkoperationcontext/properties/response). 

## **Define the GetFile(), GetArchive(), and  Dispose() Methods**

{{< highlight java >}}
using System.IO;
using Aspose.Zip;
...

	byte[] GetFile(string path)
	{
	    path = path.Replace(@"\", @"/");
	    var result = GetArchive().Entries.FirstOrDefault(x => path == x.Name);
	    if (result != null)
	    {
	        using (var fs = result.Open())
	        using (MemoryStream ms = new MemoryStream())
	        {
	            fs.CopyTo(ms);
	            return ms.ToArray();
	        }
	    }
	    return null;
	}


	Archive GetArchive()
	{
	    return archive ??= new Archive(filePath);
	}


    public void Dispose()
    {
        archive?.Dispose();
    }
{{< /highlight >}}

## **Add ZipArchiveMessageHandler to the Pipeline and Convert ZIP to JPG**

The key concept of message handlers work is chaining them together, and you would now need to add ZipArchiveMessageHandler in the pipeline. The Configuration() constructor creates an instance of the [Configuration](https://apireference.aspose.com/html/net/aspose.html/configuration) class. After the configuration is created, the GetService&lt;INetworkService&gt;(),  and MessageHandlers.Add() methods are invoked. The Add() method takes a `zip` object as a parameter and appends ZipArchiveMessageHandler to the end of the message handlers' collection.

{{< highlight java >}}
using System;
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Services;
...

	// Prepare path to a source zip file
	string documentPath = Path.Combine(DataDir, "test.zip");
	
	// Prepare path for converted file saving
	string savePath = Path.Combine(OutputDir, "zip-to-jpg.jpg");
	
	// Create an instance of ZipArchiveMessageHandler
	using var zip = new ZipArchiveMessageHandler(documentPath);
	
	// Create an instance of the Configuration class
	using var configuration = new Configuration();
	
	// Add ZipArchiveMessageHandler to the chain of existing message handlers
	configuration
	    .GetService<INetworkService>()
	    .MessageHandlers.Add(zip);
	
	// Initialize an HTML document with specified configuration
	using var document = new HTMLDocument("zip:///test.html", configuration);
	
	// Create an instance of Rendering Options
	var options = new ImageRenderingOptions()
	{
	    Format = ImageFormat.Jpeg
	};
	
	// Create an instance of Image Device   
	using var device = new ImageDevice(options, savePath);
	
	// Render ZIP to JPG
	document.RenderTo(device);
{{< /highlight >}}

In the example, the ZIP archive (test.zip) has the HTML document (test.html) in which all related resources have paths relative to the HTML document.

**Note:** The [HTMLDocument(`address, configuration`)](https://apireference.aspose.com/html/net/aspose.html/htmldocument/constructors/11) constructor takes the absolute path to the ZIP archive. But all related resources have relative paths in the HTML document and in the example's code.

For more information on how to convert HTML to JPG using [Renderto(`device`)](https://apireference.aspose.com/html/net/aspose.html/htmldocument/methods/renderto) method, please read the **[Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/)** article.

{{% alert color="primary" %}} 
Aspose.HTML provides a free online [**ZIP to JPG Converter**](https://products.aspose.app/html/en/conversion/zip-to-JPG) that allows you to quickly, easily and clearly convert ZIP to JPG.  Upload, convert files and get results in seconds. Try our forceful ZIP to JPG Converter for free now!
{{% /alert %}}
