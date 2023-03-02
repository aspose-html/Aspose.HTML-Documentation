---
title: Convert HTML to XPS Using Java
linktitle: Convert HTML to XPS
type: docs
weight: 40
keywords: html to xps, convert html to xps java, convert html to xps, html to xps conversion, save options, stream provider, java code
description: Convert HTML to XPS in Java using Aspose.HTML API. Consider various HTML to XPS conversion scenarios in Java code.
url: /java/convert-html-to-xps/
aliases: 
  - /java/html-to-xps-conversion/
  - /java/converting-between-formats/html-to-xps-conversion/ 
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-03-03
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

XPS is a document format created by Microsoft that offers several benefits, including advanced security features like digital signatures for added document protection. XPS files offer access rights management and produce high-quality, printable documents. Thus, HTML to XPS conversion can provide greater flexibility and functionality for managing and sharing documents, making it a valuable tool in certain situations.

In this article, you will find information on how to convert {{%HTML%}} to {{%XPS%}} using Aspose.HTML for Java library and how to apply [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) parameters.

## **HTML to XPS by a single line of Java code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to {{%XPS%}} in your Java application literally with a single line of code!

{{< highlight java >}}
    // Invoke the convertHTML() method to convert the HTML code to XPS           
    com.aspose.html.converters.Converter.convertHTML("<h1>Convert HTML to XPS!</h1>", ".", new XpsSaveOptions(), Path.combine(getOutputDir(), "convert-with-single-line.xps"));
{{< /highlight >}}

In the example we use the `convertHTML(content, baseUri, options, outputPath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class that takes four parameters: string with HTML code to be converted, the base folder for the input HTML file, an instance of the XpsSaveOptions class, and the output file path where the converted file will be saved.

## **Convert HTML to XPS in Java**

Converting a file to another format using the `convertHTML()` method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class.
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) object. Use the empty XpsSaveOptions() constructor to convert with the default save options.
1. Use the `convertHTML()` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save HTML as an XPS file. You need to pass the HTMLDocument, XpsSaveOptions, and output file path to the `convertHTML()` method to convert HTML to XPS.

Please take a look over the following Java code snippet which shows the process of converting HTML to XPS using Aspose.HTML for Java.

{{< highlight java >}}
    // Prepare a path to a source HTML file
    String documentPath = Path.combine(getDataDir(), "canvas.html");

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "canvas-output.xps");

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }

    // Initialize XpsSaveOptions 
    XpsSaveOptions options = new XpsSaveOptions();

    // Convert HTML to XPS
    com.aspose.html.converters.Converter.convertHTML(document, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

With [XpsSaveOptions,](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) you have the ability to personalize the rendering process for your XPS files. This includes customizing elements such as the page size, margins, background color, CSS media type, and more.

| Metod                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [getCss()](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getCss--) | Gets a [CssOptions](https://reference.aspose.com/html/java/com.aspose.html.rendering/CssOptions) object which is used for configuration of CSS properties processing. |
| [setBackgroundColor(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setBackgroundColor-com.aspose.ms.System.Drawing.Color-) | Sets the color that will fill the background of every page. By default, this property is `Transparent`. |
| [setPageSetup(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setPageSetup-com.aspose.rendering.PageSetup-) | This method sets a page setup object and uses it for configuration output page-set. |
| [setHorizontalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setHorizontalResolution-com.aspose.drawing.Resolution-) | Sets horizontal resolution for internal images, in pixels per inch. By default this property is 300 dpi.|
| [setVerticalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setVerticalResolution-com.aspose.drawing.Resolution-) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |

To learn more about [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/XpsSaveOptions) please read [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.

## **Convert HTML to XPS in Java using XpsSaveOptions**

The XpsSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to XPS format. The following example shows how to use [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and create an XPS file with custom page-size and background color:

1. Load an HTML file using one of the HTMLDocument() constructors of the  [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class. 
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) object.
1. Use the [convertHTML()](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) method of the Converter class to save HTML as an XPS file. You must pass parameters to it - `document`, `options` and output file path `savePath` to perform the conversion.

The following example shows how to use [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and create an XPS file with custom page-size and background color:

{{< highlight java >}}
    String documentPath = Path.combine(getOutputDir(), "save-options.html");
    String savePath = Path.combine(getOutputDir(), "save-options-output.xps");

    // Prepare HTML code and save it to a file
    String code = StringExtensions.concat("<h1>  XpsSaveOptions Class</h1>\r\n", 
                   "<p>Using XpsSaveOptions Class, you can programmatically apply a wide range of conversion parameters such as BackgroundColor, PageSetup, etc.</p>\r\n");

    com.aspose.html.internal.ms.System.IO.File.writeAllText(documentPath, code);

    // Initialize an HTML document from the file
    HTMLDocument document = new HTMLDocument(documentPath);
    try {        }
    finally { if (document != null) document.dispose(); }
        
    // Set up the page-size, margins and change the background color to AntiqueWhite
     XpsSaveOptions options = new XpsSaveOptions();
    com.aspose.html.drawing.Color.getAntiqueWhite().CloneTo(options.getBackgroundColor());
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(com.aspose.html.drawing.Length.fromInches(4.9f), com.aspose.html.drawing.Length.fromInches(3.5f))));

    // Convert HTML to XPS
    com.aspose.html.converters.Converter.convertHTML(document, options, savePath); 

{{< /highlight >}}

<!--## **Output Stream Providers** 

If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface to have manual control over the file creating process. This interface designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering document/page.

Aspose.HTML for Java offers a variety of output formats for rendering operations. While some formats produce a single output file, such as PDF and XPS, others generate multiple files, such as image formats JPG, PNG, etc.

The example below shows how to implement and use your own `MemoryStreamProvider` in the application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}-->

{{% alert color="primary" %}} 
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.

Check the quality of HTML to XPS conversion with our online [**HTML to XPS Converter.**](https://products.aspose.app/html/conversion/html-to-xps) Upload, convert your files and get the result in a few seconds. Try our forceful HTML to XPS Converter for free now!

{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-xps" target="_blank">![Text "Banner HTML to XPS Converter"](./../../../images/html-to-xps.png#center)</a>
