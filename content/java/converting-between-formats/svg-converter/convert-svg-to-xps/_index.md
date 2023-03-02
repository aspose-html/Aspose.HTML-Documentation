---
title: Convert SVG to XPS Using Java
linktitle: Convert SVG to XPS
type: docs
weight: 40
keywords: svg to xps, convert svg to xps java, convert svg to xps, svg to xps conversion, svg to xps converter, save options, java code
description: Convert SVG to XPS in Java using Aspose.HTML API. Consider various SVG to XPS conversion scenarios in Java code.
url: /java/convert-svg-to-xps/
aliases: 
  - /java/svg-to-xps-conversion/
  - /java/converting-between-formats/svg-to-xps-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

Why convert SVG files to XPS format? You may want to create high-quality, vector-preserving, print-ready documents or ensure file compatibility with Microsoft applications that use the XPS format as their standard document format. In addition, by converting SVG to XPS, you can protect files with a password and digital signature, providing additional security features for sensitive documents.

In this article, you will find information on how to convert an {{%SVG%}} to {{%XPS%}} and how to use [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) parameters.

## **SVG to XPS by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an {{%SVG%}} file into various formats. You can convert {{%SVG%}} to {{%XPS%}} in your Java application literally with a single line of code!

{{< highlight java >}}
    // Invoke the convertSVG method() to convert SVG to XPS
    com.aspose.html.converters.Converter.convertSVG(Path.combine(getDataDir(), "aspose.svg"), new XpsSaveOptions(), Path.combine(getOutputDir(), "aspose.xps"));   
{{< /highlight >}}

## **Convert SVG to XPS in Java**

If your scenario is required rendering an SVG document, for instance, to XPS file format, the following example demonstrates how that is simple:

1. Load an SVG file using [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument) class. In the following example we create SVG content from scratch. 
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) object. Use the empty XpsSaveOptions() constructor to convert with the default save options.
1. Use one of the `сonvertSVG()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class to save SVG as an XPS file. In the example we use the `convertHTML(content, baseUri, options, savePath)` method that takes four parameters: string with SVG code to be converted, the base folder for the input SVG file, an instance of the XpsSaveOptions class, and the output file path where the converted file will be saved.

Please review the following Java code snippet, which shows the SVG to XPS conversion process with step-by-step instructions:

{{< highlight java >}}
    // Prepare SVG code 
    String code = StringExtensions.concat("<svg xmlns='http://www.w3.org/2000/svg'>", 
                "<circle cx ='100' cy ='100' r ='60' fill='none' stroke='red' stroke-width='10' />", 
                "</svg>");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "circle.xps");

    // Initialize an instance of the XpsSaveOptions class
    XpsSaveOptions options = new XpsSaveOptions();

    // Convert SVG to XPS
    com.aspose.html.converters.Converter.convertSVG(code, ".", options, savePath);    
{{< /highlight >}}

## **Save Options** 

With [XpsSaveOptions,](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) you have the ability to personalize the rendering process for your XPS files. This includes customizing elements such as the page size, margins, background color, CSS media type, and more.

| Metod                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [getCss()](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getCss--) | Gets a [CssOptions](https://reference.aspose.com/html/java/com.aspose.html.rendering/CssOptions) object which is used for configuration of CSS properties processing. |
| [setBackgroundColor(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setBackgroundColor-com.aspose.ms.System.Drawing.Color-) | Sets the color that will fill the background of every page. By default, this property is `Transparent`. |
| [setPageSetup(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setPageSetup-com.aspose.rendering.PageSetup-) | This method sets a page setup object and uses it for configuration output page-set. |
| [setHorizontalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setHorizontalResolution-com.aspose.drawing.Resolution-) | Sets horizontal resolution for internal images, in pixels per inch. By default this property is 300 dpi.|
| [setVerticalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setVerticalResolution-com.aspose.drawing.Resolution-) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |

## **Convert SVG to XPS using XpsSaveOptions**

To convert SVG to XPS with XpsSaveOptions specifying, you should follow a few steps:

1. Load an SVG file using one of the SVGDocument() constructors of the  [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument) class. 
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) object and specify the required properties. The `XpsSaveOptions()` constructor initializes an instance of the XpsSaveOptions class that is passed to `converSVG()` method:
    - Use the `setJpegQuality()` method to specify JPEG compression quality.
    - Use the `setBackgroundColor()` method to set the color that fills the background.
    - Use the `setHorizontalResolution()` and `setVerticalResolution()` methods to set horizontal and vertical resolutions for output XPS files.
    - Use the `setPageSetup()` method to specify the page size and margins for the output document.
1. Call the `сonvertSVG(document, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class. The method takes the `document`, `options`, output file path `savePath` and performs the conversion operation.

The following example shows how to use [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and create an {{%XPS%}} file with custom page size, margins, and resolutions:

{{< highlight java >}}
    // Prepare a path to a source SVG file
    String documentPath = Path.combine(getDataDir(), "aspose.svg");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "aspose-options.xps");

    // Initialize an SVG document from the file
    SVGDocument document = new SVGDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize XpsSaveOptions. Set up the page size 500x500 pixels, margins, and resolutions  
    XpsSaveOptions options = new XpsSaveOptions();
    options.setHorizontalResolution(new Resolution(200, UnitType.AUTO));
    options.setVerticalResolution(new Resolution(200, UnitType.AUTO));    
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(500, 500), new Margin(30, 10, 10, 10)));

    // Convert SVG to XPS
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
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.

Aspose.HTML offers a free online [**SVG to XPS Converter**](https://products.aspose.app/svg/conversion/svg-to-xps) that converts SVG to XPS with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}