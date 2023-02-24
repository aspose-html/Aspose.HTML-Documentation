---
title: Convert EPUB to XPS in Java
linktitle: Convert EPUB to XPS
keywords: epub to xps, convert epub to xps java, convert epub to xps, epub to xps conversion, save options, stream provider, java code
description: Convert EPUB to XPS in Java using Aspose.HTML API. Consider various EPUB to XPS conversion scenarios in Java code.
url: /java/convert-epub-to-xps/
type: docs
weight: 40
aliases:
  - /java/epub-to-xps-conversion/
  - /java/converting-between-formats/epub-to-xps-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

XPS is a document storage and viewing format developed by Microsoft. An XPS file has a set of advantages that support security features, such as digital signatures to provide greater document security and more. With Aspose.HTML for Java, you can convert EPUB to XPS format programmatically with full control over a wide range of conversion parameters.

In this article, you will find information on how to convert an {{%EPUB%}} to {{%XPS%}} with Aspose.HTML for Java and how to use [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) parameters.

## **EPUB to XPS by a single line of Java code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an EPUB file into various formats. You can convert EPUB to XPS in your Java application literally with a single line of code!

{{< highlight java >}}
    // Invoke the convertEPUB()          
    com.aspose.html.converters.Converter.convertEPUB(File.openRead(StringExtensions.concat(getDataDir(),  "input.epub")), new XpsSaveOptions(), Path.combine(getOutputDir(), "output.xps"));
{{< /highlight >}}

## **Convert EPUB to XPS**

Using convertEPUB() methods is the most common way to convert EPUB files into various formats. The following Java code snippet shows how to convert EPUB to XPS using Aspose.HTML:

1. Open an existing EPUB file. In the example, we use the `openRead()` method to open and read an EPUB file from the file system at the specified path.
1. Create an instance of [XpsSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) Use the empty XpsSaveOptions() constructor to convert with the default save options.
1. Use the `convertEPUB(stream, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save EPUB as an XPS file. You need to pass the EPUB file stream, XpsSaveOptions, and output file path to the `convertEPUB()` method as parameters.

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "input-output.xps");

    // Create an instance of XpsSaveOptions
    XpsSaveOptions options = new XpsSaveOptions();

    // Call the convertEPUB() method
    com.aspose.html.converters.Converter.convertEPUB(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

Aspose.HTML provides the ability to programmatically convert EPUB to XPS with full control over various conversion options using [XpsSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) This feature allows users to customize the rendering process by setting the [page size,](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--) [margins,](https://reference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--) [CSS media-type,](https://reference.aspose.com/html/java/com.aspose.html.rendering/MediaType) and other parameters.

| Metod                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [getCss()](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getCss--) | Gets a [CssOptions](https://reference.aspose.com/html/java/com.aspose.html.rendering/CssOptions) object which is used for configuration of CSS properties processing. |
| [setBackgroundColor(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setBackgroundColor-com.aspose.ms.System.Drawing.Color-) | Sets the color that will fill the background of every page. By default, this property is `Transparent`. |
| [setPageSetup(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setPageSetup-com.aspose.rendering.PageSetup-) | This method sets a page setup object and uses it for configuration output page-set. |
| [setHorizontalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setHorizontalResolution-com.aspose.drawing.Resolution-) | Sets horizontal resolution for internal images, in pixels per inch. By default this property is 300 dpi.|
| [setVerticalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setVerticalResolution-com.aspose.drawing.Resolution-) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |


## **Convert EPUB to XPS using XpsSaveOptions**

Aspose.HTML for Java allows converting EPUB to XPS using default or custom save options. Setting different options of XpsSaveOptions class gives you control over the page size, margins, background color, and resolution settings for the output XPS. These are the steps to convert an EPUB file to XPS format with XpsSaveOptions specifying:  

1. Open an existing EPUB file. Use the `openRead()` method of System.IO.FileStream class to open and read source files from the file system at the specified path.
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) object and specify the required save options. Use the `setPageSetup()` and `setBackgroundColor()` methods to set the page size and background color.
1. Use the `convertEPUB(stream, options, savePath)` method to save EPUB as an XPS file. The method takes the `stream`, `options`, output file path `savePath` and performs the conversion operation.

The following Java example shows how to use `XpsSaveOptions` and create an XPS file with page-size and background color:

{{< highlight java >}}
    // Open an existing EPUB file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "input.epub"));
    try
    {;
    }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }

    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "input-options.xps");

    // Create an instance of XpsSaveOptions. Set up the page-size and change the background color to LightGray
    XpsSaveOptions options = new XpsSaveOptions();
    PageSetup pageSetup = new PageSetup();
    Page anyPage = new Page();
    anyPage.setSize(new com.aspose.html.drawing.Size(Length.fromPixels(500),Length.fromPixels(500)));
    pageSetup.setAnyPage(anyPage);
    options.setPageSetup(pageSetup);
    options.setBackgroundColor(Color.getLightGray());

    // Call the convertEPUB() method
    com.aspose.html.converters.Converter.convertEPUB(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
For further information on how to customize the conversion process with [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/XpsSaveOptions) you can refer to the [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.

Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.HTML for Java x.x.x will be displayed against these fields.
{{% /alert %}}

## **Output Stream Providers**

When it is necessary to save files to remote storage such as a cloud or database, implementing the [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface can provide manual control over the file creation process. This interface serves as a callback object that allows for creating a stream at the beginning of the document or page depending on the output format, and the release of the early created stream after the document or page is rendered. Using the MemoryStreamProvider interface allows users to have greater control over the file-saving process, which can be particularly useful when the storage location is remote or requires specific configurations.

Aspose.HTML for Java provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, XPS), others create multiple files (Image formats JPG, PNG, etc.).

The example below shows how to implement and use the your own *MemoryStreamProvider* in the application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**EPUB to XPS Converter**](https://products.aspose.app/html/conversion/epub-to-xps) that converts EPUB to XPS with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}