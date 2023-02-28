---
title: Convert Markdown to PDF in Java
linktitle: Convert Markdown to PDF
type: docs
weight: 20
keywords: markdown to pdf, convert markdown to pdf java, convert markdown to pdf, markdown to pdf conversion, markdown to pdf converter, save options, stream provider, java code
description: Learn how to convert Markdown to PDF using Java library. Consider various Markdown to PDF conversion scenarios in Java code.
url: /java/convert-markdown-to-pdf/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

Markdown is a lightweight markup language, and while Markdown is an excellent tool for writing and structuring content, it has limited formatting options, is not optimized for printing, etc. Converting Markdown to PDF allows you to take advantage of the PDF format. PDF comes with many benefits, and Markdown to PDF conversion can be used for sharing, formatting, archiving, or printing web pages. In this article, you will find information about {{%Markdown%}} to {{%PDF%}} conversion scenarios and learn how to use [PdfSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions)

{{% alert color="primary" %}}
**Note:** Any conversion from Markdown to other formats goes through the **Markdown to HTML conversion** stage.
{{% /alert %}}

## **Markdown to PDF**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert a Markdown file into various formats. Let's walk through the step-by-step instructions for a simple Markdown to PDF conversion scenario:

1. Load a Markdown file. You can load Markdown from a file or stream. In the following example we create Markdown from scratch.
1. Use the `convertMarkdown(sourcePath)` method to convert Markdown to HTML document. 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) object. 
1. Use the `сonvertHTML(document, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save an intermediate HTML document as a PDF file. The method takes as parameters `document`, `options`, and `savePath` and performs the conversion.

Please review the following Java code snippet, which shows the Markdown to PDF conversion process with step-by-step instructions:

{{< highlight java >}}
    // Prepare a path to a source Markdown file
    String sourcePath = Path.combine(getOutputDir(), "document.md");

    // Prepare a simple Markdown example
    String code = StringExtensions.concat("### Hello, World!", 
                "\r\n", 
                "[visit applications](https://products.aspose.app/html/family)");
    // Create a Markdown file
    com.aspose.html.internal.ms.System.IO.File.writeAllText(sourcePath, code);            

    // Convert Markdown to HTML 
    HTMLDocument document = Converter.convertMarkdown(sourcePath);

    // Prepare a path for converted PDF file saving
    String savePath = Path.combine(getOutputDir(), "document-output.pdf");

    try {
        // Convert the HTML document to PDF file format
        com.aspose.html.converters.Converter.convertHTML(document, new PdfSaveOptions(), savePath);
    }
    finally { if (document != null) document.dispose(); }    
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

Aspose.HTML for Java allows converting Markdown to PDF using default or custom save options. [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) allows you to customize the rendering process. You can specify the [page size,](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--) [margins,](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--) [file permissions,](https://reference.aspose.com/html/java/com.aspose.html.rendering.pdf.encryption/pdfencryptioninfo) [CSS media-type,](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType) etc. 

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
For further information on how to customize the conversion process with [PdfSaveOptions,](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) you can refer to the [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

## **Convert Markdown to PDF in Java using PdfSaveOptions**

With Aspose.HTML for Java, you can convert files programmatically with full control over a wide range of conversion parameters. To convert Markdown to PDF with PdfSaveOptions specifying, you should follow a few steps: 

1. Load a Markdown file. 
1. Convert Markdown to HTML using one of the `convertMarkdown()` methods. 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) object and specify the required properties. In the following example, we apply a custom resolutions and background color for the resulting PDF document:
    - Use the `setHorizontalResolution()` and `VerticalResolution()` methods to set horizontal and vertical resolutions for output PDF file.
    - Use the `setBackgroundColor()` method to set the color that fills the background.
1. Call the `сonvertHTML(document, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class.

The following Java example shows how to use [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) and create a PDF file with custom resolutions and background color:

{{< highlight java >}}
    // Prepare a path to a source Markdown file
    String sourcePath = Path.combine(getDataDir(), "nature.md");

    // Prepare a path for converted PDF file saving 
    String savePath = Path.combine(getOutputDir(), "nature-output.pdf");

    // Convert Markdown to HTML
    HTMLDocument document = Converter.convertMarkdown(sourcePath);
    try {
        // Initialize PdfSaveOptions. Set up the resolutions and change the background color to AliceBlue
        PdfSaveOptions options = new PdfSaveOptions();
        options.setHorizontalResolution(new Resolution(200, UnitType.AUTO));
        options.setVerticalResolution(new Resolution(200, UnitType.AUTO));;
        com.aspose.html.drawing.Color.getAliceBlue().CloneTo(options.getBackgroundColor());       

        // Convert the HTML document to PDF file format
        com.aspose.html.converters.Converter.convertHTML(document, options, savePath);
    }
    finally { if (document != null) document.dispose(); }    
{{< /highlight >}}

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**Markdown to PDF Converter**](https://products.aspose.app/html/conversion/md-to-pdf) that converts Markdown to PDF with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/md-to-pdf" target="_blank">![Text "Banner Markdown to PDF Converter"](./../../../markdown-to-pdf.png#center)</a>