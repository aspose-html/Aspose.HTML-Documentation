---
title: How to Change Text Color in HTML?
linktitle: How to Change Text Color
type: docs
weight: 10
description: In this article, we will use C# examples to show different ways to change text color in HTML.
keywords: how to change text color in html, how to change text color, html font color, change text color, html text color, c# examples, inline css, internal css
lastmod: "2022-03-28"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

In this article, we will use C# examples to show different ways to change text color in HTML using Aspose.HTML class library.

To change the text color on a web page is easy with the CSS color property. There are a few ways you can set this property value. You can use inline, internal or external CSS, and HTML color values may be specified as the standard English color names or with HEX, RGB, RGBA, HSL, and HSLA values.
In the examples below, we’ll use HEX and RGB color codes because they’re the most used.

 If you want to know more about RGB, RGBA,  HSL, HSLA and HEX color codes, please visit the [**HTML Color Codes**](https://docs.aspose.com/html/net/tutorial/html-colors/) article.

## **Change Text Color Using Inline CSS**

You can change text color inside an HTML tag using the `color` property of the `<style>` attribute. This is known as inline CSS. Inline CSS allows you to apply custom styling to one HTML element at a time. You set the CSS for an HTML element using the style attribute with any CSS properties defined within it. 

For example, in the following code snippet, you can see how to specify the CSS `color` property for HTML `<p>` element in the existing file.html file. Take a few steps:

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
    string documentPath = Path.Combine(DataDir, "file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Find the first paragraph element to set a style attribute
    var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();
    
    // Set the style attribute with color property
    paragraph.Style.Color = "#8B0000";
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}

As a result, the text of the first paragraph in the HTML file will be recolored to `#8B0000` DarkRed color (see figure a).

{{% alert color="primary" %}} 
You can download the complete examples and data files from <a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>.
{{% /alert %}}

## **Change Text Color Using Internal CSS**

The internal CSS is popular for applying style properties to individual pages. You can apply internal CSS stylesheets by placing the `<style>` element in the `<head>` section of a page. For example,  you want to change the color of all paragraphs on a web page. To do this, you should add `p {color: #8B0000; }` to the head section of an HTML file. Take a few steps:

1. Load an existing HTML file.
2. Create a `<style>` element and assign the text color value for all paragraph elements.  Use the [CreateElement(`localName`)](https://apireference.aspose.com/html/net/aspose.html.dom/document/methods/createelement) method of the [Element](https://apireference.aspose.com/html/net/aspose.html.dom/element) class that creates an element of the type specified.
3. Find the document `<head>` element and append `<style>` element to the head.
4. Save the modified HTML document.

{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare output path for HTML document saving
    string savePath = Path.Combine(OutputDir, "change-paragraph-color-internal-css.html");
    
    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "file.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Create a style element and assign the text color value for all paragraph elements
    var style = document.CreateElement("style");
    style.TextContent = "p { color:#8B0000 }";
    
    // Find the document head element and append style element to the head
    var head = document.GetElementsByTagName("head").First();
    head.AppendChild(style);          
    
    // Save the HTML document to a file
    document.Save(Path.Combine(savePath));
{{< /highlight >}}

{{% alert color="primary" %}} 
To change text color, you can use the C# examples considered in this article with HTML `<p>` , `<h1>` , or` <h2>` elements, etc. Keep in mind that using the style attribute (inline CSS) overrides any style specified in the HTML `<style>` tag or in an external style sheet. 
{{% /alert %}}

The figure illustrates the results of changing text color according to the usage of inline CSS example (a) and internal CSS example (b):

![Text "Two fragments of the HTML document with colored paragraph text"](change-text-color.png#center)

{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks.
{{% /alert %}}

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../../tutorial/html-web-apps.png#center)</a> 

