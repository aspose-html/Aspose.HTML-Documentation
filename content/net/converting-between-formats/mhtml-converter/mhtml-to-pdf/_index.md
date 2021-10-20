---
keywords: mhtml to pdf, convert mhtml to pdf, mhtml to pdf conversion, mhtml to
  pdf converter, save options, stream provider
lastmod: 2021-09-03
url: /net/converting-between-formats/mhtml-to-pdf/
title: Convert MHTML to PDF | C#
linktitle: Convert MHTML to PDF
description: This article provides information on how to convert MHTML to PDF
  using the Aspose.HTML API. You will learn about the supported MHTML to PDF
  conversion scenarios and consider examples to illustrate them.
weight: 10
type: docs
aliases:
  - /net/converting-between-formats/mhtml-to-pdf-conversion/
  - /net/mhtml-to-pdf-conversion/
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

MHTML to PDF conversion is often required to take advantage of PDF format for specific tasks. PDF comes with many benefits that other files don't have. For example, many programs and apps support PDF documents; PDF files are optimized for printing, and they are ideal for creating physical copies of your documents; you can configure the security settings for  PDF files - disable printing, editing, using an electronic signature, etc.

In this article, you find information on how to convert {{%MHTML%}} to {{%PDF%}} using ConvertHTML() methods of the Converter class and how to apply [PdfSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/mhtml-to-pdf" target="_blank">**MHTML to PDF Converter**</a> that converts MHTML to PDF file with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/mhtml-to-pdf" target="_blank">![Text "Banner MHTML to PDF Converter"](mhtml-to-pdf.png#center)</a>

## **MHTML to PDF by two lines of code**

The static methods of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an MHTML code into various formats. For example, you can convert {{%MHTML%}} to {{%PDF%}} in your C# application literally with two lines of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing MHTML file for reading
     using var stream = File.OpenRead(DataDir + "sample.mht");
     
     // Invoke the ConvertMHTML method to convert MHTML to PDF           
     Converter.ConvertMHTML(stream, new PdfSaveOptions(), Path.Combine(OutputDir, "convert-by-two-lines.pdf")); 
{{< /highlight >}}

## **Convert MHTML to PDF**

Using [Converter.ConvertMHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertmhtml/index) methods is the most common way to convert MHTML code into various formats.  With Aspose.HTML, you can convert MHTML to PDF format programmatically with full control over a wide range of conversion parameters. 

The following C# code snippet shows how to convert MHTML to PDF using Aspose.HTML for .NET.

1. Open an existing MHTML file.
1. Create an instance of the [PdfSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions) class.
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/29) method of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class to save MHTML as a PDF file. You need to pass the MHTML file stream, PdfSaveOptions, and output file path to the ConvertMHTML() method method for MHTML to PDF conversion.

In the example, we use the OpenRead() method of System.IO.FileStream class to open and read files from the file system at the specified path.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Open an existing MHTML file for reading
     using var stream = File.OpenRead(DataDir + "sample.mht");

     // Prepare a path to save the converted file 
     string savePath = Path.Combine(OutputDir, "sample-output.pdf");
    
     // Create an instance of PdfSaveOptions
     var options = new PdfSaveOptions();
    
     // Call the ConvertMHTML method to convert MHTML to PDF
     Converter.ConvertMHTML(stream, options, savePath); 
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**

Aspose.HTML allows converting MHTML to PDF using default or custom save options. [PdfSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions) usage enables you to customize the rendering process; you can specify the [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/html/net/aspose.html.drawing/page/properties/margin), [file permissions](https://apireference.aspose.com/html/net/aspose.html.rendering.pdf.encryption/pdfencryptioninfo), [CSS media-type](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype), etc.  

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [JpegQuality](https://apireference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/properties/jpegquality) | Specifies the quality of JPEG compression for images. The default value is 95. |
| [Css](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/css) | Gets a [CssOptions](https://apireference.aspose.com/html/net/aspose.html.rendering/cssoptions) object which is used for configuration of CSS properties processing. |
| [DocumentInfo](https://apireference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/properties/documentinfo) | This property contains information about the output PDF document. |
| [BackgroundColor](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/backgroundcolor) | This property sets the color that will fill the background of every page. By default, this property is Transparent. |
| [PageSetup](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/horizontalresolution) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/verticalresolution) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [Encryption](https://apireference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/properties/encryption) | This property gets or sets encryption details. If it is not set, then no encryption will be performed. |

{{% alert color="primary" %}}
To learn more about [PdfSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}



## **Convert MHTML to PDF using PdfSaveOptions**

To convert MHTML to PDF with PdfSaveOptions specifying, you should follow a few steps: 

1. Open an existing MHTML file.
1. Create a new [PdfSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions) object and specify save options.
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/29) method to save MHTML as a PDF file. You need to pass the MHTML file stream, PdfSaveOptions, and output file path to the ConvertMHTML() method for MHTML to PDF conversion.

The following example shows how to use [PdfSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions) and create a PDF file with custom save options:

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

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "sample-options.pdf");
    
    // Create an instance of PdfSaveOptions. Set up the page-size and change the background color to AliceBlue 
    var options = new PdfSaveOptions()
    {
        PageSetup =
            {
                AnyPage = new Page()
                {
                    Size = new Aspose.Html.Drawing.Size(Length.FromPixels(3000), Length.FromPixels(1000))
                }
            },
        BackgroundColor = Color.AliceBlue
    };
    
    // Call the ConvertMHTML method to convert MHTML to PDF
    Converter.ConvertMHTML(stream, options, savePath); 
{{< /highlight >}}

In the example, we use the OpenRead() method of System.IO.FileStream class to open and read source files from the file system at the specified path. The [PdfSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/constructors/main) constructor initializes an instance of the PdfSaveOptions class that is passed to ConvertMHTML() method. The ConvertMHTML() method takes the `stream`, `options`,  output file path `savePath` and performs the conversion operation. The PdfSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting MHTML to PDF format. 

In the above example, we use:
 - BackgroundColor property that specifies the color that the background will be filled in. The default BackgroundColor is Transparent;
 - PageSetup property that specifies the [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup) in pixels.

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
     string savePath = Path.Combine(OutputDir, "stream-provider.pdf");
    
     // Convert MHTML to PDF by using the MemoryStreamProvider class
     Converter.ConvertMHTML(stream, new PdfSaveOptions(), streamProvider);
    
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
You can check the quality of MHTML to PDF conversion with our online [**MHTML to PDF Converter**](https://products.aspose.app/html/en/conversion/mhtml-to-pdf). You can convert multiple MHTML files to PDF and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful MHTML to PDF Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}



