---
title: EPUB Converter | C#
linktitle: EPUB Converter 
keywords: epub converter, convert epub, epub to pdf, convert epub to pdf, c# example, online converter, c# code
description: In this article, you will learn about supported EPUB conversions and consider C# example of how to convert EPUB to PDF.
weight: 30
type: docs
url: /net/converting-between-formats/epub-converter/
lastmod: 2022-07-28
---

{{%EPUB %}} is an e-book file format that provides a standard digital publication format for publishers and consumers. The format has been so common by now that many e-readers and software applications support it. For example, on Mac OS, the pre-installed Books software provides the support for opening such files. In addition, a variety of compatible software is available for smartphones, tablets and computers. EPUB file standards are maintained by the International Digital Publishing Forum (IDPF).

The main highlight of Aspose.HTML is the conversion feature. EPUB is an open XML-based format for digital books and publications that can be viewed and read on a variety of devices. EPUB conversions are often required to take advantage of other formats.  The [Aspose.Html.Converters](https://reference.aspose.com/html/net/aspose.html.converters/) namespace implements easy access to conversion methods. It provides a wide range of EPUB conversions to popular formats, such as {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}.

This section provides information on the list of supported EPUB conversions and how to perform them using  [Converter.ConvertEPUB](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertepub/) methods.  It can be different scenarios, but any EPUB conversion can be made with a few required steps: 

1. Load an existing EPUB file. 
2. Create a Save Options object. You may customize the rendering process to get the desired result.
3. Use one of the [ConvertEPUB()](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertepub/) methods and pass the required parameters to it.

Let's consider the following code snippet that shows how to convert EPUB to PDF:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...        

    // Prepare a path to a source EPUB file
    string sourcePath = Path.Combine(DataDir, "input.epub");           
    
    // Prepare a path to save the converted file 
    string outputPath = Path.Combine(OutputDir, "input-output.pdf");
    
    // Create an instance of PdfSaveOptions
    var options = new PdfSaveOptions();
    
    // Call the ConvertEPUB method to convert EPUB to PDF
    Converter.ConvertEPUB(sourcePath, options, outputPath);
{{< /highlight >}}

In the example, we specify the source path to EPUB file for the ConvertEPUB() method. The PdfSaveOptions() constructor creates an instance of [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/) with default options. The [ConvertEPUB()](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertepub/) method of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class takes the EPUB file source path, PdfSaveOptions, and output file path and performs EPUB to PDF conversion.

**Note:** You need to specify the path to the source and output file in *your local file system* (`sourcePath` and `outputPath`). 

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}} 


## **Online EPUB Converter**

You can check the Aspose.HTML API functionality and convert EPUB in real-time. Please load an EPUB file from the local file system, select the output format and run the example. In the example, the save options are set by default. You will immediately receive the result as a separate file.

{{< app/html/converter EPUB PDF GIF BMP DOCX "JPG|JPEG" PNG TIFF XPS >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;

    using var stream = File.OpenRead(DataDir + "input.epub");
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
    Converter.ConvertEPUB(stream, options, "output.{{output lower}}");   
{{< /app/html/converter>}}

{{% alert color="primary" %}} 
Aspose.HTML offers a free online [**EPUB Converter**](https://products.aspose.app/html/conversion/epub) for converting EPUB files to a variety of popular formats. You can easily convert  [EPUB to PDF](https://products.aspose.app/html/conversion/epub-to-pdf), EPUB  to XPS, EPUB  to DOCX, [EPUB to JPG](https://products.aspose.app/html/conversion/epub-to-pdf), EPUB to PNG, EPUB to BMP, EPUB to TIFF, or EPUB to GIF. Just select the file, choose the format to convert, and you're done. It's fast and completely free!

{{% /alert %}} 

