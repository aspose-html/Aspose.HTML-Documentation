---
title: HTML to MHTML Conversion
type: docs
weight: 50
aliases: /java/html-to-mhtml-conversion/
---

In this article, you will find information on how to convert an {{%HTML%}} to {{%MHTML%}} and how to use [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions).

{{% alert color="primary" %}} 

<https://products.aspose.app/html/conversion/html-to-mhtml> 

{{% /alert %}} 

The static methods of the [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to MHTML in your Java application literally with a single line of code!

{{< gist "aspose-com-gists" "b2199f957c72708d4d2b0de93bca3098" "Examples_Java_ConvertingBetweenFormats_ConvertHTMLToMHTML_WithASingleLine.java" >}}

The next example explains how to convert HTML to PDF by line by line:

1. Load the HTML file using [HtmlDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument) class
1. Create an instance of [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions)
1. Use the [ConvertHTML()](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter#convertHTML-com.aspose.HTMLDocument-com.aspose.saving.ImageSaveOptions-java.util.Collection-) method of [Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/converter) class to save HTML as an MHTML file. You need to pass the [HTMLDocument](https://reference.aspose.com/html/java/com.aspose.html/HTMLDocument), [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions), and output file path to the ConvertHTML() method to convert HTML to MHTML.

{{< gist "aspose-com-gists" "b2199f957c72708d4d2b0de93bca3098" "Examples_Java_ConvertingBetweenFormats_ConvertHTMLToMHTML_ConvertHTMLDocumentToMHTML.java" >}}
## **Save Options** ## 
[MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions) allows you to customize the rendering process. You can specify the [UrlRestriction](https://reference.aspose.com/html/java/com.aspose.html.saving/ResourceHandlingOptions#getUrlRestriction--), [MaxHandlingDepth](https://reference.aspose.com/html/java/com.aspose.html.saving/ResourceHandlingOptions#getMaxHandlingDepth--), etc. The following example shows how to use [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions) *and* create a PDF file with custom page-size and background color:

{{< gist "aspose-com-gists" "b2199f957c72708d4d2b0de93bca3098" "Examples_Java_ConvertingBetweenFormats_ConvertHTMLToMHTML_SpecifyMHTMLSaveOptions.java" >}}

To learn more about [MHTMLSaveOptions](https://reference.aspose.com/html/java/com.aspose.html.saving/MHTMLSaveOptions) please read [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.
