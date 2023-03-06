---
title: How to Resize Document During Conversion from HTML? - C#
linktitle: How to Resize Document
keywords: resize document, how to resize document, render html, rendering html, fit size, crop html, c# render html, fit document, crop document, rendering device, rendering options
description: Learn how to use rendering options to resize document pages to the size of the content and vice versa.
weight: 190
type: docs
url: /net/resize-document/
lastmod: 2023-03-08
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

In today's world, most documents are in A4 format, but sometimes content rendered from HTML is a different size. This results in a lot of white space on the page, or the content just won't fit on the page! In this article, we will consider how to use rendering options to resize document pages to the size of the content and vice versa.

## **How to Resize Document Using Aspose.HTML**

The [Aspose.Html.Rendering](https://reference.aspose.com/html/net/aspose.html.rendering/) namespace provides a powerful set of tools such as low-level options classes, interfaces, structures, and enumerations for rendering HTML, MHTML, EPUB and SVG documents to different output formats such as PDF, XPS, DOCX, and images. 

The [PageSize](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) class of the Aspose.Html.Rendering namespace provides a way to specify the width, height, and orientation of the pages when rendering HTML documents to output formats such as PDF, XPS, DOCX, and images.

### **What is the difference between cropping and resizing a document?**

### **Convert HTML to PNG with Default Rendering Options**

To convert HTML to PNG with default rendering options, you should follow a few steps:

1. Use one of the [HTMLDocument()](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/) constructors to initialize a `document` instance. In the following examples, we load the local `rendering.html` file.
1. Initialize an instance of the [ImageRenderingOption](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/) class if you want to convert HTML to an image file format. By default `ImageFormat` is PNG. Also, **note** that by default `HorizontalResolution` and `VerticalResolution` properties are 300 dpi. So, the rendered image will be stretched in height and width by about 3 times since the source content's resolution is 96 dpi. 
1. Create a new instance of the [ImageDevice](https://reference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/) class. Use the [ImageDevice()](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/imagedevice/#constructor_3) consrtructor that takes `options` and output file path `savePath` as parameters.
1. Use the [RenderTo(device)](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/) method to convert HTML to PNG, which takes the `device` object as a parameter.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Image;
...
    // Prepare path to a source HTML file
    string documentPath = Path.Combine(DataDir, "rendering.html");

    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "a4.png");

    // Create an instance of HTMLDocument class
    using var document = new HTMLDocument(documentPath);

    // Initialize an ImageRenderingOptions object with default options
    var options = new ImageRenderingOptions();

    // Create an output rendering device and convert HTML to PNG
    using var device = new ImageDevice(options, savePath);
    document.RenderTo(device);
{{< /highlight >}}

## **Rendering Options**

[PageLayoutOptions](https://reference.aspose.com/html/net/aspose.html.rendering/pagelayoutoptions/) enumeration of the Aspose.Html.Rendering namespace specifies flags that, together with other PageSetup options, determine sizes and layouts of pages. These flags can be combined together according to their descriptions.

| Name                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| FitToContentWidth | This flag specifies that the width of pages is determined by the size of the content itself and not by the set page width. Instead, content width is calculated individually for each page. |
| UseWidestPage | When combined with `FitToContentWidth`, it specifies that the width of each page will be the same and equal to the widest content size of all pages. |
| FitToWidestContentWidth | This flag specifies that the width of each page will be the same and equal to the widest content size among all pages. |
| FitToContentHeight | This flag specifies that the page height is determined by the content's size, not by the specified page height. If this flag is set, all document content will be placed on one page. |
| ScaleToPageWidth | This flag indicates that the document's content will be scaled to fit the page. It collides with the `FitToContentWidth` flag, and if both flags are specified, only ScaleToPageWidth will take effect.|
| ScaleToPageHeight | This flag indicates that the document's content will be scaled to fit the height of the first page. It collides with the `FitToContentHeight` flag, and if both flags are specified, only `ScaleToPageHeight` will take effect. All document content will be placed on a single page only. |


### **Convert HTML to JPG Using FitToWidestContentWidth**

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Image;
...
    // Prepare path to a source HTML file
    string documentPath = Path.Combine(DataDir, "rendering.html");

    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "FitWidth.jpg");

    // Create an instance of HTMLDocument class
    using var document = new HTMLDocument(documentPath);

    // Initialize an ImageRenderingOptions object with custom options. Use the FitToWidestContentWidth flag
    var opt = new ImageRenderingOptions(ImageFormat.Jpeg)
    {
        PageSetup =
        {
            PageLayoutOptions = PageLayoutOptions.FitToWidestContentWidth
        }        
    };

    // Create an output rendering device and convert HTML
    using var device = new ImageDevice(opt, savePath);
    document.RenderTo(device);
{{< /highlight >}}

### **Convert HTML to JPG Using ???**

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Image;
...
    // Prepare path to a source HTML file
    string documentPath = Path.Combine(DataDir, "rendering.html");

    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "FitPage.png");

    // Create an instance of HTMLDocument class
    using var document = new HTMLDocument(documentPath);

    // Initialize an ImageRenderingOptions object with custom options. Use FitToContentWidth and FitToContentHeight flags
    var opt = new ImageRenderingOptions()
    {
        PageSetup =
        {
            PageLayoutOptions = PageLayoutOptions.FitToContentWidth | PageLayoutOptions.FitToContentHeight
        },
        HorizontalResolution=96,
        VerticalResolution=96
    };

    // Create an output rendering device and convert HTML
    using var device = new ImageDevice(opt, savePath);
    document.RenderTo(device);
{{< /highlight >}}

### **Convert HTML to JPG Using ???h**

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Image;
...
    // Prepare path to a source HTML file
    string documentPath = Path.Combine(DataDir, "rendering.html");

    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "FitSmallPage.jpg");

    // Initialize HTMLDocument
    using var document = new HTMLDocument(documentPath);

    // Initialize an ImageRenderingOptions object with custom options. Use FitToWidestContentWidth and FitToContentHeight flags
    var opt = new ImageRenderingOptions(ImageFormat.Jpeg)
    {
        PageSetup =
        {
            PageLayoutOptions = PageLayoutOptions.FitToWidestContentWidth | PageLayoutOptions.FitToContentHeight,
            AnyPage = new Page(new Size(20,20))
        }
    };

    // Create an output rendering device and convert HTML
    using var device = new ImageDevice(opt, savePath);
    document.RenderTo(device);
{{< /highlight >}}

### **Convert HTML to JPG Using ???h**

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Image;
...
    // Prepare path to a source HTML file
    string documentPath = Path.Combine(DataDir, "rendering.html");

    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "ScaleSmallPage.png");

    // Initialize an HTMLDocument object
    using var document = new HTMLDocument(documentPath);

    // Initialize an ImageRenderingOptions object and use ScaleToPageWidth and ScaleToPageHeight flags
    var opt = new ImageRenderingOptions()
    {
        PageSetup =
        {
            PageLayoutOptions = PageLayoutOptions.ScaleToPageWidth | PageLayoutOptions.ScaleToPageHeight,
            AnyPage = new Page(new Size(200,200))
        }
    };

    // Create an output rendering device and convert HTML
    using var device = new ImageDevice(opt, savePath);
    document.RenderTo(device);
{{< /highlight >}}



This way, you can easily convert an HTML file into a flattened PDF using C#. This process is straightforward and can be done with a few lines of code. Let's look at the steps we have taken:

1. Use one of the constructors of the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/) class to load an HTML file. In the example, the [HTMLDocument(`sourcePath`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_10) constructor loads the HTML document from a local file system. 
2. Create an instance of the [PdfSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/pdfsaveoptions/) class that is used to specify the options for saving a PDF document. In this case, the [FormFieldBehaviour](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/formfieldbehaviour/) property of PdfSaveOptions is set to `FormFieldBehaviour.Flattened`, which means that all form fields in the HTML document will be flattened when the PDF document is created.
3. Call the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/#converthtml_7) method to convert HTML to PDF using the specified options, and the resulting PDF document is saved to `resultPath`.


The figure shows the bmp-output-options.bmp file.

![Text "The image ilustrates results of document resizing"](resize-document.png#center)

### **What is the difference between PDF files saved with and without FormFieldBehaviour property?**

1. If the FormFieldBehaviour property is set to `FormFieldBehaviour.Flattened`, form fields in the PDF document will be merged into one layer of the document. This effectively flattens the form fields, making them non-interactive and impossible to edit. The result is a static PDF document that cannot be altered.
2. On the other hand, if the FormFieldBehaviour property is set to `FormFieldBehaviour.Interactive`, form fields in the PDF document will remain interactive. This means that users can fill out the form fields and make changes. 
3. In Aspose.HTML, the **default value** for the FormFieldBehaviour property is `FormFieldBehaviour.Interactive`. If the FormFieldBehaviour property is not explicitly set, form fields in the PDF document will remain interactive, allowing users to fill out and edit them.

{{% alert color="primary" %}} 
Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/conversion) for converting HTML, XHTML, MHTML, EPUB, XML and Markdown files to a variety of popular formats.  You can easily convert  [HTML to PDF,](https://products.aspose.app/html/conversion/html-to-pdf) [HTML to JPG,](https://products.aspose.app/html/conversion/html-to-jpg) [SVG to PDF,](https://products.aspose.app/svg/conversion/svg-to-pdf) [MHTML to PDF,](https://products.aspose.app/html/conversion/mhtml-to-pdf) or [MD to HTML.](https://products.aspose.app/html/conversion/md-to-html) Just select the file, choose the format to convert, and you're done. It's fast and completely free!
{{% /alert %}} 

<a href="https://products.aspose.app/html/conversion" target="_blank">![Text "Banner Free Online Converters"](./../../images/converters.png#center)</a>