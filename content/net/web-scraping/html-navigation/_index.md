---
title: HTML Navigation | C#
linktitle: HTML Navigation
type: docs
weight: 10
aliases: /net/html-navigation/
description: In this article, you find the description of how to perform a detailed inspection of the HTML document and its elements using the API, about custom filters usage for iterating over the document elements, how to navigate over the document by using CSS Selector or XPath.
keywords: HTML navigation, DOM, XPath, XPath Query, CSS selector, custom filter, C# example
lastmod: "2022-01-11"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

Using *Aspose.HTML* class library, you can easily create your own application, since our API provides a powerful toolset to analyze and collect information from HTML documents.

This article provides information on how to programmatically extract data from HTML documents with the Aspose.HTML API. You find out:
 - how to  navigate through an HTML document and  perform a detailed inspection of its elements using the API;
 - about custom filters usage for iterating over the document elements;
 - how to navigate over the document by using CSS Selector or XPath Query.

## **HTML navigation**

{{% alert color="primary" %}}

The Aspose.HtmlDom (Document Object Model) namespace provides API that represents and interacts with any HTML, XML or SVG documents and is entirely based on the [WHATWG DOM](https://dom.spec.whatwg.org/) specification supported in many modern browsers. The DOM is a document model loaded in the browser and representing the document as a node tree, where each node represents part of the document (e.g. an element, text string, or comment).

{{% /alert %}}  

We consider how the DOM represents an HTML document in memory and how to use API for navigation through HTML files. Many ways can be used to make HTML navigation. The following shortlist shows the simplest way to access all DOM elements:

|**Property**|**Description**|
| :- | :- |
|[FirstChild](https://reference.aspose.com/html/net/aspose.html.dom/node/properties/firstchild)|Accessing this property of an element must return a reference to the first child node.|
|[LastChild](https://reference.aspose.com/html/net/aspose.html.dom/node/properties/lastchild)|Accessing this property of an element must return a reference to the last child node|
|[NextSibling](https://reference.aspose.com/html/net/aspose.html.dom/node/properties/nextsibling)|Accessing this property of an element must return a reference to the sibling node of that element which most immediately follows that element.|
|[PreviousSibling](https://reference.aspose.com/html/net/aspose.html.dom/node/properties/previoussibling)|Accessing this property of an element must return a reference to the sibling node of that element which most immediately precedes that element.|
|[ChildNodes](https://reference.aspose.com/html/net/aspose.html.dom/node/properties/childnodes)|Returns a [list](https://reference.aspose.com/html/net/aspose.html.collections/nodelist) that contains all children of that element.|

Four of the [Node](https://reference.aspose.com/html/net/aspose.html.dom/node)  class properties - FirstChild, LastChild, NextSibling, and PreviousSibling, each provides a live reference to another element with the defined relationship to the current element if the related element exists. For a complete list of classes and methods represented in the Aspose.Html.Dom Namespace, please visit [API Reference Source](https://reference.aspose.com/html/net/aspose.html.dom).

Using the mentioned properties, you can navigate through an HTML document as it follows:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-WebScraping-NavigateThroughHTML.cs" >}}

### **Inspection of the HTML Document and its Elements**

Aspose.HTML contains a list of methods that are based on the [Element Traversal Specifications](https://www.w3.org/TR/ElementTraversal/). You can perform a detailed inspection of the document and its elements using the API. The following code sample shows the generalized usage of Element Traversal features.

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-HtmlNavigation-InspectionOfTheHtmlDocument.cs" >}}
**Note:** You need to specify the path to the source HTML file in **your local file system** (`documentPath`).

The [DocumentElement](https://reference.aspose.com/html/net/aspose.html.dom/document/properties/documentelement) property of the Document class gives direct access to the `<html>` element of the document ([html_file.html](https://docs.aspose.com/html/net/web-scraping/html-navigation/html_file.html)). The LastElementChild property of the Document class returns the last child element of the `<html>` element. It is the `<body>` element. According to the code snippet above, the variable "element" is overloaded again, and the FirstElementChild property returns the first child of the `<body>` element. It is the `<h1>` element.

### **Custom Filter Usage**

For the more complicated scenarios, when you need to find a node based on a specific pattern (e.g., get the list of headers, links, etc.), you can use a specialized [TreeWalker](https://reference.aspose.com/html/net/aspose.html.dom.document/createtreewalker/methods/2) or [NodeIterator](https://reference.aspose.com/html/net/aspose.html.dom.document/createnodeiterator/methods/2) object with a custom [Filter](https://reference.aspose.com/html/net/aspose.html.dom.traversal.filters/nodefilter) implementation.

The following example shows how to implement your own [NodeFilter](https://reference.aspose.com/html/net/aspose.html.dom.traversal.filters/nodefilter) to skip all elements except images:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-WebScraping-OnlyImageFilter.cs" >}}

Once you implement a filter, you can use HTML navigation as it follows:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-WebScraping-NodeFilterUsageExample.cs" >}}

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [<a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}  

## **XPath  Query**
The alternative to the *HTML Navigation* is XPath Query ( [XML Path Language](https://www.w3.org/TR/xpath20/)) that often referred to simply as an XPath. It is a query language that can be used to query data from HTML documents. It is based on a DOM representation of the HTML document, and selects nodes by various criteria. The syntax of the XPath expressions is quite simple, and what is more important, it is easy to read and support. 

The following example shows how to use XPath queries within Aspose.HTML API:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-WebScraping-XPathQueryUsageExample.cs" >}}

## **CSS Selector**
Along with *HTML Navigation* and *XPath*, you can use [CSS Selector API](http://www.w3.org/TR/selectors-4/) that is also supported by our library. This API is designed to create a search pattern to match elements in a document tree based on [CSS Selectors](https://www.w3.org/TR/selectors-3/#selectors) syntax.

In the following example, we use the [QuerySelectorAll()](https://reference.aspose.com/html/net/aspose.html.dom/document/methods/queryselectorall) method for navigation through an HTML document and search the needed elements. This method takes as a parameter the query selector and returns a NodeList of all the elements, which match the specified selector.

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-WebScraping-CSSSelectorUsageExample.cs" >}}

{{% alert color="primary" %}} 

You can download the complete C# examples and data files from [<a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

Aspose.HTML offers free online [**Data Scrapers**](https://products.aspose.app/html/data-scrapers) Apps that are a way to get data from websites. Using our web extracting tools, you're able to get data from the Internet in seconds. Our Apps are safe, work on any platform and do not require any software installation. 
{{% /alert %}}  

<a href="https://products.aspose.app/html/data-scrapers" target="_blank">![Text "Banner Data Scrapers"](./../data-scrapers.png#center)</a> 



