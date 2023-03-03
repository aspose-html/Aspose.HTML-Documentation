---
title: Convert SVG to PDF in Java
linktitle: Convert SVG to PDF
type: docs
weight: 10
keywords: svg to pdf, convert svg to pdf java, convert svg to pdf, svg to pdf conversion, svg to pdf converter, save options, java code
description: Convert SVG to PDF in Java using Aspose.HTML API. Consider various SVG to PDF conversion scenarios in Java code.
url: /java/convert-svg-to-pdf/
aliases: 
  - /java/svg-to-pdf-conversion/
  - /java/converting-between-formats/svg-to-pdf-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

In this article, you will find information about how to convert an {{%SVG%}} to {{%PDF%}} and how to use [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) and [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) parameters.

## **SVG to PDF by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an {{%SVG%}} file into various formats. You can convert {{%SVG%}} to {{%PDF%}} in your Java application literally with a single line of code!

{{< highlight java >}}
    // Invoke the convertSVG() method for SVG to PDF conversion          
    com.aspose.html.converters.Converter.convertSVG(Path.combine(getDataDir(), "shapes.svg"), new PdfSaveOptions(), Path.combine(getOutputDir(), "convert-with-single-line.pdf"));
{{< /highlight >}}

## **Convert SVG to PDF in Java**

If your scenario is required rendering an SVG document, for instance, to PDF file format, the following example demonstrates how that is simple:

1. Load an SVG file using [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument) class. You can load SVG from a file, SVG code, stream, or URL. In the following example we create SVG content from scratch. 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/PdfSaveOptions) object. Use the empty PdfSaveOptions() constructor to convert with the default save options.
1. Use one of the `сonvertSVG()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class to save SVG as a PDF file. In the example we use the `convertHTML(content, baseUri, options, savePath)` method that takes four parameters: string with SVG code to be converted, the base folder for the input SVG file, an instance of the PdfSaveOptions class, and the output file path where the converted file will be saved.

Please review the following Java code snippet, which shows the SVG to PDF conversion process with step-by-step instructions:

{{< highlight java >}}
    // Prepare SVG code
    String code = StringExtensions.concat("<svg xmlns='http://www.w3.org/2000/svg'>",
                "<circle cx ='100' cy ='100' r ='50' fill='none' stroke='red' stroke-width='5' />", 
                "</svg>");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "circle.pdf");
       
    // Initialize PdfSaveOptions class
    PdfSaveOptions options = new PdfSaveOptions();

    // Convert SVG to PDF
    com.aspose.html.converters.Converter.convertSVG(code, ".", options, savePath);
{{< /highlight >}}

## **Save Options**

Aspose.HTML for Java allows converting SVG to PDF using default or custom save options. [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) allows you to customize the rendering process. You can specify the [page size,](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--) [margins,](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--) [file permissions,](https://reference.aspose.com/html/java/com.aspose.html.rendering.pdf.encryption/pdfencryptioninfo) [CSS media-type,](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType) etc.

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
Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.HTML for Java x.x.x will be displayed against these fields.

You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Convert SVG to PDF using PdfSaveOptions**

With Aspose.HTML for Java, you can convert files programmatically with full control over a wide range of conversion parameters. To convert SVG to PDF with PdfSaveOptions specifying, you should follow a few steps:

1. Load an SVG file using one of the SVGDocument() constructors of the  [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument) class. 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) object and specify the required properties. The `PdfSaveOptions()` constructor initializes an instance of the PdfSaveOptions class that is passed to `converSVG()` method:
    - Use the `setJpegQuality()` method to specify JPEG compression quality.
    - Use the `setBackgroundColor()` method to set the color that fills the background.
    - Use the `setHorizontalResolution()` and `setVerticalResolution()` methods to set horizontal and vertical resolutions for output PDF files.
    - Use the `setPageSetup()` method to specify the page size and margins for the output document.
1. Call the `сonvertSVG(document, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class. The method takes the `document`, `options`, output file path `savePath` and performs the conversion operation.

The following Java example shows how to use [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) and create a PDF file with custom page-size, margins, resolutions, and background color:

{{< highlight java >}}
    // Prepare a path to a source SVG file
    String documentPath = Path.combine(getDataDir(), "aspose.svg");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "aspose-options.pdf");

    // Initialize an SVG document from the file
    SVGDocument document = new SVGDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize PdfSaveOptions. Set up the page-size, margins, resolutions, JpegQuality, and change the background color
    PdfSaveOptions options = new PdfSaveOptions();
    options.setHorizontalResolution(new Resolution(200, UnitType.AUTO));
    options.setVerticalResolution(new Resolution(200, UnitType.AUTO));
    com.aspose.html.drawing.Color.getGreen().CloneTo(options.getBackgroundColor());
    options.setJpegQuality(100);
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(500, 500), new Margin(30, 10, 10, 10)));

    // Convert SVG to PDF
    com.aspose.html.converters.Converter.convertSVG(document, options, savePath);
{{< /highlight >}}

To learn more about [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) please read [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.

<!--## **Output Stream Providers**

To save files in remote storage, such as a cloud or database, you can implement the [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface.  This interface allows you to manually control the file creation process by creating a stream at the beginning of the document or page (depending on the output format) and releasing the early created stream after rendering it.

{{% alert color="primary" %}} 
Aspose.HTML for Java provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).
{{% /alert %}} 

The following example demonstrates how to implement and use a custom *MemoryStreamProvider* in your Java application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}-->

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**SVG to PDF Converter**](https://products.aspose.app/svg/conversion/svg-to-pdf) that converts SVG to PDF with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-pdf" target="_blank">![Text "Banner SVG to PDF Converter"](./../../images/svg-to-pdf.png#center)</a>