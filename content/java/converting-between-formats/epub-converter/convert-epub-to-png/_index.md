---
title: Convert EPUB to PNG in Java
linktitle: Convert EPUB to PNG
keywords: epub to png, convert epub to png java, convert epub to png, epub to png conversion, epub to png converter, save options, stream provider, java code
description: Convert EPUB to PNG in Java using Aspose.HTML API. Consider various EPUB to PNG conversion scenarios in Java code.
url: /java/convert-epub-to-png/
type: docs
weight: 20
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

EPUB is the most widely supported e-book format. Converting EPUB to PNG can be helpful when you want to include an EPUB file in a PowerPoint presentation or send it by email. Or, for example, you want to share an EPUB file with someone who doesn't have an EPUB reader installed.

Aspose.HTML for Java library provides a wide range of EPUB conversions to images, such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}. Converting EPUB to any supported image format follows the same mandatory steps:
 - Opening an EPUB file.
 - Creating a save options object.
 - Converting EPUB to chosen image format.

{{% alert color="primary" %}}
The only difference is in specifying the output image format using the [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) class. The `ImageSaveOptions(format)` constructor initializes the options object with the format specifying. You can set the image format to JPG, PNG, BMP, GIF, or TIFF. The default `ImageFormat` is PNG.
{{% /alert %}}

In this article, you will find information on how to convert an {{%EPUB%}} to {{%PNG%}} using Aspose.HTML for Java and how to apply [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) and [MemoryStreamProvider.](https://reference.aspose.com/html/java/com.aspose.html/package-frame) You can easily use Java examples to convert EPUB to PNG, detailed here for converting [EPUB to JPG,](/html/java/convert-epub-to-jpg/) EPUB to BMP, EPUB to GIF, and EPUB to TIFF. Just set the `ImageFormat` to ImageSaveOptions! 

## **EPUB to PNG by a few lines of Java code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an EPUB file into various formats. You can convert EPUB to PNG in your Java application literally with a single line of code!

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try {        }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Convert EPUB to PNG           
    com.aspose.html.converters.Converter.convertEPUB(stream, new ImageSaveOptions(), Path.combine(getOutputDir(), "convert-by-few-lines.png"));   
{{< /highlight >}}

## **Convert EPUB to PNG**

Let’s walk through the step-by-step instructions for a simple EPUB to PNG conversion scenario:

1. Open an existing EPUB file. In the example, we use the `openRead()` method to open and read an EPUB file from the file system at the specified path.
1. Create an instance of [ImageSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) `ImageFormat.Png` will be used as default image format.
1. Use the `convertEPUB(stream, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save EPUB as an PNG image. The method takes as parameters `stream`, `options`, and `savePath` and performs the conversion.

The following Java code snippet shows how to convert EPUB to PNG using Aspose.HTML:

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  com.aspose.html.internal.ms.System.IO.FileStream stream = com.aspose.html.internal.ms.System.IO.File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) stream.dispose(); }

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "output.png");

    // Initialize ImageSaveOptions 
    com.aspose.html.saving.ImageSaveOptions options = new com.aspose.html.saving.ImageSaveOptions();

    // Call the convertEPUB() method to convert EPUB to PNG
    com.aspose.html.converters.Converter.convertEPUB(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

[ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) allows users to customize the rendering process by setting the [image format](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/ImageFormat), [page size](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--), [margins](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--), [compression level](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/Compression), [CSS media-type](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType), and other parameters.

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

## **Convert EPUB to PNG using ImageSaveOptions**

Aspose.HTML for Java allows converting EPUB to PNG using default or custom save options. These are the steps to convert an EPUB file to PNG format with ImageSaveOptions specifying:  

1. Open an existing EPUB file. Use the `openRead()` method of System.IO.FileStream class to open and read source files from the file system at the specified path.
2. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) object with PNG ImageFormat and specify the required save options: 
    - Use the `setSmoothingMode()` method to set the quality of the image smoothing to high.
    - Use the `setHorizontalResolution()` and `setVerticalResolution()` methods to set the horizontal and vertical resolution of the image to 400.
    - Use the `getBackgroundColor()` method to set the background color of the image to Alice Blue.    
3. Use the `convertEPUB(stream, options, savePath)` method to save EPUB file as a PNG image. The method takes the `stream`, `options`, output file path `savePath` and performs the conversion operation.

The following Java example shows how to use `ImageSaveOptions` and create a PNG file with custom rendering quality, resolution, and background color:

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  com.aspose.html.internal.ms.System.IO.FileStream stream = com.aspose.html.internal.ms.System.IO.File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) stream.dispose(); }

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "input-options.png");

    // Initialize ImageSaveOptions 
    com.aspose.html.saving.ImageSaveOptions options = new com.aspose.html.saving.ImageSaveOptions();
    options.setSmoothingMode(SmoothingMode.HighQuality);
    options.setHorizontalResolution(new Resolution(400, UnitType.AUTO));
    options.setVerticalResolution(new Resolution(400, UnitType.AUTO));
    com.aspose.html.drawing.Color.getAliceBlue().CloneTo(options.getBackgroundColor());

    // Convert EPUB to PNG
    com.aspose.html.converters.Converter.convertEPUB(stream, options, savePath);  
{{< /highlight >}}

{{% alert color="primary" %}}
For further information on how to customize the conversion process with [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) you can refer to the [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

<!-- ## **Output Stream Providers**

To save files in remote storage, such as a cloud or database, you can implement the [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface.  This interface allows you to manually control the file creation process by creating a stream at the beginning of the document or page (depending on the output format) and releasing the early created stream after rendering it.

{{% alert color="primary" %}}
Aspose.HTML for Java offers a variety of output formats for rendering tasks. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).
{{% /alert %}} 

The following example demonstrates how to implement and use a custom *MemoryStreamProvider* in your Java application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}-->

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**EPUB to PNG Converter**](https://products.aspose.app/html/conversion/epub-to-png) that converts EPUB to PNG with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/epub-to-png" target="_blank">![Text "Banner EPUB to PNG Converter"](./../../../images/epub-to-png.png#center)</a>