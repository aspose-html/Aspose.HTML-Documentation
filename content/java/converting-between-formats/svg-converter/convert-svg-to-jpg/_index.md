---
title: Convert SVG to JPG in Java
linktitle: Convert SVG to JPG
type: docs
weight: 30
keywords: svg to jpg, convert svg to jpg java, convert svg to jpg, svg to jpg conversion, svg to jpg converter, save options, java code
description: Convert SVG to JPG in Java using Aspose.HTML API. Consider various SVG to JPG conversion scenarios in Java code.
url: /java/convert-svg-to-jpg/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-03-03
---

In this article, you learn how to convert an {{%SVG%}} to {{%JPG%}} using Aspose.HTML for Java and how to apply [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) and [MemoryStreamProvider.](https://reference.aspose.com/html/java/com.aspose.html/package-frame) You can easily use Java examples to convert SVG to JPG, detailed here for converting [SVG to PNG,](/html/java/convert-svg-to-png/) BMP,  GIF, and TIFF images. Just set the required `ImageFormat` to ImageSaveOptions! 

Converting SVG to any supported image format follows the same mandatory steps:
 - Open an SVG file.
 - Create an ImageSaveOptions object and specifying image format.
 - Convert SVG to chosen image format.

{{% alert color="primary" %}}
The only difference is in specifying the output image format using the [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) class. The `ImageSaveOptions(format)` constructor initializes the options object with the format specifying. You can set the image format to {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}. The default `ImageFormat` is PNG.
{{% /alert %}}

## **Convert SVG to JPG by a single line of code**

Converting SVG to JPG gives you a raster image that can be easily shared, viewed, or emailed. The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an SVG code into various formats. You can convert SVG to JPG in your Java application literally with a single line of code!

{{< highlight java >}}
  // Invoke the convertSVG() method for SVG to JPG conversion          
  com.aspose.html.converters.Converter.convertSVG(Path.combine(getDataDir(), "shapes.svg"), new ImageSaveOptions(ImageFormat.Jpeg), Path.combine(getOutputDir(), "convert-with-single-line.jpg"));
{{< /highlight >}}

## **Convert SVG to JPG**

SVG files are great for website graphics, but not all web browsers support them. Converting SVG to JPG ensures that the image will load properly on any web browser, allowing for a better user experience. Moreover, JPG images are easy to share, send by email, embed in reports or presentations, etc. In the following Java example, we will walk through the step-by-step instructions for converting SVG to JPG with default save options:

1. Load an SVG file. You can load SVG from a file, SVG code, or URL. In the following example, we prepare SVG code to create SVG from scratch and pass it directly to `convertSVG()` method.
1. Use ImageSaveOptions() constructor to create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) object. 
1. Call the `convertSVG()` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save SVG as a JPG image. In the example we use the `convertSVG(content, baseUri, options, outputPath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class that takes four parameters: string with SVG code to be converted, the base folder for the input SVG file, an instance of ImageSaveOptions class and the output file path where the converted image will be saved. 

The following Java code snippet shows how to convert SVG to JPG using Aspose.HTML for Java:

{{< highlight java >}}
  // Prepare SVG code 
  String code = StringExtensions.concat("<svg xmlns='http://www.w3.org/2000/svg'>", 
            "<circle cx ='100' cy ='100' r ='80' fill='none' stroke='green' stroke-width='5' />", 
            "</svg>");

  // Prepare a path for converted file saving 
  String savePath = Path.combine(getOutputDir(), "green-circle.jpg");

  // Initialize an ImageSaveOptions instance
  ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Jpeg);

  // Convert SVG to JPG
  com.aspose.html.converters.Converter.convertSVG(code, ".", options, savePath);
{{< /highlight >}}

## **Save Options**

The [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) class provides methods that give you full control over a wide range of parameters and improve the process of converting SVG to image file formats. You can specify the [image format,](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/ImageFormat) [page size,](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--) [margins,](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--) [compression level,](https://reference.aspose.com/html/java/com.aspose.html.rendering.image/Compression) [CSS media-type,](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType) etc.

{{% alert color="primary" %}} 
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.

To learn more about [PdfSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/pdfsaveoptions) please read [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

## **Convert SVG to JPG using ImageSaveOptions**

If your scenario is required rendering SVG document, for instance, to JPG file format with custom save options, the following example demonstrates how that is simple:

1. Load an SVG file using [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument) class.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions) object and specify the required save options. In the following example, we apply a custom resolutions and background color for the resulting JPG image:  
    - Use the `setHorizontalResolution()` and `setVerticalResolution()` methods to set the horizontal and vertical resolution of the image to 200.    
    - Use the `setBackgroundColor()` method to set the background color for every page.
    - Use the `setSmoothingMode()` method to set the quality of the image smoothing to high.
1. Use the `convertSVG(document, options, savePath)` method of [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save SVG as a JPG image. You need to pass the [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument), [ImageSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/imagesaveoptions), and output file path to the `convertSVG()` method to perform the conversion.

{{< highlight java >}}
  // Prepare a path to a source SVG file
  String documentPath = Path.combine(getDataDir(), "flower.svg");

  // Prepare a path for converted file saving 
  String savePath = Path.combine(getOutputDir(), "flower-options.jpg");

  // Initialize an SVG document from the file
  SVGDocument document = new SVGDocument(documentPath);
  try {        }
  finally { if (document != null) document.dispose(); }

  // Initialize ImageSaveOptions. Set up the resolutions, SmoothingMode and change the background color to AliceBlue 
  ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Jpeg);
  options.setSmoothingMode(SmoothingMode.HighQuality);
  options.setHorizontalResolution(new Resolution(200, UnitType.AUTO));
  options.setVerticalResolution(new Resolution(200, UnitType.AUTO));
  com.aspose.html.drawing.Color.getAliceBlue().CloneTo(options.getBackgroundColor());

  // Convert SVG to JPG
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
Check the quality of SVG to JPG conversion with our online [**SVG to JPG Converter**](https://products.aspose.app/svg/conversion/svg-to-jpg) Upload, convert your files and get the result in a few seconds. Try our forceful SVG to JPG Converter for free now!
{{% /alert %}}