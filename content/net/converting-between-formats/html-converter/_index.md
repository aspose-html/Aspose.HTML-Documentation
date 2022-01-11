---
title: HTML Converter | C#
linktitle: HTML Converter
keywords: HTML converter, convert html, html to png, convert html to png, c# example.
description: In this article, you learn how to convert HTML to other formats using Aspose.HTML API. You find a list of supported HTML conversions and consider C# example of HTML to PNG conversion.
weight: 10
type: docs
url: /net/converting-between-formats/html-converter/
lastmod: 2022-01-11
---

{{%HTML%}} (HyperText Markup Language) is the standard markup language for documents created for display in browsers. Known as the language of the web, HTML has evolved with requirements of new information demands to be displayed as part of web pages. The latest variant is known as HTML 5 that gives a lot of flexibility for working with the language. HTML pages are either received from a server, where these are hosted or can be loaded from a local system as well.

The main highlight of Aspose.HTML is a conversion feature. Converting between formats is required for various reasons: to work in a familiar, convenient format or to take advantage of different formats for specific tasks. The [Aspose.Html.Converters](https://apireference.aspose.com/html/net/aspose.html.converters) namespace implements easy access to conversion methods. It provides a wide range of HTML conversions to popular formats, such as {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, {{%GIF%}}, {{%MHTML%}},  and {{%MD%}}. 

## **How to Convert HTML**

This article gives information on the list of supported HTML conversions and how to perform them using the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class that groups all low-level conversion operations in a single class to make them comfy and easy to use. 

{{% alert color="primary" %}} 

Any conversion you want to perform involves loading an HTML document and saving it in the supported format. It can be different scenarios, but it can be made with a few required steps:

1. Load an HTML document into a Document object using one of [HTMLDocument()](https://apireference.aspose.com/html/net/aspose.html/htmldocument) constructors. You can load HTML from a file, HTML code, stream, or URL.
2. Create a Save Options object.
3. Invoke one of the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/converthtml/index) methods and pass the required parameters to it.
    {{% /alert %}}   

Please take a look over the following C# code snippet that shows the HTML to PNG conversion using the [ConvertHTML(`document, options, savePath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method.
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
        

    // Initialize an HTML document from a file
    using var document = new HTMLDocument(Path.Combine(DataDir, "nature.html"));
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions();
    
    // Convert HTML to PNG
    Converter.ConvertHTML(document, options, Path.Combine(OutputDir, "nature-output.png"));
{{< /highlight >}}

 The ConvertHTML() method takes as parameters `document`,  `options`, and `savePath` and performs the operation. **Note:** You need to specify the path to the output file in your local file system (`savePath`). Also, for [HTMLDocument(`address`)](https://apireference.aspose.com/html/net/aspose.html/htmldocument/constructors/10) constructor, you need to provide the path to a source HTML file on your local file system. 



## **Popular HTML Conversions**


<div class="row">
	<div class="col-md-3">
		<h3>Convert HTML to PDF, XPS</h3>				
		<ul>
			<li><a href="/html/net/converting-between-formats/html-to-pdf/">Convert HTML to PDF</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-pdf/#convert-html-to-pdf-using-pdfsaveoptions">Convert HTML to PDF using PdfSaveOptions</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-pdf/#output-stream-providers">Convert HTML to PDF using MemoryStreamProvider</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-xps/">Convert HTML to XPS</a></li>					
		</ul>
	</div>
	<div class="col-md-3">
		<h3>Convert HTML to Word</h3>	
		<ul>
			<li><a href="/html/net/converting-between-formats/html-to-docx/">Convert HTML to DOCX</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-docx/#convert-html-to-docx-using-docsaveoptions">Convert HTML to DOCX using DocSaveOptions</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-docx/#output-stream-providers">Convert HTML to DOCX using MemoryStreamProvider</a></li>
	</div>
	<div class="col-md-3">
		<h3>Convert HTML to Image</h3>	
		</ul>
		<ul>
			<li><a href="/html/net/converting-between-formats/html-to-jpg/">Convert HTML to JPG</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-png/">Convert HTML to PNG</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-bmp/">Convert HTML to BMP</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-gif/">Convert HTML to GIF</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-tiff/">Convert HTML to TIFF</a></li>						
		</ul>
	</div>
	<div class="col-md-3">
		<h3>Convert HTML to Web Formats</h3>
		<ul>
			<li><a href="/html/net/converting-between-formats/html-to-markdown/">Convert HTML to Markdown</a></li>
			<li><a href="/html/net/converting-between-formats/html-to-mhtml/">Convert HTML to MHTML</a></li>			
		</ul>
	</div>	
</div>
{{% alert color="primary" %}} 

Aspose.HTML offers a free online [**HTML Converter**](https://products.aspose.app/html/conversion) for converting HTML files to a variety of popular formats. You can easily convert  [HTML to PDF](https://products.aspose.app/html/conversion/html-to-pdf), HTML to XPS, [HTML to DOCX](https://products.aspose.app/html/conversion/html-to-docx), [HTML to JPG](https://products.aspose.app/html/conversion/html-to-jpg), [HTML to PNG](https://products.aspose.app/html/conversion/html-to-png), HTML to BMP, HTML to TIFF, [HTML to GIF](https://products.aspose.app/html/conversion/html-to-gif), HTML to MD and HTML to MHTML. Just select the file, choose the format to convert, and you're done. It's fast and completely free!

You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}} 
