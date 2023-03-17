---
title: Renderers | C#
linktitle: Renderers
type: docs
weight: 30
url: /net/renderers/
description: Learn about supported renderers - HtmlRenderer, SvgRenderer, MhtmlRenderer and EpubRenderer, which are used to render HTML, SVG, MHTML, EPUB
keywords: renderers, convert html, render html, HtmlRenderer, render mhtml, render svg, SvgRenderer, render epub, timeout parameter, merge html
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-03-18
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

## **Renderers**

The [Aspose.Html.Rendering](https://reference.aspose.com/html/net/aspose.html.rendering/) namespace consists of numerous renderer objects and appropriate low-level options classes, which are responsible for rendering documents into [IDevice](https://reference.aspose.com/html/net/aspose.html.rendering/idevice/) implementation. Aspose.HTML for .NET API provides the following realization of renderers: [HtmlRenderer,](https://reference.aspose.com/html/net/aspose.html.rendering/htmlrenderer/) [SvgRenderer,](https://reference.aspose.com/html/net/aspose.html.rendering/svgrenderer/) [MhtmlRenderer,](https://reference.aspose.com/html/net/aspose.html.rendering/mhtmlrenderer/) and [EpubRenderer,](https://reference.aspose.com/html/net/aspose.html.rendering/epubrenderer/) which are used to render HTML, SVG, MHTML, and EPUB documents, respectively.

While the [RenderTo()](https://reference.aspose.com/html/net/aspose.html.dom/document/renderto/) method of the Document class  gives you the ability to send a single document to the output rendering device, using the [Renderer](https://reference.aspose.com/html/net/aspose.html.rendering/renderer-1/) instances directly, you can send multiple files at once. So, you can [merge HTML](/html/net/renderers/#merge-html), MHTML, EPUB, and SVG documents and apply rendering options to turn the output file. 

{{% alert color="primary" %}}
The current article describes supported scenarios of HTML-based file **conversion & merging** to other popular formats using Render() methods of the [Renderer](https://reference.aspose.com/html/net/aspose.html.rendering/renderer-1/) class.
{{% /alert %}}
 
### **HtmlRenderer**

Usage of the [HtmlRenderer](https://reference.aspose.com/html/net/aspose.html.rendering/htmlrenderer/) class to render HTML files to other popular formats - is one more way to convert HTML by customizing the rendering options and controlling the rendering process's output.<br>
Let's look at using the HtmlRenderer class to render HTML  to PDF with custom rendering options:
1. Initialize an HTML document. Use one of the [HTMLDocument()](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/) constructors to create an HTMLDocument instance.
1. Create a new [HtmlRenderer](https://reference.aspose.com/html/net/aspose.html.rendering/htmlrenderer/) object.
1. Create the instance of the [PdfRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/) and set custom options for the output PDF document. In the example, we specify  the [AnyPage](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/anypage/) property of the PageSetup class that sets a new Page object with a page size of 600 pixels by 200 pixels and the [Encryption](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/encryption/) property that identifies the user and owner passwords, allowed permissions, and encryption algorithm for the output PDF file.
1. Use [PdfDevice(`options`, `savePath`)](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/pdfdevice/#constructor_3) constructor to create an object of the PdfDevice class.
1. And finally, call the [Render(`device`, `document`)](https://reference.aspose.com/html/net/aspose.html.rendering/renderer-1/render/#render_2) method to render the HTML document to the output PDF file with the specified rendering options.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Rendering.Pdf.Encryption;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");

    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);

    // Create an instance of HTML Renderer
    using var renderer = new HtmlRenderer();

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "convert-html-options.pdf");

    // Create the instance of the PdfRenderingOptions and set a custom page size and encryption
    var options = new PdfRenderingOptions();
    options.PageSetup.AnyPage = new Page(new Size(600, 200));
    options.Encryption = new PdfEncryptionInfo(
            "user_pwd",
            "owner_pwd",
            PdfPermissions.PrintDocument,
            PdfEncryptionAlgorithm.RC4_128);

    // Create an instance of PDF device
    using var device = new PdfDevice(options, savePath);

    // Render HTML to PDF
    renderer.Render(device, document);
{{< /highlight >}}

{{% alert color="primary" %}}
Rendering options give you additional control over the rendering process. To learn more about them, please read the [Rendering options](/html/net/rendering-options/) article.

A renderer device takes an options object as a parameter and represents an output document. To learn more, please read the [Rendering Device](/html/net/rendering-device/) article.

If you are interested in how to use rendering options to resize document pages to the size of the content and vice versa, please visit the article [How to Resize Document During Conversion from HTML?](/html/net/resize-document/)
{{% /alert %}}

### **SvgRenderer**

The [SvgRenderer](https://reference.aspose.com/html/net/aspose.html.rendering/svgrenderer/) allows you to render SVG files to other file formats, such as PDF, XPS, DOCX, and image formats. With this, you can customize the output file using various rendering options. The following example demonstrates how to use SvgRenderer class to render SVG to PDF with a custom page size specifying:

1. Initialize an SVG document. Use one of the [SVGDocument()](https://reference.aspose.com/html/net/aspose.html.dom.svg/svgdocument/) constructors to create an SVGDocument instance.
1. Create a new [SvgRenderer](https://reference.aspose.com/html/net/aspose.html.rendering/svgrenderer/) object.
1. Create an instance of the [PdfRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/) and set custom options for the output PDF document. In the example, we specify  the [PageSetup.AnyPage](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/anypage/) property that sets a new Page object with a page size of 600x500 pixels.
1. Use the [PdfDevice(`options`, `savePath`)](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/pdfdevice/#constructor_3) constructor to create an object of the PdfDevice class.
1. And finally, call the [Render(`device`, `document`)](https://reference.aspose.com/html/net/aspose.html.rendering/renderer-1/render/#render_2) method to render the SVG document to the output PDF file with the specified rendering options.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Rendering.Pdf.Encryption;
...
    // Initialize an SVG document from the file
    using var document = new SVGDocument(Path.Combine(DataDir, "shapes.svg"));    

    // Create an instance of SVG Renderer
    using var renderer = new SvgRenderer();

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "merge-svg.pdf");

    // Create the instance of the PdfRenderingOptions class and set a custom page size
    var options = new PdfRenderingOptions();
    options.PageSetup.AnyPage = new Page(new Size(600, 500));            

    // Create an instance of PdfDevice class
    using var device = new PdfDevice(options, savePath);

    // Render SVG to PDF
    renderer.Render(device, document);
{{< /highlight >}}

### **MhtmlRenderer**

The following example demonstrates how to convert MHTML to PDF with the rendering options specifying using the [MhtmlRenderer](https://reference.aspose.com/html/net/aspose.html.rendering/mhtmlrenderer/) class:
 
1. Open an existing MHTML document.
1. Create an instance of MhtmlRenderer using the [MhtmlRenderer()](https://reference.aspose.com/html/net/aspose.html.rendering/mhtmlrenderer/mhtmlrenderer/) constructor.
1. Initialize the [PdfRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/) class and set rendering options.
1. Create an instance of the [PdfDevice](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/) class.
1. Call the [Render(`device`, `stream`)](https://reference.aspose.com/html/net/aspose.html.rendering/renderer-1/render/#render_2) method to render MHTML to PDF.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Pdf;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");
            
    // Create an instance of MHTML Renderer
    using var renderer = new MhtmlRenderer();

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "convert-mhtml-options.pdf");

    // Create the instance of Rendering Options and set a custom page size and background color
    var options = new PdfRenderingOptions();
    options.PageSetup.AnyPage = new Page(new Size(600, 200));
    options.BackgroundColor = System.Drawing.Color.Azure;

    // Create an instance of PDF device
    using var device = new PdfDevice(options, savePath);

    // Render MHTML to PDF
    renderer.Render(device, stream);
{{< /highlight >}}

### **EpubRenderer**

The [EpubRenderer](https://reference.aspose.com/html/net/aspose.html.rendering/epubrenderer/) class allows you to convert EPUB files to other formats such as PDF, XPS, DOCX, and images. The following C# examples shows how to convert EPUB to DOCX with a custom page size setting:
1. Open an existing EPUB file.
1. Create an instance of EpubRenderer class.
1. Initialize the [DocRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.doc/docrenderingoptions/) class and set rendering options.
1. Create an instance of the [DocDevice](https://reference.aspose.com/html/net/aspose.html.rendering.doc/docdevice/) class.
1. Call the [Render(`device`, `stream`)](https://reference.aspose.com/html/net/aspose.html.rendering/renderer-1/render/#render_2) method to render EPUB to DOCX.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Doc;
...
    // Open an existing EPUB file for reading
    using var stream = File.OpenRead(DataDir + "input.epub");

    // Create an instance of EPUB Renderer
    using var renderer = new EpubRenderer();

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "convert-epub-options.docx");

    // Create the instance of the DocRenderingOptions class and set a custom page size
    var options = new DocRenderingOptions();
    options.PageSetup.AnyPage = new Page(new Size(800, 400));            

    // Create an instance of the DocDevice class
    using var device = new DocDevice(options, savePath);

    // Render EPUB to DOCX
    renderer.Render(device, stream);
{{< /highlight >}}

## **Merge HTML**

[Aspose.HTML for .NET API](https://products.aspose.com/html/net/) provides the [Renderer](https://reference.aspose.com/html/net/aspose.html.rendering/renderer-1/) class for rendering and merging HTML, MHTML, EPUB, and SVG documents to popular formats. While the [RenderTo()](https://reference.aspose.com/html/net/aspose.html.dom/document/renderto/) method gives you the ability to send a single document to the output rendering device, using the `Renderer` instances directly, you can send multiple files at once. 
Using the implementation of renderers: HtmlRenderer, SvgRenderer, MhtmlRenderer, and EpubRenderer, you can merge HTML, SVG, MHTML, and EPUB documents, respectively. The next example demonstrates how to use [HtmlRenderer](https://reference.aspose.com/html/net/aspose.html.rendering/htmlrenderer/) to render multiple HTML documents:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Pdf;
...
    // Prepare HTML code
    var code1 = @"<br><span style='color: green'>Hello World!!</span>";
    var code2 = @"<br><span style='color: blue'>Hello World!!</span>";
    var code3 = @"<br><span style='color: red'>Hello World!!</span>";

    // Create three HTML documents to merge later
    using var document1 = new HTMLDocument(code1, ".");
    using var document2 = new HTMLDocument(code2, ".");
    using var document3 = new HTMLDocument(code3, ".");

    // Create an instance of HTML Renderer
    using var renderer = new HtmlRenderer();

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "merge-html.pdf");

    // Create an instance of PDF device
    using var device = new PdfDevice(savePath);
                    
    // Merge all HTML documents into PDF
    renderer.Render(device, document1, document2, document3);  
{{< /highlight >}}

## **Timeout Parameter**
One more important feature that is available for renderers is timeout. You can use it to specify how long you are ready to wait for all internal processes related to a document lifecycle to be completed, such as resource loading, active timers, etc. Sure, you can specify an infinite waiting period. However, if the document contains a script with an endless loop, you will wait indefinitely. The example below demonstrates how to use the timeout parameter: 

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Pdf;
...
    // Prepare HTML code
    var code = @"
    <script>
        var count = 0;
        setInterval(function()
            {
                var element = document.createElement('div');
                var message = (++count) + '. ' + 'Hello, World!! I know how to use Renderers!';
                var text = document.createTextNode(message);
                element.appendChild(text);
                document.body.appendChild(element);
            }, 1000);
    </script>";

    // Initialize an HTML document based on prepared HTML code
    using var document = new HTMLDocument(code, ".");

    // Create an instance of HTML Renderer
    using HtmlRenderer renderer = new HtmlRenderer();

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "output-timeout.pdf");

    // Create an instance of PDF device
    using var device = new PdfDevice(savePath);
                    
    // Render HTML to PDF
    renderer.Render(device, TimeSpan.FromSeconds(5), document); 
{{< /highlight >}}

In this example, we create an HTML document that adds a new `<div>` element every second with a sequential number and the message "Hello, World!!" We use the `TimeSpan` parameter in the [Render(`device`, `timeout`, `document`)](https://reference.aspose.com/html/net/aspose.html.rendering/renderer-1/render/#render_1) method to set the timeout. This setting specifies the maximum time the renderer will spend rendering the document. In this case, the total time is set to 5 seconds. If the renderer has not generated a document within the specified time, it will stop and render a partially rendered document. Running this example, you will get a document with five lines of "Hello World!! I know how to use Renderers!" message, as follows:

![five lines of 'Hello World'](timeout-parameter.png#center)

{{% alert color="primary" %}}
You can download the complete C# examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)

Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/conversion) that can convert HTML, XHTML, MHTML, EPUB, XML, and Markdown files to a range of popular formats. You can easily convert your HTML-based documents to PDF, XPS, DOCX, JPG, PNG, GIF, TIFF, and others. Just select the file, choose the format to convert, and you’re done. Best of all, it's completely free!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion" target="_blank">![Text "Banner Free Online Converters"](./../../images/converters.png#center)</a>
