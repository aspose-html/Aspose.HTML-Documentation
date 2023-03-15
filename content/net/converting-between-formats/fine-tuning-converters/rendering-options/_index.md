---
title: Rendering Options | C#
linktitle: Rendering Options
type: docs
weight: 20
url: /net/fine-tuning-converters/rendering-options/
description: In this article, we describe in C# examples how to use rendering options to customize rendering HTML to PDF, XPS, DOCX, and Images.
keywords: rendering options, rendering process, background color c#,  page setup, page setup in word, page setup in pdf
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-03-18
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

Rendering Options gives you additional control over the rendering device. Every rendering device - [PdfDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/) [XpsDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.xps/xpsdevice/) [DocDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.doc/pdfdevice/) and [ImageDevice](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/) has its own unique set of options implemented with classes [PdfRenderingOptions,](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/) [XpsRenderingOptions,](https://reference.aspose.com/html/net/aspose.html.rendering.xps/xpsrenderingoptions/) [DocRenderingOptions,](https://reference.aspose.com/html/net/aspose.html.rendering.doc/docrenderingoptions/) and [ImageRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/) respectively. You can change the page size, configure margins and colors, set a security password in case of a PDF device, etc. Customizing rendering options is essential to achieve the desired output document. For example, you can reduce the file size by adjusting image quality and resolution or improve readability by setting page margins and text formatting.

{{% alert color="primary" %}}
In this article, we describe in C# examples how to use rendering options to customize the rendering process from HTML to PDF, XPS, DOCX, and Images.  A renderer device takes an options object as a parameter and represents an output document. To learn more, please read the [Rendering Device](/html/net/fine-tuning-converters/rendering-device/) article.
{{% /alert %}}

Following is a demonstration of how to use PdfRenderingOptions to customize the page size during render HTML to PDF:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Drawing;
...
  var code = @"<span>Hello World!!</span>";

            // Initialize an HTML document from the HTML code
            using var document = new HTMLDocument(code, ".");

            // Create the instance of PdfRenderingOptions and set a custom page size
            var options = new PdfRenderingOptions()
            {
                PageSetup =
                    {
                        AnyPage = new Page(new Size(Length.FromInches(4),Length.FromInches(2)))
                    }
            };                

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "file-with-custom-page-size.pdf");            

            // Create an instance of the PdfDevice and specify the options and output file to render
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);  
{{< /highlight >}}

## **General Options**

The [Aspose.Html.Rendering](https://reference.aspose.com/html/net/aspose.html.rendering/) namespace consists of numerous renderer objects as well as appropriate low level options classes which are responsible to render documents into [IDevice](https://reference.aspose.com/html/net/aspose.html.rendering/idevice/) implementation. The [RenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/) and [CssOptions](https://reference.aspose.com/html/net/aspose.html.rendering/cssoptions/) classes represent rendering options, or in other words, general rendering options. These options are valid for all rendering devices and all rendering processes from HTML to PDF, XPS, DOCX, and Images: 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [PageSetup](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) | This property gets a page setup object and uses it for configuration output page-set. |
| [Css](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/css/) | Gets a [CssOptions](https://reference.aspose.com/html/net/aspose.html.rendering/cssoptions/) object which is used for configuration of CSS properties processing. |
| [BackgroundColor](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/backgroundcolor/) | This property sets the color that will fill the background of every page. By default, this property is Transparent. |
| [HorizontalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/horizontalresolution/) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/verticalresolution/) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [MediaType](https://reference.aspose.com/html/net/aspose.html.rendering/cssoptions/mediatype/) |  Sets MediaType which will be used for media queries resolution during rendering. Default value is Print. |

### **Horizontal and Vertical Resolution**
In the following example, we will show how we can control the resolution of the resulting image file, ultimately affecting its size and quality:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Image;
...
  // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");            

            // Create an instance of HTML document
            using var document = new HTMLDocument(documentPath);

            // Prepare path to save output file 
            string savePath1 = Path.Combine(OutputDir, "output_resolution_50.png");
            string savePath2 = Path.Combine(OutputDir, "output_resolution_300.png");

            // Create options for low-resolution screens
                var options1 = new ImageRenderingOptions()
                {
                    HorizontalResolution = 50,
                    VerticalResolution = 50
                };

            // Create an instance of Image device
            using var device1 = new ImageDevice(options1, savePath1);

            // Render HTML to PNG
            document.RenderTo(device1);


            // Create options for high-resolution screens
            var options2 = new ImageRenderingOptions()
            {
                HorizontalResolution = 300,
                VerticalResolution = 300
            };

            // Create an instance of Image device
            using var device2 = new ImageDevice(options2, savePath2);

            // Render HTML to PNG
            document.RenderTo(device2);              
{{< /highlight >}}

The next picture shows the result of the rendering of [spring.html](https://docs.aspose.com/html/net/converting-between-formats/html-to-pdf/spring.html) file with 50 dpi and 300 dpi resolutions:

![Two images of the spring.html file rendered to PNG format at 50 and 300 dpi](render-html-to-png.png#center)

### **CSS Media Type**

{{%CSS%}} media-type is an important feature that specifies how a document is to be presented on different media: on the screen, on paper, with a braille device, etc. There are few ways to specify media-type for a style sheet, via linked style sheets or, via inlining:

**Linked Style Sheet**

{{< highlight html >}}
 <link rel="stylesheet" type="text/css" media="print" href="style.css">
{{< /highlight >}}

**Inline Style Sheet**

{{< highlight html >}}
<style type="text/css">
@media print {
  body{ color: #000000; }
}
</style>
{{< /highlight >}}

Aspose.HTML API supports this feature, so you can convert HTML documents as they look on screen or on print with applying the corresponded media types and style sheets. Following example shows how to set up the media type:

{{< highlight java >}}
// Create an option class
var options = new PdfRenderingOptions();

// Set the 'screen' media-type
options.Css.MediaType = MediaType.Screen;
{{< /highlight >}}

{{% alert color="primary" %}} 
Please note that the default value of the [CssOptions.MediaType](https://reference.aspose.com/html/net/aspose.html.rendering/cssoptions/mediatype/) is Print. It means that the document will be converting with applying style sheets related to the printing device and looks like on paper (you can use print preview of your browser to see the difference). If you want the document to look the way it is rendered on screen, you should use [MediaType.Screen.](https://reference.aspose.com/html/net/aspose.html.rendering/mediatype/)
{{% /alert %}} 

### **Background Color**

A property that specifies the background color of the output drawing surface.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
...
   // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "spring.pdf");

            // Create an instance of HTML document
            using var document = new HTMLDocument(documentPath);

            // Initialize options with 'cyan' as a background-color
            var options = new PdfRenderingOptions()
            {
                BackgroundColor = System.Drawing.Color.Azure
            };

            // Create an instance of PDF device
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device); 
{{< /highlight >}}

### **Page Setup**

The page setup is a set of parameters that determine the layout of a printed page. Those parameters include everything from the page size, margins, and auto-resizing to @page priority rules. Using this set of parameters, you can easily set up an individual layout for every page.

The next example demonstrates how to create PDF with different page sizes for the left and right pages.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Drawing;
...
  // Prepare HTML code
            var code = @"<style>div { page-break-after: always; }</style>
            <div>First Page</div>
            <div>Second Page</div>
            <div>Third Page</div>
            <div>Fourth Page</div>";

            // Initialize an HTML document from the HTML code
            using var document = new HTMLDocument(code, ".");

            // Create the instance of Rendering Options and set a custom page-size
            var options = new PdfRenderingOptions();
            options.PageSetup.SetLeftRightPage(
                new Page(new Size(400, 200)),
                new Page(new Size(400, 100))
            );

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output.pdf");

            // Create the PDF Device and specify options and output file
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);  
{{< /highlight >}}

In some cases, the content of the HTML page could be wider than the page-size defined with options. If you don’t want to cut off the page content, you can try the PageSetup.AdjustToWidestPage property. The following example shows how to adjust the page size to the content. 

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Drawing;
...
  // Prepare HTML code
            var code = @"<style>
                div { page-break-after: always; }
            </style>
            <div style='border: 1px solid red; width: 300px'>First Page</div>
            <div style='border: 1px solid red; width: 500px'>Second Page</div>
";
            // Initialize an HTML document from the HTML code
            using var document = new HTMLDocument(code, ".");

            // Create the instance of Rendering Options and set a custom page-size
            var options = new PdfRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(400, 200));

            // Enable auto-adjusting for the page size
            options.PageSetup.AdjustToWidestPage = true;

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output-custom-page-size.pdf");

            // Create the PDF Device and specify options and output file
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);  
{{< /highlight >}}

## **PDF Options**
Using a specialized [PdfRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/) object, you can configure permissions for the PDF file. The next example demonstrates this feature.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Rendering.Pdf.Encryption;
...
  // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "document.html");

            // Initialize the HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create the instance of Rendering Options
            var options = new PdfRenderingOptions();

            // Set the permissions to the file
            options.Encryption = new PdfEncryptionInfo(
                    "user_pwd",
                    "owner_pwd",
                    PdfPermissions.PrintDocument,
                    PdfEncryptionAlgorithm.RC4_128);

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output-options.pdf");

            // Create an instance of the PdfDevice and specify options and output file
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);
{{< /highlight >}}


## **Image Options**
[ImageRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/compression/) allows you to customize a wide range of setting from smoothing (antialiasing), image resolution, and formats to image compression.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Drawing;
using System.Drawing.Drawing2D;
...
  // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "color.html");

            // Initialize the HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of Rendering Options
            var options = new ImageRenderingOptions(ImageFormat.Jpeg)
            {
                // Disable smoothing mode
                SmoothingMode = SmoothingMode.None,

                // Set the image resolution as 75 dpi
                VerticalResolution = Resolution.FromDotsPerInch(75),
                HorizontalResolution = Resolution.FromDotsPerInch(75),
            };

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "color-options.jpg");

            // Create an instance of the ImageDevice and specify options and output file
            using var device = new ImageDevice(options, savePath);

            // Render HTML to JPG
            document.RenderTo(device);  
{{< /highlight >}}

Following example demonstrates how to change resolution and antialiasing for the resulted image.


## **XPS Options**

{{%XPS%}} files generated by our library do not have any specific parameters. All parameters of [XpsRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.xps/xpsrenderingoptions/) are inherited from the base [RenderingOptions ](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/)class and described [here](/html/net/converting-between-formats/fine-tuning-converters/#fine-tuningconverters-generaloptions).

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Xps;
...
  // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "document.html");

            // Initialize the HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of Rendering Options
            var options = new XpsRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(Length.FromInches(5), Length.FromInches(2)));

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "document-options.xps");

            // Create an instance of the XpsDevice and specify options and output file
            using var device = new XpsDevice(options, savePath);

            // Render HTML to XPS
            document.RenderTo(device);
{{< /highlight >}}

## **DOCX Options**

{{%XPS%}} files generated by our library do not have any specific parameters. All parameters of [XpsRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.xps/xpsrenderingoptions/) are inherited from the base [RenderingOptions ](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/)class and described [here](/html/net/converting-between-formats/fine-tuning-converters/#fine-tuningconverters-generaloptions).

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Doc;
...
  // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "document.html");

            // Initialize the HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of Rendering Options and set a custom page size
            var options = new DocRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(Length.FromInches(6), Length.FromInches(3)));


            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "document-options.docx");

            // Create an instance of the DocDevice and specify options and output file
            using var device = new DocDevice(options, savePath);

            // Render HTML to DOCX
            document.RenderTo(device);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete C# examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)

Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/conversion) that can convert HTML, XHTML, MHTML, EPUB, XML, and Markdown files to a range of popular formats. You can easily convert your HTML-based documents to PDF, XPS, DOCX, JPG, PNG, GIF, TIFF, and others. Just select the file, choose the format to convert, and you’re done. Best of all, it's completely free!
{{% /alert %}} 