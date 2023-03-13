---
title: How to Serialize Input Value - C# Example
linktitle: How to Serialize Input Value
type: docs
weight: 70
url: /net/how-to-serialize-input-value/
description: Learn and get a step-by-step guide on how to serialize input values in HTML forms or Input fields using the Aspose.HTML for .NET library.
keywords: html form, save html, serialize input value, input field, html input field
lastmod: "2023-03-10"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

Sometimes it is necessary to save an HTML document with input form fields filled in. Although browsers don't allow this for security reasons, Aspose.HTML provides a [SerializeInputValue](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/serializeinputvalue/) property of the [HTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/) class that gives you this ability. If the HTML document has input fields filled in, using the `SerializeInputValue` property, you can save the resulting document as it looks in the browser.

This article describes how to serialize input values in HTML forms or Input fields using the Aspose.HTML for .NET library.

## **Steps to Serialize Input Values**

Some HTML documents contain form elements such as [HTMLInputElement](https://reference.aspose.com/html/net/aspose.html/htmlinputelement/), [HTMLTextAreaElement](https://reference.aspose.com/html/net/aspose.html/htmltextareaelement/), and so on. For security reasons, their values are not saved, but you can change the situation using the `SerializeInputValue` option of the `HTMLSaveOptions` class. You should follow these required steps:
1. Load an HTML document using the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class. You can load HTML from a file, HTML code, stream, or URL.
1. Use one of the `GetElement*` methods of the [Document](https://reference.aspose.com/html/net/aspose.html.dom/document/) class to get a required HTML element/elements in the document and use the `Value` properties (get or set their values).
1. Create an instance of the [HTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/) class and set the `SerializeInputValue` property to `true`.
1. Call the [Save(`path`, `saveOptions`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/save/#save_12) method of the `HTMLDocument` class and pass the file path where you want to save the document and the `HTMLSaveOptions` instance as parameters.

## **How to Serialize Input Value in HTML Form**

Let's look at the apply the `SerializeInputValue` property using an example of an [HTMLInputElement](https://reference.aspose.com/html/net/aspose.html/htmlinputelement/) that represents an HTML input element such as a text box. Follow the step-by-step instructions to serialize the input value into a simple HTML form we create from scratch:

1. Prepare HTML code.
1. In the example, we create an HTML document from a string content using [HTMLDocument (`content`, `baseUri`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_14) constructor. 
1. Use the [GetElementsByTagName()](https://reference.aspose.com/html/net/aspose.html.dom/document/getelementsbytagname/) method of the Document class to select all the `input` elements in the document and store them in the `inputElements` variable.
1. Take the first and only `<input>` element, in this case, from the resulting collection and set the [Value](https://reference.aspose.com/html/net/aspose.html/htmlinputelement/value/) property of the [HTMLInputElement](https://reference.aspose.com/html/net/aspose.html/htmlinputelement/) class.
1. Save the HTML document to a file using the [Save(`path`, `saveOptions`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/save/#save_12) method. Set the [SerializeInputValue](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/serializeinputvalue/) property to `true` on the `HTMLSaveOptions` object passed as a parameter to the `Save()` method.

Here is an example of how to serialize input values in an input field using Aspose.HTML C# library:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Saving;
...

	var html = @"
    <html>
        <body>
            <div>The new input element value: <input type = ""text"" value=""No"" /></div>
        </body>
    </html>";

    // Create an HTML document from string of code containing an HTMLInputElement
    using var doc = new HTMLDocument(html, string.Empty);

    // Get all elements with the <input> tag
    var inputElements = doc.GetElementsByTagName("input");

    // Take the first and only element, in this case, from the resulting collection
    var input = (HTMLInputElement)inputElements[0];

    // Set the desired value for this HTML form element
    input.Value = "Text";

    // Prepare path to save HTML 
    string savePath = Path.Combine(OutputDir, "result.html");

    // Save the HTML document with SerializeInputValue set to true
    doc.Save(savePath, new HTMLSaveOptions { SerializeInputValue = true });
{{< /highlight >}}

Thus, the [SerializeInputValue](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/serializeinputvalue/) property of the `HTMLSaveOptions` class determines whether the values of input elements in an HTML document are serialized and included in the saved file or not. If `SerializeInputValue` is `true`, the input element values will be included in the saved file. If `SerializeInputValue` is not set, the input element values will not be included in the saved file.

{{% alert color="primary" %}} 
You can download data files and complete C# examples that demonstrate how to set font folder from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)
{{% /alert %}} 


{{% alert color="primary" %}}
Aspose.HTML offers free <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a>, an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools, formatters, minifiers, and more. The applications work on any operating system with a web browser and do not require any additional software installation. It's a fast and easy way to efficiently and effectively solve your HTML-related tasks!
{{% /alert %}}