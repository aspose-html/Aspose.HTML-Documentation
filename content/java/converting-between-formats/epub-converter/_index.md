---
title: EPUB Converter - Java
linktitle: EPUB Converter 
keywords: epub converter, convert epub, epub to pdf, convert epub to pdf, java example, online converter, java code
description: In this article, you will learn about supported EPUB conversions and consider Java example of how to convert EPUB to PDF.
weight: 40
type: docs
url: /java/epub-converter/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

{{%EPUB %}} is an open-source e-book file format that is the standard digital publishing format. EPUB file standards are maintained by the International Digital Publishing Forum (IDPF). EPUB is supported by many e-readers and devices, including smartphones, tablets, and computers, making it a widely accepted format. An EPUB file is a collection of files, including HTML, CSS, and multimedia content, packaged together in a ZIP archive. 

EPUB conversions are often required to take advantage of other formats that can provide greater flexibility and make it easier to share, print, store, and use digital content. Aspose.HTML for Java provides a wide range of EPUB conversions to popular formats, such as {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}.

{{% alert color="primary" %}}
This section provides information on the list of supported EPUB conversions and how to perform them using `convertEPUB()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class. It can be different scenarios, but any EPUB conversion can be made with a few required steps: 

1. Load an existing EPUB file. 
2. Create a Save Options object. You may customize the rendering process to get the desired result.
3. Use one of the `convertEPUB()` methods and pass the required parameters to it.
{{% /alert %}}

Let's consider the following code snippet that shows how to convert EPUB to PDF using our Java library:

{{< highlight java >}}
    // Prepare a path to a source EPUB file
    String documentPath = Path.combine(getDataDir(), "input.epub");           
       
    // Prepare a path to save the converted file 
    String savePath = Path.combine(getOutputDir(), "output.pdf");

    // Create an instance of PdfSaveOptions
    PdfSaveOptions options = new PdfSaveOptions();

    // Call the convertEPUB() method
    com.aspose.html.converters.Converter.convertEPUB(documentPath, options, savePath);
{{< /highlight >}}

**Note:** You need to specify the path to the source and output file in *your local file system* (`sourcePath` and `outputPath`). 

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}} 

{{% alert color="primary" %}} 
Aspose.HTML provides a free online [**EPUB Converter**](https://products.aspose.app/html/conversion/epub) that enables you to convert EPUB files to various popular formats. This tool can easily convert [EPUB to PDF,](https://products.aspose.app/html/conversion/epub-to-pdf) XPS, DOCX, JPG, PNG, BMP, TIFF, and GIF. The conversion process is simple and fast. All you need to do is select the file and choose the desired output format. The best part is that it's completely free!
{{% /alert %}} 

