---
title: Flatten a PDF - C# Examples
linktitle: How to Flatten a PDF
keywords: flatten pdf, flattening a pdf, flatten pdf file, convert html to pdf
description: Learn what it means to flatten PDF and how to convert HTML to PDF and flatten a PDF file using FormFieldBehaviour property.
weight: 200
type: docs
aliases: /net/flatten-pdf/
lastmod: 2023-02-14
---

PDF (Portable Document Format) is a popular file format widely used for exchanging and storing digital documents. This versatile format allows you to create complex documents with various elements including text, images, forms, and more. However, in certain situations, it may be necessary to "flatten" a PDF document, which means converting it into a static, non-interactive file that can be easily shared, printed, or archived. This article will explain what it means to flatten a PDF and how to do it using Aspose.HTML for .NET library.

## **What Does it Mean to Flatten a PDF?**

To flatten a PDF file means to merge all document layers into a single background layer. This process effectively "flattens" the document by removing any interactive elements such as fillable form fields, editable text, and image placeholders. The result is a static PDF that can no longer be edited or have its appearance altered, making it ideal for sharing, printing, or archiving.

## **Why Flatten a PDF?**

Flattening a PDF document is a process that can have several benefits, depending on your specific needs. There are several reasons why you might want to flatten a PDF file:
 - In terms of **security**, flattening a PDF document can prevent unauthorized changes or forgery. Flattening a PDF merges all form fields into the background layer, making it difficult for anyone to make changes to the content.
 - Flattening a PDF can reduce its **file size** by removing unnecessary information, such as form fields, annotations, and layers. This can make it easier to share, email, or store the document, especially if it is large or complex.
 - Flattening a PDF file can ensure that it **prints correctly**, mainly if it contains complex graphics, images, or form fields. In addition, flattening the document eliminates any transparency effects and merges all layers into a single layer, which can help prevent printing errors and improve the overall print quality.
 - Flattening a PDF document makes it **easy to use** because it eliminates the need to interact with form fields or annotations, making it simpler to view, print, or share the document.
 - and more.

 Whether your goals are related to security, file size, printing, archiving, or ease of use, flattening a PDF can provide you with the results you need.

## **How to Flatten a PDF in C#?**



{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Saving;
...
     
    // Prepare a path to an HTML source file
    var sourcePath = Path.Combine(DataDir, "SampleHtmlForm.html");

    // Initialize an HTML document from the file
    using HTMLDocument document = new HTMLDocument(sourcePath);

    // Prepare PDF save options
    var options = new PdfSaveOptions
    {
        // Flatten all form fields
        FormFieldBehaviour = FormFieldBehaviour.Flattened
    };

    // Prepare a path to the result file
    var resultPath = Path.Combine(OutputDir, "document.pdf");

    // Convert HTML to PDF
    Converter.ConvertHTML(document, options, resultPath);
{{< /highlight >}}

## **Steps to Flatten a PDF**

## **How do I make sure my PDF forms are flattened?**

{{% alert color="primary" %}} 
Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/conversion) for converting HTML, XHTML, MHTML, EPUB, XML and Markdown files to a variety of popular formats.  You can easily convert  [HTML to PDF](https://products.aspose.app/html/conversion/html-to-pdf), [HTML to JPG,](https://products.aspose.app/html/conversion/html-to-jpg) [SVG to PDF,](https://products.aspose.app/svg/conversion/svg-to-pdf) [MHTML to PDF,](https://products.aspose.app/html/conversion/mhtml-to-pdf) or [MD to HTML](https://products.aspose.app/html/conversion/md-to-html). Just select the file, choose the format to convert, and you're done. It's fast and completely free!
{{% /alert %}} 

