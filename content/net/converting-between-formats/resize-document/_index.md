---
title: How to Resize Document During Conversion from HTML? - C#
linktitle: How to Resize Document
keywords: resize document, how to resize document, render html, rendering html, fit size, crop html, fit document, fit page, crop document, rendering device, rendering options, page size
description: Learn how to use rendering options to resize document pages to the size of the content and vice versa.
weight: 190
type: docs
url: /net/resize-document/
lastmod: 2023-03-08
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

In today's world, most documents are in A4 format, but sometimes content rendered from HTML is a different size. This results in a lot of white space on the page, or the content just won't fit on the page! In this article, we will consider how to use rendering options to resize document pages to the size of the content and vice versa.

## **How to Resize Document Using Aspose.HTML**

The [Aspose.Html.Rendering](https://reference.aspose.com/html/net/aspose.html.rendering/) namespace provides a powerful set of tools such as low-level options classes, interfaces, structures, and enumerations for rendering HTML, MHTML, EPUB, and SVG documents to different output formats such as PDF, XPS, DOCX, and images. The [PageSize](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) class of provides a way to specify the width, height, and orientation of the pages when rendering HTML documents to output formats. But sometimes, you may need to crop documents to create a smaller page size that fits the page's content size. This means the outer margins, borders, or empty space will be removed. 

The [PageSetup](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/) class provides a set of properties to manage the page setup settings for HTML documents when rendering them to different file formats. Let's take a look at some of the more used ones:
 - **Set Page Setup.** The [AnyPage](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/anypage/) property allows you to set the page setup (size, margins, orientation, etc.) for any page of an HTML document that is rendered to a multi-page format, such as PDF, XPS, DOCX, PNG, JPG, etc.
 - **Resize Document to Fit the Size of Content.** You can fit page size to the content and vice versa using the [PageLayoutOptions](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/pagelayoutoptions/) property. This property is a set of bit flags that control the behavior of the renderer. You can crop documents or scale documents to match their content to the page size.

{{% alert color="primary" %}}
You can easily use C# examples of converting HTML to Images with a custom page layout to convert HTML to PDF, XPS, and DOCX. The only differences are in specifying 
 - the appropriate rendering options - ImageRenderingOption, PdfRenderingOption, XpsRenderingOption, or DocRenderingOption;
 - the appropriate output device - ImageDevice, PdfDevice, XpsDevice or DocDevice.
{{% /alert %}}

### **Convert HTML to PNG with Default Rendering Options**

To convert HTML to PNG with default rendering options, you should follow a few steps:

1. Use one of the [HTMLDocument()](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/) constructors to initialize a `document` instance. In the following examples, we load the local [rendering.html](/html/net/resize-document/rendering.html) file.
1. Initialize an instance of the [ImageRenderingOption](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/) class if you want to convert HTML to an image file format. By default `ImageFormat` is PNG. Also, **note** that by default `HorizontalResolution` and `VerticalResolution` properties are 300 dpi. So, the rendered image will be stretched in height and width by about 3 times since the source content's resolution is 96 dpi. 
1. Create a new instance of the [ImageDevice](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/) class. Use the [ImageDevice()](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/imagedevice/#constructor_3) constructor that takes `options` and output file path `savePath` as parameters.
1. Use the [RenderTo(device)](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/) method to convert HTML to PNG, which takes the `device` object as a parameter.

Further, the fragment of C# code shows an example of converting an HTML document to an image without any additional options, i.e. with default rendering options. As a result of the conversion, an A4 PNG document was obtained with a lot of empty space (see [illustrations of conversion results (a).](/html/net/resize-document/#figures-of-the-conversion-results-with-crop-and-resize))

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

### **Rendering Options**

[PageLayoutOptions](https://reference.aspose.com/html/net/aspose.html.rendering/pagelayoutoptions/) enumeration of the Aspose.Html.Rendering namespace specifies flags that, together with other [PageSetup](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/) options, determine sizes and layouts of pages. These flags can be combined together according to their descriptions.

| Name                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| FitToContentWidth | This flag specifies that the width of pages is determined by the size of the content itself and not by the set page width. Instead, content width is calculated individually for each page. |
| UseWidestPage | When combined with `FitToContentWidth`, it specifies that the width of each page will be the same and equal to the widest content size of all pages. |
| FitToWidestContentWidth | This flag specifies that the width of each page will be the same and equal to the widest content size among all pages. |
| FitToContentHeight | This flag specifies that the page height is determined by the content's size, not by the specified page height. If this flag is set, all document content will be placed on one page. |
| ScaleToPageWidth | This flag indicates that the document's content will be scaled to fit the page. It collides with the `FitToContentWidth` flag, and if both flags are specified, only ScaleToPageWidth will take effect.|
| ScaleToPageHeight | This flag indicates that the document's content will be scaled to fit the height of the first page. It collides with the `FitToContentHeight` flag, and if both flags are specified, only `ScaleToPageHeight` will take effect. All document content will be placed on a single page only. |

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)
{{% /alert %}} 

### **Fit Page to Width when Converting HTML to JPG**

In order to fit page width of the output image to the width of the content, you need to use the `FitToContentWidth` flag, or the `FitToWidestContentWidth` flag, which will fit the width of the resulting document to the width of the widest page. Let's look at the steps you should follow:

1. Load an HTML file. In the example, the [HTMLDocument(`documentPath`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_10) constructor loads the HTML document from a local file system. 
1. Create an instance of the [ImageRenderingOption](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/) class. In this example, we set the [PageLayoutOptions](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/pagelayoutoptions/) property to `FitToWidestContentWidth`, which means that the output document's page width will fit the widest content page's width.
1. Create a new instance of the [ImageDevice](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/) class and pass it to the [RenderTo(device)](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/) method to convert HTML to JPG.

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

The HTML to JPG conversion resulted in a JPG document with a page width that fits the width of the content, but with a page height that matches the height of the format A4 (see [illustrations of conversion results (b)](/html/net/resize-document/#figures-of-the-conversion-results-with-crop-and-resize)).

### **Crop HTML to PNG Rendered  Result**

To make the output page size match the height of the image in the source file, you must set the `FitToContentHeight` flag in the [PageLayoutOptions](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/pagelayoutoptions/) property. The following example shows a combination of two flags, `FitToContentHeight` and `FitToContentWidth`.

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

    // Initialize an ImageRenderingOptions object with custom options. Use `FitToContentWidth` and FitToContentHeight flags
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

### **Fit Page Size to Content of Rendering HTML to JPG**

In the following example, the [AnyPage](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/anypage/) property sets the page size to 20x20 px, which is not large enough to fit the HTML document's content when rendered to an image. Using PageLayoutOptions with the `FitToWidestContentWidth` and `FitToContentHeight` flags causes the page to grow in size to fit the content.

1. Create an [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) instance. In the following examples, we load the local `rendering.html` file.
1. Initialize an instance of the [ImageRenderingOption](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/) class if you want to convert HTML to JPG file format.
    - Specify the `ImageFormat` as `Jpeg`.
    - Create a `PageSetup` object with the `PageLayoutOptions` property with the `FitToWidestContentWidth` and `FitToContentHeight` flags set. This ensures that the output image will fit the width and height of the content without any empty space.
1. Create a new instance of the [ImageDevice](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/) class.
1. Use the [RenderTo(device)](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/) method to convert HTML to JPG, which takes the `device` object as a parameter.

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

Despite setting the page size as 20x20 pixels, the `FitToWidestContentWidth` and `FitToContentHeight` flags allow us to fit the resulting JPG document would have a page size that fits the content size (see the [illustration of conversion results (d)](/html/net/resize-document/#figures-of-the-conversion-results-with-crop-and-resize)).

### **Scale Page Size During Converting HTML to PNG**

By analogy with the `FitTo*` flags that control page sizes, there is a set of `ScaleTo*` flags that control content sizes and allow to scale it. If the content size exceeds the page size, the content is scaled with aspect ratio until it fits on the page in width and/or height, depending on the combination of flags. The following example shows how to set the width and height scaling of content:

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

In the example, the [AnyPage](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/anypage/) property of the `PageSetup` sets a new [Page](https://reference.aspose.com/html/net/aspose.html.drawing/page/) object with a `Size` of 200x200 pixels. This sets the page size to 200x200 pixels.
Then we set the [PageLayoutOptions](https://reference.aspose.com/html/net/aspose.html.rendering/pagesetup/pagelayoutoptions/) property of the `PageSetup` object to include the `ScaleToPageWidth` and `ScaleToPageHeight` flags. This means that the output document content will be scaled to fit within the page's width and/or height (see the [illustration of conversion results (e).](/html/net/resize-document/#figures-of-the-conversion-results-with-crop-and-resize))


## **Figures of the Conversion Results with Crop and Resize**

The figure shows the results of converting the rendering.html file to PNG, JPG, and PDF formats using the RenderTo() method and various rendering options that control the page size of the output document. 

**Note:** The source image size in [rendering.html](/html/net/resize-document/rendering.html) file is 404x303, with a resolution of 96 dpi.

![Text "The image ilustrates results of document resizing"](resize-document.png#center)

**a)** The result of HTML to PNG conversion with default rendering options is an A4 page size PNG document with a lot of empty space on it. The rendered image on the A4 page is stretched in height and width by about 3 times since the default resolution is 300 dpi. 

**b)** The HTML to JPG conversion resulted in a JPG document with a page width that fits the width of the content, but with a page height that matches the height of the format A4. The rendered image on the A4 page is stretched in height and width by about 3 times since the default resolution is 300 dpi. 

**c)** The result of converting HTML to PNG with cropping the output document to fit the page size to the size of the content.

**d)** Even though the page size was set as 20x20 px, using the `FitToWidestContentWidth` and `FitToContentHeight` flags made it possible to get the resulting JPG document with a page size that fits the size of the content.

**e)** The result of rendering HTML to image when the content size is larger than the page size. We scaled down the content to fit the page size of 200x200 px.

{{% alert color="primary" %}}
You can download the complete C# examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)

Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/conversion) for converting HTML, XHTML, MHTML, EPUB, XML, and Markdown files to various popular formats. For example, you can easily convert HTML to PDF, HTML to JPG, HTML to XHTML, SVG to PDF, MHTML to PDF, MD to HTML, etc. Just select the file, choose the format to convert, and you’re done. It’s fast and completely free!
{{% /alert %}} 

<a href="https://products.aspose.app/html/conversion" target="_blank">![Text "Banner Free Online Converters"](./../../images/converters.png#center)</a>