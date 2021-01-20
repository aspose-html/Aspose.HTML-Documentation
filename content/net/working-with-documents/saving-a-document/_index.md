---
title: Saving an HTML Document
type: docs
weight: 40
url: /net/saving-a-document/
description: Save Options, Save HTML, HTML to File, HTML to MHTML, HTML to Markdown, Save SVG
---

 After downloading an existing file or creating an HTML document from scratch, you can save the changes using one of the **HTMLDocument.Save ()** methods. There are overloaded methods to save a document to a file or a URL. The API provides **[Aspose.Html.Saving Namespace](https://apireference.aspose.com/html/net/aspose.html.saving)** with the [**SaveOptions**](https://apireference.aspose.com/net/html/aspose.html.saving/saveoptions)  and **[ResourceHandlingOptions](https://apireference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions)** classes that allow you to set options for saving operations.

{{% alert color="primary" %}} 

Please note that we have two different concepts for creating the output files. The first conception is based on producing the HTML like files as output; the [**SaveOptions**](https://apireference.aspose.com/net/html/aspose.html.saving/saveoptions) as a base class for this approach helps to handle the saving process of related resources such as scripts, styles, images, etc. The second concept could be used to creating a visual representation of HTML as a result. The base class for this conception is [**RenderingOptions**](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions); it has specialized methods to specify the page size, page-margins, resolution, user-styles, etc. This article only describes how to use [**SaveOptions**](https://apireference.aspose.com/net/html/aspose.html.saving/saveoptions). To read more about the rendering mechanism, please follow this page.

{{% /alert %}} 
##  **SaveOptions & ResourceHandlingOptions** 
The [**SaveOptions**](https://apireference.aspose.com/net/html/aspose.html.saving/saveoptions) is a base class that allows you  to specify additional options for saving operations and helps to manage the linked resources.  The **ResourceHandlingOptions property**  of the **SaveOptions** class gets a ResourceHandlingOptions object which is used for configuration of resources handling. The **[ResourceHandlingOptions](https://apireference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions)** class represents resource handling options and the list of available ones are demonstrated in the following table:

|**Option**|**Description**|
| :- | :- |
|[UrlRestriction](https://apireference.aspose.com/net/html/aspose.html.saving/resourcehandlingoptions/properties/urlrestriction)|Applies restrictions to the host or folders where resources are located.|
|[MaxHandlingDepth](https://apireference.aspose.com/net/html/aspose.html.saving/resourcehandlingoptions/properties/maxhandlingdepth)|If you need to save not the only specified HTML document, but also the linked HTML pages, this option gives you the ability to control the depth of the linked pages that should be saved.|
|[JavaScript](https://apireference.aspose.com/net/html/aspose.html.saving/resourcehandlingoptions/properties/javascript)|This option specifies how do we need to treat the JavaScript files: it could be saved as a separated linked file, embed into HTML file or even be ignored.|
|[Default](https://apireference.aspose.com/net/html/aspose.html.saving/resourcehandlingoptions/properties/default)|This options specifies behavior for other than JavaScript files. |

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  
## **Save HTML**
Once you have finished your changes as it is described here, you may want to save the document. You can do it using one of the **Save()** methods of the [**HTMLDocument**](https://apireference.aspose.com/html/net/aspose.html/htmldocument) class. The following example is the easiest way to save an HTML file:
{{< highlight java >}}
using System.IO;
using Aspose.Html;
...
    // Prepare an output path for a document saving
	string documentPath = Path.Combine(OutputDir, "save-to-file.html");    

    // Initialize an empty HTML document
    using (var document = new HTMLDocument())
    {
        // Create a text node and add it to the document
        var text = document.CreateTextNode("Hello World!");
        document.Body.AppendChild(text);
    
        // Save the HTML document to the file on a disk
        document.Save(documentPath);
    }
{{< /highlight >}}

In the example above, we use the **HTMLDocument()** method for initializing an empty HTML document. The **CreateTextNode(`data`)** method of the [**HTMLDocument**](https://apireference.aspose.com/html/net/aspose.html/htmldocument) class  creates a text node given the specified string. The **Save( `path`)** method saves the document to a local file specified by path.

The sample above is quite simple. However, in real-life applications, you often need additional control over the saving process. The next few sections describe how to use resource handling options or save you document to the different formats.

### **HTML to File**
The following code snippet shows how to use [**ResourceHandlingOptions**](https://apireference.aspose.com/net/html/aspose.html.saving/saveoptions/properties/resourcehandlingoptions) property of the  [**SaveOptions**](https://apireference.aspose.com/net/html/aspose.html.saving/saveoptions) class to manage linked to your document files.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Saving;
...
    // Prepare an output path for a document
    string documentPath = Path.Combine(OutputDir, "save-with-linked-file.html");

    // Prepare a simple HTML file with a linked document
    File.WriteAllText(documentPath, "<p>Hello World!</p>" +
                                    "<a href='linked.html'>linked file</a>");
    // Prepare a simple linked HTML file
    File.WriteAllText("linked.html", "<p>Hello linked file!</p>");
    
    // Load the "save-with-linked-file.html" into memory
    using (var document = new HTMLDocument(documentPath))
    {
        // Create a save options instance
        var options = new HTMLSaveOptions();
    
        // The following line with value '0' cuts off all other linked HTML-files while saving this instance
        // If you remove this line or change value to the '1', the 'linked.html' file will be saved as well to the output folder
        options.ResourceHandlingOptions.MaxHandlingDepth = 1;
    
        // Save the document with the save options
        document.Save(Path.Combine(OutputDir, "save-with-linked-file_out.html"), options);
    }
{{< /highlight >}}

### **HTML to MHTML**
In some cases, you need to save your web page as a single file.  {{%MHTML%}} document could be handy and helpful for this purpose since it is a web-page archive and it is store everything inside itself.
The **HTMLSaveFormat** Enumeration specifies the format in which document is saved, it can be HTML, MHTML and MD formats. The example below shows how to use the **Save(`path`,`saveFormat`)** method for HTML to MYTML saving.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Saving;
...
    // Prepare an output path for a document saving
    string documentPath = Path.Combine(OutputDir, "save-to-MTHML.mht");

    // Prepare a simple HTML file with a linked document
    File.WriteAllText("document.html", "<p>Hello World!</p>" +
                                       "<a href='linked-file.html'>linked file</a>");
    // Prepare a simple linked HTML file
    File.WriteAllText("linked-file.html", "<p>Hello linked file!</p>");
    
    // Load the "document.html" into memory
    using (var document = new HTMLDocument("document.html"))
    {
        // Save the document to MHTML format
        document.Save(documentPath, HTMLSaveFormat.MHTML);
    
    }
{{< /highlight >}}

The saved "save-to-MTHML.mht" file stores HTML of the "document.html" and "linked-file.html" files.

### **HTML to Markdown**
{{%Markdown%}} is a markup language with plain-text syntax. As well as for HTML to MHTML example, you can use the **HTMLSaveFormat** for HTML to MD saving. Please take a look at the following example:
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Saving;
...
    // Prepare an output path for a document saving
    string documentPath = Path.Combine(OutputDir, "save-to-MD.md");

    // Prepare HTML code
    var html_code = "<H2>Hello World!</H2>";
    
    // Initialize a document from the string variable
    using (var document = new HTMLDocument(html_code, "."))
    {
        // Save the document as a Markdown file
        document.Save(documentPath, HTMLSaveFormat.Markdown);
    }
{{< /highlight >}}

For the more information how to use Markdown Converter, please visit the [**HTML to Markdown Conversion**](/html/net/html-to-markdown-conversion/) article.
## **Save SVG**
Usually, you could see  {{%SVG%}}  as a part of an HTML file, it is used to represent the vector data on the page: images, icons, tables, etc. However, SVG also could be extracted from the web page and you can manipulate it in a similar way as the HTML document.

Since [**SVGDocument**](https://apireference.aspose.com/net/html/aspose.html.dom.svg/svgdocument) and [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument) are based on the same [WHATWG DOM](https://dom.spec.whatwg.org/) standard, all operations such as loading, reading, editing, converting and saving are similar for both documents. So, all examples where you can see manipulation with the **HTMLDocument** are applicable for the **SVGDocument** as well.

To save your changes, please use follows:
{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Dom.Svg;
...
    // Prepare an output path for an SVG document saving
    string documentPath = Path.Combine(OutputDir, "save-to-SVG.svg");

    // Prepare SVG code
    var code = @"
        <svg xmlns='http://www.w3.org/2000/svg' height='200' width='300'>
            <g fill='none' stroke-width= '10' stroke-dasharray='30 10'>
                <path stroke='red' d='M 25 40 l 215 0' />
                <path stroke='black' d='M 35 80 l 215 0' />
                <path stroke='blue' d='M 45 120 l 215 0' />
            </g>
        </svg>";
    
    // Initialize an SVG instance from the content string
    using (var document = new SVGDocument(code, "."))
    {
        // Save the SVG file to a disk
        document.Save(documentPath);
    }
{{< /highlight >}}

For more information about SVG Basics Drawing and and the API usage for the processing and rendering of SVG documents, see the [**Aspose.SVG for .NET Documentation**](https://docs.aspose.com/svg/net/).
{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  



