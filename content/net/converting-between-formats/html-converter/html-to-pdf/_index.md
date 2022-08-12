---
keywords: html to pdf, convert html to pdf c#, online html converter, convert html to pdf, html to pdf conversion, html to pdf
  converter, save options, stream provider, c# code
lastmod: 2022-07-28
url: /net/converting-between-formats/html-to-pdf/
title: Convert HTML to PDF | C# Examples and Online Converter
linktitle: Convert HTML to PDF
description: Convert HTML to PDF in C# using Aspose.HTML API. Consider various HTML to PDF conversion scenarios in C# examples. Try online HTML Converter.
weight: 10
type: docs
aliases:
  - /net/converting-between-formats/html-to-pdf-conversion/
  - /net/html-to-pdf-conversion/
  - /display/htmlnet/HTML+to+PDF+Conversion
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

In this guide, you find information on how to convert an HTML document into a Portable Document Format ({{%PDF%}}) file format. HTML to PDF conversion is often required to establish limited access to documents editing or copying; to produce official documentation or send some information, for example, by email. In this article, you find information on how to convert  HTML to PDF using [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/) methods of the Converter class, and how to apply [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/) and [ICreateStreamProvider](https://reference.aspose.com/html/net/aspose.html.io/icreatestreamprovider/) parameters.


## **Online HTML Converter**

You can convert HTML to PDF with Aspose.HTML for .NET API in real time. First, load an HTML file from your local drive and then run the example. In this example, the save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/html/converter HTML PDF "JPG|JPEG" TIFF PNG GIF BMP XPS DOCX MD MHTML >}}
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
{{#if_output 'MD'}}
    var options = new MarkdownSaveOptions();
{{/if_output}}
{{#if_output 'MHTML'}}
    var options = new MHTMLSaveOptions();
{{/if_output}}
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output param2 camel}});
{{/if_output}}
    Converter.ConvertHTML(document, options, "output.{{output lower}}");   
{{< /app/html/converter>}}

If you want to convert HTML to PDF programmatically, please see the following C# code examples.

## **HTML to PDF by a single line of code**

HTML to PDF conversion is very popular. To perform this feature,  Aspose.HTML for .NET offer the static methods of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class  as an understandable and straightforward way to convert HTML code into a PDF file literally with a single line of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Invoke the ConvertHTML method to convert the HTML code to PDF           
     Converter.ConvertHTML(@"<h1>Convert HTML to PDF!</h1>", ".", new PdfSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.pdf"));
{{< /highlight >}}

## **Convert HTML to PDF in C#**
Any conversion you want to perform involves loading an HTML document and saving it in PDF format.  You can load HTML from a file, HTML code, stream, or URL (see the [Creating an HTML Document](/html/net/working-with-documents/creating-a-document/) article). It can be different scenarios but it can be made with a few required steps: 

1. Load an HTML file using one of HTMLDocument() constructors of the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class. In the example we use [HTMLDocument(string)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/) constructor that initializes an HTML document from a file. 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/) object. 
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of the Converter class to save HTML as a PDF file. You need to pass the HTMLDocument, PdfSaveOptions, and output file path to the ConvertHTML() method to convert HTML to PDF.

Please take a look over the following C# code snippet that shows the HTML to PDF conversion process for the [spring.html](/html/net/converting-between-formats/html-to-pdf/spring.html) file.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "spring.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "spring-output.pdf");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize PdfSaveOptions 
    var options = new PdfSaveOptions();
    
    // Convert HTML to PDF
    Converter.ConvertHTML(document, options, savePath);    
{{< /highlight >}}

The figure illustrates the spring-output.pdf file.

![Text "spring-output.pdf image"](../spring-output.png#center)

## **Save Options**
Aspose.HTML allows converting HTML to PDF using default or custom save options. [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/) usage enables you to customize the rendering process; you can specify the page size, margins, file permissions, Css, etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [JpegQuality](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/jpegquality/) | Specifies the quality of JPEG compression for images. The default value is 95. |
| [Css](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/css/) | Gets a [CssOptions](https://reference.aspose.com/html/net/aspose.html.rendering/cssoptions/) object which is used for configuration of CSS properties processing. |
| [DocumentInfo](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/documentinfo/) | This property contains information about the output PDF document. |
| [BackgroundColor](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/backgroundcolor/) | This property sets the color that will fill the background of every page. By default, this property is Transparent. |
| [PageSetup](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/horizontalresolution/) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/verticalresolution/) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [Encryption](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/encryption/) | This property gets or sets encryption details. If it is not set, then no encryption will be performed. |

{{% alert color="primary" %}}

To learn more about [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}

## **Convert HTML to PDF in C# using PdfSaveOptions**

With Aspose.HTML, you can convert files programmatically with full control over a wide range of conversion parameters. To convert HTML to PDF with PdfSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the  [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class ([drawing.html](/html/net/converting-between-formats/html-to-pdf/drawing.html)). 
1. Create a new [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/) object and specify the required properties.
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of the  Converter class to save HTML as a PDF file. You need to pass the HTMLDocument, PdfSaveOptions, and output file path to the ConvertHTML() method to convert HTML to PDF.

The following example shows how to use [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/) and create a PDF file with custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System.Drawing;
using Aspose.Html.Drawing;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "drawing.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "drawing-options.pdf");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize PdfSaveOptions. Set up the page-size 600x300 pixels, margins, resolutions and change the background color to AliceBlue 
    var options = new PdfSaveOptions()
    {                
        HorizontalResolution = 200,
        VerticalResolution = 200,
        JpegQuality = 100,
        BackgroundColor = Color.AliceBlue                
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(600, 300), new Margin(20, 10, 10, 10));     
    
    // Convert HTML to PDF
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The [PdfSaveOptions()](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/pdfsaveoptions/) constructor initializes an instance of the PdfSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation. The PdfSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to PDF format. 

In the above example, we use:
 - JpegQuality property that enables you to specify the quality of JPEG compression for images;  
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - PageSetup property that specifies the [page size](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) and [margins](https://reference.aspose.com/html/net/aspose.html.drawing/page/margin/).

The figure illustrates the drawing-options.pdf file.

![Text "drawing-options.pdf image"](drawing-options.png#center)

{{% alert color="primary" %}} 

Check the quality of HTML to PDF conversion with our online [**HTML to PDF Converter**](https://products.aspose.app/html/conversion/html-to-pdf). Upload, convert your files and get the result in a few seconds. Try our forceful HTML to PDF Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [ICreateStreamProvider](https://reference.aspose.com/html/net/aspose.html.io/icreatestreamprovider/) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

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

    // Initialize an HTML document
    using var document = new HTMLDocument(@"<h1>Convert HTML to PDF File Format!</h1>", ".");
    
    // Convert HTML to PDF using the MemoryStreamProvider
    Converter.ConvertHTML(document, new PdfSaveOptions(), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.pdf")))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/html-to-pdf" target="_blank">**HTML to PDF Converter**</a> that converts HTML to PDF with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-pdf" target="_blank">![Text "Banner HTML to PDF Converter"](html-to-pdf.png#center)</a>





