---
keywords: HTML to MHTML, convert HTML to MHTML, HTML to MHTML conversion, HTML to MHTML converter, save options, online converter, c# code
lastmod: 2022-07-28
url: /net/converting-between-formats/html-to-mhtml/
title: Convert HTML to MHTML | C# code and Online Converter
linktitle: Convert HTML to MHTML
description: This article provides information on how to convert HTML to MHTML
  using Aspose.HTML API. You will learn about the supported HTML to MHTML
  conversion scenarios and consider examples to illustrate them.
weight: 90
type: docs
aliases:
  - /net/html-to-mhtml-conversion/
  - /net/converting-between-formats/html-to-mhtml-conversion/
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

MHTML combines normal HTML with external resources like images, animations, audio, etc., into one file with the .mht file extension.  MHTML uses the MIME email protocol to combine items into a single web page archive file. With MHTML, the archival of online web pages becomes much easier and less cluttered.

In this article, you will find information on how to convert  {{%HTML%}} to {{%MHTML%}} and how to use [MHTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/mhtmlsaveoptions/).

## **Online HTML Converter**

You can convert HTML to MHTML with Aspose.HTML for .NET API in real time. First, load an HTML file from your local drive and then run the example. In this example, the save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/html/converter HTML MHTML BMP "JPG|JPEG" TIFF PNG GIF PDF XPS DOCX MD >}}
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

If you want to convert HTML to MHTML programmatically, please see the following C# code examples.

## **HTML to MHTML by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to MHTML in your C# application literally with a single line of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Invoke the ConvertHTML method to convert the HTML code to MHTML           
    Converter.ConvertHTML(@"<h1>Hellow, Word!</h1>", ".", new MHTMLSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.mht"));
{{< /highlight >}}

## **Convert HTML to MHTML**

Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving. The next example explains how to convert HTML to MHTML by line by line:

1. Load the HTML file using [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class.
1. Create an instance of the [MHTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/mhtmlsaveoptions/) class.
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class to save HTML as an MHTML file. You need to pass the HTMLDocument, MHTMLSaveOptions, and output file path to the ConvertHTML() method to convert HTML to MHTML.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "drawing.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "drawing-output.mht");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize MHTMLSaveOptions 
    var options = new MHTMLSaveOptions();
    
    // Convert HTML to MHTML
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**

Aspose.HTML allows converting HTML to MHTML using default or custom save options. [MHTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/mhtmlsaveoptions/) usage enables you to customize the rendering process; you can specify the PageUrlRestriction, ResourceUrlRestriction, MaxHandlingDepth, etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [PageUrlRestriction](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/pageurlrestriction/) | This property gets or sets restrictions applied to URLs of handled pages. The default value is [RootAndSubFolders](https://reference.aspose.com/html/net/aspose.html.saving/urlrestriction/). |
| [ResourceUrlRestriction](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/resourceurlrestriction/) | Gets or sets restrictions applied to URLs of handled resources such as CSS, js, images, etc. The default is [SameHost](https://reference.aspose.com/html/net/aspose.html.saving/urlrestriction/). |
| [MaxHandlingDepth](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/maxhandlingdepth/) | Gets or sets the maximum depth of pages that will be handled. |

{{% alert color="primary" %}} 

To learn more about [MHTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/mhtmlsaveoptions/), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}

## **Convert HTML to MHTML using MHTMLSaveOptions**

To convert HTML to MHTML with MHTMLSaveOptions specifying, you should follow a few steps: 

1. Load or prepare an HTML file. 
1. Create a new [MHTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) object.
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of the  Converter class to save HTML as a MHTML file. You need to pass the HTMLDocument, MHTMLSaveOptions, and output file path to the ConvertHTML() method to convert HTML to MHTML.

The following example shows how to use [MHTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/mhtmlsaveoptions/) and create an MHTML file with custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Prepare HTML code with a link to another file and save it to the file as 'document.html'
     var code = "<span>Hello, World!!</span> " +
                "<a href='document2.html'>click</a>";
     File.WriteAllText("document.html", code);

     // Prepare HTML code and save it to the file as 'document2.html'
     code = @"<span>Hello, World!!</span>";
     File.WriteAllText("document2.html", code);
     
     string savePath = Path.Combine(OutputDir, "output-options.mht");
    
     // Change the value of the resource linking depth to 1 in order to convert document with directly linked resources
     var options = new MHTMLSaveOptions()
     {
         ResourceHandlingOptions =
         {
             MaxHandlingDepth = 1
         }
     };
    
     // Convert HTML to MHTML
     Converter.ConvertHTML("document.html", options, savePath);
{{< /highlight >}}

The [MHTMLSaveOptions()](https://reference.aspose.com/html/net/aspose.html.saving/mhtmlsaveoptions/mhtmlsaveoptions/) constructor initializes an instance of the MHTMLSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation. The MHTMLSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to MHTML format. 

In the above example, we use the property `MaxHandlingDepth = 1` means that only pages directly referenced from the saved document will be handled.

{{% alert color="primary" %}}

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/html-to-mhtml" target="_blank">**HTML to MHTML Converter**</a> that converts HTML to MHTML with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-mhtml" target="_blank">![Text "Banner HTML to MHTML Converter"](html-to-mhtml.png#center)</a>



