---
title: SVG Converter - Convert SVG in Java
linktitle: SVG Converter
keywords: svg converter, svg conversions, convert svg, svg to image, svg to pdf, java example, java code
description: Convert SVG to other formats using Aspose.HTML for Java API or Online SVG Converter. Consider Java example of SVG to PNG conversion.
weight: 60
type: docs
url: /java/svg-converter/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

{{%SVG%}} is Scalable Vector Graphics. This is a vector image format for creating graphics and images that can be scaled up or down without losing quality. SVG images are created using XML code that describes the shapes, paths, lines, and colors that make up the image. 

One of the main features of Aspose.HTML is its conversion capability. Aspose.HTML for Java provides easy access to conversion methods through its [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class, which is a shared facade for most often conversion scenarios and offers a wide range of SVG conversions to popular formats like {{%PDF%}}, {{%XPS%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}. 

## **How to Convert SVG in Java**

The articles in the "SVG Converter" chapter give information on the list of supported SVG conversions and how to perform them using the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class.

{{% alert color="primary" %}} 

To convert SVG, you should take a few steps:

1. [Install Aspose.HTML for Java library](/html/java/getting-started/installation/) to convert SVG.
2. Initialize a new instance of the [SVGDocument](https://reference.aspose.com/html/java/com.aspose.html.dom.svg/SVGDocument) class using one of SVGDocument() constructors.
3. Create a Save Options object that specifies the desired output format and conversion options.
4. Call one of the [convertSVG()](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) methods and pass the necessary parameters to it.
{{% /alert %}}   

Please take a look over the following Java code snippet that shows the SVG to PNG conversion using the `convertSVG(document, options, savePath)` method.

{{< highlight java >}}
	// Prepare a path to a source SVG file
    String documentPath = Path.combine(getDataDir(), "gradient.svg");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "gradient-options.png");

    // Initialize an SVG document from the file
    SVGDocument document = new SVGDocument(documentPath);
    try {
        // Initialize an instance of ImageSaveOptions 
        ImageSaveOptions options = new ImageSaveOptions();        

        // Convert SVG to PNG
        com.aspose.html.converters.Converter.convertSVG(document, options, savePath);
    }
    finally {
        if (document != null)
            document.dispose();
    }
{{< /highlight >}}

## **Popular SVG Conversions**

- [Convert SVG to PDF](/html/java/convert-svg-to-pdf/) - Learn how to convert SVG to PDF using Java library. 
- [Convert SVG to XPS](/html/java/convert-svg-to-xps/) - Consider various SVG to XPS conversion scenarios in Java code.
- [Convert SVG to PNG](/html/java/convert-svg-to-png/) - Learn how to convert SVG to PNG with Aspose.HTML for Java, and you can easily use the Java code described here to convert SVG to JPG, BMP, GIF, TIFF.
- [Convert SVG to JPG](/html/java/convert-svg-to-jpg/) - Know how to convert SVG to JPG using the `convertSVG()` methods of the Converter class and how to apply ImageSaveOptions.

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**SVG Converter**](https://products.aspose.app/svg/conversion/svg) for converting SVG files to various popular formats. You can easily convert  [SVG to PDF,](https://products.aspose.app/svg/conversion/svg-to-pdf) SVG to XPS, [SVG to PNG,](https://products.aspose.app/svg/conversion/svg-to-png) [SVG to JPG,](https://products.aspose.app/svg/conversion/svg-to-jpg) etc. Select the file and the format to convert, and you’re done. It’s fast and completely free!

You can download the complete Java examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}} 
