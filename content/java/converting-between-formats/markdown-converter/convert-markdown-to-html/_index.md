---
title: Convert Markdown to HTML in Java
linktitle: Convert Markdown to HTML
type: docs
weight: 10
keywords: markdown to html, convert markdown to html java, convert markdown to html, markdown to html conversion, markdown to html converter, save options, stream provider, java code
description: Learn how to convert Markdown to HTML using Java library. Consider various Markdown to HTML conversion scenarios in Java code.
url: /java/convert-markdown-to-html/
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
aliases: 
  - /java/markdown-to-html-conversion/
  - /java/converting-between-formats/markdown-to-html-conversion/
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

{{%Markdown%}} is a markup language with a plain-text-formatting syntax. Markdown is often used as a format for documentation and readme files since it allows writing in an easy-to-read and easy-to-write style. Its design allows it to be easily converted to many output formats, but initially it was created to convert the only to HTML. 

This article provides information on how to convert Markdown to HTML using the Aspose.HTML for Java library. In addition, you will consider Java examples to illustrate conversion scenarios.

## **Why Convert Markdown to HTML?**

1. Markdown is a lightweight markup language originally designed to be easily converted to HTML. The idea was to allow writers to use a simple and easy-to-learn syntax to format their text without worrying about the complexities of HTML. HTML is the standard markup language for creating web pages, so converting Markdown to HTML makes publishing content on the web easy.
2. Aspose.HTML uses Markdown to HTML conversion as an intermediate step to convert Markdown documents to other popular formats such as PDF, XPS, and images.

## **Convert Markdown to HTML**

Using the Aspose.HTML class library in your Java application, you can easily convert Markdown to HTML with just a few lines of code! An easy way to perform the conversion is to call the `convertMarkdown(sourcePath, outputPath)` method, which only takes a path to the source Markdown file and output file path.

{{< highlight java >}}
   // Prepare a path to a source Markdown file
   String sourcePath = Path.combine(getDataDir(), "nature.md");

   // Prepare a path for converted file saving 
   String outputPath = Path.combine(getOutputDir(), "nature-output.html");

   // Convert Markdown to HTML
   com.aspose.html.converters.Converter.convertMarkdown(sourcePath, outputPath);
{{< /highlight >}}

Let's look at another Java example. You can prepare Markdown source code from scratch and convert it to HTML:

{{< highlight java >}}
   // Prepare a simple Markdown example
   String code = StringExtensions.concat("### Hello, World!", 
               "\r\n", 
               "[visit applications](https://products.aspose.app/html/family)");
   
   // Create a Markdown file
   com.aspose.html.internal.ms.System.IO.File.writeAllText(sourcePath, code);

   // Prepare a path for converted file saving 
   String outputPath = Path.combine(getOutputDir(), "document-output.html");

   // Convert Markdown to HTML
   com.aspose.html.converters.Converter.convertMarkdown(sourcePath, outputPath);
{{< /highlight >}}

{{% alert color="primary" %}}
Aspose.HTML offers a free online [**Markdown to HTML Converter**](https://products.aspose.app/html/conversion/md-to-html) that converts Markdown to HTML with high quality, easy and fast. Just upload, convert your files and get the result in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/md-to-html" target="_blank">![Text "Banner Markdown to HTML Converter"](./../../images/md-to-html.png#center)</a>

## **Markdown Syntax**

This article demonstrates the syntax declared in the [core Markdown specification](https://daringfireball.net/projects/markdown/) and [GitLab Flavored Markdown](https://docs.gitlab.com/ee/user/markdown.html) variation. All these features are supported by Aspose.HTML out-of-the-box.

### **Headers**
Markdown supports two styles of headers, *Setext* and *atx*:

{{< highlight java >}}
 This is an H1

\=============

This is an H2

\-------------
{{< /highlight >}}

{{< highlight java >}}
 # This is an H1

\## This is an H2

\###### This is an H6
{{< /highlight >}}

### **Lists**

Markdown supports ordered (numbered) and unordered (bulleted) lists. Unordered lists use asterisks, pluses, and hyphens — interchangably — as list markers:

{{< highlight java >}}
 *   Red

\*   Green

\*   Blue
{{< /highlight >}}

Ordered lists use numbers followed by periods:

{{< highlight java >}}
 1.  Bird

\2.  McHale

\3.  Parish
{{< /highlight >}}

### **Images**

Inline image syntax looks like this:

{{< highlight java >}}
 ![Alt text](/path/to/img.jpg)
{{< /highlight >}}

### **Links**

Links syntax looks like this:

{{< highlight java >}}
 [an example](http://example.com/ "Title")
{{< /highlight >}}

### **Emphasis**

Markdown treats asterisks * and underscores (_) as indicators of emphasis:

{{< highlight java >}}
 *single asterisks*

_single underscores_

**double asterisks**

__double underscores__
{{< /highlight >}}

### **Blockquotes**

Markdown uses email-style > characters for blockquoting:

{{< highlight java >}}
 > This is the first level of quoting.

\>

\> > This is nested blockquote.
{{< /highlight >}}

### **Code Block**

To indicate a span of code, wrap it with backtick quotes (`):

{{< highlight java >}}
 javascript

function myFunc() {

   alert('Hello World!!!');

}

\
{{< /highlight >}}

### **Tables**

Tables aren’t part of the core Markdown spec, but they are part of GFM:

{{< highlight java >}}
 | header 1 | header 2 | header 3 |

\| --- | ------ |--------- |

| cell 1 | cell 2 | cell 3 |
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.
{{% /alert %}}