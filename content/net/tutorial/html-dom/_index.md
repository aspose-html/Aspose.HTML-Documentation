---
title: What is HTML DOM? - C# examples
linktitle: What is HTML DOM?
type: docs
weight: 10
description: 
keywords: html, document object model, dom, html file, html document, html dom, dom tree, dom node, html document tree, node tree
lastmod: "2023-01-16"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />
{{% alert color="primary" %}} 
With Aspose.HTML for .NET you can modify the document by inserting new nodes, removing, or editing the content of existing nodes. Please visit the [**Editing an HTML Document**](https://docs.aspose.com/html/net/working-with-documents/editing-a-document/) article that gives you basic information on how to read or modify the Document Object Model (DOM). You’ll explore how to create an HTML Element and how to work with it.
{{% /alert %}} 

## **Document Object Model**

The Document Object Model (DOM) is a standard cross-platform programming API for accessing and manipulating HTML and XML documents. It represents the structure of a document as a tree-like hierarchy of nodes, where each node represents a part of the document, such as an element, attribute, or piece of text. A DOM tree is an in-memory representation of a document. In other words, the Document Object Model creates a logical document structure and defines objects, properties, events and method for accessing and modifying them.


 ## **HTML DOM**

The HTML DOM is a programming interface that allows you to access and manipulate an HTML document's elements, attributes, and content. It provides a tree structure for the document, where each element is represented as a node in the tree. Each branch of the tree ends in a node, and each node contains objects. The HTML DOM is implemented as a standard by the World Wide Web Consortium (W3C) and is supported by all modern web browsers. It provides a consistent and standardized way to access, manipulate and manage HTML elements, making it an effective tool for creating dynamic and interactive web pages.

HTML DOM tree is created by the browser when it parses an HTML document and is used to access and manipulate the elements, attributes, and content of the document.

HTML DOM defines a set of standard methods that can be used to access and control all HTML elements. You can use these methods to perform various tasks, such as creating, modifying, and deleting elements, and managing their properties and events.

![Text "HTML document tree"](html-document-tree.png#center)

## **Why DOM is required?**

Let's point out a few aspects why DOM is needed:

1. DOM provides the ability to access and manipulate the content of an HTML or XML document, allowing you to create dynamic and interactive web pages that can update and change in response to user actions or other events.
2. DOM is a standard and is supported by all modern web browsers. This makes it a reliable and consistent way to access and manage web page content across browsers and platforms.
3. DOM allows search engines and other tools to understand the structure and content of a web page, which is essential when indexing and searching the page.
4. The DOM also allows accessibility tools to understand the web page and interact with it, making it accessible to people with disabilities.

Thus, The HTML DOM is a standard for how to get, change, add, or delete HTML elements. Moreover, the DOM allows web pages to be dynamic and interactive while making it possible for search engines and accessibility tools to understand and interact with them.

## **How to access HTML DOM using C#**

HTML DOM defines HTML elements as objects, providing a set of properties and methods that you can use to access and manage them. Each element in an HTML document is represented by a node in the DOM tree, and each node has its own set of properties and methods.

Aspose.HTML for .NET provides a set of classes and methods that allow you to access and manipulate the HTML DOM in C# and other .NET languages. You can use the [HtmlDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class to load and parse an HTML document. For example, you can use the following code to load an HTML file and access the `<body>` element of the document: 

{{< highlight java >}}
using Aspose.Html;
...

    using var document = new HTMLDocument(documentPath);
    var body = document.Body;
{{< /highlight >}}

Once you have a reference to an element, you can use, for example, the [InnerHtml](https://reference.aspose.com/html/net/aspose.html.dom/element/innerhtml/) property to get or set the inner HTML of the element.

{{< highlight java >}}
using Aspose.Html;
...

    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "document.html");

    // Prepare a path for edited file saving 
    string savePath = Path.Combine(OutputDir, "document-edited.html");

    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);

    // Write the content of the HTML document into the console output
    Console.WriteLine(document.DocumentElement.OuterHTML); // output: <html><head></head><body>Hello, World!</body></html>

    // Edit the content of the body element
    document.Body.InnerHTML = "<p>HTML is the standard markup language for Web pages.</p>";

    // Write the content of the HTML document into the console output
    Console.WriteLine(document.DocumentElement.OuterHTML); // output: <html><head></head><body><p>HTML is the standard markup language for Web pages.</p></body></html>

    // Save edited HTML document to a file
    document.Save(savePath);
{{< /highlight >}}

{{< highlight java >}}
using Aspose.Html;
...

    using var document = new HTMLDocument(documentPath);
    var body = document.Body;
{{< /highlight >}}


{{% alert color="primary" %}} 
Aspose.HTML offers free online [HTML Web Applications](https://products.aspose.app/html/applications) that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. Easily convert, merge, encode, generate HTML code, extract data from the web, or analyze web pages in terms of SEO wherever you are. Use our collection of HTML Web Applications to perform your daily matters and make your workflow seamlessly!
{{% /alert %}} 

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../html-web-apps.png#center)</a> 







