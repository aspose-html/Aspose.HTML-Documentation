---
title: Convert MHTML to PDF in Java
linktitle: Convert MHTML to PDF
type: docs
weight: 10
keywords: mhtml to pdf, convert mhtml to pdf java, convert mhtml to pdf, mhtml to pdf conversion, mhtml to pdf converter, save options, stream provider, java code
description: Learn how to convert MHTML to PDF using Java library. Consider various MHTML to PDF conversion scenarios in Java code.
url: /java/convert-mhtml-to-pdf/
aliases: 
    - /java/mhtml-to-pdf-conversion/
    - /java/converting-between-formats/mhtml-to-pdf-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

PDF comes with many benefits, and MHTML to PDF conversion can be used for sharing, archiving, or printing web pages. In this article, you will find information about {{%MHTML%}} to {{%PDF%}} conversion scenarios and learn how to use [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) and [MemoryStreamProvider.](https://reference.aspose.com/html/java/com.aspose.html/package-frame)

## **MHTML to PDF by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an MHTML file into various formats. You can convert MHTML to PDF with just a single line of code!

{{< highlight java >}}
    // Invoke the сonvertMHTML() method to convert MHTML to PDF           
    com.aspose.html.converters.Converter.convertMHTML(File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht")), new PdfSaveOptions(), Path.combine(getOutputDir(), "output.pdf"));
{{< /highlight >}}

## **Convert MHTML to PDF in Java**

Let's walk through the step-by-step instructions for a simple MHTML to PDF conversion scenario:

1. Load an MHTML file. You can load MHTML from a file, stream, or URL. In the example we use `openRead(path)` method to open and read an MHTML document from the file system.
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) object. 
1. Use the `сonvertMHTML(stream, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save an MHTML document as a PDF file. The method takes as parameters `stream`, `options`, and `savePath` and performs the conversion.

Please review the following Java code snippet, which shows the MHTML to PDF conversion process with step-by-step instructions:

{{< highlight java >}}
    // Open an existing MHTML file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht"));
    try
    {;
    }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "sample-output.pdf");

    // Create an instance of PdfSaveOptions
    PdfSaveOptions options = new com.aspose.html.saving.PdfSaveOptions();

    // Convert MHTML to PDF
    com.aspose.html.converters.Converter.convertMHTML(stream, options, savePath);   
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

Aspose.HTML for Java allows converting MHTML to PDF using default or custom save options. [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) allows you to customize the rendering process. You can specify the [page size,](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--) [margins,](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--) [file permissions,](https://reference.aspose.com/html/java/com.aspose.html.rendering.pdf.encryption/pdfencryptioninfo) [CSS media-type,](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType) etc. 

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

Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.HTML for Java x.x.x will be displayed against these fields.
{{% /alert %}}

## **Convert MHTML to PDF in Java using PdfSaveOptions**

With Aspose.HTML for Java, you can convert files programmatically with full control over a wide range of conversion parameters. To convert MHTML to PDF with PdfSaveOptions specifying, you should follow a few steps: 

1. Load an MHTML file. 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) object and specify the required properties. In the following example, we apply a custom page size and background color for the resulting PDF document:
    - Use the `setPageSetup()` method to specify the page size for the output PDF document.
    - Use the `setBackgroundColor()` method to set the color that fills the background.
1. Call the `сonvertMHTML(stream, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class.

The following Java example shows how to use [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) and create a PDF file with custom page size and background color:

{{< highlight java >}}
    // Open an existing MHTML file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht"));
    try
    {;
    }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "sample-options.pdf");

    // Create an instance of PdfSaveOptions. Set up the page-size and change the background color to AliceBlue 
    PdfSaveOptions options = new PdfSaveOptions();
    PageSetup pageSetup = new PageSetup();
    Page anyPage = new Page();
    anyPage.setSize(new com.aspose.html.drawing.Size(Length.fromPixels(1000),Length.fromPixels(1000)));
    pageSetup.setAnyPage(anyPage);
    options.setPageSetup(pageSetup);
    options.setBackgroundColor(Color.getAliceBlue());

    // Convert MHTML to PDF
    com.aspose.html.converters.Converter.convertMHTML(stream, options, savePath);        
{{< /highlight >}}

<!--## **Output Stream Providers**

If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface to have manual control over the file creating process. This interface designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering document/page.

{{% alert color="primary" %}}
Aspose.HTML for Java provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).
{{% /alert %}} 

The example below shows how to implement and use the your own *MemoryStreamProvider* in the application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}-->

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**MHTML to PDF Converter**](https://products.aspose.app/html/conversion/mhtml-to-pdf) that converts MHTML to PDF with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/mhtml-to-pdf" target="_blank">![Text "Banner MHTML to PDF Converter"](./../../images/mhtml-to-pdf.png#center)</a>