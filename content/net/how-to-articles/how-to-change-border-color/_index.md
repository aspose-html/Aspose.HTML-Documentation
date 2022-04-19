---
title: How to Change Border Color in HTML? C# Examples
linktitle: How to Change Border Color
type: docs
weight: 30
description: In this article, we will use C# examples to show different ways to change border color in HTML files using Aspose.HTML class library.
keywords: how to change border color in html, how to change border color, html border color, change border color, border color, table border color, html table border color, c# examples, inline css, internal css
lastmod: "2022-04-19"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

In this article, we will use C# examples to show different ways to set or change border color in HTML files using Aspose.HTML class library.

To set or change the border color for HTML element is easy with the CSS `border-color` property. There are a few ways you can set this property value. You can use inline, internal or external CSS, and HTML color values may be specified as the standard color names or with HEX, RGB, RGBA, HSL, and HSLA values.

{{% alert color="primary" %}} 
For more information on how to use HTML color codes, please visit the [**HTML Color Codes**](https://docs.aspose.com/html/net/tutorial/html-colors/) article.  In the [**Border Color**](/html/net/tutorial/working-with-html-color/#border-color) section, you find out HTML code examples of how to change the border color.
{{% /alert %}} 

## **Change Border Color Using Inline CSS** 
You can set or change the border color using inline `style` attribute - inline CSS. The `border-color` property will only work when the `border-style` property is defined first, which is used to set the borders. This property will not work alone. If this property is not set, it inherits the element’s colour. The `border-color` property accepts color names, RGB, RGBA, HEX, HSL, or HSLA values.
To change border color for HTML element using Aspose.HTML API you should follow a few steps:

1. Load an existing HTML file.
2. Create an instance of an HTML document.
3. Determine which element you want to change the border color for and find this element to set a style attribute for it. Use the [GetElementsByTagName(`name`)](https://apireference.aspose.com/html/net/aspose.html.dom/element/methods/getelementsbytagname) method of the [Element](https://apireference.aspose.com/html/net/aspose.html.dom/element) class that returns HTML element with a given tag name.
4. Set the `style` attribute with `border-style` and `border-color` properties:  use the [Style](https://apireference.aspose.com/html/net/aspose.html/htmlelement/properties/style) property of the [HTMLElement](https://apireference.aspose.com/html/net/aspose.html/htmlelement) class. 
5. Save the modified HTML document.

You can set or change border color for various HTML elements such as `<p>`,  `<h1>`…`<h6>`, `<div>` or `<table>`.  The following C# example shows the border color change for the `<h1>`element:

{{< highlight java >}}
using Aspose.Html;
using System.IO;
using System.Linq;
...

    // Prepare an output path for a document saving
    string savePath = Path.Combine(OutputDir, "change-border-color.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the h1 element to set a style attribute
    var header = (HTMLElement)document.GetElementsByTagName("h1").First();
    
    // Set style attribute properties
    header.Style.Color = "#8B0000";
    header.Style.BorderStyle = "solid";
    header.Style.BorderColor = "rgb(220,30,100)";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}
It should be noted that in this С# example, not only the border color for the `<h1>` element was changed, but also the text color for this element (the `color` property was added).

{{% alert color="primary" %}} 
You can download the complete examples and data files from <a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>.
{{% /alert %}}

## **Change Color for Four Sides of the Border**

The `border-color` property sets the color of the four borders of an element. If the `border-color` property has a single value, then the entire border will be painted with this color. But you can set different color values for the top, right, bottom, and left borders. For example, if you set the `border-color: red blue green gray`, the top border is red, the right border is blue, the bottom border is green and the left border is grey.

{{< highlight java >}}
using Aspose.Html;
using System.IO;
using System.Linq;
...

    // Prepare output path for document saving
    string savePath = Path.Combine(OutputDir, "change-four-border-color.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "change-border-color.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the h1 element to set a style attribute
    var header = (HTMLElement)document.GetElementsByTagName("h1").First();
    
    // Set style attribute properties
    header.Style.BorderStyle = "solid";
    header.Style.BorderColor = "red blue green gray";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}

The figure illustrates the results of changing border color for the `<h1>` element using inline CSS: a) changed color for entire border; b) changed color for each of the four sides of the border.

![Text "Rendered the change-border-color.html and change-four-border-color.html files with changed border color for the h1"](change-border-color.png#center)

## **Change Border Color Using Internal CSS**

The same border colorization result can be achieved using internal CSS, as shown in the following HTML code example:

```html
<head>
<style>
	h1 { 
	border-color: rgb(220,30,100);
	}
</style>
</head>
```
**Note:** Keep in mind, that the usage of a `style` attribute overrides any style set in the HTML `<style>` tag or external style sheet.

The next C# example demonstrates how to realize internal CSS to change border color. Take a few steps:

1. Load an existing HTML file.
2. Create an instance of an HTML document.
3. Create a `<style>` element and assign the `border-style` and `border-color` values for `<h1>` element.
4. Find the  `<head>` element  in your document and add the `<style>` element into it.
5. Save the modified HTML document.

{{< highlight java >}}
using Aspose.Html;
using System.IO;
using System.Linq;
...

    // Prepare an output path for a document saving
    string savePath = Path.Combine(OutputDir, "change-border-color-internal-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Create a style element and assign the color border-style and border-color values for h1 element
    var style = document.CreateElement("style");
    style.TextContent = "h1 { color:DarkRed; border-style:solid; border-color:rgb(220,30,100) }";
    
    // Find the document head element and append style element to the head
    var head = document.GetElementsByTagName("head").First();
    head.AppendChild(style);             
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}
The С# code execution that we have given above will result in the `<style>` element appearing in the `<head>` of the output file, which is illustrated by the following HTML code:
```html
<head>
<style>
	h1 { 
		color: darkred; 
		border-top-style: solid; 
		border-right-style: solid; 
		border-bottom-style: solid; 
		border-left-style: solid; 
		border-top-color: rgb(220, 30, 100); 
		border-right-color: rgb(220, 30, 100); 
		border-bottom-color: rgb(220, 30, 100); 
		border-left-color: rgb(220, 30, 100); }
</style>
</head>
```
The result is similar to the one shown in Figure (a) above.
{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks.
{{% /alert %}}

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../../tutorial/html-web-apps.png#center)</a> 

