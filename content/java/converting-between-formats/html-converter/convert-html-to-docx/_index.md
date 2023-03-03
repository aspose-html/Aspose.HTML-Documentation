---
title: Convert HTML to DOCX in Java
linktitle: Convert HTML to DOCX
type: docs
weight: 30
keywords: html to docx, convert html to docx java, convert html to docx, html to docx conversion, html to docx converter, save options, stream provider, java code
description: Convert HTML to DOCX in Java using Aspose.HTML API. Consider various HTML to DOCX conversion scenarios in Java code.
url: /java/convert-html-to-docx/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-03-03
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

A DOCX file is a Microsoft Word document that typically contains text but can contain a wide range of data, including tables,  graphics, video, sounds, etc. The DOCX file is highly editable, easy to use, and manageable in size. This format is popular because of the variety of options it offers users to write any documents and is available through numerous programs.

In this article, you find information on how to convert an HTML document into a ({{%DOCX%}}) file format using convertHTML() methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class, and how to apply DocSaveOptions and [ICreateStreamProvider](https://reference.aspose.com/html/java/com.aspose.html.io/ICreateStreamProvider) parameters.

## **HTML to DOCX by a single line of Java code**

HTML to DOCX conversion is a highly sought-after feature, and Aspose.HTML for Java offers an easy solution. Through static methods in the Converter class, users can convert an HTML document into a DOCX file with just a single line of code!

{{< highlight java >}}
    // Invoke the convertHTML() method to convert HTML code to DOCX           
    com.aspose.html.converters.Converter.convertHTML("<h1>Convert HTML to DOCX!</h1>", ".", new DocSaveOptions(), Path.combine(getOutputDir(), "convert-with-single-line.docx"));   
{{< /highlight >}}

## **Convert HTML to DOCX**

Let's walk through the step-by-step instructions for a simple HTML to DOCX conversion scenario:

1. Load an HTML file using one of HTMLDocument() constructors of the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class. You can load HTML from a file, HTML code, stream, or URL (see the [Creating an HTML Document](/html/java/working-with-documents/creating-a-document/) article). In the example we use `HTMLDocument(address)` constructor that initializes an HTML document from a file. 
1. Create a new `DocSaveOptions` object. 
1. Use the `сonvertHTML(document, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class to save HTML as a DOCX file.

Please review the following Java code snippet, which shows the HTML to DOCX conversion process with step-by-step instructions:

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "canvas.html");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "canvas-output.docx");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize DocSaveOptions 
    DocSaveOptions options = new DocSaveOptions();

    // Convert HTML to DOCX
    com.aspose.html.converters.Converter.convertHTML(document, options, savePath);      
{{< /highlight >}}
    

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Convert HTML to DOCX using DocSaveOptions**

With Aspose.HTML for Java, you can convert files programmatically with full control over a wide range of conversion parameters. To convert HTML to DOCX with DocSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the  [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class. 
1. Create a new `DocSaveOptions` object and specify the required properties. Use the `getPageSetup()` method to specify the page size and margins for the output document. 
1. Use the `сonvertHTML()` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class to save HTML as a DOCX file.

The following Java example shows how to use DocSaveOptions and create a DOCX file with custom page size and margins:

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "canvas.html");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "canvas-output-options.docx");

    // Initialize an HTML document from the file
    HTMLDocument   document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize DocSaveOptions. Set up the pag size 600x400 pixels and margins
    DocSaveOptions options = new DocSaveOptions();
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(600, 400), new Margin(10, 10, 10, 10)));

    // Convert HTML to DOCX
    com.aspose.html.converters.Converter.convertHTML(document, options, savePath);       
{{< /highlight >}}

The `DocSaveOptions()` constructor initializes an instance of the DocSaveOptions class that is passed to `convertHTML()` method. The method takes the `document`, `options`, output file path `savePath` and performs the conversion operation.

<!--## **Output Stream Providers**

When it is necessary to save files to remote storage such as a cloud or database, implementing the [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface can provide manual control over the file creation process. This interface serves as a callback object that allows for creating a stream at the beginning of the document or page (depending on the output format) and the release of the early created stream after the document or page is rendered. Using the MemoryStreamProvider interface allows users to have greater control over the file-saving process, which can be particularly useful when the storage location is remote or requires specific configurations.

{{% alert color="primary" %}} 

Aspose.HTML for Java provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance {{%PDF%}}, {{%XPS%}}), others create multiple files (Image formats {{%JPG%}}, {{%PNG%}}, etc.).

{{% /alert %}} 

The example below shows how to implement and use your own *MemoryStreamProvider* in the application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}-->

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.

Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/html-to-docx" target="_blank">**HTML to DOCX Converter**</a> that converts HTML to DOCX with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-docx" target="_blank">![Text "Banner HTML to DOCX Converter"](./../../images/html-to-docx.png#center)</a>