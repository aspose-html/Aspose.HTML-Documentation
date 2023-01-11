---
keywords: HTML to XPS, convert HTML to XPS, HTML to XPS conversion, HTML to XPS converter, save options, stream provider, online converter, c# code
lastmod: 2022-07-28
url: /net/converting-between-formats/html-to-xps/
title: Convert HTML to XPS | C# Examples
linktitle: Convert HTML to XPS
description: You will learn about the supported HTML to XPS conversion scenarios using Aspose.HTML API and consider C# examples to illustrate them.
weight: 70
type: docs
aliases:
  - /net/converting-between-formats/html-to-xps-conversion/
  - /net/html-to-xps-conversion/
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

XPS is a document storage and viewing format developed by Microsoft.  It has a set of advantages that support security features, such as digital signatures to provide greater document security and more. HTML to XPS conversion is often required to establish limited access to document editing or copying. XPS file format provides access rights management and gives high-quality printable documents. XPS files can be used to share documents, and you can be sure that what you see on the page is the same as what other people see when using the XPS Viewer. 

Using [Converter.ConvertHTML](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) methods is the most common way to convert HTML code into various formats.  With Aspose.HTML, you can convert HTML to XPS format programmatically with full control over a wide range of conversion parameters. In this article, you find information on how to convert  HTML to {{%XPS%}} using ConvertHTML() methods of the Converter class, and how to apply [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) and [ICreateStreamProvider](https://reference.aspose.com/html/net/aspose.html.io/icreatestreamprovider/) parameters.


## **Online HTML Converter**

You can check the Aspose.HTML API functionality and convert HTML in real-time. Please load HTML from the local file system, select the output format and run the example. In the example, the save options are set by default. You will immediately receive the result as a separate file.

{{< app/html/converter HTML XPS GIF BMP "JPG|JPEG" TIFF PNG  PDF DOCX MD MHTML >}}
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

If you want to convert HTML to XPS programmatically, please see the following C# code examples.

## **HTML to XPS by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to XPS in your C# application literally with a single line of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Invoke the ConvertHTML method to convert the HTML code to XPS           
    Converter.ConvertHTML(@"<h1>Convert HTML to XPS!</h1>", ".", new XpsSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.xps"));
{{< /highlight >}}

## **Convert HTML to XPS**
Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class.
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) object. 
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of the Converter class to save HTML as a XPS file. You need to pass the HTMLDocument, XpsSaveOptions, and output file path to the ConvertHTML() method to convert HTML to XPS.

Please take a look over the following C# code snippet which shows the process of converting HTML to XPS using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "canvas.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "canvas-output.xps");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize XpsSaveOptions 
    var options = new XpsSaveOptions();
    
    // Convert HTML to XPS
    Converter.ConvertHTML(document, options, savePath);    
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting HTML to XPS using default or custom save options. [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) usage enables you to customize the rendering process. You can specify the page size, margins, Css, etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [PageSetup](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) | This property gets a page setup object and uses it for configuration output page-set. |
| [Css](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/css/) | Gets a [CssOptions](https://reference.aspose.com/html/net/aspose.html.rendering/cssoptions/) object which is used for configuration of CSS properties processing. |
| [BackgroundColor](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/backgroundcolor/) | This property sets the color that will fill the background of every page. By default, this property is Transparent. |
| [HorizontalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/horizontalresolution/) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/verticalresolution/) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |


{{% alert color="primary" %}}

To learn more about [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}

## **Convert HTML to XPS using XpsSaveOptions**

To convert HTML to XPS with XpsSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the  [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class. 
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) object.
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of the  Converter class to save HTML as a PDF file. You need to pass the HTMLDocument, XpsSaveOptions, and output file path to the ConvertHTML() method to convert HTML to XPS.

The following example shows how to use [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) and create an XPS file with custom page-size and background color:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System.Drawing;
using Aspose.Html.Drawing;
...
    string documentPath = Path.Combine(OutputDir, "save-options.html");
    string savePath = Path.Combine(OutputDir, "save-options-output.xps");

    // Prepare HTML code and save it to a file
    var code = "<h1>  XpsSaveOptions Class</h1>\r\n" +
               "<p>Using XpsSaveOptions Class, you can programmatically apply a wide range of conversion parameters such as BackgroundColor, PageSetup, etc.</p>\r\n";
    
    File.WriteAllText(documentPath, code);
    
    // Initialize an HTML Document from the html file
    using var document = new HTMLDocument(documentPath);
    
    // Set up the page-size, margins and change the background color to AntiqueWhite
    var options = new XpsSaveOptions()
    {
        BackgroundColor = System.Drawing.Color.AntiqueWhite
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(4.9f), Length.FromInches(3.5f)), new Margin(30, 20, 10, 10));
    
    // Convert HTML to XPS
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The [XpsSaveOptions()](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/xpssaveoptions/) constructor initializes an instance of the XpsSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation. The XpsSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to XPS format. 

In the above example, we use:

 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - PageSetup property that specifies the [page size](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) and [margins](https://reference.aspose.com/html/net/aspose.html.drawing/page/margin/).

   

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
            // This method is called when the only one output stream is required, for instance for XPS, PDF or TIFF formats.
            MemoryStream result = new MemoryStream();
            Streams.Add(result);
            return result;
        }
    
        public Stream GetStream(string name, string extension, int page)
        {
            // This method is called when the creation of multiple output streams are required. For instance, during the rendering HTML to list of the image files (JPG, PNG, etc.)
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
    using var document = new HTMLDocument(@"<h1>Convert HTML to XPS File Format!</h1>", ".");
    
    // Convert HTML to PDF using the MemoryStreamProvider
    Converter.ConvertHTML(document, new XpsSaveOptions(), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.xps")))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/html-to-xps" target="_blank">**HTML to XPS Converter**</a> that converts HTML to XPS with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}
<a href="https://products.aspose.app/html/en/conversion/html-to-xps" target="_blank">![Text "Banner HTML to XPS Converter"](html-to-xps.png#center)</a>





