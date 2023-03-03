---
title: MHTML Converter - Java
linktitle: MHTML Converter 
keywords: mhtml converter, convert mhtml, mhtml to pdf, java example, java code
description: In this article, you will learn about supported MHTML conversions and consider Java example of how to convert MHTML to PDF.
weight: 40
type: docs
url: /java/mhtml-converter/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

{{%MHTML %}} is a web page archive format that allows embedding multiple resources, such as images, CSS styles, audio, and video files, into a single file, typically with a .mht file extension. MHTML format allows a web page to be saved and sent as a single file, preserving its appearance and interactivity. It can be opened by most web browsers. But sometimes you want to Convert MHTML to get the advantages of other formats.

Aspose.HTML for Java provides a wide range of MHTML conversions to popular formats, such as {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}.

{{% alert color="primary" %}}
This section provides information on the list of supported MHTML conversions and how to perform them using `convertMHTML()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class. It can be different scenarios, but any MHTML conversion can be made with a few required steps: 

1. Load an existing MHTML file. You can load MHTML from a file, stream, or URL.
2. Create a Save Options object. You may customize the rendering process to get the desired result.
3. Use one of the `convertMHTML()` methods and pass the required parameters to it.
{{% /alert %}}

Let's consider the following code snippet that shows how to convert MHTML to PDF using our Java library:

{{< highlight java >}}
    // Open an existing MHTML file for reading
    final  FileStream stream = File.openRead(StringExtensions.concat(getDataDir(),  "sample.mht"));
    try
    {;
    }
    finally { if (stream != null) ((IDisposable)stream).dispose(); }    

    // Сonvert MHTML to PDF
    com.aspose.html.converters.Converter.convertMHTML(stream, new com.aspose.html.saving.PdfSaveOptions(), Path.combine(getOutputDir(), "sample-output.pdf"));    
{{< /highlight >}}

**Popular MHTML Conversions**

- [Convert MHTML to PDF](/html/java/convert-mhtml-to-pdf/) - Learn how to convert MHTML to PDF using Java library. 
- [Convert MHTML to XPS](/html/java/convert-mhtml-to-xps/) - Consider various MHTML to XPS conversion scenarios in Java code.
- [Convert MHTML to JPG](/html/java/convert-mhtml-to-jpg/) - Learn how to convert MHTML to JPG with Aspose.HTML for Java, and you can easily use the Java code described here to convert MHTML to PNG, MHTML to BMP, MHTML to GIF, and MHTML to TIFF.
- [Convert MHTML to PNG](/html/java/convert-mhtml-to-png/) - Know how to convert MHTML to PNG using the `convertMHTML()` methods of the Converter class and how to apply `ImageSaveOptions`.

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}} 

{{% alert color="primary" %}} 
Aspose.HTML provides a free online [**MHTML Converter**](https://products.aspose.app/html/conversion/mhtml) that enables you to convert MHTML files to various popular formats. This tool can easily convert [MHTML to PDF,](https://products.aspose.app/html/conversion/mhtml-to-pdf) XPS, DOCX, JPG, PNG, BMP, TIFF, and GIF. The conversion process is simple and fast. You don't need any additional software. The best part is that it's completely free!
{{% /alert %}} 