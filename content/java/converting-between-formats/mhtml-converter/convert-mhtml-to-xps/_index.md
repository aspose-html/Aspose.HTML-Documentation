---
title: MHTML to XPS Conversion
linktitle: Convert MHTML to XPS
type: docs
weight: 40
keywords: mhtml to xps, convert mhtml to xps java, convert mhtml to xps, mhtml to xps conversion, mhtml to xps converter, save options, stream provider, java code
description: Learn how to convert MHTML to XPS using Aspose.HTML for Java library. Consider various MHTML to XPS conversion scenarios in Java code.
url: /java/convert-mhtml-to-xps/
aliases: 
    - /java/mhtml-to-xps-conversion/
    - /java/converting-between-formats/mhtml-to-xps-conversion/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

XPS is a fixed-layout document format that can be viewed on any device with an XPS viewer installed. It allows for high-quality printing and supports various page layouts and typography features. Therefore, if you want to create a document that can be easily shared and printed, converting MHTML to XPS may be a good option.

In this article, you will find information on how to convert an {{%MHTML%}} to {{%XPS%}} using Aspose.HTML for Java library and how to apply [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and [MemoryStreamProvider.](https://reference.aspose.com/html/java/com.aspose.html/package-frame)

## **MHTML to XPS by a few lines of code**

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an MHTML file into various formats. You can convert MHTML to XPS with just a few lines of code!

{{< highlight java >}}
    // Open an existing MHTML file for reading
    final  com.aspose.html.internal.ms.System.IO.FileStream stream = com.aspose.html.internal.ms.System.IO.File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht"));
    try
    {;
    }
    finally { if (stream != null) stream.dispose(); }

    // Invoke the convertMHTML() method to convert MHTML           
    com.aspose.html.converters.Converter.convertMHTML(stream, new XpsSaveOptions(), Path.combine(getOutputDir(), "convert-by-few-lines.xps"));
{{< /highlight >}}

## **Convert MHTML to XPS in Java**

Let's walk through the step-by-step instructions for a simple MHTML to XPS conversion scenario:

1. Load an MHTML file. You can load MHTML from a file, stream, or URL. In the example we use `openRead(path)` method to open and read an MHTML document from the file system.
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) object. Use the empty XpsSaveOptions() constructor to convert with the default save options.
1. Use the `сonvertMHTML(stream, options, savePath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save an MHTML document as an XPS file. The method takes as parameters `stream`, `options`, and `savePath` and performs the conversion.

{{< highlight java >}}
    // Open an existing MHTML file for reading
    final  com.aspose.html.internal.ms.System.IO.FileStream stream = com.aspose.html.internal.ms.System.IO.File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht"));
    try
    {;
    }
    finally { if (stream != null) stream.dispose(); }

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "sample-output.xps");

    // Create an instance of XpsSaveOptions
    XpsSaveOptions options = new XpsSaveOptions();

    // Convert MHTML to XPS
    com.aspose.html.converters.Converter.convertMHTML(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}

## **Save Options**

[XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) allows you to personalize the rendering process. This includes customizing properties such as the page size, margins, background color, CSS media type, and more.

| Metod                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [getCss()](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getCss--) | Gets a [CssOptions](https://reference.aspose.com/html/java/com.aspose.html.rendering/CssOptions) object which is used for configuration of CSS properties processing. |
| [setBackgroundColor(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setBackgroundColor-com.aspose.ms.System.Drawing.Color-) | Sets the color that will fill the background of every page. By default, this property is `Transparent`. |
| [setPageSetup(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setPageSetup-com.aspose.rendering.PageSetup-) | This method sets a page setup object and uses it for configuration output page-set. |
| [setHorizontalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setHorizontalResolution-com.aspose.drawing.Resolution-) | Sets horizontal resolution for internal images, in pixels per inch. By default this property is 300 dpi.|
| [setVerticalResolution(value)](https://reference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#setVerticalResolution-com.aspose.drawing.Resolution-) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |

{{% alert color="primary" %}}
Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.HTML for Java x.x.x will be displayed against these fields.

For further information on how to customize the conversion process with [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/XpsSaveOptions) you can refer to the [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

## **Convert MHTML to XPS in Java using XpsSaveOptions**

The XpsSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting MHTML to XPS format. 

1. Load an MHTML file. You can load MHTML from a file, stream, or URL.
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) object and set the required save options:
    - Use the `setPageSetup()` method to specify the page size for the output XPS document.
    - Use the `setBackgroundColor()` method to set the color that fills the background.
1. Use the [convertHTML()](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) method of the Converter class to save HTML as an XPS file. You must pass parameters to it - `document`, `options` and output file path `savePath` to perform the conversion.

The following example shows how to use [XpsSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and create an XPS file with custom page size and background color:

{{< highlight java >}}
    // Open an existing MHTML file for reading
    final  com.aspose.html.internal.ms.System.IO.FileStream stream = com.aspose.html.internal.ms.System.IO.File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht"));
    try
    {;
    }
    finally { if (stream != null) stream.dispose(); }

    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "sample-options.xps");

    // Create an instance of XpsSaveOptions. Set up the page-size and change the background color to AliceBlue 
    XpsSaveOptions options = new XpsSaveOptions();
    options.getPageSetup().setAnyPage(new Page(new com.aspose.html.drawing.Size(com.aspose.html.drawing.Length.fromInches(8.3f), com.aspose.html.drawing.Length.fromInches(5.8f))));
    com.aspose.html.drawing.Color.getAliceBlue().CloneTo(options.getBackgroundColor());

    // Convert MHTML to XPS
    com.aspose.html.converters.Converter.convertMHTML(stream, options, savePath);
{{< /highlight >}}

<!--## **Output Stream Providers**

You can implement the [MemoryStreamProvider](https://reference.aspose.com/html/java/com.aspose.html/package-frame) interface to manually control the process of saving files in remote storage such as the cloud or database. This interface works as a callback object that creates a stream at the beginning of the document/page (depending on the output format) and releases the created stream after rendering the document/page. By implementing this interface, you can fully control the file creation process in remote storage.

Aspose.HTML for Java offers a variety of output formats for rendering tasks. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).

The following example demonstrates how to implement and use a custom *MemoryStreamProvider* in your Java application:

{{< highlight java >}}

{{< /highlight >}}

{{< highlight java >}}

{{< /highlight >}}-->

{{% alert color="primary" %}} 
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.

Aspose.HTML offers a free online [**MHTML to XPS Converter**](https://products.aspose.app/html/conversion/mhtml-to-xps) that converts MHTML to XPS with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/mhtml-to-xps" target="_blank">![Text "Banner MHTML to XPS Converter"](./../../../mhtml-to-xps.png#center)</a>
