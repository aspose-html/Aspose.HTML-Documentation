---
title: Convert HTML to Image in Java - PNG, JPG, BMP, GIF, TIFF
linktitle: Convert HTML to Image
type: docs
weight: 20
keywords: html to image, convert html to image java, convert html to image, html to image conversion, html to image converter, save options, stream provider, java code
description: Convert HTML to Images like JPG, PNG, GIF, TIFF, and BMP using Java library. Consider HTML to Image conversion scenarios in Java code.
url: /java/convert-html-to-image/
aliases: 
    - /java/html-to-image-conversion/
    - /java/converting-between-formats/html-to-jpg/
    - /java/converting-between-formats/html-to-image-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-03-03
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

Converting HTML to images helps you create visual representations of web content for documentation, reports, presentations, or emailing. For example, using HTML to image conversion, you can quickly get images of HTML-based documents like reports, webpages, or charts for preview or thumbnails.

{{% alert color="primary" %}}
Aspose.HTML for Java library allows you to convert HTML documents to {{%JPG%}}, {{%PNG%}}, {{%GIF%}}, {{%TIFF%}} and {{%BMP%}} file formats with full control over a wide range of conversion parameters. Any HTML to Image conversion can be made with a few required steps:

1. Load an existing HTML file from a local file system, URL, stream, or create HTML from scratch.
2. Create an  [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame) object. Here you may set an image format (JPG, PNG, BMP, GIF or TIFF) and customize the rendering process to get the desired result.
3. Use one of the `convertHTML()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class and pass the required parameters to it.
{{% /alert %}}

In this article, you will find information on how to convert an HTML to Image File Formats and how to use [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame) and [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) parameters. Let's look at HTML to Image conversion scenarios in Java examples! 

## **HTML to JPG by a single line of Java code**

You can convert HTML to Image in your Java application literally with a single line of code! The following Java code shows HTML to JPG conversion:

{{< highlight java >}}
    // Invoke the convertHTML() method to convert HTML to JPG
    com.aspose.html.converters.Converter.convertHTML("<h1>Convert HTML to Image in Java</h1>", ".", new ImageSaveOptions(ImageFormat.Jpeg), Path.combine(getOutputDir(), "convert-with-single-line.jpg"));
{{< /highlight >}}

In the example we use the `convertHTML(content, baseUri, options, outputPath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class that takes four parameters: string with HTML code to be converted, the base folder for the input HTML file, an instance of ImageSaveOptions class that defines options for the output image, such as image format,  and the output file path where the converted image will be saved.

## **Convert HTML to JPG**

The JPG format is commonly used for images because it supports a high compression ratio, which allows you to use smaller files without significant loss in image quality. This makes it ideal for storing images online or sharing them via email or other digital media. To convert HTML to JPG, you should follow a few steps:

1. Load an HTML file using [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame) object with JPG ImageFormat. `ImageFormat.Png` will be used as default image format.
1. Use the `convertHTML(document, options, outputPath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class to save HTML as a JPG image.

The following Java code snippet shows how to convert HTML to JPG using Aspose.HTML:

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "file.html");

    // Prepare a path for converted file saving 
    String outputPath = Path.combine(getOutputDir(), "file-output.jpg");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize an ImageSaveOptions instance
     ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Jpeg);

    // Convert HTML to JPG
    com.aspose.html.converters.Converter.convertHTML(document, options, outputPath);   
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Convert HTML to PNG**

PNG is a popular image file format that supports lossless image compression, making it widely used. HTML files can be converted to PNG images for various purposes, such as adding a web page to a PowerPoint presentation, inserting it on a blog, or sending it via email. In the following Java example, we'll walk through the step-by-step instructions for converting HTML to PNG with default save options:

1. Load an HTML file using one of HTMLDocument() constructors of the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class.
1. Use ImageSaveOptions() constructor to create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame) object. The `options` object can be customized to specify different settings for the conversion process.
1. Call the `convertHTML(document, options, outputPath)` method of [Converter](https://reference.aspose.com/html/java/com.aspose.html/package-frame) class to save HTML as a PNG image. You need to pass the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument), [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame), and output file path to the `convertHTML()` method as parameters.

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "nature.html");

    // Prepare a path for converted file saving 
    String outputPath = Path.combine(getOutputDir(), "nature-output.png");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize an ImageSaveOptions object
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Png);

    // Convert HTML to PNG
    com.aspose.html.converters.Converter.convertHTML(document, options, outputPath);    
{{< /highlight >}}

## **Convert HTML to BMP**

The following example shows how to convert HTML to BMP using Aspose.HTML for Java.

1. Load an HTML file using [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame) object with BMP ImageFormat. By default, the Format property is PNG. 
1. Use the `convertHTML(document, options, outputPath)` method of [Converter](https://reference.aspose.com/html/java/com.aspose.html/package-frame) class to save HTML as a BMP image. The method requires passing the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument), [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame), and output file path as parameters.

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "bmp.html");

    // Prepare a path for converted file saving 
    String outputPath = Path.combine(getOutputDir(), "bmp-output.bmp");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize ImageSaveOptions 
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Bmp);

    // Convert HTML to BMP
    com.aspose.html.converters.Converter.convertHTML(document, options, outputPath);   
{{< /highlight >}}

## **Convert HTML to GIF**

The following Java code snippet shows how to convert HTML to GIF using Aspose.HTML.

1. Load an HTML file using [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame) object with GIF ImageFormat.
1. Use the `convertHTML()` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html/package-frame) class to save HTML as a GIF image.

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "spring.html");

    // Prepare a path for converted file saving 
    String outputPath = Path.combine(getOutputDir(), "spring-output.gif");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize ImageSaveOptions 
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Gif);

    // Convert HTML to GIF
    com.aspose.html.converters.Converter.convertHTML(document, options, outputPath);   
{{< /highlight >}}

## **Convert HTML to TIFF**

The following Java code snippet shows how to convert HTML to TIFF using Aspose.HTML.

1. Load an HTML file using [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame) object with TIFF ImageFormat.
1. Use the `convertHTML()` method of [Converter](https://reference.aspose.com/html/java/com.aspose.html/package-frame) class to save HTML as a TIFF image. You need to pass the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument), [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/package-frame), and output file path to the `convertHTML()` method as parameters.

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "nature.html");

    // Prepare a path for converted file saving 
    String outputPath = Path.combine(getOutputDir(), "nature-output.tiff");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize ImageSaveOptions 
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Tiff);

    // Convert HTML to TIFF
    com.aspose.html.converters.Converter.convertHTML(document, options, outputPath);    
{{< /highlight >}}

## **Save Options**

Aspose.HTML for Java allows converting HTML to Images using default or custom save options. [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/ImageSaveOptions) allows you to customize the rendering process. You can specify the [image format](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/ImageFormat), [page size](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--), [margins](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--), [compression level](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/Compression), [CSS media-type](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType), etc.

| Method                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| setCompression(value)| Sets the Tagged Image File Format (TIFF) Compression. By default this property is `Compression.LZW`.|
| getCss | Gets a CssOptions object which is used for configuration of CSS properties processing. |
| setFormat(value)| Sets ImageFormat (JPG, PNG, BMP, TIFF, or GIF). By default this property is `ImageFormat.Png`. |
| setBackgroundColor(value) | Sets Color which will fill background of every page. Default value is `Color.Transparent(Color.getTransparent())`. |
| setPageSetup(value) | Gets a page setup object is used for configuration output page-set.|
| setHorizontalResolution(value) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| setVerticalResolution(value) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| setSmoothingMode(value) | Sets the rendering quality for this image. |
| getText() | Gets a TextOptions object which is used for configuration of text rendering. |

The following Java example shows how to use ImageSaveOptions and create the output image with custom resolutions, page-size, and background color:

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "color.html");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "color-output.jpg");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize an ImageSaveOptions object and customize save options
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Jpeg);    
    options.setHorizontalResolution(new Resolution(200, UnitType.AUTO));
    options.setVerticalResolution(new Resolution(200, UnitType.AUTO));
    com.aspose.html.drawing.Color.getAliceBlue().CloneTo(options.getBackgroundColor());
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(500, 500), new Margin(30, 20, 10, 10)));
        
    // Convert HTML to JPG
    com.aspose.html.converters.Converter.convertHTML(document, options, savePath);    
{{< /highlight >}}

To learn more about [ImageOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/ImageSaveOptions) please read [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.

<!--## **Output Stream Providers** ## 

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
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.

Aspose.HTML offers a free online [**HTML to Image Converter**](https://products.aspose.app/html/conversion/html-to-image) that converts HTML to Images with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-jpg" target="_blank">![Text "Banner HTML to JPG Converter"](./../../images/html-to-jpg.png#center)</a>