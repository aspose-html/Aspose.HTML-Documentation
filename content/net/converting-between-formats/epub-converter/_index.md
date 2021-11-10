---
title: EPUB Converter | C#
linktitle: EPUB Converter 
keywords: epub converter, convert epub, epub to pdf, epub to jpg, convert epub
  to pdf, convert epub to jpg, epub to xps, epub to png, epub to bmp, epub to
  gif, epub to tiff.
description: In this section, you find out how to convert EPUB to PDF, XPS, JPG,
  PNG, BMP, TIFF and GIF formats using Aspose.HTML API. You consider the
  supported EPUB conversions and C# examples to illustrate them.
weight: 40
type: docs
url: /net/converting-between-formats/epub-converter/
lastmod: 2021-11-10
---

{{%EPUB %}} is an e-book file format that provides a standard digital publication format for publishers and consumers. The format has been so common by now that many e-readers and software applications support it. For example, on Mac OS, the pre-installed Books software provides the support for opening such files. In addition, a variety of compatible software is available for smartphones, tablets and computers. EPUB file standards are maintained by the International Digital Publishing Forum (IDPF).

The main highlight of Aspose.HTML is the conversion feature. EPUB is an open XML-based format for digital books and publications that can be viewed and read on a variety of devices. EPUB conversions are often required to take advantage of other formats.  The [Aspose.Html.Converters](https://apireference.aspose.com/html/net/aspose.html.converters) namespace implements easy access to conversion methods. It provides a wide range of EPUB conversions to popular formats, such as {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}.

This section provides information on the list of supported EPUB conversions and how to perform them using the [Converter.ConvertEPUB](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertepub/index) methods.  It can be different scenarios, but any EPUB conversion can be made with a few required steps: 

1. Load an existing EPUB file. In the example, we pass the EPUB file source path to ConvertEPUB() method.
2. Create an instance of [PdfSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions).
3. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/45) method of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class to save EPUB as a PDF file. To convert an EPUB to a PDF, you need to pass the EPUB file source path, PdfSaveOptions, and output file path to the ConvertEPUB() method.

Let's consider the following code snippet that shows how to convert EPUB to PDF:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
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

**Note:** You need to specify the path to the source and output file in *your local file system* (`sourcePath` and `outputPath`). 

 **Popular EPUB Conversions**

<div class="row">				
		<ul>
			<li><a href="/html/net/converting-between-formats/epub-to-pdf/">Convert EPUB to PDF</a></li>
			<li><a href="/html/net/converting-between-formats/epub-to-docx/">Convert EPUB to DOCX</a></li>
			<li><a href="/html/net/converting-between-formats/epub-to-xps/">Convert EPUB to XPS</a></li>					
		</ul>			
		<ul>
			<li><a href="/html/net/converting-between-formats/epub-to-jpg/">Convert EPUB to JPG</a></li>
			<li><a href="/html/net/converting-between-formats/epub-to-png/">Convert EPUB to PNG</a></li>
			<li><a href="/html/net/converting-between-formats/epub-to-bmp/">Convert EPUB to BMP</a></li>			
		</ul>
		<ul>
			<li><a href="/html/net/converting-between-formats/epub-to-gif/">Convert EPUB to GIF</a></li>
			<li><a href="/html/net/converting-between-formats/epub-to-tiff/">Convert EPUB to TIFF</a></li>						
		</ul>		
</div>

{{% alert color="primary" %}} 

Aspose.HTML offers a free online [**EPUB Converter**](https://products.aspose.app/html/en/conversion/epub) for converting EPUB files to a variety of popular formats. You can easily convert  [EPUB to PDF](https://products.aspose.app/html/en/conversion/epub-to-pdf), EPUB  to XPS, EPUB  to DOCX, [EPUB to JPG](https://products.aspose.app/html/en/conversion/epub-to-pdf), EPUB to PNG, EPUB to BMP, EPUB to TIFF, or EPUB to GIF. Just select the file, choose the format to convert, and you're done. It's fast and completely free!

{{% /alert %}} 

