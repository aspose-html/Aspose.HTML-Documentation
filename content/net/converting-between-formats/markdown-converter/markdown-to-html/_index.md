---
keywords: markdown to html, convert markdown to html, markdown to html
  conversion, markdown to html converter
lastmod: 2021-09-03
url: /net/converting-between-formats/markdown-to-html/
title: Convert Markdown to HTML | C#
description: This article provides information on how to convert Markdown to
  HTML using the Aspose.HTML API. You will learn about the supported Markdown to
  HTML conversion scenarios and consider examples to illustrate them.
weight: 10
type: docs
aliases:
  - /net/converting-between-formats/markdown-to-html-conversion/
  - /net/markdown-to-html-conversion/
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{%Markdown%}} is a markup language with a plain-text-formatting syntax. Markdown is often used as a format for documentation and readme files since it allows writing in an easy-to-read and easy-to-write style. Its design allows it to be easily converted to many output formats, but initially, it was created to convert only to HTML. Using the Aspose.HTML class library in your C# application, you can easily convert Markdown into an HTML file with just a few lines of code!

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/md-to-html" target="_blank">**MD to HTML Converter**</a> that converts Markdown to HTML file with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/md-to-html" target="_blank">![Text "Banner MD to HTML Converter"](md-to-html.png#center)</a>

## **Example 1. Create a source MD file from code and convert Markdown to HTML**
You can convert Markdown to HTML format using C# and other .NET programming languages. Aspose.HTML provides  ConvertMarkdown() methods as an understandable and straightforward way to perform Markdown to HTML conversion. If your case is to create a Markdown document from a user string directly in your code and save it to a file, the following example could help you: 

1. Prepare a source Markdown document. In the example, we create a Markdown file from code. 
1. Prepare a path for converted file saving. 
1. Use the [ConvertMarkdown()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmarkdown/methods/7) method of the Converter class to save Markdown as an HTML file. You need to pass the `sourcePath` and `savePath` to the ConvertMarkdown() method for Markdown to HTML conversion.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
...
    // Prepare a path to a source Markdown file
    string sourcePath = Path.Combine(OutputDir, "document.md");

    // Prepare a simple Markdown example
    var code = "### Hello, World!" +
               "\r\n" +
               "[visit applications](https://products.aspose.app/html/family)";
    // Create a Markdown file
    File.WriteAllText(sourcePath, code);
    
    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "document-output.html");
    
    // Convert Markdown to HTML document
    Converter.ConvertMarkdown(sourcePath, savePath);

{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Example 2. Convert an existing Markdown file to HTML**
If your case is to convert an existing Markdown document from a local file system, the following example could help you. You need to follow a few steps:

1. Open an existing Markdown document. In the example, we load a Markdown file from a local file system ([nature.md](https://github.com/aspose-html/Aspose.HTML-Documentation/blob/oa_conversion/content/tests-net/tests-data/nature.md)). 
1. Prepare a path for converted file saving. 
1. Use the [ConvertMarkdown()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmarkdown/methods/7) method of the Converter class to save Markdown as an HTML file. You need to pass the `sourcePath` and `savePath` to the ConvertMarkdown() method for Markdown to HTML conversion.

The following code snippet shows how to convert Markdown to HTML using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
...
    // Prepare a path to a source Markdown file
    string sourcePath = Path.Combine(DataDir, "nature.md");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "nature-output.html");
    
    // Convert Markdown to HTML document
    Converter.ConvertMarkdown(sourcePath, savePath);
{{< /highlight >}}

You can view the resulting HTML file by following the link - [nature-output.html](/html/net/converting-between-formats/markdown-to-html/nature-output.html) 

{{% alert color="primary" %}} 
You can check the quality of Markdown to HTML conversion with our online [**MD to HTML Converter**](https://products.aspose.app/html/en/conversion/md-to-html). Upload, convert your files and get results in a few seconds. Try our forceful Markdown to HTML Converter for free now!
{{% /alert %}}
