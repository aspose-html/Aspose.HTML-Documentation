---
title: Flatten PDF - C# Examples
linktitle: How to Flatten a PDF
keywords: flatten pdf, flattening a pdf, flatten pdf file, convert html to pdf, pdf document
description: Learn what it means to flatten PDF and how to convert HTML to PDF and flatten a PDF file using FormFieldBehaviour property.
weight: 200
type: docs
url: /net/flatten-pdf/
lastmod: 2023-02-14
---

PDF (Portable Document Format) is a popular file format widely used for exchanging and storing digital documents. This versatile format allows you to create complex documents with various elements including text, images, forms, and more. However, in certain situations, it may be necessary to flatten a PDF document, which means converting it into a static, non-interactive file that can be easily shared, printed, or archived. This article will explain what it means to flatten a PDF and how to do it using Aspose.HTML for .NET library.

## **What Does it Mean to Flatten a PDF?**

To flatten a PDF file means to merge all document layers into a single background layer. This process effectively "flattens" the document by removing any interactive elements such as fillable form fields and editable text. The result is a static PDF that can no longer be edited or have its appearance altered, making it ideal for sharing, printing, or archiving.

## **Why Flatten a PDF?**

Flattening a PDF document is a process that can have several benefits, depending on your specific needs. There are several reasons why you might want to flatten a PDF file:
 - In terms of **security**, flattening a PDF document can prevent unauthorized changes or forgery. Flattening a PDF merges all form fields into the background layer, making it difficult for anyone to change the content.
 - Flattening a PDF can reduce its **file size** by removing unnecessary information, such as form fields, annotations, and layers. This can make it easier to share, email, or store the document, especially if it is large or complex.
 - Flattening a PDF file can ensure that it **prints correctly**, mainly if it contains complex graphics, images, or form fields. In addition, flattening the document removes any transparency effects and merges all layers into a single layer, which can help prevent printing errors and improve the overall print quality.
 - Flattening a PDF document makes it **easy to use** because it excludes the need to interact with interactive elements, making it simpler to view, print, or share.
 - If you need to save a PDF document for later use and **archive** it, flattening a document can ensure that it is readable and accessible for many years. Flattening eliminates the need for any specialized software or plugins, as the document will be a static, non-interactive PDF file.
 - and more.

 Whether your goals are related to security, file size, printing, archiving, or ease of use, flattening a PDF can provide you with the results you need.

## **How to Flatten a PDF in C#?**

Flattening a PDF document is a useful process for ensuring the stability and security of a document, as well as for improving its compatibility with printers or software applications. By converting HTML or MHTML files into flattened PDFs using C# code, we can easily create static, non-interactive PDF documents.

Aspose.HTML for .NET offers the [FormFieldBehaviour](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/formfieldbehaviour/) property of the PdfSaveOptions class to flatten PDF documents after their conversion from HTML or MHTML. This property is used to specify the behavior of form fields in a PDF document. If the value is set to `FormFieldBehaviour.Flattened` all form fields in the PDF document will be flattened.

### **HTML to PDF conversion and PDF flattening**

To flatten a PDF file using Aspose.HTML for .NET, you first need to convert an HTML file into a PDF document. The HTML file can contain interactive forms that need to be converted to PDF and flattened. Here is an example of how to convert HTML to PDF and use the FormFieldBehaviour property to flatten PDF:

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
    var resultPath = Path.Combine(OutputDir, "form-flattened.pdf");

    // Convert HTML to PDF
    Converter.ConvertHTML(document, options, resultPath);
{{< /highlight >}}

This way, you can easily convert an HTML file into a flattened PDF using C#. This process is straightforward and can be done with a few lines of code. Let's look at the steps we have taken:

1. Use one of the constructors of the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/) class to load an HTML file. In the example, the [HTMLDocument(`sourcePath`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_10) constructor loads the HTML document from a local file system. 
2. Create an instance of the [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/) class that is used to specify the options for saving a PDF document. In this case, the [FormFieldBehaviour](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/formfieldbehaviour/) property of PdfSaveOptions is set to `FormFieldBehaviour.Flattened`, which means that all form fields in the HTML document will be flattened when the PDF document is created.
3. Call the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/#converthtml_7) method to convert HTML to PDF using the specified options, and the resulting PDF document is saved to `resultPath`.

### **MHTML to PDF conversion and PDF flattening**

The following C# example shows how to convert an MHTML document located at `sourcePath` to a flattened  PDF document and save it to `outputPath`:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Saving;
...
     
    // Prepare a path to an MHTML source file
    var sourcePath = Path.Combine(DataDir, "SampleHtmlForm.mhtml");

    // Initialize PDF save options
    var options = new PdfSaveOptions
    {
        // Flatten all form fields
        FormFieldBehaviour = FormFieldBehaviour.Flattened
    };

    // Prepare a path to the result file
    var outputPath = Path.Combine(OutputDir, "document-flattened.pdf");

    // Convert MHTML to PDF
    Converter.ConvertMHTML(sourcePath, options, outputPath);
{{< /highlight >}}

To convert MHTML to PDF with FormFieldBehaviour property specifying, you should follow a few steps:

1. Initialize an instance of the PdfSaveOptions class and specify the options for saving the PDF document. In this example, the [FormFieldBehaviour](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/formfieldbehaviour/) property of PdfSaveOptions is set to `FormFieldBehaviour.Flattened`, which means that all form fields in the MHTML document will be flattened when the PDF document is created. 

2. Use the [ConvertMHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/#converthtml_7) method to convert MHTML to PDF, which takes the sourcepath, options, and outputPath as parameters.

### **What is the difference between PDF files saved with and without FormFieldBehaviour property?**

1. If the FormFieldBehaviour property is set to `FormFieldBehaviour.Flattened`, form fields in the PDF document will be merged into one layer of the document. This effectively flattens the form fields, making them non-interactive and impossible to edit. The result is a static PDF document that cannot be altered.
2. On the other hand, if the FormFieldBehaviour property is set to `FormFieldBehaviour.Interactive`, form fields in the PDF document will remain interactive. This means that users can fill out the form fields and make changes. 
3. In Aspose.HTML, the **default value** for the FormFieldBehaviour property is `FormFieldBehaviour.Interactive`. If the FormFieldBehaviour property is not explicitly set, form fields in the PDF document will remain interactive, allowing users to fill out and edit them.

{{% alert color="primary" %}} 
Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/conversion) for converting HTML, XHTML, MHTML, EPUB, XML, and Markdown files to various popular formats. You can easily convert  [HTML to PDF,](https://products.aspose.app/html/conversion/html-to-pdf) [HTML to JPG,](https://products.aspose.app/html/conversion/html-to-jpg) [SVG to PDF,](https://products.aspose.app/svg/conversion/svg-to-pdf) [MHTML to PDF,](https://products.aspose.app/html/conversion/mhtml-to-pdf) or [MD to HTML.](https://products.aspose.app/html/conversion/md-to-html) Just select the file, choose the format to convert, and you're done. It's fast and completely free!
{{% /alert %}} 

