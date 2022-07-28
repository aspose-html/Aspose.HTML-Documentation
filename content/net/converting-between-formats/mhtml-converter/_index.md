---
title: MHTML Converter | C#
linktitle: MHTML Converter
keywords: mhtmlconverter, convert mhtml, convert mhtml to png, mhtml to png, c# example, online converter
description: In this article, you learn how to convert MHTML to other formats using Aspose.HTML API and consider C# example of MHTML to PNG conversion.
weight: 30
type: docs
lastmod: 2022-07-28
---

Files with {{%MHTML%}} extension represent a web page archive format that a number of different applications can create. The format is known as archive format because it saves the web HTML code and associated resources in a single file. These resources include anything linked to the webpage such as images, applets, animations, audio files and so on. MHTML files can be opened in a variety of applications such as Internet Explorer and Microsoft Word. The actual specifications of the format are as detailed by RFC 2557.

The main highlight of Aspose.HTML is a conversion feature. The [Aspose.Html.Converters](https://reference.aspose.com/html/net/aspose.html.converters) namespace implements easy access to conversion methods. This section provides information on the list of supported MHTML conversion scenarios and how to perform them using the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter) class that groups all low-level conversion operations in a single class to make them comfy and easy to use. For example, you can convert MHTML to PNG in your C# application literally with two lines of code!

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}} 

Please take a look over the following C# code snippet that shows the MHTML to PNG conversion using the [ConvertMHTML(`stream, options, outputPath`)](https://reference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/27) method.
{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...        

    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");
    
    // Invoke the ConvertMHTML() method to convert MHTML to PNG           
    Converter.ConvertMHTML(stream, new ImageSaveOptions(), Path.Combine(OutputDir, "convert-by-two-lines.png"));
{{< /highlight >}}

In the example, we use the OpenRead(`path`) method of System.IO.FileStream class to open and read an MHTML file from the file system at the specified path. You need to pass the MHTML file stream, ImageSaveOptions, and output file path to the [ConvertMHTML()](https://reference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/27) method for MHTML to PNG conversion.  **Note:** You need to specify the path to the output file in *your local file system* (`outputPath`). Also, for OpenRead(`path`), you need to provide the path to a source MHTML file in *your local file system*. 

## **Online MHTML Converter**
You can convert MHTML to other formats with Aspose.HTML for .NET API in real time. First, load an MHTML file from your local drive and then run the example. In this example, the save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/html/converter MHTML PNG BMP "JPG|JPEG" GIF TIFF DOCX PDF XPS >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;

    using var stream = File.OpenRead("sample.mht");
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
    Converter.ConvertMHTML(stream, options, "output.{{output lower}}");   
{{< /app/html/converter>}} 


{{% alert color="primary" %}} 
Aspose.HTML offers a free online [**MHTML Converter**](https://products.aspose.app/html/conversion) for converting MHTML files to a variety of popular formats.  You can easily convert  [MHTML to PDF](https://products.aspose.app/html/conversion/mhtml-to-pdf), MHTML to XPS, [MHTML to JPG](https://products.aspose.app/html/conversion/mhtml-to-jpg), MHTML to PNG, MHTML to BMP, MHTML to TIFF, and MHTML to GIF. Just select the file, choose the format to convert, and you're done. It's fast and completely free!
{{% /alert %}} 





