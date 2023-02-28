---
title: Convert MHTML to PNG in Java
linktitle: Convert MHTML to PNG
type: docs
weight: 30
keywords: mhtml to png, convert mhtml to png java, convert mhtml to png, mhtml to png conversion, mhtml to png converter, save options, java code
description: Convert MHTML to PNG, JPG, GIF, TIFF, BMP using Aspose.HTML for Java. Consider various MHTML to PNG conversion scenarios in Java code.
url: /java/convert-mhtml-to-png/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

Aspose.HTML for Java library provides a wide range of MHTML conversions to images, such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}. Converting MHTML to any supported image format follows the same mandatory steps:
 - Opening an MHTML file.
 - Creating an ImageSaveOptions object.
 - Converting MHTML to chosen image format.

{{% alert color="primary" %}}
The only difference is in specifying the output image format using the [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) class. The `ImageSaveOptions(format)` constructor initializes the options object with the format specifying. You can set the image format to JPG, PNG, BMP, GIF, or TIFF. The default `ImageFormat` is PNG.
{{% /alert %}}

In this article, you will find information on how to convert an {{%MHTML%}} to {{%PNG%}} using Aspose.HTML for Java and how to apply [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) and [MemoryStreamProvider.](https://reference.aspose.com/html/java/com.aspose.html/package-frame) You can easily use Java examples to convert MHTML to PNG, detailed here for converting [MHTML to PNG,](/html/java/convert-mhtml-to-png/) MHTML to BMP, MHTML to GIF, and MHTML to TIFF. Just set the `ImageFormat` to ImageSaveOptions! 

## **Convert MHTML to PNG** 

Let’s walk through the step-by-step instructions for a simple MHTML to PNG conversion scenario:

1. Open an existing MHTML file. In the example, we use the `openRead()` method to open and read an MHTML file from the file system at the specified path.
1. Create an instance of [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions). `ImageFormat.Png` will be used as default image format.
1. Use the `convertMHTML(stream, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save MHTML as PNG image. The method takes as parameters `stream`, `options`, and `savePath` and performs the conversion.

Using `convertMHTML()` methods is the most common way to convert MHTML files into various formats. The following Java code snippet shows how to convert MHTML to PNG using Aspose.HTML:

{{< highlight java >}}
    // Open an existing MHTML file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht"));
    try {        }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }
                    
    // Create an instance of ImageSaveOptions
    ImageSaveOptions options = new ImageSaveOptions();

    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "sample-output.png");

    // Convert MHTML to PNG
    com.aspose.html.converters.Converter.convertMHTML(stream, options, savePath);      
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

Aspose.HTML for Java provides the ability to programmatically convert MHTML to PNG with full control over various conversion options using [ImageSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) This feature allows users to customize the rendering process by setting the [image format](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/ImageFormat), [page size](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--), [margins](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--), [compression level](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/Compression), [CSS media-type](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType), and other parameters.

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

## **Convert MHTML to PNG using ImageSaveOptions**

Aspose.HTML for Java allows converting MHTML to PNG using default or custom save options. Setting different options of ImageSaveOptions class gives you control over the page size, margins, background color, and resolution settings for the output image. These are the steps to convert an MHTML file to PNG format with ImageSaveOptions specifying:  

1. Open an existing MHTML file. Use the `openRead()` method of System.IO.FileStream class to open and read source files from the file system at the specified path.
2. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) and specify the required save options:     
    - Use the `getBackgroundColor()` method to set the background color of the image to Beige.
    - Use the `setAnyPage()` method to set the size of the image.
3. Use the `convertMHTML(stream, options, savePath)` method to save MHTML file as a PNG image. The method takes the `stream`, `options`, output file path `savePath` and performs the conversion operation.

The following Java example shows how to use `ImageSaveOptions` and create a PNG file with custom page-size, margins, resolution, rendering quality, and background color:

{{< highlight java >}}
    // Open an existing MHTML file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht"));
    try {        }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "sample-options.png");

    // Initailize the ImageSaveOptions with a custom page size and a background color 
    ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Jpeg)
    {,
        PageSetup =
            {
                AnyPage = new Page()
                {
                    Size = new com.aspose.html.drawing.Size(Length.FromPixels(1000), Length.FromPixels(500))
                }
            }
        BackgroundColor = com.aspose.ms.System.Drawing.Color.getBeige()
    };

    // Call the convertMHTML() method to convert MHTML to PNG
    com.aspose.html.converters.Converter.convertMHTML(stream, options, savePath);    
{{< /highlight >}}

<!--## **Output Stream Providers**

You can implement the [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface to manually control the process of saving files in remote storage such as the cloud or database. This interface works as a callback object that creates a stream at the beginning of the document/page (depending on the output format) and releases the created stream after rendering the document/page. By implementing this interface, you can fully control the file creation process in remote storage.

{{% alert color="primary" %}}
Aspose.HTML for Java provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).
{{% /alert %}} 

The following example demonstrates how to implement and use a custom *MemoryStreamProvider* in your Java application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}-->

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**MHTML to PNG Converter**](https://products.aspose.app/html/conversion/mhtml-to-png) that converts MHTML to PNG with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}