---
title: Convert HTML to Markdown | C#
type: docs
weight: 100
url: /net/converting-between-formats/html-to-markdown/
aliases:
    - /net/html-to-markdown/
    - /net/html-to-markdown-conversion/
    - /net/converting-between-formats/html-to-markdown-conversion/
description: This article provides information on how to convert HTML to Markdown using the Aspose.HTML API. You will learn about the supported HTML to Markdown conversion scenarios and consider examples to illustrate them.  
keywords: HTML to Markdown, convert HTML to Markdown, HTML to Markdown conversion, HTML to Markdown converter, save options
lastmod: "2021-09-03"
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{%Markdown%}} is a markup language with a plain-text-formatting syntax. Markdown is often used as a format for documentation and readme files since it allows writing in an easy-to-read and easy-to-write style. It is popular with technical writers for its simplicity of use, lightweight learning and broad support. Its design allows it to be easily converted to many output formats, but initially, it was created to convert only to HTML.  Aspose.HTML class library provides a reversed conversion from HTML to Markdown. You can access and edit Markdown files or create new content from any device in any text editor.

In this article, you find information on how to convert  HTML to {{%MD%}} using [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/index) methods of the Converter class, and how to apply [MarkdownSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/markdownsaveoptions).

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/html-to-md" target="_blank">**HTML to MD Converter**</a> that converts HTML to Markdown with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/html-to-md" target="_blank">![Text "Banner HTML to MD Converter"](html-to-md.png#center)</a>

## **HTML to Markdown by a few lines of code**

You can convert HTML to Markdown format using C# and other .NET programming languages. The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats.  The following code snippet shows how to convert HTML to Markdown literally with a few lines of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare HTML code and save it to a file
    var code = "<h1>Header 1</h1>" +
               "<h2>Header 2</h2>" +
               "<p>Hello, World!!</p>";
    File.WriteAllText("singl-line.html", code);

    // Call ConvertHTML() method to convert HTML to Markdown
    Converter.ConvertHTML("singl-line.html", new MarkdownSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.md"));
{{< /highlight >}}

## **Save Options**
The [MarkdownSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/markdownsaveoptions) has a number of properties that give you control over the conversion process. The most important option is [MarkdownSaveOptions.Features](https://apireference.aspose.com/net/html/aspose.html.saving/markdownsaveoptions/properties/features). This option allows you to enable/disable the conversion of the particular element.

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [Default](https://apireference.aspose.com/html/net/aspose.html.saving/markdownsaveoptions/properties/default) | This property returns a set of options that are compatible with default Markdown documentation. |
| [Features](https://apireference.aspose.com/html/net/aspose.html.saving/markdownsaveoptions/properties/features) | A flag set that controls which HTML elements are converted to Markdown. |
| [Formatter](https://apireference.aspose.com/html/net/aspose.html.saving/markdownsaveoptions/properties/formatter) | This property gets or sets the Markdown formatting style.    |
| [Git](https://apireference.aspose.com/html/net/aspose.html.saving/markdownsaveoptions/properties/git) | This property returns a set of options that are compatible with GitLab Flavored Markdown. |
| [ResourceHandlingOptions](https://apireference.aspose.com/html/net/aspose.html.saving/saveoptions/properties/resourcehandlingoptions) | Gets a [ResourceHandlingOptions](https://apireference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions) object which is used for configuration of resources handling. |


{{% alert color="primary" %}}

To learn more about [MarkdownSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/markdownsaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% /alert %}}

## **Convert HTML to Markdown using MarkdownSaveOptions**

To convert HTML to Markdown with Markdown SaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the HTMLDocument class. 
1. Create a new [MarkdownSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/markdownsaveoptions) object.
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the Converter class to save HTML as a Markdown file. You need to pass the HTMLDocument, MarkdownSaveOptions, and output file path to the ConvertHTML() method to convert HTML to Markdown .

The following example shows how to process only links and paragraphs, other HTML elements remain as is:

{{< highlight java >}} 
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "options-output.md");

    // Prepare HTML code and save it to the file
    var code = "<h1>Header 1</h1>" +
               "<h2>Header 2</h2>" +
               "<p>Hello, World!!</p>" +
               "<a href='aspose.com'>aspose</a>";
    File.WriteAllText(Path.Combine(OutputDir, "options.html"), code);
    
    // Create an instance of SaveOptions and set up the rule: 
    // - only <a> and <p> elements will be converted to Markdown
    var options = new MarkdownSaveOptions();
    options.Features = MarkdownFeatures.Link | MarkdownFeatures.AutomaticParagraph;
    
    // Call the ConvertHTML method to convert HTML to Markdown.
    Converter.ConvertHTML(Path.Combine(OutputDir, "options.html"), options, savePath);
{{< /highlight >}}

To convert HTML to Markdown you can define your own set of rules or use the predefined templates. For instance, you can use the template based on [GitLab Flavored Markdown](https://guides.github.com/features/mastering-markdown/) syntax:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "output-git.md");

    // Prepare HTML code and save it to the file
    var code = "<h1>Header 1</h1>" +
               "<h2>Header 2</h2>" +
               "<p>Hello World!!</p>";
    File.WriteAllText(Path.Combine(OutputDir, "document.html"), code);
    
    // Call ConvertHTML() method to convert HTML to Markdown
    Converter.ConvertHTML(Path.Combine(OutputDir, "document.html"), MarkdownSaveOptions.Git, savePath); 
{{< /highlight >}}

GitLab Flavored Markdown is the GitHub.com version of the Markdown syntax that provides an additional set of helpful features that make it easier to work with content on GitHub.com.
## **Limitation**
Markdown is a lightweight and easy-to-use syntax. Not all HTML elements are possible to convert to Markdown since there is no equivalent in Markdown syntax. The elements such as [STYLE](https://html.spec.whatwg.org/multipage/semantics.html#the-style-element), [SCRIPT](https://html.spec.whatwg.org/multipage/scripting.html#the-script-element), [LINK](https://html.spec.whatwg.org/multipage/semantics.html#the-link-element), [EMBED](https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-embed-element), etc. will be discarded during conversion.

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

### **Inline HTML**
Markdown allows you to specify the pure HTML code, which will be rendered as is. The feature, which allows this behavior, is called "Inline HTML". In order to use it, you should place one of the specific elements, supported by this feature, at the beginning of new line. Or you can mark one of such elements as "Inline HTML", by adding the attribute *markdown* with the value *inline* to this element. Here is small example, which demonstrate, how to use this attribute:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "inline-html.md");

    // Prepare HTML code and save it to the file
    var code = "text<div markdown='inline'><code>text</code></div>";
    File.WriteAllText(Path.Combine(OutputDir, "inline.html"), code);
    
    // Call ConvertHTML method for HTML to Markdown conversion
    Converter.ConvertHTML(Path.Combine(OutputDir, "inline.html"), new MarkdownSaveOptions(), savePath);
    
    // Output file will contain: text\r\n<div markdown="inline"><code>text</code></div>
{{< /highlight >}}

As you can see, content of the div element is not converted to Markdown and is treated by Markdown Processor as-is. The list of elements, which support this feature, is different for every Markdown processor.

The original Markdown specification supports these tags: BLOCKQUOTE,H1, H2, H3, H4, H5, H6, P, PRE, OL, UL, DL, DIV, INS, DEL, IFRAME, FIELDSET, NOSCRIPT, FORM, MATH.

The GitLab Flavored Markdown extends this list with the next tags: ARTICLE, FOOTER, NAV, ASIDE, HEADER, ADDRESS, HR, DD, FIGURE, FIGCAPTION, ABBR, VIDEO, AUDIO, OUTPUT, CANVAS, SECTION, DETAILS, HGROUP, SUMMARY.

### **Features nesting**
Markdown supports a lot of features, but not all of them can be used together. As an example list elements inside of table elements would not be converted. The following table shows what features can be nested. Each feature is a member of the [MarkdownFeatures](https://apireference.aspose.com/net/html/aspose.html.saving/markdownfeatures) enumeration.

|**Parent feature** |**Features which can be processed inside**|
| :- | :- |
|Header |Link, Emphasis, Strong, InlineCode, Image, Strikethrough, Video |
|Blockquote |Any |
|List |AutomaticParagraph, Link, Emphasis, Strong, InlineCode, Image, LineBreak, Strikethrough, Video, TaskList, List |
|Link |Emphasis, Strong, InlineCode, Image, LineBreak, Strikethrough |
|AutomaticParagraph |Link, Emphasis, Strong, InlineCode, Image, LineBreak, Strikethrough |
|Strikethrough |Link, Emphasis, Strong, InlineCode, Image, LineBreak |
|Table |Video, Strikethrough, Image, InlineCode, Emphasis, Strong, Link |
|Emphasis |Link, InlineCode, Image, LineBreak, Strikethrough, Video |
|Strong |Link, InlineCode, Image, LineBreak, Strikethrough, Video|

{{% alert color="primary" %}}
You can check the quality of HTML to Markdown conversion with our online [**HTML to MD Converter**](https://products.aspose.app/html/en/conversion/html-to-md). You can convert multiple HTML files to MHTML and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful HTML to Markdown Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}
