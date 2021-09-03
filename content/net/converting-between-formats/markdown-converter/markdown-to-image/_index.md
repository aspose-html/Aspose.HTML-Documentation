---
title: Convert Markdown to Image
type: docs
weight: 50
url: /net/converting-between-formats/markdown-to-image/
description: This article provides information on how to convert Markdown to images using the Aspose.HTML API. You will learn about the supported Markdown to JPG, PNG, BMP, GIF or TIFF conversion scenarios and consider examples to illustrate them.  
keywords: markdown to jpg, convert markdown to jpg, markdown to jpg conversion, markdown to jpg converter, markdown to png, markdown to bmp, markdown to gif, markdown to tiff
lastmod: "2021-09-03"
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

If you need to preview a Markdown file, you can convert it to image formats. Using the Aspose.HTML class library, you can easily convert Markdown into JPG, PNG, BMP, GIF or TIFF files with just a few lines of code!

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/md-to-jpg" target="_blank">**MD to JPG Converter**</a> that converts Markdown to JPG image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/md-to-jpg" target="_blank">![Text "Banner MD to JPG Converter"](md-to-jpg.png#center)</a>

## **Convert Markdown to JPG**

If your scenario is required rendering Markdown document, for instance, to the JPG image file format, the following example demonstrates how that is simple: 

1. Prepare a source Markdown document. In the example, we create a Markdown file from code. 
1. Prepare a path for converted file saving. 
1. Convert Markdown to HTML. Use the [ConvertMarkdown(`sourcePath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmarkdown/methods/4) method to save Markdown as an HTML document. 
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/3) method to render the intermediary HTML document to JPG image. You need to pass the HTMLDocument, ImageSaveOptions, and output file path to the ConvertHTML() method for converting HTML to JPG.

If your case is to create a Markdown document from a user string directly in your code and convert it to a JPG file, the following example could help you: 

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;
...
   // Prepare a path to a source Markdown file
   string sourcePath = Path.Combine(OutputDir, "document.md");

   // Prepare a simple Markdown example
   var code = "### Hello, World!" +
              "\r\n" +
              "[visit applications](https://products.aspose.app/html/family)";
   // Create a Markdown file
   File.WriteAllText(sourcePath, code);

   // Prepare a path for converted file saving 
   string savePath = Path.Combine(OutputDir, "document-output.jpg");

   // Convert Markdown to HTML document
   using var document = Converter.ConvertMarkdown(sourcePath);

   // Convert HTML document to JPG image file format
   Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Jpeg), savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Convert Markdown to JPG using ImageSaveOptions**
If your case is to convert an existing Markdown document from a local file system, the following example could help you. You need to follow a few steps:

1. Open an existing Markdown document. In the example, we load a Markdown file from a local file system ([nature.md](https://github.com/aspose-html/Aspose.HTML-Documentation/blob/oa_conversion/content/tests-net/tests-data/nature.md)). 
1. Prepare a path for converted file saving. 
1. Convert Markdown to HTML. Use the [ConvertMarkdown(`sourcePath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmarkdown/methods/4) method of the Converter class to save Markdown as an HTML document. 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object and specify the required properties.
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/3) method to render the intermediary HTML document to JPG image. You need to pass the HTMLDocument, ImageSaveOptions, and output file path to the ConvertHTML() method.

The following code snippet demonstrates how to convert Markdown to JPG using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;
using System.Drawing;
using Aspose.Html.Drawing;
using System.Drawing.Drawing2D;
...
    // Prepare a path to a source Markdown file
    string sourcePath = Path.Combine(DataDir, "nature.md");            

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "nature-options.jpg");
    
    // Convert Markdown to HTML document
    using var document = Converter.ConvertMarkdown(sourcePath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Jpeg)
    {
        SmoothingMode = SmoothingMode.HighQuality,
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = Color.AliceBlue
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(600, 950), new Margin(30, 20, 10, 10));
    
    // Convert HTML document to JPG image file format
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting Markdown to JPG format. To learn more about [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

In the above example, we use:

 - SmoothingMode property that sets the rendering quality for this image;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi; 
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - PageSetup property that specifies the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup) and [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin) in pixels.

## **Convert Markdown to PNG**
The following code snippet demonstrates how to convert Markdown to PNG: 

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;
...
   // Prepare a path to a source Markdown file
   string sourcePath = Path.Combine(DataDir, "document.md");

   // Prepare a path for converted file saving 
   string savePath = Path.Combine(OutputDir, "output.png");

   // Convert Markdown to HTML document
   using var document = Converter.ConvertMarkdown(sourcePath);

   // Convert HTML document to PNG image file format
   Converter.ConvertHTML(document, new ImageSaveOptions(), savePath);
{{< /highlight >}} 

## **Convert Markdown to BMP**
The following code snippet demonstrates how to convert Markdown to BMP: 

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;
...
   // Prepare a path to a source Markdown file
   string sourcePath = Path.Combine(DataDir, "document.md");

   // Prepare a path for converted file saving 
   string savePath = Path.Combine(OutputDir, "output.bmp");

   // Convert Markdown to HTML document
   using var document = Converter.ConvertMarkdown(sourcePath);

   // Convert HTML document to BMP image file format
   Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Bmp), savePath);
{{< /highlight >}} 

## **Convert Markdown to GIF**
The following code snippet demonstrates how to convert Markdown to GIF: 

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;
...
   // Prepare a path to a source Markdown file
   string sourcePath = Path.Combine(DataDir, "document.md");

   // Prepare a path for converted file saving 
   string savePath = Path.Combine(OutputDir, "output.gif");

   // Convert Markdown to HTML document
   using var document = Converter.ConvertMarkdown(sourcePath);

   // Convert HTML document to GIF image file format
   Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Gif), savePath);
{{< /highlight >}} 

## **Convert Markdown to TIFF**
The following code snippet demonstrates how to convert Markdown to TIFF: 

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;
...
   // Prepare a path to a source Markdown file
   string sourcePath = Path.Combine(DataDir, "document.md");

   // Prepare a path for converted file saving 
   string savePath = Path.Combine(OutputDir, "output.tiff");

   // Convert Markdown to HTML document
   using var document = Converter.ConvertMarkdown(sourcePath);

   // Convert HTML document to TIFF image file format
   Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Tiff), savePath);
{{< /highlight >}} 

{{% alert color="primary" %}} 
You can check the quality of Markdown to JPG conversion with our online [**MD to JPG Converter**](https://products.aspose.app/html/en/conversion/md-to-jpg). Upload, convert your files and get results in a few seconds. Try our forceful Markdown to JPG Converter for free now!
{{% /alert %}}

