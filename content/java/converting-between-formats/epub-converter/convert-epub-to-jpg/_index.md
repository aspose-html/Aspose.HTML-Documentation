---
title: Convert EPUB to JPG in Java
linktitle: Convert EPUB to JPG
keywords: epub to jpg, convert epub to jpg java, convert epub to jpg, epub to jpg conversion, epub to jpg converter, save options, stream provider, java code
description: Convert EPUB to JPG in Java using Aspose.HTML API. Consider various EPUB to JPG conversion scenarios in Java code.
url: /java/convert-epub-to-jpg/
type: docs
weight: 20
aliases: 
  - /java/epub-to-image-conversion/
  - /java/converting-between-formats/html-to-image-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

EPUB is the most widely supported e-book format. An EPUB file is a ZIP archive that actually contains a website, including HTML files, images, CSS style sheets, and other assets. Converting EPUB to JPG can be helpful when you want to include an EPUB file in a PowerPoint presentation or send it by email. Or, for example, you want to share an EPUB file with someone who doesn't have an EPUB reader installed.

{{% alert color="primary" %}}

Aspose.HTML for Java library provides a wide range of EPUB conversions to image formats, such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}.

Converting EPUB to any supported image format follows the same mandatory steps:
 - Opening an EPUB file.
 - Creating a save options object.
 - Converting EPUB to chosen image format.

The only difference is in specifying the output image format using the [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) class. The `ImageSaveOptions(format)` constructor initializes the options object with the image format specifying. You can set the image format to JPG, PNG, BMP, GIF, or TIFF. The default `ImageFormat` is PNG.
{{% /alert %}}

In this article, you will find information on how to convert an {{%EPUB%}} to {{%JPG%}} using Aspose.HTML for Java and how to apply [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) and [MemoryStreamProvider.](https://reference.aspose.com/html/java/com.aspose.html/package-frame) You can easily use Java examples to convert EPUB to JPG, detailed here for converting [EPUB to PNG,](/html/java/convert-epub-to-png/) EPUB to BMP, EPUB to GIF, and EPUB to TIFF. Just set the `ImageFormat` to ImageSaveOptions! 

## **EPUB to JPG by two lines of Java code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an EPUB file into various formats. You can convert EPUB to JPG in your Java application literally with a single line of code!

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  com.aspose.html.internal.ms.System.IO.FileStream stream = com.aspose.html.internal.ms.System.IO.File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) stream.dispose(); }

    // Invoke the convertEPUB() method           
    com.aspose.html.converters.Converter.convertEPUB(stream, new ImageSaveOptions(ImageFormat.Jpeg), Path.combine(getOutputDir(), "convert-by-two-lines.jpg"));   
{{< /highlight >}}

## **Convert EPUB to JPG**

Let’s walk through the step-by-step instructions for a simple EPUB to JPG conversion scenario:

1. Open an existing EPUB file. In the example, we use the `openRead()` method to open and read an EPUB file from the file system at the specified path.
1. Create an instance of [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) with JPG ImageFormat. `ImageFormat.Png` will be used as default image format.
1. Use the `convertEPUB(stream, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save EPUB as an JPG image. The method takes as parameters `stream`, `options`, and `savePath` and performs the conversion.

Using `convertEPUB()` methods is the most common way to convert EPUB files into various formats. The following Java code snippet shows how to convert EPUB to JPG using Aspose.HTML:

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  com.aspose.html.internal.ms.System.IO.FileStream stream = com.aspose.html.internal.ms.System.IO.File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) stream.dispose(); }

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "output.jpg");            

    // Initialize ImageSaveOptions 
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Jpeg);

    // Call the convertEPUB method() to convert EPUB to JPG
    com.aspose.html.converters.Converter.convertEPUB(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

Aspose.HTML for Java provides the ability to programmatically convert EPUB to JPG with full control over various conversion options using [ImageSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) This feature allows users to customize the rendering process by setting the [image format](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/ImageFormat), [page size](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--), [margins](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--), [compression level](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/Compression), [CSS media-type](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType), and other parameters.

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

{{% alert color="primary" %}}
For further information on how to customize the conversion process with [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) you can refer to the [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

## **Convert EPUB to JPG using ImageSaveOptions**

Aspose.HTML for Java allows converting EPUB to JPG using default or custom save options. Setting different options of ImageSaveOptions class gives you control over the page size, margins, background color, and resolution settings for the output image. These are the steps to convert an EPUB file to JPG format with ImageSaveOptions specifying:  

1. Open an existing EPUB file. Use the `openRead()` method of System.IO.FileStream class to open and read source files from the file system at the specified path.
2. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) object with JPG ImageFormat and specify the required save options: 
    - Use the `setSmoothingMode()` method to set the quality of the image smoothing to high.
    - Use the `setHorizontalResolution()` and `setVerticalResolution()` methods to set the horizontal and vertical resolution of the image to 400.
    - Use the `getBackgroundColor()` method to set the background color of the image to Alice Blue.
    - Use the `setAnyPage()` method to set the size of the image and margins.
3. Use the `convertEPUB(stream, options, savePath)` method to save EPUB file as a JPG image. The method takes the `stream`, `options`, output file path `savePath` and performs the conversion operation.

The following Java example shows how to use `ImageSaveOptions` and create a JPG file with custom page-size, margins, resolution, rendering quality, and background color:

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  com.aspose.html.internal.ms.System.IO.FileStream stream = com.aspose.html.internal.ms.System.IO.File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) stream.dispose(); }
    
    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "input-options.jpg");
                    
    // Initialize an instance of the ImageSaveOptions class
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Jpeg);
    options.setSmoothingMode(SmoothingMode.HighQuality);
    options.setHorizontalResolution(new Resolution(400, UnitType.AUTO));
    options.setVerticalResolution(new Resolution(400, UnitType.AUTO));
    com.aspose.html.drawing.Color.getAliceBlue().CloneTo(options.getBackgroundColor());
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(800, 500), new Margin(30, 20, 10, 10)));

    // Convert EPUB to JPG
    com.aspose.html.converters.Converter.convertEPUB(stream, options, savePath);    
{{< /highlight >}}

## **Output Stream Providers**

When it is necessary to save files to remote storage such as a cloud or database, implementing the [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface can provide manual control over the file creation process. This interface serves as a callback object that allows for creating a stream at the beginning of the document or page (depending on the output format) and the release of the early created stream after the document or page is rendered. Using the MemoryStreamProvider interface allows users to have greater control over the file-saving process, which can be particularly useful when the storage location is remote or requires specific configurations.

{{% alert color="primary" %}}
Aspose.HTML for Java provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).
{{% /alert %}} 

The example below shows how to implement and use the your own *MemoryStreamProvider* in the application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**EPUB to JPG Converter**](https://products.aspose.app/html/conversion/epub-to-jpg) that converts EPUB to JPG with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/epub-to-jpg" target="_blank">![Text "Banner EPUB to JPG Converter"](./../../../epub-to-jpg.png#center)</a>