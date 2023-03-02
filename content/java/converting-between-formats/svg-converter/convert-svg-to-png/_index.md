---
title: Convert SVG to PNG in Java
linktitle: Convert SVG to PNG
type: docs
weight: 20
keywords: svg to png, convert svg to png java, convert svg to png, svg to png conversion, svg to png converter, save options, java code
description: Convert SVG to PNG in Java using Aspose.HTML API. Consider various SVG to PNG conversion scenarios in Java code.
url: /java/convert-svg-to-png/
aliases: 
  - /java/svg-to-image-conversion/
  - /java/converting-between-formats/svg-to-image-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

Each image format has unique strengths and weaknesses. SVG is great for creating graphics that can be scaled up or down without losing quality. But sometimes you need to convert SVG files to other image formats like PNG, JPG, BMP, TIFF, or GIF. Overall, SVG conversions can be helpful for developers and designers who must work with different image formats for various purposes. In addition, knowing how to convert between formats can help ensure your graphics and images are accessible and usable for a wider audience.

Aspose.HTML for Java library provides a wide range of SVG conversions to images, such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}. Converting SVG to any supported image format follows the same mandatory steps:
 - Opening an SVG file.
 - Creating an ImageSaveOptions object and specifying image format.
 - Converting SVG to chosen image format.

{{% alert color="primary" %}}
The only difference is in specifying the output image format using the [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) class. The `ImageSaveOptions(format)` constructor initializes the options object with the format specifying. You can set the image format to JPG, PNG, BMP, GIF, or TIFF. The default `ImageFormat` is PNG.
{{% /alert %}}

In this article, you learn how to convert an {{%SVG%}} to {{%PNG%}} using Aspose.HTML for Java and how to apply [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) and [MemoryStreamProvider.](https://reference.aspose.com/html/java/com.aspose.html/package-frame) You can easily use Java examples to convert SVG to PNG, detailed here for converting [SVG to JPG,](/html/java/convert-svg-to-jpg/) BMP,  GIF, and TIFF images. Just set the required `ImageFormat` to ImageSaveOptions! 

## **Convert SVG to PNG by a single line of code**

By converting SVG to PNG, you get a raster image that can be easily shared, viewed, sent by email, and compressed without losing of quality. The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an SVG code into various formats. You can convert SVG to PNG in your Java application literally with a single line of code!

{{< highlight java >}}
  // Invoke the convertSVG() method for SVG to PNG conversion          
  com.aspose.html.converters.Converter.convertSVG(Path.combine(getDataDir(), "shapes.svg"), new ImageSaveOptions(), Path.combine(getOutputDir(), "convert-with-single-line.png"));
{{< /highlight >}}

## **Convert SVG to PNG**

In the following Java example, we will walk through the step-by-step instructions for converting SVG to PNG with default save options:

1. Load an SVG file. You can load SVG from a file, SVG code, or URL. In the following example, we prepare SVG code to create SVG from scratch and pass it directly to `convertSVG()` method.
1. Use ImageSaveOptions() constructor to create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) object. By default, the Format property is PNG.
1. Call the `convertSVG()` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save SVG as a PNG image. In the example we use the `convertSVG(content, baseUri, options, outputPath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class that takes four parameters: string with SVG code to be converted, the base folder for the input SVG file, an instance of ImageSaveOptions class and the output file path where the converted image will be saved. 

The following Java code snippet shows how to convert SVG to PNG using Aspose.HTML for Java.

{{< highlight java >}}
  // Prepare SVG code 
  String code = StringExtensions.concat("<svg xmlns='http://www.w3.org/2000/svg'>", 
            "<circle cx ='100' cy ='100' r ='60' fill='none' stroke='red' stroke-width='10' />", 
            "</svg>");

  // Prepare a path for converted file saving 
  String savePath = Path.combine(getOutputDir(), "circle.png");

  // Initialize an ImageSaveOptions instance
  ImageSaveOptions options = new ImageSaveOptions();

  // Convert SVG to PNG
  com.aspose.html.converters.Converter.convertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

The [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) class provides methods that give you full control over a wide range of parameters and improve the process of converting SVG to image file formats. You can specify the [image format,](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/ImageFormat) [page size,](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--) [margins,](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--) [compression level,](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/Compression) [CSS media-type,](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType) etc.

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

## **Convert SVG to PNG using ImageSaveOptions**

If your scenario is required rendering SVG document, for instance, to PNG file format with custom save options, the following example demonstrates how that is simple:

1. Load an SVG file using [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument) class.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) object and specify the required save options. In the following example, we apply a custom resolutions and background color for the resulting PNG image:  
    - Use the `setHorizontalResolution()` and `setVerticalResolution()` methods to set the horizontal and vertical resolution of the image to 200.    
    - Use the `setBackgroundColor()` method to set the background color for every page.
    - Use the `setSmoothingMode()` method to set the quality of the image smoothing to high.
1. Use the `convertSVG(document, options, savePath)` method of [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save SVG as a PNG image. You need to pass the [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument), [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions), and output file path to the `convertSVG()` method to perform the conversion.

{{< highlight java >}}
  // Prepare a path to a source SVG file
  String documentPath = Path.combine(getDataDir(), "flower1.svg");

  // Prepare a path for converted file saving 
  String savePath = Path.combine(getOutputDir(), "flower-options.png");

  // Initialize an SVG document from the file
  SVGDocument document = new SVGDocument(documentPath);
  try {        }
  finally { if (document != null) document.dispose(); }

  // Initialize ImageSaveOptions. Set up the SmoothingMode, resolutions, and change the background color to AliceBlue 
  ImageSaveOptions options = new ImageSaveOptions();
  options.setHorizontalResolution(new Resolution(200, UnitType.AUTO));
  options.setVerticalResolution(new Resolution(200, UnitType.AUTO));;
  com.aspose.html.drawing.Color.getAliceBlue().CloneTo(options.getBackgroundColor());
  options.setSmoothingMode(SmoothingMode.HighQuality);            

  // Convert SVG to PNG
  com.aspose.html.converters.Converter.convertSVG(document, options, savePath);  
{{< /highlight >}}

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
Aspose.HTML offers a free online [**SVG to PNG Converter**](https://products.aspose.app/svg/conversion/svg-to-png) that converts SVG to PNG with high quality, easy and fast. This tool helps you create high-quality images and graphics that are compatible with a wide range of platforms and devices. So why not try? Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-png" target="_blank">![Text "Banner SVG to PNG Converter"](./../../../images/svg-to-png.png#center)</a>