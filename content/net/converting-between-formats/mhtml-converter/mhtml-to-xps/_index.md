---
keywords: MHTML to XPS, convert MHTML to XPS, MHTML to XPS conversion, MHTML to
  XPS converter, save options, stream provider
lastmod: 2021-09-03
url: /net/converting-between-formats/mhtml-to-xps/
title: Convert MHTML to XPS | C#
description: This article provides information on how to convert MHTML to XPS
  using the Aspose.HTML API. You will learn about the supported MHTML to XPS
  conversion scenarios and consider examples to illustrate them.
weight: 20
type: docs
aliases:
  - /net/converting-between-formats/mhtml-to-xps-conversion/
  - /net/mhtml-to-xps-conversion/
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

MHTML to XPS conversion is often required to take advantage of XPS format for specific tasks. An XPS file represents page layout files that are based on XML Paper Specifications, created by Microsoft. 

In this article, you find information on how to convert {{%MHTML%}} to {{%XPS %}} using ConvertHTML() methods of the Converter class and how to apply [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/mhtml-to-xps" target="_blank">**MHTML to XPS Converter**</a> that converts MHTML to XPS file with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/mhtml-to-xps" target="_blank">![Text "Banner MHTML to XPS Converter"](mhtml-to-xps.png#center)</a>


## **MHTML to XPS by two lines of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an MHTML code into various formats. For example, you can convert {{%MHTML%}} to {{%XPS %}} in your C# application literally with two lines of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing MHTML file for reading
     using var stream = File.OpenRead(DataDir + "sample.mht");

     // Invoke the ConvertMHTML method to convert the MHTML code to XPS           
     Converter.ConvertMHTML(stream, new XpsSaveOptions(), Path.Combine(OutputDir, "convert-by-two-lines.xps")); 
{{< /highlight >}}

## **Convert MHTML to XPS**

Using [Converter.ConvertMHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertmhtml/index) methods is the most common way to convert MHTML code into various formats.  With Aspose.HTML, you can convert MHTML to XPS format programmatically with full control over a wide range of conversion parameters. 

The following C# code snippet shows how to convert MHTML to XPS using Aspose.HTML for .NET.

1. Open an existing MHTML file.
1. Create an instance of the [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) class.
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/29) method of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class to save MHTML as a XPS file. You need to pass the MHTML file stream, XpsSaveOptions, and output file path to the ConvertMHTML() method method for MHTML to XPS conversion.

In the example, we use the OpenRead() method of System.IO.FileStream class to open and read files from the file system at the specified path.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing MHTML file for reading
     using var stream = File.OpenRead(DataDir + "sample.mht");

     // Prepare a path for converted file saving 
     string savePath = Path.Combine(OutputDir, "sample-output.xps");
    
     // Create an instance of XpsSaveOptions
     var options = new XpsSaveOptions();
    
     // Call the ConvertMHTML method to convert MHTML to XPS
     Converter.ConvertMHTML(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**

Aspose.HTML allows converting MHTML to XPS using default or custom save options. [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) usage enables you to customize the rendering process; you can specify the page size, margins, background color, resolutions, etc.  


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


## **Convert MHTML to XPS using XpsSaveOptions**

To convert MHTML to XPS with XpsSaveOptions specifying, you should follow a few steps: 

1. Open an existing MHTML file.
1. Create a new [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) object and specify save options.
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/29) method to save MHTML as a XPS file. You need to pass the MHTML file stream, XpsSaveOptions, and output file path to the ConvertMHTML() method for MHTML to XPS conversion.

The following example shows how to use [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) and create an XPS file with custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System.Drawing;
using Aspose.Html.Drawing;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "sample-options.xps");
    
    // Create an instance of XpsSaveOptions. Set up the page-size and change the background color to AliceBlue 
    var options = new XpsSaveOptions();
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(8.3f), Length.FromInches(5.8f)));
    options.BackgroundColor = Color.AliceBlue;            
    
    // Call the ConvertMHTML method to convert MHTML to XPS
    Converter.ConvertMHTML(stream, options, savePath);
{{< /highlight >}}

In the example, we use the OpenRead() method of System.IO.FileStream class to open and read source files from the file system at the specified path. The [XpsSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/constructors/main) constructor initialize an instance of the XpsSaveOptions class that is passed to ConvertMHTML() method. The ConvertMHTML() method takes the `stream`, `options`,  output file path `savePath` and performs the conversion operation. The XpsSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting MHTML to XPS format. 

In the above example, we use:
 - BackgroundColor property that specifies the color that the background will be filled in. The default BackgroundColor is Transparent;
 - PageSetup property that specifies the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup) in pixels.

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

{{% alert color="primary" %}} 

Aspose.HTML for .NET provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance {{%PDF%}}, {{%XPS%}}), others create multiple files (Image formats {{%JPG%}}, {{%PNG%}}, etc.).

{{% /alert %}} 

The example below shows how to implement and use your own *MemoryStreamProvider* in the application:

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

     // Open an existing MHTML file for reading
     using var stream = File.OpenRead(DataDir + "sample.mht");
    
     // Prepare a path for converted file saving 
     string savePath = Path.Combine(OutputDir, "stream-provider.xps");
    
     // Convert MHTML to XPS by using the MemoryStreamProvider class
     Converter.ConvertMHTML(stream, new XpsSaveOptions(), streamProvider);
    
     // Get access to the memory stream that contains the result data
     var memory = streamProvider.Streams.First();
     memory.Seek(0, SeekOrigin.Begin);
    
     // Flush the result data to the output file
     using (FileStream fs = File.Create(savePath))
     {
         memory.CopyTo(fs);
     }
{{< /highlight >}}

{{% alert color="primary" %}} 
You can check the quality of MHTML to XPS conversion with our online [**MHTML to XPS Converter**](https://products.aspose.app/html/en/conversion/mhtml-to-xps). You can convert multiple MHTML files to XPS and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful MHTML to XPS Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}



