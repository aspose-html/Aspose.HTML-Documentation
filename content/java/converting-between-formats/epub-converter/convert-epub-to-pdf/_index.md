---
title: Convert EPUB to PDF in Java
linktitle: Convert EPUB to PDF
keywords: EPUB to pdf, convert epub to pdf java, convert epub to pdf, epub to pdf conversion, epub to pdf converter, save options, stream provider, java code
description: Convert EPUB to PDF in Java using Aspose.HTML API. Consider various EPUB to PDF conversion scenarios in Java code.
url: /java/convert-epub-to-pdf/
type: docs
weight: 10
aliases:
  - /java/epub-to-pdf-conversion/
  - /java/converting-between-formats/epub-to-pdf-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

EPUB is a format that is widely used for e-books, but it is not always compatible with all devices or software applications. Converting EPUB to PDF can be helpful in situations where you want to create a document that is easily readable across different devices and platforms. PDFs are also optimized for printing, making them ideal for creating physical copies of your documents. You can configure security settings for PDF files to restrict access or editing.

In this article, you will find information about how to convert EPUB to PDF using Aspose.HTML for Java library and how to use [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) and [MemoryStreamProvider.](https://reference.aspose.com/html/java/com.aspose.html/package-frame)

## **EPUB to PDF by a few lines of Java code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an EPUB file into various formats. You can convert EPUB to PDF in your Java application literally with a few lines of code!

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Invoke the convertEPUB() method           
    com.aspose.html.converters.Converter.convertEPUB(stream, new PdfSaveOptions(), Path.combine(getOutputDir(), "convert-by-few-lines.pdf"));
{{< /highlight >}}

## **Convert EPUB to PDF in Java**

You should follow a few steps: 

1. Open an existing EPUB file. In the example, we use the `openRead()` method of System.IO.FileStream class to open and read an EPUB file from the file system at the specified path.
1. Create an instance of [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions). Use the empty PdfSaveOptions() constructor to convert with the default save options.
1. Use the `convertEPUB(stream, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save EPUB as a PDF file. You need to pass the EPUB file stream, PdfSaveOptions, and output file path to the ConvertEPUB() method as parameters.

The following Java code snippet shows how to convert EPUB to PDF using Aspose.HTML:

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "input-output.pdf");

    // Create an instance of PdfSaveOptions
    PdfSaveOptions options = new PdfSaveOptions();

    // Call the convertEPUB() method
    com.aspose.html.converters.Converter.convertEPUB(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

Aspose.HTML provides the ability to programmatically convert EPUB to PDF with full control over various conversion options using [PdfSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) This feature allows users to customize the rendering process by setting the [page size,](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--) [margins,](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--) [file permissions,](https://reference.aspose.com/html/java/com.aspose.html.rendering.pdf.encryption/pdfencryptioninfo) [CSS media-type,](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType) and other parameters.

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

## **Convert EPUB to PDF using PdfSaveOptions**

Setting different options of PdfSaveOptions class gives you control over the page size, resolution, background color, and compression settings for the output PDF. These are the steps to convert an EPUB file to PDF format with PdfSaveOptions specifying.

1. Open an existing EPUB file.
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) object and specify the required save options. Use the `setPageSetup()` and `setBackgroundColor()` methods to set the page size and background color.
1. Call the `convertEPUB(stream, options, savePath)` method to save EPUB as a PDF file. You need to pass the EPUB file stream, PdfSaveOptions, and output file path to the convertEPUB () method as parameters.

The following example shows how to use PdfSaveOptions and create a PDF file with custom custom page-size and background color:

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "input-options.pdf");

    // Create an instance of PdfSaveOptions. Set up the page-size and change the background color to AliceBlue
    PdfSaveOptions options = new PdfSaveOptions();
    PageSetup pageSetup = new PageSetup();
    Page anyPage = new Page();
    anyPage.setSize(new com.aspose.html.drawing.Size(Length.fromPixels(1000),Length.fromPixels(1000)));
    pageSetup.setAnyPage(anyPage);
    options.setPageSetup(pageSetup);
    options.setBackgroundColor(Color.getAliceBlue());

    // Call the convertEPUB() method
    com.aspose.html.converters.Converter.convertEPUB(stream, options, savePath);
{{< /highlight >}}

<!-- ## **Output Stream Providers**

When it is necessary to save files to remote storage such as a cloud or database, implementing the [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface can provide manual control over the file creation process. This interface serves as a callback object that allows for creating a stream at the beginning of the document or page (depending on the output format) and the release of the early created stream after the document or page is rendered. Using the MemoryStreamProvider interface allows users to have greater control over the file-saving process, which can be particularly useful when the storage location is remote or requires specific configurations.

{{% alert color="primary" %}} 
Aspose.HTML for Java provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).
{{% /alert %}} 

The following example demonstrates how to implement and use a custom *MemoryStreamProvider* in your Java application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}
-->

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**EPUB to PDF Converter**](https://products.aspose.app/html/conversion/epub-to-pdf) that converts EPUB to PDF with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/epub-to-pdf" target="_blank">![Text "Banner EPUB to PDF Converter"](./../../../epub-to-pdf.png#center)</a>