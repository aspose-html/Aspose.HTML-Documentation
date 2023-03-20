---
title: How To Use XPath To Select XML Nodes - C# 
linktitle: How To Use XPath To Select XML Nodes
type: docs
weight: 60
description: You will learn how to navigate through an XML document and select nodes using XPath. The article considers С# examples of selecting the required information from an XML file using XPath queries.
keywords: xpath xml, xpath query, Evaluate() method, xpath expressions, c# code, javascript code, xml file, xml document, descendant, select nodes, xpath axes
lastmod: "2022-04-28"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

XPath (XML Path Language) is based on a DOM representation of an XML document. Therefore, you can use XPath to find a specific node or nodes in an XML file that match some criteria defined in the XPath expression. The article considers С# examples of selecting the required information from an XML file using XPath queries. You will learn how to navigate through an XML document and select nodes using XPath.

{{% alert color="primary" %}} 

To learn how to use the Evaluate() method to navigate an HTML document and select nodes using an XPath query, please see the article [**How to use the XPath - Evaluate() method**](https://docs.aspose.com/html/net/how-to-articles/how-to-use-xpath/).

You can download the data files and complete C# examples that demonstrate the use of the Evaluate() method for XPath Queries from <a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>.

{{% /alert %}} 

## **XPath Query - Select Nodes from XML file**

These examples will show how to select the required information from an XML file using the XPath query language. Let’s take a look at the XML document  [cars.xml](/html/net/how-to-articles/how-to-use-xpath-to-select-xml-nodes/cars.xml).  This test XML document contains a database of car dealers, their phone numbers, names, and a list of the cars they own. 

Let's sequentially compose XPath expressions that will select names, phone numbers and a list of cars of interest to you. XPath is powerful, as you will see in the following examples:

### **Select all "Dealer" nodes in the XML file**
XPath is used programmatically to evaluate expressions and pick specific nodes in an XML document. To select nodes from XML, use the  [Evaluate()](https://reference.aspose.com/html/net/aspose.html.dom/document/evaluate/) method. 

Let's start with a straightforward XPath Query for all "Dealer" nodes in the XML document. The following uses the XPath expression `//Dealer`.  It selects all `Dealer` elements no matter where they are in the document:

**C# code**

{{< highlight java >}}
var dealers = doc.Evaluate("//Dealer", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
{{< /highlight >}}

**JavaScript code**

{{< highlight java >}}

var dealers = document.evaluate("//Dealer", document, null, XPathResult.ANY_TYPE, null);
{{< /highlight >}}

So, you select information about all dealers from the XML file without any restrictions. XPath expression `//Dealer` allows you to pick all nested nodes named "Dealer". 

### **Select Nodes using XPath Axes - `descendant::`**
#### **XPath Query with Limits on Car Production Date**

Let's complicate the XPath query and add a restriction on the year of car production. 

You can use XPath Axes in XPath expressions. XPath Axes represents a relationship to the current node and is used to locate nodes relative to that node on the document tree. The `descendant` axis indicates all of the children of the context node, all of their children, and so forth. In other words, the descendant selects all descendants (children, grandchildren, etc.) of the current node. For example, `descendant::Car`  selects all Car descendants of the current node.

So, let's create an XPath expression to find the dealers that have a car `descendant::Car` with a model's date of manufacture newer than 2005 `descendant::Model > 2005`.   In terms of the DOM tree, we are looking for all "Dealer" children named "Car" that have a child named "Model" that has a value bigger than "2005". The following uses the XPath expression `//Dealer[descendant::Car[descendant::Model > 2005]]`.

**C# code**
{{< highlight java >}}
var dealers = doc.Evaluate("//Dealer[descendant::Car[descendant::Model > 2005]]", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
{{< /highlight >}}

**JavaScript code**

{{< highlight java >}}
var dealers = document.evaluate("//Dealer[descendant::Car[descendant::Model > 2005]]", document, null, XPathResult.ANY_TYPE, null);
{{< /highlight >}}
#### **XPath Query with Limits on Car Production Date and Price**
In the next step let's add **more restrictions**:  introduce a restriction on the price of the car `and descendant::Price < 25000`. 

XPath expression is following `//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]`. **Note:** the conditions for price and year of manufacture are combined with `and`, which means that both of these conditions be performed at the same time:

**C# code**
{{< highlight java >}}
var dealers = doc.Evaluate("//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
{{< /highlight >}}

**JavaScript code**

{{< highlight java >}}
var dealers = document.evaluate("//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]", document, null, XPathResult.ANY_TYPE, null);
{{< /highlight >}}

As a result, only dealers will be selected if they have a car with a manufacture date no older than 2005 and a price of less than 25,000.

## **C# Example, part 1 - Select Nodes from XML file**

Let's consider how to select dealers from an XML file that have a car with a manufacture date no older than 2005 and a price of less than 25,000, and print the required information to the console. You should follow a few steps:

1. Load an existing XML file ([cars.xml](/html/net/how-to-articles/how-to-use-xpath-to-select-xml-nodes/cars.xml)).
2. Use the  [Evaluate()](https://reference.aspose.com/html/net/aspose.html.dom/document/evaluate/) method of the [Document](https://reference.aspose.com/html/net/aspose.html.dom/document/) class and pass XPath expression  `//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]`and other parameters to it.
3. Iterate over the resulted nodes and print their contents to the console.
4. You will get a list of dealers with the entire content of the "Dealer" nodes.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Dom;
using Aspose.Html.Dom.XPath;
using System.IO;
...	

	// Create an instance of a document
	using (var doc = new HTMLDocument(Path.Combine(DataDir, "cars.xml")))
	{
	    // Evaluate the XPath expression
		var dealers = doc.Evaluate("//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);    
	    Node dealer;
	
	        // Iterate over the resulted nodes and print their contents to the console
	        while ((dealer = dealers.IterateNext()) != null)
	        {
	            Output.WriteLine(dealer.TextContent);
	        } 
	}       
{{< /highlight >}}

## **C# Example, part 2 - Pick Specific Information from Selected Nodes**

In the previous part of the example, the XPath query selects all the contents of the "Dealer" node that matched the XPath expression `//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]`. But you can choose and print only the information you are interested in from the entire contents of the selected "Dealer".

In this example ([cars.xml](/html/net/how-to-articles/how-to-use-xpath-to-select-xml-nodes/cars.xml)), an internal query was added within the loop to the selected "Dealer" nodes. The query collects as a string the information about the dealer such as the "Name" and "Telephone": `concat('Dealer name: ', Name, 'Telephone: ', Telephone)"`. Pay attention to the second parameter passed to the [Evaluate(`expression`, `contextNode`, `resolver`, `type`, `result`)](https://reference.aspose.com/html/net/aspose.html.dom/document/evaluate/) method. This is the node relative to which the query will be executed - the current "Dealer" node. This query concatenates content from nodes with the names "Name" and "Telephone". **Note:** the query uses the expected result type of the string `XPathResultType.String`, and the result value is obtained through the `StringValue` property and not through the node iterator.

To the list of the selected dealers, you can add the "CarID" attribute, which points to a specific car. A query should be made with the XPath expression `.//Car[descendant::Model > 2005 and descendant::Price < 25000]/@CarID`. There are several features in the added query; let's look at them:

-  the query selects all nested cars relative to the current node `.//Car`, not relative to the tree root `//Car`; 
- in XPath expression, we request the `/@CarID` attribute we are interested in for selected cars.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Dom;
using Aspose.Html.Dom.XPath;
using System.IO;
...	

	// Create an instance of a document
	using (var doc = new HTMLDocument(Path.Combine(DataDir, "cars.xml")))
	{
	    // Select dealers that match XPath expression
	    var dealers = doc.Evaluate("//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
	    Node dealer;
	
	    // Iterate over the selected dealers
	    while ((dealer = dealers.IterateNext()) != null)
	    {
	        // Get and print Dealer name and Telephone
	        var dealerInfo = doc.Evaluate("concat('Dealer name: ', Name, ' Telephone: ', Telephone)", dealer, doc.CreateNSResolver(doc), XPathResultType.String, null);
	        Console.WriteLine(dealerInfo.StringValue);
	
	        // Select and print CarID that match XPath expression
	        var carIds = doc.Evaluate(".//Car[descendant::Model > 2005 and descendant::Price < 25000]/@CarID", dealer, doc.CreateNSResolver(doc), XPathResultType.Any, null);
	        Node carId;
	
	        while ((carId = carIds.IterateNext()) != null)
	        {
	            Console.WriteLine("Car id: " + carId.TextContent);
	        }
	    }
	}
{{< /highlight >}}

As a result, we get a list of dealers with Names, Telephones and  ID codes of the cars that interest us.

{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools, and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks.
{{% /alert %}}

<a href="https://products.aspose.app/html/applications" target="_blank">![Text "Banner HTML Web Applications"](../../tutorial/html-web-apps.png#center)</a> 

