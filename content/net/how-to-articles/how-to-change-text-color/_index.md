---
title: How to Change Text Color in HTML?
linktitle: How to Change Text Color
type: docs
weight: 10
description: In this article, we will use C# examples to show different ways to change text color in HTML.
keywords: how to change text color in html, how to change text color, html font color, change text color, html text color, c# examples
lastmod: "2022-03-28"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

In this article, we will use C# examples to show different ways to change text color in HTML using Aspose.HTML class library.

To change the text color on a web page is easy with the CSS color property. There are a few ways you can set this property value. You can use inline, internal or external CSS, and HTML color values may be specified as the standard English color names or with HEX, RGB, RGBA, HSL, and HSLA values.
In the examples below, we’ll use HEX and RGB color codes because they’re the most used.

 If you want to know more about RGB, RGBA,  HSL, HSLA and HEX color codes, please visit the [**HTML Color Codes**](https://docs.aspose.com/html/net/tutorial/html-colors/) article.

## **Change Text Color Using Inline CSS**

You can change text color inside an HTML tag using the `color` property of the `<style>` attribute. This is known as inline CSS. Inline CSS allows you to apply custom styling to one HTML element at a time. You set the CSS for an HTML element using the style attribute with any CSS properties defined within it. 

For example, in the following code snippet, you can see how to specify the CSS `color` property for HTML `<p>` element in the existing html_file.html file. Take a few steps:

1. Load an existing HTML file.
2. Find, for example, the first paragraph element to set a style attribute.  Use the [GetElementsByTagName(`name`)](https://apireference.aspose.com/html/net/aspose.html.dom/element/methods/getelementsbytagname) method of the [Element](https://apireference.aspose.com/html/net/aspose.html.dom/element) class that returns the first element with a given tag name in document order.
3. Use the [Style](https://apireference.aspose.com/html/net/aspose.html/htmlelement/properties/style) property of the [HTMLElement](https://apireference.aspose.com/html/net/aspose.html/htmlelement) class to set the `style` attribute with `color` property.
4. Save the modified HTML document.

{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare output path for HTML document saving
    string savePath = Path.Combine(OutputDir, "change-paragraph-color-inline-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "html_file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the first paragraph element to set a style attribute
    var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();
    
    // Set the style attribute with color property
    paragraph.Style.Color = "DarkRed";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}



## **Change Text Color Using Internal CSS**


{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare output path for HTML document saving
    string savePath = Path.Combine(OutputDir, "change-paragraph-color-inline-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "html_file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the first paragraph element to set a style attribute
    var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();
    
    // Set the style attribute with color property
    paragraph.Style.Color = "DarkRed";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}


{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare output path for HTML document saving
    string savePath = Path.Combine(OutputDir, "change-paragraph-color-inline-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "html_file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the first paragraph element to set a style attribute
    var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();
    
    // Set the style attribute with color property
    paragraph.Style.Color = "DarkRed";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}


{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare output path for HTML document saving
    string savePath = Path.Combine(OutputDir, "change-paragraph-color-inline-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "html_file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the first paragraph element to set a style attribute
    var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();
    
    // Set the style attribute with color property
    paragraph.Style.Color = "DarkRed";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}


{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks.
{{% /alert %}}

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../tutorial/html-web-apps.png#center)</a> 

