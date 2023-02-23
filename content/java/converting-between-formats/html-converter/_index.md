---
title: HTML Converter - Convert HTML in Java
linktitle: HTML Converter
keywords: html converter, html conversions, convert html, html to image, convert html to image, java example, online converter, java code
description: Convert HTML to other formats using Aspose.HTML for Java API or Online HTML Converter. Consider Java example of HTML to PNG conversion.
weight: 10
type: docs
url: /java/html-converter/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

{{%HTML%}} is the standard language used to create documents for display in web browsers. As the web language, HTML has continuously evolved to meet the changing demands of displaying new types of information on web pages. HTML documents are the foundation of the World Wide Web and are used to create virtually all the content you see online. Converting HTML to other formats can be helpful in many ways. For example, by converting HTML to PDF, you can view content on a broader range of devices and platforms, make it easier to print the content while preserving the original formatting, or provide a way to keep the content for future reference.

One of the main features of Aspose.HTML is its conversion capability. Aspose.HTML for Java provides easy access to conversion methods through its [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class, which is a shared facade for most often conversion scenarios and offers a wide range of HTML conversions to popular formats like {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, {{%GIF%}}, {{%MHTML%}},  and {{%MD%}}. 

## **How to Convert HTML in Java**

This articles in the "HTML Converter" chapter give information on the list of supported HTML conversions and how to perform them using the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class.

{{% alert color="primary" %}} 

To perform HTML conversion, you should take a few steps:

1. [Install Aspose.HTML for Java library](/html/java/getting-started/installation/) to convert HTML.
2. Initialize a new instance of the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class using one of HTMLDocument() constructors.
3. Create a Save Options object that specifies the desired output format and conversion options.
4. Call one of the [convertHTML()](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) methods and pass the necessary parameters to it.
    {{% /alert %}}   

Please take a look over the following Java code snippet that shows the HTML to PNG conversion using the `convertHTML(document, options, savePath)` method.
{{< highlight java >}}

	// Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "nature.html");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "nature-output.png");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try /*JAVA: was using*/
    {;
    }
    finally { if (document != null) ((com.aspose.html.internal.ms.System.IDisposable)document).dispose(); }

    // Initialize ImageSaveOptions 
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Png);

    // Convert HTML to PNG
    com.aspose.html.converters.Converter.convertHTML(document, options, savePath);

{{< /highlight >}}

 The `convertHTML()` method takes as parameters `document`,  `options`, and `savePath` and performs the operation. **Note:** You need to specify the path to the output file in your local file system (`savePath`). Also, for `HTMLDocument(documentPath)` constructor, you need to provide the path to a source HTML file on your local file system. 

## **Popular HTML Conversions**

<div class="row">
	<div class="col-md-3">
		<h3>Convert HTML to PDF, XPS</h3>				
		<ul>
			<li><a href="/html/java/convert-html-to-pdf/">Convert HTML to PDF</a></li>
			<li><a href="/html/java/convert-html-to-pdf/#convert-html-to-pdf-in-java-using-pdfsaveoptions">Convert HTML to PDF using PdfSaveOptions</a></li>
			<li><a href="/html/java/convert-html-to-pdf/#output-stream-providers">Convert HTML to PDF using MemoryStreamProvider</a></li>
			<li><a href="/html/java/convert-html-to-xps/">Convert HTML to XPS</a></li>					
		</ul>
	</div>
	<div class="col-md-3">
		<h3>Convert HTML to Word</h3>	
		<ul>
			<li><a href="/html/java/convert-html-to-docx/">Convert HTML to DOCX</a></li>
			<li><a href="/html/java/convert-html-to-docx/#convert-html-to-docx-using-docsaveoptions">Convert HTML to DOCX using DocSaveOptions</a></li>
			<li><a href="/html/java/convert-html-to-docx/#output-stream-providers">Convert HTML to DOCX using MemoryStreamProvider</a></li>
	</div>
	<div class="col-md-3">
		<h3>Convert HTML to Image</h3>	
		</ul>
		<ul>
			<li><a href="/html/java/convert-html-to-image/#convert-html-to-jpg">Convert HTML to JPG</a></li>
			<li><a href="/html/java/convert-html-to-image/#convert-html-to-png">Convert HTML to PNG</a></li>
			<li><a href="/html/java/convert-html-to-image/#convert-html-to-bmp">Convert HTML to BMP</a></li>
			<li><a href="/html/java/convert-html-to-image/#convert-html-to-gif">Convert HTML to GIF</a></li>
			<li><a href="/html/java/convert-html-to-image/#convert-html-to-tiff">Convert HTML to TIFF</a></li>						
		</ul>
	</div>
	<div class="col-md-3">
		<h3>Convert HTML to Web Formats</h3>
		<ul>
			<li><a href="/html/java/convert-html-to-markdown/">Convert HTML to Markdown</a></li>
			<li><a href="/html/java/convert-html-to-mhtml/">Convert HTML to MHTML</a></li>			
		</ul>
	</div>	
</div>
{{% alert color="primary" %}} 

Aspose.HTML offers a free online [**HTML Converter**](https://products.aspose.app/html/conversion) for converting HTML files to a variety of popular formats. You can easily convert  [HTML to PDF,](https://products.aspose.app/html/conversion/html-to-pdf) HTML to XPS, [HTML to Image,](https://products.aspose.app/html/conversion/html-to-image) HTML to MD and HTML to MHTML. Just select the file, choose the format to convert, and you're done. It's fast and completely free!

You can download the complete Java examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}} 
