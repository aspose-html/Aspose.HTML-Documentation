---
title: Convert Markdown to Image in Java - PNG, JPG, BMP, GIF, TIFF
linktitle: Convert Markdown to Image
type: docs
weight: 30
keywords: markdown to image, markdown to png, markdown to jpg, convert markdown to image, save options, java code
description: Convert Markdown to Image like JPG, PNG, GIF, TIFF, BMP using Java library. Consider various Markdown to image conversion scenarios in Java code.
url: /java/convert-markdown-to-image/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

Markdown to Image conversion can be useful where you want to create a visual representation of your content,  share it on social media, embed it in websites or blog posts, or use it as part of a presentation. Aspose.HTML for Java library provides a wide range of Markdown conversions to images, such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}. Converting Markdown to any supported image format follows the same mandatory steps:
 - Open a Markdown file.
 - Convert Markdown file to HTML document.
 - Create an ImageSaveOptions object.
 - Convert HTML document to chosen image format.

{{% alert color="primary" %}}
The only difference is in specifying the output image format using the [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) class. The `ImageSaveOptions(format)` constructor initializes the options object with the format specifying. You can set the image format to JPG, PNG, BMP, GIF, or TIFF. The default `ImageFormat` is PNG.
{{% /alert %}}

In this article, you will find information on how to convert a {{%Markdown%}} to Image using Aspose.HTML for Java and how to apply [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions.) You can easily use Java examples to convert Markdown to images, detailed here for converting Markdown to PNG, JPG, BMP, GIF, and TIFF. Just set the `ImageFormat` to ImageSaveOptions! 

If your scenario is required rendering Markdown document, for instance, to the Image file format, the following example demonstrates how that is simple.

## **Markdown to PNG**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert a Markdown file into various formats. You can convert Markdown to Image in your Java application literally with a few lines of code!

1. Prepare paths for a source Markdown file - `sourcePath` and converted file saving - `savePath`.
1. Use the `convertMarkdown(sourcePath)` method to convert Markdown to HTML document. 
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) object. `ImageFormat.Png` will be used as default image format.
1. Use the `сonvertHTML(document, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save an intermediate HTML document as a PNG image. The method takes as parameters `document`, `options`, and `savePath` and performs the conversion.
 
If your scenario is required rendering Markdown document, for instance, to PNG file format, the following example demonstrates how that is simple:

{{< highlight java >}}
    // Prepare a path to a source Markdown file
    String sourcePath = Path.combine(getDataDir(), "document.md");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "output.png");

    // Convert Markdown to HTML
    final HTMLDocument document = com.aspose.html.converters.Converter.convertMarkdown(sourcePath);
    try {
        // Convert HTML document to PNG image file format
        com.aspose.html.converters.Converter.convertHTML(document, new ImageSaveOptions(), savePath);
    }
    finally { if (document != null) document.dispose(); }    
{{< /highlight >}}

## **Save Options**

Aspose.HTML for Java provides the ability to programmatically convert Markdown to Image with full control over various conversion options using [ImageSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) This feature allows users to customize the rendering process by setting the [image format](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/ImageFormat), [page size](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--), [margins](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--), [compression level](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/Compression), [CSS media-type](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType), and other parameters.

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

## **Convert Markdown to JPG using ImageSaveOptions**

Aspose.HTML for Java allows converting Markdown to Image using default or custom save options. Setting different options of ImageSaveOptions class gives you control over the page size, margins, background color, and resolution settings for the output image. 

These are the steps to convert a Markdown file to JPG format with ImageSaveOptions specifying:  

1. Prepare a source path - `sourcePath` to open an existing Markdown file.
2. Use the `convertMarkdown(sourcePath)` method to convert Markdown to HTML document. 
3. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) object with JPG `ImageFormat` and specify the required save options:     
    - Use the `setSmoothingMode()` method to set the quality of the image smoothing to high.
    - Use the `setHorizontalResolution()` and `setVerticalResolution()` methods to set the horizontal and vertical resolution of the image to 200.    
    - Use the `setAnyPage()` method to set the size of the image and margins.
4. Use the `convertHTML(document, options, savePath)` method to save Markdown file as a JPG image. The method takes the `document`, `options`, output file path `savePath` and performs the conversion operation.

The following Java example shows how to use `ImageSaveOptions` and create a JPG file with custom page-size, margins, resolution, and rendering quality:

{{< highlight java >}}
    // Prepare a path to a source Markdown file
    String sourcePath = Path.combine(getDataDir(), "nature.md");            

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "nature-options.jpg");

    // Convert Markdown to HTML
    HTMLDocument document = Converter.convertMarkdown(sourcePath);

    try {
        // Initialize ImageSaveOptions
        ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Jpeg);
        options.setSmoothingMode(SmoothingMode.HighQuality);
        options.setHorizontalResolution(new Resolution(200, UnitType.AUTO));
        options.setVerticalResolution(new Resolution(200, UnitType.AUTO));        
        options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(600, 950), new Margin(30, 20, 10, 10)));

        // Convert HTML document to JPG image file format
        com.aspose.html.converters.Converter.convertHTML(document, options, savePath);
    }
    finally { if (document != null) document.dispose(); }   
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**Markdown to Image Converter**](https://products.aspose.app/html/conversion/md-to-image) that converts Markdown to JPG with high quality, easy and fast. If you need to include Markdown files in a PowerPoint presentation or send them by email, please transform them to the appropriate image format and use them as you want! Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}
