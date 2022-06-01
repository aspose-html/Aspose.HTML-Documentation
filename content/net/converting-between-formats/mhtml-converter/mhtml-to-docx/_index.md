---
title: Convert MHTML to DOCX | C#
linktitle: Convert MHTML to DOCX
keywords: MHTML to DOCX, convert MHTML to DOCX, MHTML to DOCX conversion, MHTML
  to DOCX converter, save options, stream provider
description: This article provides information on how to convert MHTML to DOCX
  using the Aspose.HTML API. You will learn about the supported MHTML to DOCX
  conversion scenarios and consider examples to illustrate them.
weight: 30
type: docs
url: /net/converting-between-formats/mhtml-to-docx/
lastmod: 2022-06-01
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

MHTML to DOCX conversion is often required to take advantage of DOCX format for specific tasks. DOCX is a well-known format for Microsoft Word documents. It can contain a wide range of data, including text, tables, raster and vector graphics, video, sounds and diagrams. This format is popular because it supports a wide range of formatting features and offers users a variety of options to write any type of document. 

In this article, you find information on how to convert {{%MHTML%}} to {{%DOCX%}} using ConvertMHTML() methods of the Converter class and how to apply [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/mhtml-to-docx" target="_blank">**MHTML to DOCX Converter**</a> that converts MHTML to DOCX file with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/mhtml-to-docx" target="_blank">![Text "Banner MHTML to DOCX Converter"](mhtml-to-docx.png#center)</a>

## **MHTML to DOCX by two lines of code**

The static methods of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an MHTML code into various formats. For example, you can convert {{%MHTML%}} to {{%DOCX%}} in your C# application literally with two lines of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing MHTML file for reading
     using var stream = File.OpenRead(DataDir + "sample.mht");

     // Invoke the ConvertMHTML method to convert MHTML to DOCX           
     Converter.ConvertMHTML(stream, new DocSaveOptions(), Path.Combine(OutputDir, "convert-by-two-lines.docx"));
{{< /highlight >}}

## **Convert MHTML to DOCX**

Using [Converter.ConvertMHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertmhtml/index) methods is the most common way to convert MHTML code into various formats.  With Aspose.HTML, you can convert MHTML to DOCX format programmatically with full control over a wide range of conversion parameters. 

The following C# code snippet shows how to convert MHTML to DOCX using Aspose.HTML for .NET.

1. Open an existing MHTML file.
1. Create an instance of the [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) class.
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/25) method of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class to save MHTML as a DOCX file. You need to pass the MHTML file stream, DocSaveOptions, and output file path to the ConvertMHTML() method method for MHTML to DOCX conversion.

In the example, we use the OpenRead() method of System.IO.FileStream class to open and read files from the file system at the specified path.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing MHTML file for reading
     using var stream = File.OpenRead(DataDir + "sample.mht");

     // Prepare a path to save the converted file 
     string savePath = Path.Combine(OutputDir, "sample-output.docx");
    
     // Create an instance of DocSaveOptions
     var options = new DocSaveOptions();
    
     // Call the ConvertMHTML method to convert MHTML to DOCX
     Converter.ConvertMHTML(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

### **MHTML Converter Live Demos**
You can convert MHTML to other formats with Aspose.HTML for .NET API in real time. First, load an MHTML file from your local drive and then run the example. In this example, the save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/html/converter MHTML DOCX PDF "JPG|JPEG" TIFF PNG GIF XPS BMP >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;

    using var document = new HTMLDocument("document.{{input lower}}");
{{#if_output 'PDF'}}
    var options = new PdfSaveOptions();
{{/if_output}}
{{#if_output 'DOCX'}}
    var options = new DocSaveOptions();
{{/if_output}}
{{#if_output 'XPS'}}
    var options = new XpsSaveOptions();
{{/if_output}}
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output param2 camel}});
{{/if_output}}
    Converter.ConvertHTML(document, options, "output.{{output lower}}");   
{{< /app/html/converter>}}

## **Save Options**

Aspose.HTML allows converting MHTML to DOCX using default or custom save options. [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) usage enables you to customize the rendering process; you can specify the page size, margins, resolutions, CSS, etc. 


| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [FontEmbeddingRule](https://apireference.aspose.com/html/net/aspose.html.rendering.doc/docrenderingoptions/properties/fontembeddingrule) | This property gets or sets the font embedding rule. Available values are Full and None. The default value is [None](https://apireference.aspose.com/html/net/aspose.html.rendering.doc/fontembeddingrule). |
| [Css](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/css) | Gets a [CssOptions](https://apireference.aspose.com/html/net/aspose.html.rendering/cssoptions) object which is used for configuration of CSS properties processing. |
| [DocumentFormat](https://apireference.aspose.com/html/net/aspose.html.rendering.doc/docrenderingoptions/properties/documentformat) | This property gets or sets the file format of the output document. The default value is [DOCX](https://apireference.aspose.com/html/net/aspose.html.rendering.doc/documentformat). |
| [PageSetup](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/horizontalresolution) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/verticalresolution) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |

{{% alert color="primary" %}}

To learn more about [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}


## **Convert MHTML to DOCX using DocSaveOptions**

To convert MHTML to DOCX with DocSaveOptions specifying, you should follow a few steps: 

1. Open an existing MHTML file.
1. Create a new [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) object and specify save options.
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/25) method to save MHTML as a DOCX file. You need to pass the MHTML file stream, DocSaveOptions, and output file path to the ConvertMHTML() method for MHTML to DOCX conversion.

The following example shows how to use [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) and create a DOCX file with custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Drawing;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "sample-options.docx");
    
    // Create an instance of DocSaveOptions and set A5 as a page size. 
    var options = new DocSaveOptions();
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(8.3f), Length.FromInches(5.8f)));            
    
    // Call the ConvertMHTML method to convert MHTML to DOCX
    Converter.ConvertMHTML(stream, options, savePath); 
{{< /highlight >}}

In the example, we use the OpenRead() method of System.IO.FileStream class to open and read source files from the file system at the specified path. The [DocSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions/constructors/main) constructor initializes an instance of the DocSaveOptions class that is passed to ConvertMHTML() method. The ConvertMHTML() method takes the `stream`, `options`,  output file path `savePath` and performs the conversion operation. The DocSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting MHTML to DOCX format. In the example, we use the PageSetup property that specifies the page size of the DOCX document.

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

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
    
     // Prepare a path to save the converted file 
     string savePath = Path.Combine(OutputDir, "stream-provider.docx");
    
     // Convert MHTML to DOCX by using the MemoryStreamProvider class
     Converter.ConvertMHTML(stream, new DocSaveOptions(), streamProvider);
    
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
You can check the quality of MHTML to DOCX conversion with our online [**MHTML to DOCX Converter**](https://products.aspose.app/html/conversion/mhtml-to-docx). You can convert multiple MHTML files to DOCX and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful MHTML to DOCX Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}



