---
title: Font Folder - How to Install using C#
linktitle: How to Set Font Folder
type: docs
weight: 70
url: /net/how-to-set-font-folder/
description: Learn and get a step-by-step guide on how to set font folder to render HTML to PDF or Image using the Aspose.HTML for .NET library.
keywords: font folder, add font, custom font, install font, how to set font folder, how to install font folder
lastmod: "2023-02-17"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

## **Custom Font - Why font is important**

Fonts play an important role in shaping the text's look, accessibility, aesthetic appeal, and emotional impact. Therefore, choosing the right font can be crucial for achieving specific goals, whether making a text more visually appealing, readable, or recognizable. In certain cases, you might desire to install custom fonts that you have designed, bought, or acquired from an external source. 

This article describes how to install font folders so that they can be used when rendering HTML documents.

## **Install Font - Add Custom Font Folder in C#**

Aspose.HTML for .NET is a powerful library for working with HTML documents. It allows developers to access and manipulate the HTML DOM in C# and other .NET languages. It also provides the ability to set font folder for rendering HTML documents to particular formats.

By default, Aspose.HTML for .NET looks for fonts installed in the system. Using the [FontsSettings](https://reference.aspose.com/html/net/aspose.html/fontssettings/) class sets the folders where Aspose.HTML looks for fonts when rendering documents.

The C# examples will demonstrate how to set font folder for rendering an HTML document to PDF and Image formats. We will consider the `SetFontsLookupFolder()` methods that are used in the Aspose.HTML for .NET library to specify a folder where custom fonts are located. But before you start:
1. Locate the custom font files that you want to use.
2. Create a folder where you will store the custom fonts.
3. Copy the custom fonts to the font folder.

### **Set Font Folder to Render HTML to PDF**

When rendering an HTML document to a PDF file, for example, it is important to ensure that the custom fonts used in the HTML document are available to the rendering engine. By default, Aspose.HTML looks for fonts in the system font folder. However, if you are using custom fonts, you will need to call the `SetFontsLookupFolder(fontsFolder)` method and tell it where to find them.

Here is an example of how to set a custom font to render an HTML document to PDF using Aspose.HTML C# library:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Services;
...

	// Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");

    // Create an instance of Configuration
    using (var configuration = new Configuration())
    {
        // Get the IUserAgentService 
        var service = configuration.GetService<IUserAgentService>();                

        // Set a custom font folder path
        service.FontsSettings.SetFontsLookupFolder(Path.Combine(DataDir + "fonts"));

        // Initialize an HTML document with specified configuration
        using (var document = new HTMLDocument(documentPath, configuration))
        {
            // Convert HTML to PDF
            Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "file-fontsetting.pdf"));
        }
    }
{{< /highlight >}}

Let's consider the C# example of how to set custom font folder. You should follow a few steps:

1. Create an instance of the [Configuration](https://reference.aspose.com/html/net/aspose.html/configuration/) class using [Configuration()](https://reference.aspose.com/html/net/aspose.html/configuration/configuration/) constructor.
2. Call the [GetService](https://reference.aspose.com/svg/net/aspose.svg/configuration/getservice/) method on the configuration object to retrieve an instance of the [IUserAgentService](https://reference.aspose.com/html/net/aspose.html.services/iuseragentservice/) interface.
3. Use the  [SetFontsLookupFolder(`fontsFolder`)](https://reference.aspose.com/html/net/aspose.html/fontssettings/setfontslookupfolder/) method of the [FontsSettings](https://reference.aspose.com/html/net/aspose.html/fontssettings/) class and pass a custom font folder path to it. This method allows the library to search for fonts in the specified folder when the PDF document is being generated. If any custom fonts are not located in this folder, they will not be available for use in the PDF document.
3. Initialize an HTML document with specified configuration using [HTMLDocument()](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_11) constructor.
4. Call the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/#converthtml_7) method for HTML to PDF conversion.

{{% alert color="primary" %}} 
You can download data files and complete C# examples that demonstrate how to set font folder from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)
{{% /alert %}} 

### **Set Font Folder to Render HTML to Image**

Let's consider C# example of how to use the Aspose.HTML for .NET library to convert an HTML document to an image format, while also setting a folder for custom fonts:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Services;
...
	// Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "file-output.png");

    // Create an instance of Configuration class
    using (var configuration = new Configuration())
    {
        // Get the IUserAgentService
        var service = configuration.GetService<IUserAgentService>();

        // Use the SetFontsLookupFolder() method to set a directory which will act as a new fontsFolder.
        // Pass "true" as the recursive parameter to use all nested directories. 
        service.FontsSettings.SetFontsLookupFolder(Path.Combine(DataDir + "font"), true);

        // Initialize the HTML document with specified configuration
        using (var document = new HTMLDocument(documentPath, configuration))
        {
            // Convert HTML to Image
            Converter.ConvertHTML(document, new ImageSaveOptions(), savePath);
        }
    }
{{< /highlight >}}

To render HTML to Image using custom fonts, you should follow a few steps:

1. Create the `configuration` object, and use the [GetService](https://reference.aspose.com/svg/net/aspose.svg/configuration/getservice/) method to get a reference to the [IUserAgentService](https://reference.aspose.com/html/net/aspose.html.services/iuseragentservice/) interface. 
2. Call the [SetFontsLookupFolder(`fontsFolder`, `recursive`)](https://reference.aspose.com/html/net/aspose.html/fontssettings/setfontslookupfolder/#setfontslookupfolder_1) method to set font folder. This method takes two parameters: the folder path where the fonts are located and a boolean value that specifies whether to include subfolders or not. By setting the `true` as the `recursive` parameter, the method includes all subfolders of the specified folder in the font lookup.
3. Initialize the HTML document with specified configuration.
4. Call the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/#converthtml_3) method to convert HTML to Image.

Thus, by setting the font folder using `SetFontsLookupFolder()` methods, the Aspose.HTML library will use the custom fonts located in the specified folder to render the HTML document to various output formats, such as PDF or images, ensuring that the documents are displayed as intended with the desired fonts.


{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks.
{{% /alert %}}