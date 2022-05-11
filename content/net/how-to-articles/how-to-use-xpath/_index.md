---
title: How to use XPath - Evaluate() method 
linktitle: How to use XPath in HTML
type: docs
weight: 50
description: This article introduces how to use Evaluate() method to navigate through the HTML document and select nodes by XPath Query. You will learn, how to select all photos from an HTML document using XPath expressions.
keywords: xpath, xpath query, Evaluate(), Evaluate() method, how to use xpath, xpath expressions, xpath expression examples, c# code, html document, javascript code
lastmod: "2022-05-01"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

## **XPath**

XPath (XML Path Language) provides a flexible way of pointing to different parts of an XML-based document using a non-XML syntax. The name of the XPath derives from the path expression, which provides a means of hierarchic addressing of the nodes in a document tree. XPath is a query language, with lots of possibilities. XPath allows the processing of values conforming to the DOM data model;  it is based on a DOM representation of the HTML document and selects nodes by various criteria. XPath expressions can also be used in C and C++, JavaScript, XML Schema, PHP, Python,  and many other languages.

XPath is primarily used to navigate the DOM of an XML-based language document using XPath expressions. You can use XPath in HTML and SVG instead of relying on the [GetElement()](https://apireference.aspose.com/html/net/aspose.html.dom/document/methods/createelement) or [QuerySelectorAll()](https://apireference.aspose.com/html/net/aspose.html.dom/document/methods/queryselectorall)  methods and other DOM functions.

This article introduces how to use [Evaluate()](https://apireference.aspose.com/html/net/aspose.html.dom.xpath/ixpathevaluator/methods/evaluate) method to navigate through the HTML document and select nodes by XPath Query. You will learn, how to select all photos from an HTML document using XPath expressions.

{{% alert color="primary" %}} 

You can download the data files and complete C# examples that demonstrate the use of the Evaluate() method for XPath Queries from <a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>.

{{% /alert %}} 

## **Evaluate() method**

XPath queries are mainly made using the [Document](https://apireference.aspose.com/html/net/aspose.html.dom/document) class's [Evaluate()](https://apireference.aspose.com/html/net/aspose.html.dom/document/methods/evaluate) method. The Evaluate(`expression`, `contextNode`, `resolver`, `type`, `result`) method accepts an XPath expression and other given parameters and returns a result of the specified type:

- `expression` is a string representation of the XPath to be evaluated.
- `contextNode` specifies the context node for the evaluation of the XPath expression. It's common to pass the document as the context node.
- `resolver` permits the translation of all prefixes, including the xml namespace prefix, within the XPath expression into appropriate namespace URIs.
- `type` corresponds to the type of result XPathResult to return. If a specific type is specified, then the result will be returned as the corresponding type.
- `result` specifies a specific result object which may be reused and returned by this method. null is the most common and will create a new XPathResult.

## **XPath Query - Get images from a web page**

Often you want to save a large number of images from different services, such as photos from a particular album. It's possible to do it by hand, but it would take a considerable amount of time. Thus, it is long and inefficient, so you can use Aspose.HTML library to automate this process.

In this example, you will learn how to find links to all desired images on a web page using Evaluate() method and XPath expression. XPath is a powerful query language that gives you a lot of freedom to customize queries. Let's take a look at the HTML document [xpath-image.htm](/html/net/how-to-articles/how-to-use-xpath/xpath-image.htm). It consists of a header and footer containing advertising images, as well as the main element that contains rows of photos interspersed with advertising banners.

### **Get links to all images in the document**
Let's start with a straightforward XPath Query for all the images in the document. The following uses the XPath expression `//img`.  It selects all `img` elements no matter where they are in the document:

**XPath Expression**

```html
//img
```
**C# code**

{{< highlight java >}}
var result = doc.Evaluate("//img", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
{{< /highlight >}}

**JavaScript code**

{{< highlight java >}}
var result = document.evaluate("//img", document, null, XPathResult.ANY_TYPE, null);
{{< /highlight >}}

This XPath Query will return all links to images (photos, banners) from the header and footer, as well as those that are between the rows of photos and among them.

### **Get rid of banners in the header and footer**
First, let's get rid of the banners in the header and footer, there are many ways to do this, but in this example, we will set the filtering by a parent. The XPath query `//main//img` returns all nested `//img` elements inside all `//main` elements. This result is already better suited for the request to get photos from the document but still contains extra banners.

**XPath Expression**
```html
//main//img
```
**C# code**
{{< highlight java >}}
var result = doc.Evaluate("//main//img", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
{{< /highlight >}}

**JavaScript code**

{{< highlight java >}}
var result = document.evaluate("//main//img", document, null, XPathResult.ANY_TYPE, null);
{{< /highlight >}}

### **Get rid of some banners in the "main" container**
In the next step let's get rid of banners in the even `/div` children of the `main` container. This XPath expression lets you select all `/div` child elements whose position number will give the remainder when divided by 2, i.e. odd:

**XPath Expression**
```html
//main/div[position() mod 2 = 1]//img
```
**C# code**
{{< highlight java >}}
var result = doc.Evaluate("//main/div[position() mod 2 = 1]//img", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
{{< /highlight >}}

**JavaScript code**

{{< highlight java >}}
var result = document.evaluate("//main/div[position() mod 2 = 1]//img", document, null, XPathResult.ANY_TYPE, null);
{{< /highlight >}}

So, we got a list containing links to photos and banners ads located in all odd `div` elements that are children of the `main` container.



### **Get only links to photos from the HTML document**

To get rid of banner ads located among photos, the XPath expression must include the name of the image class because all the photos in the rows have the corresponding class `photo`:

**XPath Expression**

```html
//main/div[position() mod 2 = 1]//img[@class = 'photo']
```
**C# code**
{{< highlight java >}}
var result = doc.Evaluate("//main/div[position() mod 2 = 1]//img[@class = 'photo']", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
{{< /highlight >}}

**JavaScript code**

{{< highlight java >}}
var result = document.evaluate("//main/div[position() mod 2 = 1]//img[@class = 'photo']", document, null, XPathResult.ANY_TYPE, null);
{{< /highlight >}}

As a result, we got a list containing only links to photos. So the only thing left to do is download them.

## **C# Example - Get only links to photos from the HTML document**

Let's consider the C# example of how to use Evaluate() method to select all photos from an HTML document using XPath expressions. You should follow a few steps:

1. Load an existing HTML file ( [xpath-image.htm](/html/net/how-to-articles/how-to-use-xpath/xpath-image.htm)).
2. Use the  [Evaluate()](https://apireference.aspose.com/html/net/aspose.html.dom/document/methods/evaluate) method of the [Document](https://apireference.aspose.com/html/net/aspose.html.dom/document) class and pass XPath expression and other parameters to it.
3. Iterate over the resulted nodes and print them to the console.
4. You will get a list containing only links to photos from the HTML document.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Dom;
using Aspose.Html.Dom.XPath;
using System.IO;
...	

	// Create an instance of an HTML document
	using (var doc = new HTMLDocument(Path.Combine(DataDir, "xpath.htm")))
	{
	    // Evaluate the XPath expression
		var result = doc.Evaluate("//main/div[position() mod 2 = 1]//img[@class = 'photo']", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
	    
		// Iterate over the resulted nodes and print them to the console
		Node node;
	    while ((node = result.IterateNext()) != null)
	    {
	        var img = (HTMLImageElement)node;
	        Console.WriteLine(img.Src);
	    }       
	}        
{{< /highlight >}}



{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks.
{{% /alert %}}

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../../tutorial/html-web-apps.png#center)</a> 

