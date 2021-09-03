---
keywords: HTML to DOCX, convert HTML to DOCX, HTML to DOCX conversion, HTML to
  DOCX converter, save options
lastmod: 2021-09-03
url: /net/converting-between-formats/html-to-docx/
title: Convert HTML to DOCX
description: This article provides information on how to convert HTML to DOCX
  using the Aspose.HTML API. You will learn about the supported HTML to DOCX
  conversion scenarios and consider examples to illustrate them.
weight: 80
type: docs
aliases:
  - /net/converting-between-formats/html-to-docx-conversion/
  - /net/html-to-docx-conversion/
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

A DOCX file is a Microsoft Word document that typically contains the text but can contain a wide range of data, including tables, raster and vector graphics, video, sounds and diagrams. The DOCX file is highly editable, easy to use and manageable in size. This format is popular because of the variety of options it offers users to write any type of documents. This file format is one of the most widely used and is available through numerous programs.


Using [Converter.ConvertHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/converthtml/index) methods is the most common way to convert HTML code into various formats.  With Aspose.HTML, you can convert HTML to DOCX format programmatically with full control over a wide range of conversion parameters. 

In this article, you find information on how to convert  HTML to {{%DOCX %}} using ConvertHTML() methods of the Converter class, and how to apply [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/html-to-docx" target="_blank">**HTML to DOCX Converter**</a> that converts HTML to DOCX with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/html-to-docx" target="_blank">![Text "Banner HTML to DOCX Converter"](html-to-docx.png#center)</a>


## **HTML to DOCX by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to DOCX in your C# application literally with a single line of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Invoke the ConvertHTML method to convert HTML code to DOCX           
     Converter.ConvertHTML(@"<h1>Convert HTML to DOCX!</h1>", ".", new DocSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.docx"));
{{< /highlight >}}

## **Convert HTML to DOCX**
Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument) class.
1. Create a new [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) object. 
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/1) method of the Converter class to save HTML as a DOCX file. You need to pass the HTMLDocument, DocSaveOptions, and output file path to the ConvertHTML() method to convert HTML to DOCX.

Please take a look over the following C# code snippet which shows the process of converting HTML to DOCX using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "canvas.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "canvas-output.docx");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize DocSaveOptions 
    var options = new DocSaveOptions();
    
    // Convert HTML to DOCX
    Converter.ConvertHTML(document, options, savePath);    
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}


## **Save Options**
Aspose.HTML allows converting HTML to DOCX using default or custom save options. [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) usage enables you to customize the rendering process; you can specify the page size, margins, resolutions, CSS, etc. 

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

## **Convert HTML to DOCX using DocSaveOptions**

To convert HTML to DOCX with DocSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the  [HTMLDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument) class. 
1. Create a new [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) object.
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/1) method of the  Converter class to save HTML as a DOCX file. You need to pass the HTMLDocument, DocSaveOptions, and output file path to the ConvertHTML() method to convert HTML to DOCX.

The following example shows how to use DocSaveOptions and create a DOCX file with custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Drawing;
...
    string documentPath = Path.Combine(OutputDir, "save-options.html");
    string savePath = Path.Combine(OutputDir, "save-options-output.docx");

    // Prepare HTML code and save it to a file
    var code = "<h1>DocSaveOptions Class</h1>\r\n" +
               "<p>Using DocSaveOptions Class, you can programmatically apply a wide range of conversion parameters.</p>\r\n";
    
    File.WriteAllText(documentPath, code);
    
    // Initialize an HTML Document from the html file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize DocSaveOptions. Set A5 as a page-size 
    var options = new DocSaveOptions();            
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(8.3f), Length.FromInches(5.8f)));
    
    // Convert HTML to DOCX
    Converter.ConvertHTML(document, options, savePath);   
{{< /highlight >}}

The [DocSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions/constructors/main) constructor initialize an instance of the DocSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation. The DocSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to DOCX format. In the above example, we use the PageSetup property that specifies the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup) of the DOCX document.


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

    // Initialize an HTML document
    using var document = new HTMLDocument(@"<h1>Convert HTML to DOCX File Format!</h1>", ".");
    
    // Convert HTML to DOCX using the MemoryStreamProvider
    Converter.ConvertHTML(document, new DocSaveOptions(), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.docx")))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

{{% alert color="primary" %}} 

You can check the quality of HTML to DOCX conversion with our online [**HTML to DOCX Converter**](https://products.aspose.app/html/en/conversion/html-to-docx). You can convert multiple HTML files to DOCX and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful HTML to DOCX Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}





