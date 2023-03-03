---
title: Markdown Converter - Java
linktitle: Markdown Converter 
keywords: markdown converter, convert markdown, markdown to pdf, java example, java code
description: In this article, you will learn about supported Markdown conversions and consider Java example of how to convert Markdown to PDF.
weight: 40
type: docs
url: /java/markdown-converter/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

{{%Markdown %}} is a web page archive format that allows embedding multiple resources, such as images, CSS styles, audio, and video files, into a single file, typically with a .mht file extension. Markdown format allows a web page to be saved and sent as a single file, preserving its appearance and interactivity. It can be opened by most web browsers. But sometimes you want to Convert Markdown to get the advantages of other formats.

Aspose.HTML for Java provides a wide range of Markdown conversions to popular formats, such as {{%PDF%}}, {{%XPS%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}.

{{% alert color="primary" %}}
This section provides information on the list of supported Markdown conversions and how to perform them using `convertMarkdown()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class. It can be different scenarios, but any Markdown conversion can be made with a few required steps: 

1. Load an existing Markdown file. You can load Markdown from a file or stream.
2. Create a Save Options object. You may customize the rendering process to get the desired result.
3. Use one of the `convertMarkdown()` methods to convert Markown to HTML and pass the required parameters to it.
4. Call one of the `convertHTML()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to convert the HTML to the required output format.

**Note:** Any conversion from Markdown to other formats goes through the **Markdown to HTML conversion** stage.
{{% /alert %}}

Let's consider the following code snippet that shows how to convert Markdown to PDF using our Java library:

{{< highlight java >}}
    // Prepare a path to a source Markdown file
    String sourcePath = Path.combine(getDataDir(), "nature.md");

    // Prepare a path for converted PDF file saving 
    String savePath = Path.combine(getOutputDir(), "nature-output.pdf");

    // Convert Markdown to HTML
    HTMLDocument document = Converter.convertMarkdown(sourcePath);
    try {
        // Initialize PdfSaveOptions
        PdfSaveOptions options = new PdfSaveOptions();           

        // Convert the HTML document to PDF file format
        com.aspose.html.converters.Converter.convertHTML(document, options, savePath);
    }
    finally { if (document != null) document.dispose(); }       
{{< /highlight >}}

**Popular Markdown Conversions**

- [Convert Markdown to HTML](/html/java/convert-markdown-to-html/) - Consider various Markdown to HTML conversion scenarios in Java code. Converting Markdown to HTML is an important basic operation because all conversions to other formats go through the Markdown to HTML conversion step.
- [Convert Markdown to PDF](/html/java/convert-markdown-to-pdf/) - Learn how to convert Markdown to PDF using Java library. You can easily use the Java code described here to convert Markdown to PDF, or Markdown to XPS.
- [Convert Markdown to Image](/html/java/convert-markdown-to-image/) - Learn how to convert Markdown to Image with Aspose.HTML for Java, and you can easily use the Java code described here to convert Markdown to PNG, JPG, BMP, GIF, and TIFF.

{{% alert color="primary" %}}
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}} 

{{% alert color="primary" %}} 
Aspose.HTML provides a free online [**Markdown Converter**](https://products.aspose.app/html/conversion/md) that enables you to convert Markdown files to various popular formats. This tool can easily convert [Markdown to PDF,](https://products.aspose.app/html/conversion/md-to-pdf) XPS, DOCX, JPG, PNG, BMP, TIFF, and GIF. The conversion process is simple and fast. You don't need any additional software. The best part is that it's completely free!
{{% /alert %}} 