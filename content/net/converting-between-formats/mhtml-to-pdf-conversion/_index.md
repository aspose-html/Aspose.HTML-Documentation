---
title: MHTML to PDF Conversion
type: docs
weight: 140
aliases: /net/mhtml-to-pdf-conversion/
---

In this article, you will find information about how to convert an {{%MHTML%}} to {{%PDF%}} and how to use [PdfSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/pdfsaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}} 

<https://products.aspose.app/html/conversion/mhtml-to-pdf>

{{% /alert %}} 

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an {{%MHTML%}} code into various formats. You can convert {{%MHTML%}} to {{%PDF%}} in your C# application literally with a single line of code!

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertMHTMLToPDF-WithASingleLine.cs" >}}

The following C# code snippet shows how to convert MHTML to PDF using Aspose.HTML for .NET.

1. Open an existing MHTML file;
1. Create an instance of [PdfSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/pdfsaveoptions);
1. Use the [Converter.ConvertMHTML](https://apireference.aspose.com/net/html/aspose.html.converters.converter/convertmhtml/methods/9) method of [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class to save MHTML as a PDF file. You need to pass the MHTML file stream, [PdfSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/pdfsaveoptionsQ), and output file path to the [Converter.ConvertMHTML](https://apireference.aspose.com/net/html/aspose.html.converters.converter/convertmhtml/methods/9) method to convert MHTML to PDF.

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertMHTMLToPDF-ConvertMHTMLFileToPDF.cs" >}}
## **Save Options**
[PdfSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/pdfsaveoptions) allows you to customize the rendering process. You can specify the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin), [file permissions](https://apireference.aspose.com/net/html/aspose.html.rendering.pdf.encryption/pdfencryptioninfo), [CSS media-type](https://apireference.aspose.com/net/html/aspose.html.rendering/mediatype), etc. The following example shows how to use [PdfSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/pdfsaveoptions) *and* create a PDF file with custom page-size and background color:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertMHTMLToImage-SpecifyImageSaveOptions.cs" >}}

Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.HTML for .NET x.x.x will be displayed against these fields.

To learn more about [PdfSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/pdfsaveoptions) please read [Fine-Tuning Converters](/html/net/fine-tuning-converters/) article.
## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering document/page.

{{% alert color="primary" %}} 

Aspose.HTML for .NET provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).

{{% /alert %}} 

The example below shows how to implement and use the your own *MemoryStreamProvider* in the application:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-MemoryStreamProvider.cs" >}}

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertMHTMLToImage-SpecifyCustomStreamProvider.cs" >}}



