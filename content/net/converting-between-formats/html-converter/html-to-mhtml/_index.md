---
keywords: HTML to MHTML, convert HTML to MHTML, HTML to MHTML conversion, HTML
  to MHTML converter, save options
lastmod: 2021-09-03
url: /net/converting-between-formats/html-to-mhtml/
title: Convert HTML to MHTML | C#
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

In this article, you will find information on how to convert  {{%HTML%}} to {{%MHTML%}} and how to use [MHTMLSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/mhtmlsaveoptions).

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/html-to-mhtml" target="_blank">**HTML to MHTML Converter**</a> that converts HTML to MHTML with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/html-to-mhtml" target="_blank">![Text "Banner HTML to MHTML Converter"](html-to-mhtml.png#center)</a>

## **HTML to MHTML by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to MHTML in your C# application literally with a single line of code!

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

1. Load the HTML file using [HTMLDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument) class.
1. Create an instance of the [MHTMLSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/mhtmlsaveoptions) class.
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/5) method of [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class to save HTML as an MHTML file. You need to pass the HTMLDocument, MHTMLSaveOptions, and output file path to the ConvertHTML() method to convert HTML to MHTML.

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

Aspose.HTML allows converting HTML to MHTML using default or custom save options. [MHTMLSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/mhtmlsaveoptions) usage enables you to customize the rendering process; you can specify the [PageUrlRestriction](https://apireference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/properties/pageurlrestriction), [ResourceUrlRestriction](https://apireference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/properties/resourceurlrestriction), [MaxHandlingDepth](https://apireference.aspose.com/net/html/aspose.html.saving/resourcehandlingoptions/properties/maxhandlingdepth), etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [PageUrlRestriction](https://apireference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/properties/pageurlrestriction) | This property gets or sets restrictions applied to URLs of handled pages. The default value is [RootAndSubFolders](https://apireference.aspose.com/html/net/aspose.html.saving/urlrestriction). |
| [ResourceUrlRestriction](https://apireference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/properties/resourceurlrestriction) | Gets or sets restrictions applied to URLs of handled resources such as CSS, js, images, etc. The default is [SameHost](https://apireference.aspose.com/html/net/aspose.html.saving/urlrestriction). |
| [MaxHandlingDepth](https://apireference.aspose.com/net/html/aspose.html.saving/resourcehandlingoptions/properties/maxhandlingdepth) | Gets or sets the maximum depth of pages that will be handled. |

{{% alert color="primary" %}} 

To learn more about [MHTMLSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/mhtmlsaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}

## **Convert HTML to MHTML using MHTMLSaveOptions**

To convert HTML to MHTML with MHTMLSaveOptions specifying, you should follow a few steps: 

1. Load or prepare an HTML file. 
1. Create a new [MHTMLSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) object.
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/5) method of the  Converter class to save HTML as a MHTML file. You need to pass the HTMLDocument, MHTMLSaveOptions, and output file path to the ConvertHTML() method to convert HTML to MHTML.

The following example shows how to use [MHTMLSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/mhtmlsaveoptions) and create an MHTML file with custom save options:

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

The [MHTMLSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/mhtmlsaveoptions/constructors/main) constructor initializes an instance of the MHTMLSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation. The MHTMLSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to MHTML format. 

In the above example, we use the property `MaxHandlingDepth = 1` means that only pages directly referenced from the saved document will be handled.

{{% alert color="primary" %}} 

You can check the quality of HTML to MHTML conversion with our online [**HTML to MHTML Converter**](https://products.aspose.app/html/en/conversion/html-to-mhtmls). You can convert multiple HTML files to MHTML and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful HTML to MHTML Converter for free now!

{{% /alert %}}



