---
title: Convert HTML to MHTML Using Java
linktitle: Convert HTML to MHTML
keywords: html to mhtml, convert html to mhtml java, convert html to mhtml, html to mhtml conversion, html to mhtml converter, save options, stream provider, java code
description: Convert HTML to MHTML in Java using Aspose.HTML API. Consider various HTML to MHTML conversion scenarios in Java code.
type: docs
weight: 60
url: /java/convert-html-to-mhtml/
aliases: 
  - /java/html-to-mhtml-conversion/
  - /java/converting-between-formats/html-to-mhtml-conversion/ 
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

HTML files often link to external resources such as images, videos, audio, and other documents by specifying their URLs. If you want to archive or save a web page containing such external resources, you need to save them all separately along with the HTML file, which makes it a bit complicated and cluttered. MHTML is a file format that combines HTML with external resources into a single .mht file. MHTML uses the MIME email protocol to combine web page elements into a single archive file, making it easier to archive web pages.

This article explains how to convert HTML to MHTML using Aspose.HTML for Java library and apply [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions).

## **HTML to MHTML by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to MHTML in your Java application literally with a single line of code!

{{< highlight java >}}
    // Invoke the convertHTML() method to convert the HTML code to MHTML file           
    com.aspose.html.converters.Converter.convertHTML("<h1>Hellow, Word!</h1>", ".", new MHTMLSaveOptions(), Path.combine(getOutputDir(), "convert-with-single-line.mht"));

{{< /highlight >}}

## **Convert HTML to MHTML in Java**

Converting a file to another format using the `convertHTML()` method is a sequence of operations among which document loading and saving. The next example explains how to convert HTML to MHTML by line by line:

1. Load an HTML file using [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class.
1. Create an instance of the [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions) class.
1. Use the `convertHTML(document, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class and pass the required parameters to it.

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "drawing.html");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "drawing-output.mht");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try /*JAVA: was using*/
    {;
    }
    finally { if (document != null) ((IDisposable)document).dispose(); }

    // Initialize MHTMLSaveOptions object
    MHTMLSaveOptions options = new MHTMLSaveOptions();

    // Convert HTML to MHTML
    com.aspose.html.converters.Converter.convertHTML(document, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Convert HTML to MHTML using MHTMLSaveOptions**

Aspose.HTML allows converting HTML to MHTML using default or custom save options. [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions) usage enables you to customize the rendering process. You can specify the [UrlRestriction](https://reference.aspose.com/html/java/com.aspose.html.saving/ResourceHandlingOptions#getUrlRestriction--), [MaxHandlingDepth](https://reference.aspose.com/html/java/com.aspose.html.saving/ResourceHandlingOptions#getMaxHandlingDepth--), etc. To convert HTML to MHTML with MHTMLSaveOptions specifying, you should follow a few steps: 

1. Load or prepare an HTML file. In this example we create a source HTML file from scratch.
1. Create a new [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions) object.
1. Use the `convertHTML()` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save HTML document as an MHTML file.

{{< highlight java >}}
    // Prepare HTML code with a link to another file and save it to the file as 'document.html'
    String code = StringExtensions.concat("<span>Hello, World!!</span> ", 
                "<a href='document2.html'>click</a>");
    File.writeAllText("document.html", code);

    // Prepare HTML code and save it to the file as 'document2.html'
    code = "<span>Hello, World!!</span>";
    File.writeAllText("document2.html", code);
        
    String savePath = Path.combine(getOutputDir(), "output-options.mht");

    // Change the value of the resource linking depth to 1 in order to convert document with directly linked resources
    MHTMLSaveOptions options = new MHTMLSaveOptions();
    // TODO: Fix this, no set for resource handling
//       {
//           ResourceHandlingOptions =
//
//           {
//               MaxHandlingDepth = 1
//           }
//       };

    // Convert HTML to MHTML
    com.aspose.html.converters.Converter.convertHTML("document.html", options, savePath);
{{< /highlight >}}

The [MHTMLSaveOptions()](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions) constructor initializes an instance of the MHTMLSaveOptions class that is passed to `convertHTML()` method. The `convertHTML()` method takes the `document`, `options`,  output file path `savePath` and performs the conversion. In the above example, we use the property `MaxHandlingDepth = 1` means that only pages directly referenced from the saved document will be handled.

{{% alert color="primary" %}} 
To learn more about [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions) please read [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.

Aspose.HTML offers a free online [HTML to MHTML Converter](https://products.aspose.app/html/conversion/html-to-mhtml) that converts HTML to MHTML with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-mhtml" target="_blank">![Text "Banner HTML to MHTML Converter"](./../../../html-to-mhtml.png#center)</a>