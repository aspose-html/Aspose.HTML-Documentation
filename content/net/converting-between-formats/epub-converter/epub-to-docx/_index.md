---
title: Convert EPUB to DOCX
keywords: EPUB to DOCX, convert EPUB to DOCX, EPUB to DOCX conversion, EPUB to
  DOCX converter, save options, stream provider
description: This article provides information on how to convert EPUB to DOCX
  using the Aspose.HTML API. You will learn about the supported EPUB to DOCX
  conversion scenarios and consider examples to illustrate them.
weight: 20
type: docs
url: /net/converting-between-formats/epub-to-docx/
lastmod: 2021-09-03
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

DOCX is a well-known format for Microsoft Word documents. This format is popular because it supports a wide range of formatting features and offers users a variety of options to write any type of document. DOCX files can be opened with Word 2007 and lateral versions but not with the earlier versions of MS Word, which support DOC file extensions. EPUB to DOCX conversion is often required to take advantage of DOCX format for specific user tasks. 

In this article, you find information on how to convert {{%EPUB%}} to {{%DOCX%}} using ConvertEPUB() methods of the Converter class and how to apply [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/epub-to-docx" target="_blank">**EPUB to DOCX Converter**</a> that converts EPUB to DOCX with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/epub-to-docx" target="_blank">![Text "Banner EPUB to DOCX Converter"](epub-to-docx.png#center)</a>

## **EPUB to DOCX by two lines of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an EPUB file into various formats. For example, you can convert {{%EPUB%}} to {{%DOCX%}} in your C# application literally with two lines of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing EPUB file for reading
     using var stream = File.OpenRead(DataDir + "input.epub");

     // Invoke the ConvertEPUB method to convert EPUB to DOCX           
     Converter.ConvertEPUB(stream, new DocSaveOptions(), Path.Combine(OutputDir, "convert-by-two-lines.docx"));
{{< /highlight >}}

## **Convert EPUB to DOCX**

Using [Converter.ConvertMHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertmhtml/index) methods is the most common way to convert MHTML code into various formats. The following C# code snippet shows how to convert EPUB to DOCX using Aspose.HTML for .NET.

1. Open an existing EPUB file.
1. Create an instance of the [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) class.
1. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/25) method of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class to save EPUB as a DOCX file. You need to pass the EPUB file stream, DocSaveOptions, and output file path to the ConvertEPUB() method for EPUB to DOCX conversion.

In the example, we use the OpenRead() method of System.IO.FileStream class to open and read EPUB files from the file system at the specified path.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
      // Open an existing EPUB file for reading
      using var stream = File.OpenRead(DataDir + "input.epub");

      // Prepare a path to save the converted file 
      string savePath = Path.Combine(OutputDir, "input-output.docx");
    
      // Create an instance of DocSaveOptions
      var options = new DocSaveOptions();
    
      // Call the ConvertEPUB method to convert EPUB to DOCX
      Converter.ConvertEPUB(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**

Aspose.HTML allows converting EPUB to DOCX using default or custom save options. [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) usage enables you to tune the rendering process; you can specify the page size, margins, resolutions, CSS, etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [FontEmbeddingRule](https://apireference.aspose.com/html/net/aspose.html.rendering.doc/docrenderingoptions/properties/fontembeddingrule) | This property gets or sets the font embedding rule. Available values are Full and None. The default value is [None](https://apireference.aspose.com/html/net/aspose.html.rendering.doc/fontembeddingrule). |
| [Css](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/css) | Gets a [CssOptions](https://apireference.aspose.com/html/net/aspose.html.rendering/cssoptions) object which is used for configuration of CSS properties processing. |
| [DocumentFormat](https://apireference.aspose.com/html/net/aspose.html.rendering.doc/docrenderingoptions/properties/documentformat) | This property gets or sets the file format of the output document. The default value is [DOCX](https://apireference.aspose.com/html/net/aspose.html.rendering.doc/documentformat). |
| [PageSetup](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/horizontalresolution) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/verticalresolution) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |

{{% alert color="primary" %}}

To learn more about [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}

## **Convert EPUB to DOCX using DocSaveOptions**

With Aspose.HTML, you can convert EPUB to DOCX format programmatically with full control over a wide range of conversion parameters. To convert EPUB to DOCX with DocSaveOptions specifying, you should follow a few steps: 

1. Open an existing EPUB file.
1. Create a new [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) object and specify the required save options.
1. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/25) method to save EPUB as a DOCX file. You need to pass the EPUB file stream, DocSaveOptions, and output file path to the ConvertEPUB() method for EPUB to DOCX conversion.

The following example shows how to use [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) and create a DOCX file with custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Drawing;
...
    // Open an existing EPUB file for reading
    using var stream = File.OpenRead(DataDir + "input.epub");

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "input-options.docx");
    
    // Create an instance of DocSaveOptions. Set A5 as a page-size  
    var options = new DocSaveOptions();
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(8.3f), Length.FromInches(5.8f)));            
    
    // Call the ConvertEPUB method to convert EPUB to DOCX
    Converter.ConvertEPUB(stream, options, savePath); 
{{< /highlight >}}

In the example, we use the OpenRead() method of System.IO.FileStream class to open and read source files from the file system at the specified path. The [DocSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions/constructors/main) constructor initialize an instance of the DocSaveOptions class that is passed to ConvertEPUB() method. The ConvertEPUB() method takes the `stream`, `options`,  output file path `savePath` and performs the conversion operation. The DocSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting EPUB to DOCX format. In the example, we use the PageSetup property that specifies the page size of the DOCX document.

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

     // Open an existing EPUB file for reading
     using var stream = File.OpenRead(DataDir + "input.epub");
    
     // Prepare a path to save the converted file 
     string savePath = Path.Combine(OutputDir, "stream-provider.docx");
    
     // Convert EPUB to DOCX by using the MemoryStreamProvider class
     Converter.ConvertEPUB(stream, new DocSaveOptions(), streamProvider);
    
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
You can check the quality of EPUB to DOCX conversion with our online [**EPUB to DOCX Converter**](https://products.aspose.app/html/en/conversion/epub-to-docx). You can convert multiple EPUB files to DOCX and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful EPUB to DOCX Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}



