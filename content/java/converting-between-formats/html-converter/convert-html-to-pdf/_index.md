---
title: Convert HTML to PDF Using Java
linktitle: Convert HTML to PDF
keywords: html to pdf, convert html to pdf java, convert html to pdf, html to pdf conversion, html to pdf converter, save options, stream provider, java code
description: Convert HTML to PDF in Java using Aspose.HTML API. Consider various HTML to PDF conversion scenarios in Java code.
type: docs
weight: 10
url: /java/convert-html-to-pdf_/
aliases: 
  - /java/html-to-pdf-conversion/
  - /java/converting-between-formats/html-to-pdf-conversion/ 
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-03-03
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

In this article, you find information on how to convert an HTML document into a Portable Document Format ({{%PDF%}}) file format using Aspose.HTML for Java library. PDF files have many advantages over other formats, and sometimes you may need to convert HTML to PDF. This is particularly useful for creating high-quality, printer-friendly versions of web pages, generating reports, or sharing documents that are difficult to edit or modify.

In this article, you find information on how to convert HTML to PDF using `convertHTML()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class, and how to apply [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) and [ICreateStreamProvider](https://reference.aspose.com/html/java/com.aspose.html.io/ICreateStreamProvider) parameters.

## **HTML to PDF by a single line of Java code**

HTML to PDF conversion is a highly sought-after feature, and Aspose.HTML for Java offers an easy solution. Through static methods in the Converter class, you can convert an HTML document into a PDF file with just a single line of code!

{{< highlight java >}}
    // Invoke the сonvertHTML() method to convert HTML to PDF           
    com.aspose.html.converters.Converter.convertHTML("<h1>Convert HTML to PDF!</h1>", ".", new PdfSaveOptions(), Path.combine(getOutputDir(), "convert-with-single-line.pdf"));
{{< /highlight >}}

In the example we use the convertHTML(content, baseUri, options, outputPath) method of the Converter class that takes four parameters: string with HTML code to be converted, the base folder for the input HTML file, an instance of the PdfSaveOptions class, and the output file path where the converted file will be saved.

## **Convert HTML to PDF in Java**

Let's walk through the step-by-step instructions for a simple HTML to PDF conversion scenario:

1. Load an HTML file using one of HTMLDocument() constructors of the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class. You can load HTML from a file, HTML code, stream, or URL (see the [Creating an HTML Document](/html/java/working-with-documents/creating-a-document/) article). In the example we use `HTMLDocument(address)` constructor that initializes an HTML document from a file. 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/PdfSaveOptions) object. Use the empty PdfSaveOptions() constructor to convert with the default save options.
1. Use the `сonvertHTML(document, options, outputPath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class to save HTML as a PDF file.

Please review the following Java code snippet, which shows the HTML to PDF conversion process with step-by-step instructions:

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "spring.html");

    // Prepare a path for converted file saving 
    String outputPath = Path.combine(getOutputDir(), "spring-output.pdf");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize PdfSaveOptions object
    PdfSaveOptions options = new PdfSaveOptions();

    // Convert HTML to PDF
    com.aspose.html.converters.Converter.convertHTML(document, options, outputPath);
{{< /highlight >}}

## **Save Options**

Aspose.HTML for Java allows converting HTML to PDF using default or custom save options. [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) allows you to customize the rendering process. You can specify the [page size,](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--) [margins,](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--) [file permissions,](https://reference.aspose.com/html/java/com.aspose.html.rendering.pdf.encryption/pdfencryptioninfo) [CSS media-type,](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType) etc. 

| Metod                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [setJpegQuality(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering.pdf/PdfRenderingOptions#setJpegQuality--) | Specifies the quality of JPEG compression for images. The default value is 95. |
| [getCss()](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getCss--) | Gets a [CssOptions](https://reference.aspose.com/html/java/com.aspose.html.rendering/CssOptions) object which is used for configuration of CSS properties processing. |
| [setBackgroundColor(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setBackgroundColor-com.aspose.ms.System.Drawing.Color-) | Sets the color that will fill the background of every page. By default, this property is `Transparent`. |
| [setPageSetup(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setPageSetup-com.aspose.rendering.PageSetup-) | This method sets a page setup object and uses it for configuration output page-set. |
| [setHorizontalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setHorizontalResolution-com.aspose.drawing.Resolution-) | Sets horizontal resolution for internal images, in pixels per inch. By default this property is 300 dpi.|
| [setVerticalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setVerticalResolution-com.aspose.drawing.Resolution-) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [setEncryption](https://reference.aspose.com/html/java/com.aspose.html.rendering.pdf/PdfRenderingOptions#setEncryption-com.aspose.rendering.pdf.encryption.PdfEncryptionInfo-) | This method gets or sets encryption details. If it is not set, then no encryption will be performed. |

{{% alert color="primary" %}}
To learn more about [PdfSaveOptions,](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) please read the [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.

You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Convert HTML to PDF in Java using PdfSaveOptions**

With Aspose.HTML for Java, you can convert files programmatically with full control over a wide range of conversion parameters. To convert HTML to PDF with PdfSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the  [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class. 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) object and specify the required properties.
1. Use the `сonvertHTML()` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save HTML as a PDF file.

The following Java example shows how to use [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) and create a PDF file with custom page-size, margins, resolutions, background color, and compression specifying:

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "drawing.html");

    // Prepare a path for converted file saving 
    String outputPath = Path.combine(getOutputDir(), "drawing-options.pdf");

    // Initialize an HTML document from the file
    HTMLDocument   document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize PdfSaveOptions. Set up the page-size 500x300 pixels, margins, resolutions and change the background color to AliceBlue 
    PdfSaveOptions options = new PdfSaveOptions();
    options.setHorizontalResolution(new Resolution(200, UnitType.AUTO));
    options.setVerticalResolution(new Resolution(200, UnitType.AUTO));;
    com.aspose.html.drawing.Color.getAliceBlue().CloneTo(options.getBackgroundColor());
    options.setJpegQuality(100);
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(500, 300), new Margin(20, 10, 10, 10)));

    // Convert HTML to PDF
    com.aspose.html.converters.Converter.convertHTML(document, options, outputPath);    
{{< /highlight >}}

The [PdfSaveOptions()](https://reference.aspose.com/html/java/com.aspose.html.saving/PdfSaveOptions#PdfSaveOptions--) constructor initializes an instance of the PdfSaveOptions class that is passed to `convertHTML()` method. The method takes the `document`, `options`,  output file path `outputPath` and performs the conversion operation. 

The PdfSaveOptions class provides methods that give you full control over a wide range of parameters and improve the process of converting HTML to PDF format. In the example above, several save options were used:
 - `setJpegQuality()` specifies JPEG compression quality for images.
 - `setBackgroundColor()` sets the color that fills the background.
 - `setHorizontalResolution()` and `setVerticalResolution()` set horizontal and vertical resolutions for output PDF files.
 - `setPageSetup()` specifies the page size and margins for the output document. 

**One more Java example**. Here we create HTML document from scratch - prepare HTML code and save it to a file. Then we apply PdfSaveOptions to convert HTML to PDF: 

{{< highlight java >}}
    String documentPath = Path.combine(getOutputDir(), "save-options.html");
    String savePath = Path.combine(getOutputDir(), "save-options-output.pdf");

    // Prepare HTML code and save it to a file
    String code = StringExtensions.concat("<h1>PdfSaveOptions Class</h1>\r\n", 
              "<p>Using PdfSaveOptions Class, you can programmatically apply a wide range of conversion parameters such as BackgroundColor, Resolutions, PageSetup, etc.</p>\r\n");

    com.aspose.html.internal.ms.System.IO.File.writeAllText(documentPath, code);

    // Initialize an HTML Document from the html file
    HTMLDocument   document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }
        
    // Set up the page-size, margins and change the background color to AntiqueWhite
    PdfSaveOptions  options = new PdfSaveOptions();
    com.aspose.html.drawing.Color.getAntiqueWhite().CloneTo(options.getBackgroundColor());
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(com.aspose.html.drawing.Length.fromInches(4.9f), com.aspose.html.drawing.Length.fromInches(3.5f))));

    // Convert HTML to PDF
    com.aspose.html.converters.Converter.convertHTML(document, options, savePath);   
{{< /highlight >}}

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
Aspose.HTML offers a free online [**HTML to PDF Converter**](https://products.aspose.app/html/conversion/html-to-pdf) that converts HTML to PDF with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-pdf" target="_blank">![Text "Banner HTML to PDF Converter"](./../../images/html-to-pdf.png#center)</a>