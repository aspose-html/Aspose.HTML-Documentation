---
keywords: HTML to XPS, convert HTML to XPS, HTML to XPS conversion, HTML to XPS
  converter, save options, stream provider
lastmod: 2021-09-03
url: /net/converting-between-formats/html-to-xps/
title: Convert HTML to XPS | C#
linktitle: Convert HTML to XPS
description: This article provides information on how to convert HTML to XPS
  using Aspose.HTML API. You will learn about the supported HTML to XPS
  conversion scenarios and consider examples to illustrate them.
weight: 70
type: docs
aliases:
  - /net/converting-between-formats/html-to-xps-conversion/
  - /net/html-to-xps-conversion/
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

XPS is a document storage and viewing format developed by Microsoft.  It has a set of advantages that support security features, such as digital signatures to provide greater document security and more. HTML to XPS conversion is often required to establish limited access to document editing or copying. XPS file format provides access rights management and gives high-quality printable documents. XPS files can be used to share documents, and you can be sure that what you see on the page is the same as what other people see when using the XPS Viewer. 

Using [Converter.ConvertHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/converthtml/index) methods is the most common way to convert HTML code into various formats.  With Aspose.HTML, you can convert HTML to XPS format programmatically with full control over a wide range of conversion parameters. 

In this article, you find information on how to convert  HTML to {{%XPS%}} using ConvertHTML() methods of the Converter class, and how to apply [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/html-to-xps" target="_blank">**HTML to XPS Converter**</a> that converts HTML to XPS with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}
<a href="https://products.aspose.app/html/en/conversion/html-to-xps" target="_blank">![Text "Banner HTML to XPS Converter"](html-to-xps.png#center)</a>

## **HTML to XPS by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to XPS in your C# application literally with a single line of code!

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

1. Load an HTML file using the [HTMLDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument) class.
1. Create a new [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) object. 
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/9) method of the Converter class to save HTML as a XPS file. You need to pass the HTMLDocument, XpsSaveOptions, and output file path to the ConvertHTML() method to convert HTML to XPS.

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
Aspose.HTML allows converting HTML to XPS using default or custom save options. [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) usage enables you to customize the rendering process. You can specify the page size, margins, Css, etc. 

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

## **Convert HTML to XPS using XpsSaveOptions**

To convert HTML to XPS with XpsSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the  [HTMLDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument) class. 
1. Create a new [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) object.
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/9) method of the  Converter class to save HTML as a PDF file. You need to pass the HTMLDocument, XpsSaveOptions, and output file path to the ConvertHTML() method to convert HTML to XPS.

The following example shows how to use [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) and create an XPS file with custom page-size and background color:

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
        BackgroundColor = Color.AntiqueWhite
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(4.9f), Length.FromInches(3.5f)), new Margin(30, 20, 10, 10));
    
    // Convert HTML to XPS
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The [XpsSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/constructors/main) constructor initializes an instance of the XpsSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation. The XpsSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to XPS format. 

In the above example, we use:

 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - PageSetup property that specifies the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup) and [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin).

   

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

You can check the quality of HTML to XPS conversion with our online [**HTML to XPS Converter**](https://products.aspose.app/html/en/conversion/html-to-xps). You can convert multiple HTML files to XPS and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful HTML to XPS Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}





