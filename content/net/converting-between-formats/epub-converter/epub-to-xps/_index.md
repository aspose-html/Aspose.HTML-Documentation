---
title: Convert EPUB to XPS
type: docs
weight: 30
url: /net/converting-between-formats/epub-to-xps/
aliases: 
    - /net/converting-between-formats/epub-to-xps-conversion/
    - /net/epub-to-xps-conversion/
description: This article provides information on how to convert EPUB to XPS using Aspose.HTML API. You will learn about the supported EPUB to XPS conversion scenarios and consider examples to illustrate them.  
keywords: epub to xps, convert epub to xps, epub to xps converter, save options
lastmod: "2021-09-03"
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

In this article, you will find information on how to convert {{%EPUB%}} to {{%XPS%}} and how to use [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/epub-to-xps" target="_blank">**EPUB to XPS Converter**</a> that converts EPUB to XPS file with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/epub-to-xps" target="_blank">![Text "Banner EPUB to XPS Converter"](epub-to-xps.png#center)</a>

## **EPUB to XPS by two lines of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an EPUB file into various formats. You can convert {{%EPUB%}} to {{%XPS%}} in your C# application literally with two lines of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing EPUB file for reading
     using var stream = File.OpenRead(DataDir + "input.epub");

     // Invoke the ConvertEPUB method to convert EPUB to XPS           
     Converter.ConvertEPUB(stream, new XpsSaveOptions(), Path.Combine(OutputDir, "convert-by-two-lines.xps"));
{{< /highlight >}}

## **Convert EPUB to XPS**

Using [Converter.ConvertEPUB](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertepub/index) methods is the most common way to convert EPUB files into various formats.  The following C# code snippet shows how to convert EPUB to XPS using Aspose.HTML for .NET.

1. Open an existing EPUB file. In the example, we use the OpenRead () method of System.IO.FileStream class to open and read an EPUB file from the file system at the specified path.
1. Create an instance of [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions).
1. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/31) method of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class to save EPUB as an XPS file. You need to pass the EPUB file stream, XpsSaveOptions, and output file path to the ConvertEPUB() method to convert EPUB to XPS.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing EPUB file for reading
     using var stream = File.OpenRead(DataDir + "input.epub");

     // Prepare a path to save the converted file 
     string savePath = Path.Combine(OutputDir, "input-output.xps");
    
     // Create an instance of XpsSaveOptions
     var options = new XpsSaveOptions();
    
     // Call the ConvertEPUB method to convert EPUB to XPS
     Converter.ConvertEPUB(stream, options, savePath); 
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**
With Aspose.HTML, you can convert EPUB to XPS format programmatically with full control over a wide range of conversion parameters. [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) usage enables you to tune the rendering process; you can specify the page size, margins, CSS, etc.  

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [PageSetup](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup) | This property gets a page setup object and uses it for configuration output page-set. |
| [Css](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/css) | Gets a [CssOptions](https://apireference.aspose.com/html/net/aspose.html.rendering/cssoptions) object which is used for configuration of CSS properties processing. |
| [BackgroundColor](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/backgroundcolor) | This property sets the color that will fill the background of every page. By default, this property is Transparent. |
| [HorizontalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/horizontalresolution) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/verticalresolution) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |

{{% alert color="primary" %}}
To learn more about [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}

## **Convert EPUB to XPS using XpsSaveOptions**

Aspose.HTML allows converting EPUB to XPS using default or custom save options. You should follow a few steps: 

1. Open an existing EPUB file.
1. Create a new [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) object and specify the required save options.
1. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/31) method to save EPUB as an XPS file. You need to pass the EPUB file stream, XpsSaveOptions, and output file path to the ConvertEPUB () method for EPUB to XPS conversion.

The following example shows how to use [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) and create an XPS file with custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System.Drawing;
using Aspose.Html.Drawing;
...
    // Open an existing EPUB file for reading
    using var stream = File.OpenRead(DataDir + "input.epub");

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "input-options.xps");
    
    // Create an instance of XpsSaveOptions. Set up the page-size and change the background color to LightGray 
    var options = new XpsSaveOptions()
    {
        PageSetup =
            {
                AnyPage = new Page()
                {
                    Size = new Aspose.Html.Drawing.Size(Length.FromPixels(500), Length.FromPixels(500))
                }
            },
        BackgroundColor = Color.LightGray
    };
    
    // Call the ConvertEPUB method to convert EPUB to XPS
    Converter.ConvertEPUB(stream, options, savePath); 
{{< /highlight >}}

In the example, we use the OpenRead () method of System.IO.FileStream class to open and read source files from the file system at the specified path. The [XpsSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/constructors/main) constructor initialize an instance of the XpsSaveOptions class that is passed to ConvertEPUB() method. The ConvertEPUB() method takes the `stream`, `options`,  output file path `savePath` and performs the conversion operation. The XpsSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of EPUB to XPS conversion. 

In the example, we use:

 - BackgroundColor property that specifies the color that the background will be filled in. The default BackgroundColor is Transparent;
 - PageSetup property that specifies the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup) in pixels.

Aspose.HTML for .NET provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance {{%PDF%}}, {{%XPS%}}), others create multiple files (Image formats {{%JPG%}}, {{%PNG%}}, etc.).

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering document/page.


The example below shows how to implement and use the your own *MemoryStreamProvider* in the application:

{{< highlight java >}}
using System.IO;
using System.Collections.Generic;
...
    class MemoryStreamProvider : Aspose.Html.IO.ICreateStreamProvider
    {
        // List of MemoryStream objects created during the document rendering
        public List<MemoryStream> Streams { get; } = new List<MemoryStream>();

        public Stream GetStream(string name, string extension)
        {
            // This method is called when only one output stream is required, for instance for XPS, PDF or TIFF formats.
            MemoryStream result = new MemoryStream();
            Streams.Add(result);
            return result;
        }
    
        public Stream GetStream(string name, string extension, int page)
        {
            // This method is called when the creation of multiple output streams are required. For instance, during the rendering HTML to list of image files (JPG, PNG, etc.)
            MemoryStream result = new MemoryStream();
            Streams.Add(result);
            return result;
        }
    
        public void ReleaseStream(Stream stream)
        {
            //  Here you can release the stream filled with data and, for instance, flush it to the hard-drive
        }
    
        public void Dispose()
        {
            // Releasing resources
            foreach (var stream in Streams)
                stream.Dispose();
        }
    }

{{< /highlight >}}

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using System.Linq;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Create an instance of MemoryStreamProvider
    using var streamProvider = new MemoryStreamProvider();

    // Open an existing EPUB file for reading
    using var stream = File.OpenRead(DataDir + "input.epub");
    
    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "stream-provider.xps");
    
    // Convert EPUB to XPS by using the MemoryStreamProvider class
    Converter.ConvertEPUB(stream, new XpsSaveOptions(), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(savePath))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

The ConvertEPUB(`Stream`, `XpsSaveOptions`, `ICreateStreamProvider`) method takes the conversion source, options, and instance of MemoryStreamProvider, which will be used to get an output stream, and performs the conversion operation.

{{% alert color="primary" %}} 

You can check the quality of EPUB to XPS conversion with our online [**EPUB to XPS Converter**](https://products.aspose.app/html/en/conversion/epub-to-xps). You can convert multiple EPUB files to XPS and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful EPUB to XPS Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}