---
title: What is HTML DOM? - C# Parsing
linktitle: What is HTML DOM?
type: docs
weight: 10
description: You will find information about an HTML DOM and learn how to access and manipulate a DOM tree using the Aspose.HTML C# library.
keywords: html, document object model, dom, html file, html document, html dom, dom tree, dom node, html document tree, node tree
lastmod: "2023-03-13"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}}
[Aspose.HTML for .NET](https://products.aspose.com/html/net/) is a .NET library that allows you to access and manipulate the HTML DOM in C# and other .NET languages. It provides classes and methods that enable you to load and parse HTML documents, navigate the DOM tree, and access and modify document elements, attributes, and content.

Please visit the [**Editing an HTML Document**](https://docs.aspose.com/html/net/working-with-documents/editing-a-document/) article that gives you basic information on how to read or modify the Document Object Model (DOM). You’ll explore how to create an HTML Element and how to work with it using Aspose.HTML for .NET API.
{{% /alert %}} 

## **Document Object Model**

The Document Object Model, or DOM for short, is a standard cross-platform programming API that helps programmers access and modify parts of a document. DOM defines the structure of a document as a tree with a hierarchy of nodes, where each node represents a part of the document, such as an element, class, tag,  attribute, or text. For example, each piece, such as an image or piece of text, is called a "node." A DOM tree is how or with what structure a document is represented in memory. In other words, the Document Object Model creates a logical document structure and defines objects, properties, events, and methods to access and modify them.

 ## **HTML DOM**

The HTML DOM is an API for representing an HTML document that allows you to access and manipulate the content of an HTML document. It provides a tree structure of the document, where each element is represented as a tree node. Each branch of the tree ends with a node, and each node contains objects. The HTML DOM is implemented as a standard by the World Wide Web Consortium (W3C) and is supported by all modern web browsers. It provides a consistent and standardized way to access and manipulate HTML elements, making it an effective tool for creating dynamic and interactive web pages.

The HTML DOM is a document model loaded in the browser and representing the document as a node tree, where each node represents part of the document, such as an element, text string, or comment. We describe the elements in the tree in the same way as would a family tree - there are ancestors, descendants, parents, and children. For example, an HTML document with the following structure (fig. 1) will be represented by a DOM tree with a `document` object at the top, child nodes for the `<html>` element, a child node for the `<head>` element, and so on.

```html
<html>
    <head>
        <title>HTML document tree</title>
    </head>
    <body>
        <h1>HTML DOM</h1>
        <p>HTML DOM is a programming interface for HTML documents.</p>
    </body>
</html>
```

![Text "HTML document tree"](html-document-tree.png#center)

## **Why DOM is required?**

Let's point out a few aspects of why DOM is needed:

 - First, DOM is standard and supported by all modern web browsers. This makes it a reliable way to access and manage web page content across browsers and platforms.
 - DOM provides manipulation of HTML document content. Each DOM tree object defines methods, properties, and events to access and modify. In this way, developers can create dynamic and interactive web pages that can update and change in response to user actions or other events.
 - DOM allows search engines and other tools to understand the structure and content of a web page, which is essential when indexing and searching the page.
 - The DOM allows accessibility tools to understand and interact with the web page, making it accessible to people with disabilities, which is very important.
 - And finally, the DOM determines events based on user actions, such as clicking, mouse movements, and sending forms, and provides a way to manipulate elements in response to events.

Thus, The HTML DOM is a standard for how to get, change, add, or delete HTML elements. Moreover, the DOM allows web pages to be dynamic and interactive while making it possible for search engines and accessibility tools to understand and interact with them.

## **Accessing HTML DOM using C#**

HTML DOM defines HTML elements as **objects**, providing a set of **properties** and **methods** that you can use to access and manage them. Each element in an HTML document is represented by a node in the DOM tree, and each node has its own set of properties and methods. As an object-oriented representation of a web page, it can be modified using [Aspose.HTML C# library.](https://products.aspose.com/html/net/)

### **How HTML DOM defines HTML elements as objects?**

Aspose.HTML for .NET provides a set of classes and methods that allow you to access and manipulate the HTML DOM in C#. You can use the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class to load and parse an HTML document. For example, you can use the following code to load an HTML file and access the `<body>` element of the document: 

{{< highlight java >}}
using Aspose.Html;
...

    using var document = new HTMLDocument(documentPath);
    var body = document.Body;
{{< /highlight >}}

### **DOM properties**

Let's look at a C# example of how to use the `HTMLDocument` class to access the DOM and modify the content of an HTML file. In the following C# example, the `document.Body.InnerHTML` property is used to access the `<body>` element. It represents the content of the document's `<body>` element, and you can use the [InnerHtml](https://reference.aspose.com/html/net/aspose.html.dom/element/innerhtml/) property, for example, to get or set the element's inner HTML.

{{< highlight java >}}
using Aspose.Html;
using System.IO;
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

    // Save the edited HTML file
    document.Save(savePath);
{{< /highlight >}}

 In the C# example above, we take the following steps:
 - We declare variables `documentPath` and `savePath` that set the path to a source and final HTML file.
 - Then we create an instance of the `HTMLDocument` class using the `HTMLDocument(documentPath)` constructor and open the document for editing.
 - We use the `WriteLine()` method to output the [OuterHTML](https://reference.aspose.com/html/net/aspose.html.dom/element/outerhtml/) of `DocumentElement` property, which represents the `<html>` element.
 - We assign a new string value to the `document.Body.InnerHTML` property, which represents the content of the `<body>` element.
 - Then we output the `OuterHTML` property after the change, using the `WriteLine()` method.
 - Finally, we save the edited HTML file by calling the [Save(savePath)](https://reference.aspose.com/html/net/aspose.html/htmldocument/save/#save_10) method.

### **DOM methods**

HTML DOM defines a set of methods that can be used to access and control all HTML elements. You can use these methods to perform various tasks, such as creating, modifying, and deleting elements, and managing their properties and events. For example, the most commonly used methods are:
 - the [Document](https://reference.aspose.com/html/net/aspose.html.dom/document/) class provides such methods as [GetElementById()](https://reference.aspose.com/html/net/aspose.html.dom/document/getelementbyid/), [GetElementsByTagName()](https://reference.aspose.com/html/net/aspose.html.dom/document/getelementsbytagname/), [CreateElement()](https://reference.aspose.com/html/net/aspose.html.dom/document/createelement/), [CreateTextNode()](https://reference.aspose.com/html/net/aspose.html.dom/document/createtextnode/), and [more](https://reference.aspose.com/html/net/aspose.html.dom/document/#methods).
 - the [Element](https://reference.aspose.com/html/net/aspose.html.dom/element/) class provides methods [SetAttribute()](https://reference.aspose.com/html/net/aspose.html.dom/element/setattribute/), [GetAttribute()](https://reference.aspose.com/html/net/aspose.html.dom/element/getattribute/), [QuerySelector()](https://reference.aspose.com/html/net/aspose.html.dom/element/queryselector/), [Remove()](https://reference.aspose.com/html/net/aspose.html.dom/element/remove/), and [more](https://reference.aspose.com/html/net/aspose.html.dom/element/#methods).
 - the [Node](https://reference.aspose.com/html/net/aspose.html.dom/node/) class provides methods [AppendChild()](https://reference.aspose.com/html/net/aspose.html.dom/node/appendchild/), [InsertBefore()](https://reference.aspose.com/html/net/aspose.html.dom/node/insertbefore/), [RemoveChild()](https://reference.aspose.com/html/net/aspose.html.dom/node/removechild/), etc. 


Let's look at the C# example that demonstrates how to use the `HTMLDocument` class to create new elements and text nodes, and how to use the `AppendChild()` method to add them to HTML document.

{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

    // Prepare a path for edited file saving 
    string savePath = Path.Combine(OutputDir, "dom.html");

    // Initialize an empty HTML document
    using var document = new HTMLDocument();

    // Declare a variable body that references the <body> element
    var body = document.Body;
    
    // Create an <h1> element with text content
    var h1 = document.CreateElement("h1");
    var text1 = document.CreateTextNode("HTML DOM");
    h1.AppendChild(text1);

    // Create a <p> element with text content
    var p = document.CreateElement("p");            
    var text2 = document.CreateTextNode("HTML Document Object Model is a programming interface for HTML documents.");
    p.AppendChild(text2);

    // Add new elements into <body>
    body.AppendChild(h1);
    body.AppendChild(p);

    // Save the document to a file
    document.Save(savePath);
{{< /highlight >}}

The [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class provides the main entry point for working with the DOM, it allows you to load and parse HTML documents and access nodes of the DOM tree. In the example, we used the `HTMLDocument` class to create a new HTML document, and the `CreateElement()` and `CreateTextNode()` methods of the `HTMLDocument` class to create new elements and text nodes.

{{% alert color="primary" %}} 
Aspose.HTML offers free online [HTML Web Applications](https://products.aspose.app/html/applications) that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. Easily convert, merge, encode, generate HTML code, extract data from the web, or analyze web pages in terms of SEO wherever you are. Use our collection of HTML Web Applications to perform your daily matters and make your workflow seamlessly!
{{% /alert %}} 

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../html-web-apps.png#center)</a> 







