---
title: How to Change Background Color in HTML? C# Examples
linktitle: How to Change Background Color
type: docs
weight: 20
description: In this article, we will use C# examples to show different ways to change background color in HTML files using Aspose.HTML class library.
keywords: how to change background color in html, how to change background color, html background color, change background color, c# examples, inline css, internal css
lastmod: "2022-03-28"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

In this article, we will use C# examples to show different ways to change background color in HTML files using Aspose.HTML class library.

To change the background color on a web page is easy with the CSS background-color property. There are a few ways you can set this property value. You can use inline, internal or external CSS, and HTML color values may be specified as the standard color names or with HEX, RGB, RGBA, HSL, and HSLA values. In the examples below, we’ll use HEX and RGB color codes because they’re the most used.

{{% alert color="primary" %}} 
For more information on how to use HTML color codes, please visit the [**HTML Color Codes**](https://docs.aspose.com/html/net/tutorial/html-colors/) article.  In the [**Background Color**](/html/net/tutorial/working-with-html-color/#background-color) section, you find out HTML code examples of how to change the background color.
{{% /alert %}} 

## **Change Background Color of Specific Element** 

To change background color for HTML element using Aspose.HTML API you should follow a few steps:

1. Load an existing HTML file.
2. Determine which element you want to change the background color for and find this element to set a style attribute for it. Use the [GetElementsByTagName(`name`)](https://apireference.aspose.com/html/net/aspose.html.dom/element/methods/getelementsbytagname) method of the [Element](https://apireference.aspose.com/html/net/aspose.html.dom/element) class that returns HTML element with a given tag name.
3. Set the `style` attribute with `background-color` property:  use the [Style](https://apireference.aspose.com/html/net/aspose.html/htmlelement/properties/style) property of the [HTMLElement](https://apireference.aspose.com/html/net/aspose.html/htmlelement) class. 
4. Save the modified HTML document.

You can set or change background color for various HTML elements such as `<p>`,  `<h1>`…`<h6>`, `<div>` or `<table>`.  The following C# example shows the background color change for the first `<p>`element:

{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare output path for document saving
    string savePath = Path.Combine(OutputDir, "change-background-color-p-inline-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the paragraph element to set a style attribute
    var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();
    
    // Set the style attribute with background-color property
    paragraph.Style.BackgroundColor = "#e5f3fd";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}

The figure illustrates the results of changing background color for the first paragraph in the HTML file using inline CSS:

![Text "Rendered the change-background-color-p-inline-css.html with changed background color for the first paragraph"](change-background-color-p.png#center)

## **Change Background Color of the Entire Web Page** 

You can change the background color using inline `style` attribute or using internal CSS.

### **Change Background Color Using Inline CSS**

If you want to change the color of the entire HTML document, you should use the `background-color` property of the `style` attribute in the opening tag of the `<body>` section. 

{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare output path for document saving
    string savePath = Path.Combine(OutputDir, "change-background-color-inline-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the body element to set a style attribute
    var body = (HTMLElement)document.GetElementsByTagName("body").First();
    
    // Set the style attribute with background-color property
    body.Style.BackgroundColor = "#e5f3fd";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from <a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>.
{{% /alert %}}

### **Change Background Color Using Internal CSS**

The same background colorization result can be achieved using internal CSS, as shown in the following HTML code example:

```html
<head>
<style>
	body { 
	background-color: rgb(229, 243, 253);
	}
</style>
</head>
```
**Note:** Keep in mind, that the usage of a `style` attribute overrides any style set in the HTML `<style>` tag or external style sheet.

The next C# example demonstrates how to realize internal CSS to change background color for a whole HTML file. Take a few steps:

1. Load an existing HTML file.
2. Find the `<body>` element and remove the `background-color` property from the `style` attribute. **Note:** If the background color is set using inline `style` attribute, this step  is required because using the `style` attribute overrides both internal and external CSS.
3. Create a `<style>` element and assign the `background-color` value for `<body>` element.
4. Find the  `<head>` element  in your document and add the `<style>` element into it.
5. Save the modified HTML document.

{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare output path for document saving
    string savePath = Path.Combine(OutputDir, "change-background-color-internal-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the body element
    var body = (HTMLElement)document.GetElementsByTagName("body").First();
    
    // Remove the background-color property from the style attribute
    body.Style.RemoveProperty("background-color");
    
    // Create a style element and assign the background-color value for body element
    var style = document.CreateElement("style");
    style.TextContent = "body { background-color: rgb(229, 243, 253) }";
    
    // Find the document head element and append style element to the head
    var head = document.GetElementsByTagName("head").First();
    head.AppendChild(style);
    
    // Save the HTML document
    document.Save(Path.Combine(savePath));
{{< /highlight >}}

The figure shows two fragments of the HTML file before (a) and after (b) changing the background color for the entire document:

![Text "Two fragments of the HTML document before and after changing the background color."](change-background-color.png#center)


{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks.
{{% /alert %}}

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../../tutorial/html-web-apps.png#center)</a> 

