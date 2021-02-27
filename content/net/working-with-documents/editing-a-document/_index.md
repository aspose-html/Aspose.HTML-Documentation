---
title: Editing an HTML Document
type: docs
weight: 30
aliases: /net/editing-a-document/
description: Document Object Model, DOM Tree, Edit HTML, Edit a Document Tree, Using InnerHTML & OuterHTML properties, Edit CSS, Inline CSS, Internal CSS, External CSS
---
<link href="./../style.css" rel="stylesheet" type="text/css" />

As we already mentioned [here](https://docs.aspose.com/html/net/creating-a-document/) the implementation of the [**HTMLDocument**](https://apireference.aspose.com/net/html/aspose.html/htmldocument) as well as the whole DOM are based on [WHATWG DOM](https://dom.spec.whatwg.org/) standard. So, it is easy to use Aspose.HTML having a basic knowledge of {{%HTML%}} and {{%JavaScript%}} languages.
{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}} 

## **DOM namespace**

A DOM tree is an in-memory representation of a document. The DOM is an API for accessing and manipulating documents content. HTML documents consist of a tree that contains several kinds of nodes whose root is a **[Document](https://apireference.aspose.com/html/net/aspose.html.dom/document)**. The [**DOM namespace**](https://apireference.aspose.com/net/html/aspose.html.dom/) is represented with the following fundamental data types:

|**Data type** |**Description**|
| :- | :- |
|[Document](https://apireference.aspose.com/net/html/aspose.html.dom/document)|The Document class represents the entire HTML, XML or SVG document. Conceptually, it is the root of the document tree and provides the primary access to the document's data.|
|[EventTarget](https://apireference.aspose.com/net/html/aspose.html.dom/eventtarget)|The EventTarget class is implemented by all Nodes in an implementation that supports the *DOM Event Model*. An EventTarget object represents a target to which an event can be dispatched when something has occurred.|
|[Node](https://apireference.aspose.com/net/html/aspose.html.dom/node)|The Node class is the primary datatype for the entire *Document Object Model*. It represents a single node in the document tree.|
|[Element](https://apireference.aspose.com/net/html/aspose.html.dom/element)|The element type is based on node and represents a base class for *HTML*, *XML* or *SVG DOM.*|
|[Attr](https://apireference.aspose.com/net/html/aspose.html.dom/attr)|The Attr class represents an attribute in an Element object. Typically the allowable values for the attribute are defined in a schema associated with the document.|

The following is a brief list of useful API methods provides by the core data types:

|**Method** |**Description**|
| :- | :- |
|[Document.GetElementById(`elementId`)](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/getelementbyid) |The method, when invoked, must return the first element whose ID is elementId and null if there is no such element otherwise.|
|[Document.GetElementsByTagName(`tagname`) ](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/getelementsbytagname)|The method must return the list of elements with the given name.|
|[Document.CreateElement(`localname`)](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/createelement)|The method creates an element of the type specified, or an  [HTMLUnknownElement](https://apireference.aspose.com/net/html/aspose.html/htmlunknownelement) if tagname isn't recognized.|
|[Node.AppendChild(`node`)](https://apireference.aspose.com/net/html/aspose.html.dom/node/methods/appendchild)|The method adds a node to the end of the list of children of a specified parent node.|
|[Element.SetAttribute(`name, value`)](https://apireference.aspose.com/net/html/aspose.html.dom/element/methods/setattribute)|Sets the value of an attribute on the specified element.|
|[Element.GetAttribute(`name`)](https://apireference.aspose.com/net/html/aspose.html.dom/element/methods/getattribute)|The method returns the value of a specified attribute on the element.|
|[Element.innerHTML](https://apireference.aspose.com/net/html/aspose.html.dom/element/properties/innerhtml) |The property returns a fragment of markup contained within the element.|

For a complete list of interfaces and methods represented in the DOM namespace please visit [**API Reference Source**](https://apireference.aspose.com/net/html/aspose.html.dom/).
## **Edit HTML**
There are many ways you can edit HTML by using our library. You can modify the document by inserting new nodes, removing, or editing the content of existing nodes. If you need to create a new node, the following methods are ones that need to be invoked:

|**Method** |**Description** |
| :- | :- |
|[Document.CreateCDATASection(`data`)](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/createcdatasection) |Creates a CDATASection node whose value is the specified string. |
|[Document.CreateComment(`data`)](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/createcomment) |Creates a Comment node given the specified string. |
|[Document.CreateDocumentFragment()](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/createdocumentfragment) |Creates an empty DocumentFragment object. |
|[Document.CreateElement(`localname`)](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/createelement) |Creates an element of the type specified. |
|[Document.CreateEntityReference(`name`)](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/createentityreference) |Creates an EntityReference object. |
|[Document.CreateProcessingInstruction(`target, data`)](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/createprocessinginstruction) |Creates an ProcessingInstruction with the specified name and data. |
|[Document.CreateTextNode(`data`)](https://apireference.aspose.com/net/html/aspose.html.dom/document/methods/createtextnode) |Creates a Text node given the specified string. |


Once you have new nodes are created, there are several methods in the DOM that can help you to insert nodes into the document tree. The following list describes the most common way of inserting nodes: 

|**Method** |**Description** |
| :- | :- |
|[Node.InsertBefore(`node, child`)](https://apireference.aspose.com/net/html/aspose.html.dom/node/methods/insertbefore) |Inserts the node before the reference *child* node.|
|[Node.AppendChild(`node`)](https://apireference.aspose.com/net/html/aspose.html.dom/node/methods/appendchild) |Adds the node to the list of children of the current node. |
|[Node.RemoveChild(`child`)](https://apireference.aspose.com/net/html/aspose.html.dom/node/methods/removechild) | Removes the child node from the list of children. |
|[Element.Remove()](https://apireference.aspose.com/net/html/aspose.html.dom/node/methods/removechild) | Removes this instance from the HTML DOM tree. |

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  

### **Edit a Document Tree**

HTML documents consist of a tree of elements. Each element is denoted in the source by a start tag, such as `<body>`, and an end tag, such as `</body>`. Elements can have attributes, which control how the elements work. Aspose.HTML API supports a set of HTML elements that are defined in HTML Standard, along with rules about how the elements can be nested. 

Consider simple steps to create and edit HTML. The document will contain a  text  paragraph with an *id* attribute:

 - Create an instance of an HTML document.
 - Create a paragraph element.
 - Set *id* attribute for the paragraph element.
 - Create a text node.
 - Add the text to the paragraph.
 - Add the paragraph to the document body.
 - Save the HTML document to a file.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
...
    // Create an instance of an HTML document
    using (var document = new HTMLDocument())
    {
        var body = document.Body;

        // Create a paragraph element
        var p = (HTMLParagraphElement)document.CreateElement("p");
    
        // Set a custom attribute
        p.SetAttribute("id", "my-paragraph");
    
        // Create a text node
        var text = document.CreateTextNode("my first paragraph");
    
        // Add the text to the paragraph
        p.AppendChild(text);
    
        // Attach paragraph to the document body 
        body.AppendChild(p);
    
        // Save the HTML document to a file 
        document.Save(Path.Combine(OutputDir, "edit-document-tree.html"));
    }
{{< /highlight >}}

Let’s take a look at creating a more complex HTML document. Each HTML document is represented as a node tree, and some of the nodes in a tree can have children. The following code snippet shows how to edit HTML document using DOM Tree and the mentioned above functional:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
...
    // Create an instance of an HTML document
    using (var document = new HTMLDocument())
    {
        // Create a style element and assign the green color for all elements with class-name equals 'gr'.
        var style = document.CreateElement("style");
        style.TextContent = ".gr { color: green }";

        // Find the document header element and append the style element to the header
        var head = document.GetElementsByTagName("head").First();
        head.AppendChild(style);
    
        // Create a paragraph element with class-name 'gr'.
        var p = (HTMLParagraphElement)document.CreateElement("p");
        p.ClassName = "gr";
    
        // Create a text node
        var text = document.CreateTextNode("Hello World!!");
    
        // Append the text node to the paragraph
        p.AppendChild(text);
    
        // Append the paragraph to the document body element
        document.Body.AppendChild(p);
    	
    	 // Save the HTML document to a file 
         document.Save(Path.Combine(OutputDir, "using-dom.html"));
    
        // Create an instance of the PDF output device and render the document into this device
        using (var device = new PdfDevice(Path.Combine(OutputDir, "using-dom.pdf")))
    	{
            // Render HTML to PDF
    		document.RenderTo(device);
    	}
    }
{{< /highlight >}}
{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  


## **Using InnerHTML & OuterHTML properties**
Having DOM objects gives you a powerful tool to manipulate with an HTML Document. However, sometime much better to work just with [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.8). The following code snippet shows you how to use the [**InnerHTML**](https://apireference.aspose.com/net/html/aspose.html.dom/element/properties/innerhtml) & [**OuterHTML**](https://apireference.aspose.com/net/html/aspose.html.dom/element/properties/outerhtml) properties to edit HTML.

{{< highlight java >}}
using System;
using Aspose.Html;
...
    // Create an instance of an HTML document
    using (var document = new HTMLDocument())
    {
        // Write the content of the HTML document into the console output
        Console.WriteLine(document.DocumentElement.OuterHTML); // output: <html><head></head><body></body></html>

        // Set the content of the body element
        document.Body.InnerHTML = "<p>HTML is the standard markup language for Web pages.</p>";
    
        // Write the content of the HTML document into the console output
        Console.WriteLine(document.DocumentElement.OuterHTML); // output: <html><head></head><body><p>HTML is the standard markup language for Web pages.</p></body></html>
    }
{{< /highlight >}}

## **Edit CSS**
Cascading Style Sheets ({{%CSS%}}) is a style sheet language used for describing how web pages look in the browser. CSS can be added to HTML documents as an inline, internal, and external way. Thus you can set the unique style to a single HTML element using inline CSS,  or for multiple web pages to share formatting by specifying the relevant CSS in a separate .css file.

 Aspose.HTML not only support CSS out-of-the-box but also gives you instruments to manipulate with document styles just on the fly before converting the HTML document to the other formats, as it follows:

### **Inline CSS**
When CSS is written using the **`style`** attribute inside of an HTML tag, it’s called an “inline style CSS”. The Inline CSS gives you to apply an individual style to one HTML element at a time. You set CSS to an HTML element by using the **`style`** attribute with any CSS properties defined within it.
In the following code snippet, you can see how to specify CSS style properties for an HTML `<p>` element.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
...
    // Create an instance of an HTML document with specified content
    var content = "<p> Inline CSS </p>";
    using (var document = new HTMLDocument(content, "."))
    {
        // Find the paragraph element to set a style attribute
        var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();

        // Set the style attribute
        paragraph.SetAttribute("style", "font-size: 250%; font-family: verdana; color: #cd66aa");
                        
        // Save the HTML document to a file 
        document.Save(Path.Combine(OutputDir, "edit-inline-css.html"));
    
        // Create the instance of the PDF output device and render the document into this device
        using (var device = new PdfDevice(Path.Combine(OutputDir, "edit-inline-css.pdf")))
        {
            // Render HTML to PDF
    		document.RenderTo(device);
        }                     
    }
{{< /highlight >}}

In this particular example, color, font-size and font-family apply to the `<p>` element. The fragment of rendered pdf page looks like this:

![Text "Inline CSS"](inline_CSS.png#center)

### **Internal CSS**

The internal CSS styling option is popular for applying properties to individual pages by encasing all styles in the `<style> `element placed it in the `<head>` of HTML documents.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Dom.Css;
...
    // Create an instance of an HTML document with specified content
    var content = "<div><p>Internal CSS</p><p>An internal CSS is used to define a style for a single HTML page</p></div>";
    using (var document = new HTMLDocument(content, "."))
    {
        var style = document.CreateElement("style");
        style.TextContent = ".frame1 { margin-top:50px; margin-left:50px; padding:20px; width:360px; height:90px; background-color:#a52a2a; font-family:verdana; color:#FFF5EE;} \r\n" +
                            ".frame2 { margin-top:-90px; margin-left:160px; text-align:center; padding:20px; width:360px; height:100px; background-color:#ADD8E6;}";

        // Find the document header element and append the style element to the header
        var head = document.GetElementsByTagName("head").First();
        head.AppendChild(style);
                                                      
        // Find the first paragraph element to inspect the styles
        var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();
        paragraph.ClassName = "frame1";
    
        // Find the last paragraph element to inspect the styles
        var lastParagraph = (HTMLElement)document.GetElementsByTagName("p").Last();
        lastParagraph.ClassName = "frame2";
                                                       
        // Set a color to the first paragraph
        paragraph.Style.FontSize = "250%";
        paragraph.Style.TextAlign = "center";                
    
        // Set a font-size to the last paragraph
        lastParagraph.Style.Color = "#434343";
        lastParagraph.Style.FontSize= "150%";
        lastParagraph.Style.FontFamily = "verdana";
    
        // Save the HTML document to a file 
        document.Save(Path.Combine(OutputDir, "edit-internal-css.html"));
    
        // Create the instance of the PDF output device and render the document into this device
        using (var device = new PdfDevice(Path.Combine(OutputDir, "edit-internal-css.pdf")))
        {
            // Render HTML to PDF
            document.RenderTo(device);
        }                
    }           
{{< /highlight >}}

The figure illustrates the fragment of rendered "edit-internal-css.pdf" file:

![Text "Internal CSS"](internal_css.png#center)

In this example, we use internal CSS and also declare additional style properties for individual elements using the **Style** property of the **[HTMLElement](https://apireference.aspose.com/html/net/aspose.html/htmlelement)** class.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  

### **External CSS**
An external style sheet can be written in any text editor, and saved with a .css extension. It is a standalone CSS file that is linked from a web page. The advantage of external CSS is that it can be created once and the rules applied to multiple web pages. 

#### **Example 1**

Let's look at an example of an external CSS realization in which we use a link to a URL-address of a CSS file:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
...
   // Create an instance of an HTML document with specified content
   var htmlContent = "<link rel=\"stylesheet\" href=\"https://docs.aspose.com/html/net/editing-a-document/external.css\" type=\"text/css\" />\r\n" +
                     "<div class=\"rect1\" ></div>\r\n" +
                     "<div class=\"rect2\" ></div>\r\n" +
                     "<div class=\"frame\">\r\n" +
                     "<p style=\"font-size:2.5em; color:#ae4566;\">External CSS</p>\r\n" +
                     "<p class=\"rect3\">An external CSS can be created once and applied to multiple web pages</p></div>\r\n";                             

   using (var document = new HTMLDocument(htmlContent, "."))
   {          
       // Save the HTML document to a file 
       document.Save(Path.Combine(OutputDir, "external-css.html"));

       // Create the instance of the PDF output device and render the document into this device
       using (var device = new PdfDevice(Path.Combine(OutputDir, "external-css.pdf")))
       {
           // Render HTML to PDF
           document.RenderTo(device);
       }       
   }               
{{< /highlight >}}

The result of the external CSS applying looks like this:

![Text "External CSS"](external-css1.png#center)

#### **Example 2**

You can write content for a CSS file in a string and save it to a separate linked file how it is shown in the following example:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
...
    // Prepare content for a CSS file 
    var styleContent = ".flower1 { width:120px; height:40px; border-radius:20px; background:#4387be; margin-top:50px; } \r\n" +
                       ".flower2 { margin-left:0px; margin-top:-40px; background:#4387be; border-radius:20px; width:120px; height:40px; transform:rotate(60deg); } \r\n" +
                       ".flower3 { transform:rotate(-60deg); margin-left:0px; margin-top:-40px; width:120px; height:40px; border-radius:20px; background:#4387be; }\r\n" +
                       ".frame { margin-top:-50px; margin-left:310px; width:160px; height:50px; font-size:2em; font-family:Verdana; color:grey; }\r\n";

    // Prepare a linked CSS file
    File.WriteAllText("flower.css", styleContent);
    
    // Create an instance of an HTML document with specified content
    var htmlContent = "<link rel=\"stylesheet\" href=\"flower.css\" type=\"text/css\" /> \r\n" +
                      "<div style=\"margin-top: 80px; margin-left:250px; transform: scale(1.3);\" >\r\n" +
                      "<div class=\"flower1\" ></div>\r\n" +
                      "<div class=\"flower2\" ></div>\r\n" +
                      "<div class=\"flower3\" ></div></div>\r\n" +
                      "<div style = \"margin-top: -90px; margin-left:120px; transform:scale(1);\" >\r\n" +
                      "<div class=\"flower1\" style=\"background: #93cdea;\"></div>\r\n" +
                      "<div class=\"flower2\" style=\"background: #93cdea;\"></div>\r\n" +
                      "<div class=\"flower3\" style=\"background: #93cdea;\"></div></div>\r\n" +
                      "<div style =\"margin-top: -90px; margin-left:-80px; transform: scale(0.7);\" >\r\n" +
                      "<div class=\"flower1\" style=\"background: #d5effc;\"></div>\r\n" +
                      "<div class=\"flower2\" style=\"background: #d5effc;\"></div>\r\n" +
                      "<div class=\"flower3\" style=\"background: #d5effc;\"></div></div>\r\n" +
                      "<p class=\"frame\">External</p>\r\n" +
                      "<p class=\"frame\" style=\"letter-spacing:10px; font-size:2.5em \">  CSS </p>\r\n";
    
    using (var document = new HTMLDocument(htmlContent, "."))
    {
        // Save the HTML document to a file 
        document.Save(Path.Combine(OutputDir, "edit-external-css.html"));                
    }
{{< /highlight >}}

This example displays how to create CSS graphics from scratch. The visualization of the "edit-external-css.html"  file is shown on the figure:

![Text "External CSS"](external-css2.png#center)

As was mentioned, the most common application of CSS is to style web pages written in HTML and other markup languages.  But beyond the web design, you can use CSS to create some nice graphics, like the one we show you above. The critical concept of CSS drawing is to use border-radius, rotation and locating to create curves and shapes creatively.
{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  