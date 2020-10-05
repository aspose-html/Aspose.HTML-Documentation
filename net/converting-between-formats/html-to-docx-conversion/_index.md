---
title: HTML to DOCX Conversion
type: docs
weight: 40
url: /net/html-to-docx-conversion/
---

In this article, you will find information on how to convert an [HTML](https://en.wikipedia.org/wiki/HTML) to [DOCX](https://en.wikipedia.org/wiki/Office_Open_XML) and how to use [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to DOCX in your C# application literally with a single line of code!

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertHTMLToDOCX-WithASingleLine.cs" >}}

The next example explains how to convert HTML to DOCX line by line:

1. Load the HTML file using [HtmlDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument) class
1. Create an instance of [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions)
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/1) method of [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class to save HTML as a DOCX file. You need to pass the [HTMLDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument), [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions), and output file path to the ConvertHTML() method to convert HTML to DOCX.

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertHTMLToDOCX-ConvertHTMLDocumentToDOCX.cs" >}}
## **Save Options**
[DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) allows you to customize the rendering process. You can specify the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin), [CSS media-type](https://apireference.aspose.com/net/html/aspose.html.rendering/mediatype), etc. The following example shows how to use [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) *and* create a DOCX file with custom page-size:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertHTMLToDOCX-SpecifyDocSaveOptions.cs" >}}

To learn more about [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) please read [Fine-Tuning Converters](/html/net/fine-tuning-converters/) article.
## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering document/page.

Aspose.HTML for .NET provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, XPS, DOCX), others create multiple files (Image formats JPG, PNG, etc.).

The example below shows how to implement and use the your own *MemoryStreamProvider* in the application:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-MemoryStreamProvider.cs" >}}

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertHTMLToDOCX-SpecifyCustomStreamProvider.cs" >}}

