---
title: Convert HTML to Markdown Using Java
linktitle: Convert HTML to Markdown
keywords: html to markdown, convert html to markdown java, convert html to markdown, html to markdown conversion, save options, stream provider, java code
description: Learn how to convert HTML to Markdown in Java using Aspose.HTML API. Consider various HTML to Markdown conversion scenarios in Java code.
type: docs
weight: 50
url: /java/convert-html-to-markdown/
aliases: 
  - /java/html-to-markdown-conversion/
  - /java/converting-between-formats/html-to-markdown-conversion/ 
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-02-28
---

{{%Markdown%}} (MD) is a simple markup language that uses a plain-text-formatting syntax. It is commonly used for creating documentation and readme files due to its easy-to-read and easy-to-write format. Its design allows it to be easily converted to many output formats, but initially, it was created to convert only to HTML.  Aspose.HTML provides a class library that allows you to convert HTML to Markdown format in Java and other Java programming languages, offering a reverse conversion from HTML to Markdown.

In this article, you find information on how to convert HTML to Markdown using `convertHTML()` methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class, and how to apply [MarkdownSaveOptions.](https://reference.aspose.com/html/java/com.aspose.html.saving/markdownsaveoptions)

## **HTML to Markdown by a few lines of code**

You can convert HTML to Markdown format using Java and other Java programming languages. The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. The following code snippet shows how to convert HTML to Markdown literally with a few lines of code!

{{< highlight java >}}
    // Prepare HTML code and save it to a file
    String code = StringExtensions.concat("<h1>Convert HTML to Markdown Using Java</h1>", 
                "<h2>How to Convert HTML to MD in Java</h2>", 
                "<p>The Aspose.HTML for Java library allows you to convert HTML to Markdown.</p>");
    com.aspose.html.internal.ms.System.IO.File.writeAllText("conversion.html", code);

    // Call convertHTML() method
    com.aspose.html.converters.Converter.convertHTML("conversion.html", new MarkdownSaveOptions(), Path.combine(getOutputDir(), "conversion.md"));
{{< /highlight >}}

## **Save Options** ## 

The [MarkdownSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/markdownsaveoptions) has a number of properties that give you control over the conversion process. The most important option is `MarkdownFeatures`. This option allows you to enable/disable the conversion of the particular element.

| Method                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| getDefault() | This method returns a set of options that are compatible with default Markdown documentation. |
| setFeatures(value) | A flag set that controls which HTML elements are converted to Markdown. |
| setFormatter(value) | This method gets or sets the Markdown formatting style.    |
| getGit() | This method returns a set of options that are compatible with GitLab Flavored Markdown. |
| getResourceHandlingOptions() | Gets a [ResourceHandlingOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/ResourceHandlingOptions) object which is used for configuration of resources handling. |

{{% alert color="primary" %}}
To learn more about [MarkdownSaveOptions,](https://reference.aspose.com/html/java/com.aspose.html.saving/markdownsaveoptions) please read the [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.

In the [Markdown Syntax](https://docs.aspose.com/html/net/converting-between-formats/markdown-syntax/) article, you will find information on the main Markdown elements, details, and examples of the Markdown syntax.
{{% /alert %}}

## **Convert HTML to Markdown in Java using MarkdownSaveOptions**

### **setFeatures() method**

To convert HTML to Markdown with MarkdownSaveOptions specifying, you should follow a few steps: 

1. One popular scenario is to load an HTML file using one of the HTMLDocument() constructors of the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class. But in this example, we create an HTML source from scratch by preparing  HTML code and saving it to a file.
1. Create a new [MarkdownSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/markdownsaveoptions/) object. The MarkdownSaveOptions object can be customized to specify different settings for the conversion process.
1. Use the `convertHTML(sourcePath, options, outputPath)` method of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter) class to save HTML as a Markdown file.

The following example shows how to process only links and paragraphs, other HTML elements remain as is:

{{< highlight java >}} 
    // Prepare a path for converted file saving 
    String outputPath = Path.combine(getOutputDir(), "save-options-output.md");

    // Prepare HTML code and save it to a file
    String code = StringExtensions.concat("<h1>How to Use MarkdownSaveOptions</h1>", 
                "<h2>setFeatures() method</h2>", 
                "<p>Hello, World!!!</p>", 
                "<a href='aspose.com'>Aspose</a>");
    com.aspose.html.internal.ms.System.IO.File.writeAllText(Path.combine(getOutputDir(), "save-options.html"), code);

    // Create an instance of MarkdownSaveOptions and set up the rule: 
    // - only <a> and <p> elements will be converted to Markdown
    MarkdownSaveOptions options = new MarkdownSaveOptions();
    options.setFeatures (MarkdownFeatures.Link | MarkdownFeatures.AutomaticParagraph);

    // Call the convertHTML() method to convert HTML to MD
    com.aspose.html.converters.Converter.convertHTML(Path.combine(getOutputDir(), "save-options.html"), options, outputPath);
{{< /highlight >}}

In the Java code above, the `options` object is created, and two options are set using the `setFeatures()` method. The `Link` feature specifies that HTML `<a>` elements will be converted to Markdown, while the `AutomaticParagraph` feature determines that HTML `<p>` elements will be converted to Markdown. Any other elements in the HTML document will not be converted.

### **getGit() method**

GitHub Flavored Markdown is the GitHub.com version of the Markdown syntax that provides an additional set of helpful features that make it easier to work with content on GitHub.com. It is an extension of the standard Markdown syntax and adds many additional features, including code highlighting, task lists, tables, and more.

To convert HTML to Markdown you can define your own set of rules or use the predefined templates. For instance, you can use the template based on [GitLab Flavored Markdown](https://docs.gitlab.com/ee/user/markdown.html) syntax:

{{< highlight java >}}
    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "output-git.md");

    // Prepare HTML code and save it to the file
    String code = StringExtensions.concat("<h1>Header 1</h1>", 
                "<h2>Header 2</h2>", 
                "<p>Hello World!!</p>");
    com.aspose.html.internal.ms.System.IO.File.writeAllText(Path.combine(getOutputDir(), "document.html"), code);

    // Call ConvertHTML() method to convert HTML to Markdown
    com.aspose.html.converters.Converter.convertHTML(Path.combine(getOutputDir(), "document.html"), MarkdownSaveOptions.getGit(), savePath);
{{< /highlight >}}

In the java example above, the `convertHTML(sourcePath, options, outputPath)` method performs the conversion. It takes three arguments: `sourcePath`, `options`, and `outputPath`. The second argument is an instance of the MarkdownSaveOptions. We use the `getGit()` method in MarkdownSaveOptions that returns an `options` instance with Git enabled. Enabling Git in MarkdownSaveOptions means that the generated Markdown output file will contain a Git-flavored Markdown, a Markdown syntax that includes Git-specific features.

## **Limitation**

Markdown is a lightweight and easy-to-use syntax. Not all HTML elements are possible to convert to Markdown since there is no equivalent in Markdown syntax. The elements such as [STYLE](https://html.spec.whatwg.org/multipage/semantics.html#the-style-element), [SCRIPT](https://html.spec.whatwg.org/multipage/scripting.html#the-script-element), [LINK](https://html.spec.whatwg.org/multipage/semantics.html#the-link-element), [EMBED](https://html.spec.whatwg.org/multipage/iframe-embed-object.html#the-embed-element), etc. will be discarded during conversion.

### **Inline HTML** ### 

Markdown allows you to specify the pure HTML code, which will be rendered as is. The feature, which allows this behaviour, is called "Inline HTML". In order to use it, you should place one of the specific elements, supported by this feature, at the beginning of new line. Or you can mark one of such elements as "Inline HTML", by adding the attribute *markdown* with the value *inline* to this element. Here is small example, which demonstrate, how to use this attribute:

The "Inline HTML" feature in Markdown enables you to include pure HTML code that will be rendered as-is. To use this feature, you need to place one of the specific elements supported by this feature at the beginning of a new line. Alternatively, you can mark an element as "Inline HTML" by adding the attribute `markdown` with the value `inline` to that element. Here is a small example that demonstrates how to use this attribute:

{{< highlight java >}}
    // Prepare a path for converted file saving 
    String savePath = Path.combine(getOutputDir(), "inline-html.md");

    // Prepare HTML code and save it to the file
    String code = "text<div markdown='inline'><code>text</code></div>";
    com.aspose.html.internal.ms.System.IO.File.writeAllText(Path.combine(getOutputDir(), "inline.html"), code);

    // Call convertHTML method to convert HTML to Markdown.
    com.aspose.html.converters.Converter.convertHTML(Path.combine(getOutputDir(), "inline.html"), new MarkdownSaveOptions(), savePath);

    // Output file will contain: text\r\n<div markdown="inline"><code>text</code></div>
{{< /highlight >}}

As you can see, content of the `<div>` element is not converted to Markdown and is treated by Markdown Processor as-is. The list of elements, which support this feature, is different for every Markdown processor.

The original Markdown specification supports these tags: BLOCKQUOTE,H1, H2, H3, H4, H5, H6, P, PRE, OL, UL, DL, DIV, INS, DEL, IFRAME, FIELDSET, NOSCRIPT, FORM, MATH.

The GitLab Flavored Markdown extends this list with the next tags: ARTICLE, FOOTER, NAV, ASIDE, HEADER, ADDRESS, HR, DD, FIGURE, FIGCAPTION, ABBR, VIDEO, AUDIO, OUTPUT, CANVAS, SECTION, DETAILS, HGROUP, SUMMARY.

### **Features nesting** ### 

Although Markdown supports a wide range of features, not all of them can be combined. For example, list elements inside table elements will not be converted. The table below shows which features can be nested. Each feature is a member of the [MarkdownFeatures](https://reference.aspose.com/html/java/com.aspose.html.saving/markdownfeatures) enumeration.

|**Parent feature** |**Features which can be processed inside**|
| :-: | :-: |
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
You can download the complete examples and data files from {{%GITHUB_JAVA_EXAMPLES_LINK%}}.

Aspose.HTML offers a free online [HTML to Markdown Converter](https://products.aspose.app/html/conversion/html-to-md) that converts HTML to Markdown with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}
