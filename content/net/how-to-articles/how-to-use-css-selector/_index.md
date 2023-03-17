---
title: How to use CSS Selector - QuerySelector, QuerySelectorAll
linktitle: How to use CSS Selector
type: docs
weight: 40
description: Learn how to effectively apply selectors to select the elements you want to style using QuerySelector() and QuerySelectorAll() methods.
keywords: css selector, query selector, queryselector, query selector all, document query selector, how to use css selector, c# examples, JavaScript querySelector(), JavaScript querySelectorAll()
lastmod: "2023-03-11"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

CSS selectors are used to select the HTML elements you want to style and apply a set of CSS rules. Moreover, you can navigate an HTML document using CSS Selectors and extract information about selected elements or edit them.  CSS Selectors are used to declare which of the markup elements a style applies to, a kind of match expression. Aspose.HTML API allows you to create a search pattern to match elements in a document tree based on CSS Selectors syntax.

In this article, discover how to effectively apply selectors to select the elements you want to style using [QuerySelector(`selector`)](https://reference.aspose.com/html/net/aspose.html.dom/document/queryselector/) and [QuerySelectorAll(`selector`)](https://reference.aspose.com/html/net/aspose.html.dom/document/queryselectorall/) methods of the [Document](https://reference.aspose.com/html/net/aspose.html.dom/document/) class.  Methods allow you to quickly and easily retrieve element nodes from the DOM by matching against selectors. You can select elements by class, id or name, or any complex CSS selector.

{{% alert color="primary" %}} 
For more information on how to effectively apply selectors to select the elements you want to style, please visit the article [**CSS Selectors**](/html/net/tutorial/css-selectors/). You will cover Basic Selectors, Combinator Selectors, Attribute Selectors, Group Selectors and Pseudo Selectors.

You can download the complete examples and data files from <a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>.

{{% /alert %}} 

## **QuerySelector() to Navigate HTML**

The  [QuerySelector()](https://reference.aspose.com/html/net/aspose.html.dom/document/queryselector/) method is used to query a DOM element that matchs a CSS selector. It returns the first element in the document that matches the specified selector. If no matches are found, null is returned. In the following example we use CSS Element Selector to find the first paragraph element and output its contents to the Console:

### **C# Example**

{{< highlight java >}}
using Aspose.Html;
using System.IO;
...	

    // Prepare path to source HTML file
    string documentPath = Path.Combine(DataDir, "queryselector.html");
    
    // Create an instance of an HTML document
    var document = new HTMLDocument(documentPath);
    
    // Here we create a CSS Selector that extracts the first paragraph element in the document
    var element = document.QuerySelector("p");
    
    // Print content of the first paragraph  
    Console.WriteLine(element.InnerHTML);
    // output: The QuerySelector() method returns the first element in the document that matches the specified selector.
    
    // Set style attribute with properties for the selected element               
    element.SetAttribute("style", "color:rgb(50,150,200); background-color:#e1f0fe;");
    
    // Save the HTML document to a file
    document.Save(Path.Combine(OutputDir, "queryselector-p.html"))    
{{< /highlight >}}

Moreover, in the C# example, the text color and background color were changed for the selected element. The next HTML code example includes JavaScript that uses querySelector("p") method:

### **JavaScript querySelector()**
```html
<html>
<head>
</head>
	<body>
		<h1>QuerySelector() Method</h1>
		<p>The QuerySelector() method returns the first element in the document that matches the specified selector.</p>
		<p>CSS Selectors are used to declare which of the markup elements a style applies to, a kind of match expression.</p>
	</body>
	<script> 	
		// Create a CSS Selector that selects the first paragraph element
        var element = document.querySelector("p");

        // Set style attribute with properties for the selected element               
        element.setAttribute("style", "color:rgb(50,150,200); background-color:#e1f0fe");		
	</script>
</html>
```

## **QuerySelector() to Style Selected Element**

The [QuerySelector()](https://reference.aspose.com/html/net/aspose.html.dom/document/queryselector/) method accepts selector to determine what an element should be returned and returns the first matching element in the node's subtree. If no matching node is found, null is returned. In the following C# example, QuerySelector() method takes as a parameter `div:last-child` selector that means to select  `<div>` element that is the last child of its parent. **Note**: The QuerySelector() method returns the **first** element that matches the selector.
### **C# Example**

{{< highlight java >}}

using Aspose.Html;
using System.IO;
...

	// Prepare output path for HTML document saving
	string savePath = Path.Combine(OutputDir, "css-celector-style.html");
	
	// Prepare path to source HTML file
	string documentPath = Path.Combine(DataDir, "nature.html");
	
	// Create an instance of an HTML document
	var document = new HTMLDocument(documentPath);
	
	// Create a CSS Selector that selects <div> element that is the last child of its parent
	var element = document.QuerySelector("div:last-child");
	                    
	// Set style attribute with properties for the selected element               
	element.SetAttribute("style", "color:rgb(50,150,200); background-color:#e1f0fe; text-align:center");   
	
	// Save the HTML document to a file
	document.Save(Path.Combine(savePath));
{{< /highlight >}}

### **JavaScript querySelector()**
```html
<script> 	
	// Create a CSS Selector that selects <div> element that is the 2-d child of its parent
	var element = document.querySelector("div:nth-child(2)");

	// Set style attribute with properties for the selected element               
	element.setAttribute("style", "color:rgb(50,150,200); background-color:#e1f0fe; text-align:center");		
</script>
```

Let's look at the result of using the QuerySelector() method to restyle the `<div>` element that matches the selector:  a) an image of original HTML document; b) the image of the HTML document after changing the style.

![Text "Two images of the nature.html document before and after changes in style."](queryselector.png#center)

## **QuerySelectorAll() to Style Selected Elements**

If you want a list of all elements that match the specified selectors, you should use the QuerySelectorAll() method.

In the following example, we use the [QuerySelectorAll()](https://reference.aspose.com/html/net/aspose.html.dom/document/queryselectorall/) method for navigation through an HTML document and searching for the needed elements. This method takes as a parameter the query selector and returns a NodeList of all the elements, which match the specified selector. We select all elements whose 'class' attribute equals 'square2' and recolor them:
### **C# Example**

{{< highlight java >}}
using Aspose.Html;
using System.IO;
...

	// Prepare output path for HTML document saving
	string savePath = Path.Combine(OutputDir, "css-selector-color.html");
	
	// Prepare path to source HTML file
	string documentPath = Path.Combine(DataDir, "spring.html");
	
	// Create an instance of an HTML document
	var document = new HTMLDocument(documentPath);
	
	// Here we create a CSS Selector that extracts all elements whose 'class' attribute equals 'square2'
	var elements = document.QuerySelectorAll(".square2");
	
	// Iterate over the resulted list of elements
	foreach (HTMLElement element in elements)
	{
	    // Set style attribute with new background-color property
	    element.Style.BackgroundColor = "#b0d7fb";
	}
	
	// Save the HTML document to a file
	document.Save(Path.Combine(savePath));
{{< /highlight >}}

### **JavaScript querySelectorAll()**
```html
<script> 	
	// Create a CSS Selector that extracts all elements whose 'class' attribute equals 'square2'
	var elements = document.querySelectorAll(".square2");

	// Iterate over the resulted list of elements and set style background-color property
	for(var i = 0; i < elements.length; i++){
	document.querySelectorAll(".square2")[i].style.backgroundColor = "#b0d7fb";
	}		
</script>
```

All elements with `class="square2"` were recolored. The figure shows the result of applying the QuerySelectorAll() method (b) to the source file "spring.html" (a):

![Text "Two images of the spring.html document before and after changes in style."](css-selector.png#center)  

{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools, and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks.
{{% /alert %}}

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../../tutorial/html-web-apps.png#center)</a> 

