---
title: Creating an HTML Document
type: docs
weight: 20
url: /net/creating-a-document/
description: Create an Empty HTML Document, Create HTML from a String, Create HTML from a Stream, Load HTML from a File, Load HTML from the Web, Reading HTML with Resources Async, SVG Document, MHTML Document, EPUB Document
---

This section offers a detailed guide on how to create an HTML document.  Aspose.HTML for .NET API provides an **HTMLDocument** class that is the root of the HTML hierarchy and holds the entire content.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  

## **HTML Document**

The [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument) is a starting point for Aspose.HTML class library. You can load the HTML page into the **Document Object Model (DOM)** by using the [HTMLDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument) class and then programmatically read, modify the document tree, add and remove nodes, change the node properties in the document as it is described in the official specifications.

{{% alert color="primary" %}} 

The [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument)  class provides an in-memory representation of an **HTML DOM** and entirely based on [W3C DOM](http://www.w3.org/DOM/) and [WHATWG DOM](https://dom.spec.whatwg.org/) specifications that are supported in many modern browsers. If you are familiar with [WHATWG DOM](https://dom.spec.whatwg.org/), [WHATWG HTML](https://html.spec.whatwg.org/multipage/), and [JavaScript](https://www.ecma-international.org/ecma-262/10.0/index.html) standards, you will find it quite comfy to use the Aspose.HTML library. Otherwise, you can visit [www.w3schools.com](https://www.w3schools.com/html/default.asp), where you can find a lot of examples and tutorials on how to work with HTML documents.

{{% /alert %}} 

HTML documents can be created from scratch as an empty document with HTML structure, from a string, from a memory stream or loaded from a file or a URL. The [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument)  has several overloaded constructors allowing you to create or load HTML documents.

### **Create an Empty HTML Document**

Once the document object is created, it can be filled later with HTML elements. The following code snippet shows the usage of the default **HTMLDocument()** constructor to create an empty HTML document and save it to a file.
{{< highlight java >}}
using System.IO;
using Aspose.Html;
...
    // Prepare an output path for a document saving
    string documentPath = Path.Combine(OutputDir, "create-empty-document.html");    

    // Initialize an empty HTML document
    using (var document = new HTMLDocument())
    {
        // Work with the document
        
        // Save the document to a file
        document.Save(documentPath);
    }
{{< /highlight >}}
After the creation, file create-empty-document.html appears with the initial document structure: the empty document includes elements such as `<html>` `<head>` and `<body>`. More details about HTML files saving are in the **[Saving an HTML Document](https://docs.aspose.com/html/net/editing-a-document/)** section.

### **Create a New HTML Document**

If you want to generate a document programmatically from scratch, please use constructor without parameters as specified in the following code snippet:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
...
    // Prepare an output path for a document saving
    string documentPath = Path.Combine(OutputDir, "create-new-document.html");
			
	// Initialize an empty HTML document
	using (var document = new HTMLDocument())
	{
	    // Create a text element and add it to the document
	    var text = document.CreateTextNode("Hello World!");
	    document.Body.AppendChild(text);
	
	    // Save the document to a disk
	    document.Save(documentPath);
	}
{{< /highlight >}}
In the new document, we have created a text node, given the specified string, using the **CreateTextNode()** method and added it to the body element using **AppendChild()** method. How to edit an HTML file is described in detail in the [**Editing an HTML Document**](https://docs.aspose.com/html/net/editing-a-document/) section.

### **Load from a File**
Following code snippet shows how to load the [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument) from an existing file:
{{< highlight java >}}
using System;
using Aspose.Html;
...
     // Prepare an output path for a file saving
	 var htmlFile = Path.Combine(OutputDir, "load-from-file.html");
	
    // Prepare a 'load-from-file.html' document
    File.WriteAllText(htmlFile, "Hello World!");
    
    // Load from the 'load-from-file.html' 
    using (var document = new HTMLDocument(htmlFile))
    {
        // Write the document content to the output stream
        Console.WriteLine(document.DocumentElement.OuterHTML);
    }
{{< /highlight >}}

In the example above, the HTML document loaded from a file using **HTMLDocument (`string`)** constructor. If you require to load an existing HTML file from a disk, work and save it, then the following code snippet will help you.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
...
    // Prepare a path to a file
	string documentPath = Path.Combine(DataDir, "Sprite.html");
    
    // Initialize an HTML document from a file
    using (var document = new HTMLDocument(documentPath))
    {
        // Work with the document
               
        // Save the document to a disk
        document.Save(Path.Combine(OutputDir, "Sprite_out.html"));
    }
{{< /highlight >}}

### **Load from a URL**
The ability to select files and interact with them on the user's local device is one of the most used features of the Internet. In the next code snippet, you can see how to load a web page into the [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument).

{{% alert color="primary" %}} 
In case if you pass a wrong URL that can't be reached right at the moment, the library throws the [DOMException](https://apireference.aspose.com/net/html/aspose.html/htmlexception) with specialized code 'NetworkError' to inform you that the selected resource can not be found.
{{% /alert %}} 
{{< highlight java >}}
using System;
using Aspose.Html;
...
    // Load a document from 'https://docs.aspose.com/html/net/creating-a-document/document.html' web page
    using (var document = new HTMLDocument("https://docs.aspose.com/html/net/creating-a-document/document.html"))
    {
        // Write the document content to the output stream
        Console.WriteLine(document.DocumentElement.OuterHTML);
    }
{{< /highlight >}}
In the example above, we have specified document.html file to load from the URL.


### **Load from HTML Code**
If you prepare an HTML code as an in-memory [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.8) or [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream?view=netframework-4.8) objects, you don't need to save them to the file, simply pass your HTML code into specialized constructors.

{{% alert color="primary" %}} 

In case your HTML code has the linked resources (styles, scripts, images, etc.), you need to pass a valid baseUrl parameter to the constructor of the document. It will be used to resolve the location of the resource during the document loading.

{{% /alert %}} 

#### **Load from a String**

You can create a document from a string content using **HTMLDocument (`string, string`)** constructor. If your case is to create a document from a user string directly in your code and save it to a file, the following example could help you: we produce an HTML document that contains "Hello World!" text.
{{< highlight java >}}
using System IO;
using Aspose.Html;
...
    // Prepare HTML code
    var html_code = "<p>Hello World!</p>";

    // Initialize a document from the string variable
    using (var document = new HTMLDocument(html_code, "."))
    {
        // Save the document to a disk
        document.Save(Path.Combine(OutputDir, "create-from-string.html"));
    }
{{< /highlight >}}

#### **Load from a Stream**
To create an HTML document from a stream, you can use the **HTMLDocument(`stream, string`)** constructor:

{{< highlight java >}}
using System IO;
using Aspose.Html;
...
    // Create a memory stream object
    using (var mem = new MemoryStream())
    using (var sw = new StreamWriter(mem))
    {
        // Write the HTML code into memory object
        sw.Write("<p>Hello World! I love HTML!</p>");

        // It is important to set the position to the beginning since HTMLDocument starts the reading exactly from the current position within the stream
        sw.Flush();
        mem.Seek(0, SeekOrigin.Begin);
    
        // Initialize a document from the string variable
        using (var document = new HTMLDocument(mem, "."))
        {
            // Save the document to a disk
            document.Save(Path.Combine(OutputDir, "load-from-stream.html"));
        }
    }
{{< /highlight >}}

## **SVG Document**
Since Scalable Vector Graphics ({{%SVG%}}) is a part of [W3C](https://www.w3.org/) standards and could be embedded into the [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument), we implemented the [**SVGDocument**](https://apireference.aspose.com/net/html/aspose.html.dom.svg/svgdocument) and all its functionality. Our implementation is based on official [SVG 2 specification](https://www.w3.org/TR/SVG2/), so you can load, read, manipulate SVG documents as it described officially.

Since the **SVGDocument** and  the **HTMLDocument** are based on the same [WHATWG DOM](https://dom.spec.whatwg.org/) standard, all operations such as loading, reading, editing, converting and saving are similar for both documents. So, all examples where you can see manipulation with the **HTMLDocument** are applicable for the **SVGDocument** as well.

You can create a document from a string content using **SVGDocument (`string, string`)** constructor. If you want to load the SVG Document from the in-memory [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.8) variable and you don’t need to save it to a file; the example below shows you how to do it:

{{< highlight java >}}
using System;
using Aspose.Html.Dom.Svg;
...
    // Initialize an SVG document from a string object
    using (var document = new SVGDocument("<svg xmlns='http://www.w3.org/2000/svg'><circle cx='50' cy='50' r='40'/></svg>", "."))
    {
        // Write the document content to the output stream
        Console.WriteLine(document.DocumentElement.OuterHTML);
	}
{{< /highlight >}}
  In the example above, we have produced an SVG document that contains a circle with a radius of 40 pixels. You can learn more about working with SVG documents from the **[How to work with Aspose.SVG API](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/)** chapter.

## **MHTML Document**
{{%MHTML%}} stands for MIME encapsulation of aggregate HTML documents. An MHTML file is an archive containing all the content of a web page. It stores the HTML of a web page as well as related resources on a web page, which can include CSS, JavaScript, images, and audio files. It is a specialized format to create web page archives, and web developers primarily use MHTML files to save the current state of a web page for archiving purposes. 
The Aspose.HTML library supports this format, but with some limitations. We only support the rendering operations from MHTML to the supported output formats. For more details, please read the [**Converting Between Formats**](/html/net/converting-between-formats/) article.

## **EPUB Document**
{{%EPUB%}} is a format supported by a majority of eReaders and compatible with most devices you read on - smartphones, tablets, and computers.  For {{%EPUB%}} format, which represents an *electronic publication* format, we have the same limitation as for {{%MHTML%}}. We only support the rendering operations from EPUB to the supported output formats. For more details, please read the [**Converting Between Formats**](/html/net/converting-between-formats/) article.

## **Asynchronous Operations**
We realize that loading a document could be a resource-intensive operation since it’s required loading not only the document itself but all linked resources and processing all scripts. So, in the following code snippets, we show you how to use asynchronous operations and load the [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument) without blocking the main thread:

{{< highlight java >}}
using System;
using Aspose.Html;
using System.Threading;
...
    // Initialize an AutoResetEvent
    var resetEvent = new AutoResetEvent(false);
			
	// Create an instance of an HTML document
	var document = new HTMLDocument();
	
	// Create a string variable for OuterHTML property reading
	var outerHTML = string.Empty;
	
	// Subscribe to 'ReadyStateChange' event
	// This event will be fired during the document loading process
	document.OnReadyStateChange += (sender, @event) =>
	{
	    // Check the value of the 'ReadyState' property
	    // This property is representing the status of the document. For detail information please visit https://www.w3schools.com/jsref/prop_doc_readystate.asp
	    if (document.ReadyState == "complete")
	    {
	        // Fill the outerHTML variable by value of loaded document                  
	        outerHTML = document.DocumentElement.OuterHTML;
			resetEvent.Set();
	    }
	};
	
	// Navigate asynchronously at the specified Uri
	document.Navigate("https://docs.aspose.com/html/net/creating-a-document/document.html");
	
	// Here the outerHTML is empty yet
    Console.WriteLine($"outerHTML = {outerHTML}");
                   
        // Wait 5 seconds for the file to load
        if (!resetEvent.WaitOne(5000))
        {
            Console.WriteLine("Thread works too long, more than 5000 ms");
        }

    // Here the outerHTML is filled 
    Console.WriteLine("outerHTML = {0}", outerHTML);

{{< /highlight >}}

*ReadyStateChange* is not the only event that can used to handle an async loading operation, you can also subscribe for *Load* event, as it follows:
{{< highlight java >}}
using System;
using Aspose.Html;
using System.Threading;
...
    // Initialize an AutoResetEvent
    var resetEvent = new AutoResetEvent(false);
	
	// Initialize an HTML document
    var document = new HTMLDocument();
    var isLoading = false;            

    // Subscribe to the 'OnLoad' event
    // This event will be fired once the document is fully loaded
    document.OnLoad += (sender, @event) =>
    {                
        isLoading = true;
		resetEvent.Set();
    };
    
    // Navigate asynchronously at the specified Uri
    document.Navigate("https://docs.aspose.com/html/net/creating-a-document/document.html");
                
    // Here the document is not loaded yet
       
    // Wait 5 seconds for the file to load
        if (!resetEvent.WaitOne(5000))
        {
            Console.WriteLine("Thread works too long, more than 5000 ms");
        }
			
    // Here is the loaded document
    Console.WriteLine("outerHTML = {0}", document.DocumentElement.OuterHTML);
{{< /highlight >}}
{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  