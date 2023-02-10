---
title: Setting Attributes in HTML Template - C# Examples
linktitle: Setting Attributes in HTML Template 
description: In this article, you learn how to set attributes in HTML template and control the presence of attributes when populating templates.
weight: 30
type: docs
keywords: html template, set attribute, setting attribute, html checkbox, data source
lastmod: 2023-02-10
url: /net/setting-attributes-in-html-template/
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

## **HTML Template**

The HTML template is a standard HTML file that contains special inline expressions, indicated by double curly brackets, which map the input data source to the HTML page markup. During template processing, these inline expressions will be replaced with the corresponding data values as specified by the rules outlined in the [HTML Template](/html/net/html-template/) article.

Aspose.HTML for .NET library allows you to set attributes in HTML template and control the presence of attributes when populating templates. The following article shows you how to use this feature in C# examples.

## **Set Attribute in HTML Template**

In HTML templates, attributes are used to set properties of HTML elements such as id, class, style, etc. These attributes are specified in the opening tag of an HTML element and can be set using expressions, dynamic data, or static values.

### **Set Attribute `checked` for HTML Checkbox**

For example, let's take the following HTML template:

{{< highlight html >}}
<input type="checkbox" {{attr}} disabled />
{{< /highlight >}}

It's a checkbox form element that has a disabled attribute set which makes it uneditable and a `{{attr}}` label that can be added an attribute based on the data source. In this label, using the following data source, we will set the attribute `checked` which will display a checkmark in this HTML checkbox when drawn:

{{< highlight html >}}
<Data><attr>checked</attr></Data>
{{< /highlight >}}

A complete C# example of filling the template looks like this:

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Loading;
using Aspose.Html.Rendering.Image;
using System.IO;
using System.Linq;
...
    // Create a template with a string of HTML code
    var htmlCode = "<input type=\"checkbox\" disabled {{attr}} />";

    // Set data for the template in XML format
    var dataSource = "<Data><attr>checked</attr></Data>";

    // Convert template to HTML
    using (var htmlDocument = Converter.ConvertTemplate(htmlCode, string.Empty,
                new TemplateData(new TemplateContentOptions(dataSource, TemplateContent.XML)),
                new TemplateLoadOptions()))
    {
        // Request the input checkbox element that we specified in the template
        var input = (HTMLInputElement)htmlDocument.GetElementsByTagName("input").First();

        // Check if it has a checkmark 
        Assert.True(input.Checked);
        Assert.Equal(3, input.Attributes.Length);
        Assert.Equal("type", input.Attributes[0].Name);
        Assert.Equal("disabled", input.Attributes[1].Name);
        Assert.Equal("checked", input.Attributes[2].Name);        

        // Prepare a path to the output image file
        string outputPath = Path.Combine(OutputDir, "out-checked.png"); 
                
        // Convert HTML to PNG using RenderTo() method
        htmlDocument.RenderTo(new ImageDevice(new ImageRenderingOptions(), outputPath));

        // Save the HTML document to a file
        htmlDocument.Save(Path.Combine(OutputDir, "out-checked.html"));
    }

{{< /highlight >}}

Let’s take a closer look at this code snippet:

1. The template is converted to HTML document using the [Converter.ConvertTemplate(`content`, `baseUrl`, `data`, `options`)](https://reference.aspose.com/html/net/aspose.html.converters/converter/converttemplate/#converttemplate_6) method. This method converts a string of HTML content into a fully-formed HTMLDocument object. The method takes four parameters:
 - `content` (htmlCode) - a string containing HTML code to use as the template;
 - `baseUrl` (string.Empty) - this parameter is not used and is simply an empty string in this example;
 - `data` (TemplateData) - this parameter is used to specify the data source to use for populating the template. In this case, it is an XML string stored in the `dataSource` variable;
 - `options` (TemplateLoadOptions) - this parameter is used to specify any load options for the template.
2. After creating the HTML document, the code accesses an `<input>` element within the document and verifies that it has the correct attributes, such as `checked` in this case:
 - The method [GetElementsByTagName()](https://reference.aspose.com/html/net/aspose.html.dom/document/getelementsbytagname/) is used to retrieve the first `<input>` element in the document.
 - Then, several assertions are executed to check the properties of the input element. The first assertion, `Assert.True(input.Checked)`, checks if the checkbox is checked. The next two assertions, `Assert.Equal(3, input.Attributes.Length)` and `Assert.Equal("type", input.Attributes[0].Name)`, check the number of attributes and the name of the first attribute of the input element, respectively, and so on.
3. The HTML document is rendered to an image file using the [RenderTo()](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/) method.
4. Finally, the HTML document is saved to an HTML file (out-checked.html). The contents of this file can be seen below:

{{< highlight html >}}
<html>
    <head>
    </head>
    <body>
        <input type="checkbox" disabled="" checked="">
    </body>
</html>
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from **[GitHub.](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)**
{{% /alert %}}

### **Empty Checkbox**

If you want to create a document based on this template with an empty checkbox element, then use the following data source:

{{< highlight html >}}
<Data><attr></attr></Data>
{{< /highlight >}}

As you can see, to get such a result, it is enough to pass an empty value simply. The complete conversion example looks like this:

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Loading;
using Aspose.Html.Rendering.Image;
using System.IO;
using System.Linq;
...
    // Create a template with a string of HTML code
    var htmlCode = "<input type=\"checkbox\" disabled {{attr}} />";

    // Create an empty data source that won't set an attribute
    var dataSource = "<Data><attr></attr></Data>";

    // Convert template to HTML
    using (var htmlDocument = Converter.ConvertTemplate(htmlCode, string.Empty,
                new TemplateData(new TemplateContentOptions(dataSource, TemplateContent.XML)),
                new TemplateLoadOptions()))
    {
        // Request the input checkbox element that we specified in the template
        var input = (HTMLInputElement)htmlDocument.GetElementsByTagName("input").First();

        // Сheck if the checkbox is checked - it should not be there
        Assert.False(input.Checked);
        Assert.Equal(2, input.Attributes.Length);
        Assert.Equal("type", input.Attributes[0].Name);
        Assert.Equal("disabled", input.Attributes[1].Name);

        // Save the HTML document to a file
        htmlDocument.Save(Path.Combine(OutputDir, "out-unchecked.html"));

        // Prepare a path to the output file
        string outputPath = Path.Combine(OutputDir, "out-unchecked.png");

        // Convert HTML to PNG
        htmlDocument.RenderTo(new ImageDevice(new ImageRenderingOptions(), outputPath));
    }
{{< /highlight >}}

{{% alert color="primary" %}} 
Aspose.HTML offers free online **[Converters](https://products.aspose.app/html/conversion)** for converting HTML, XHTML, MHTML, EPUB, XML and Markdown files to a variety of popular formats. You can easily convert [HTML to PDF,](https://products.aspose.app/html/conversion/html-to-pdf) [HTML to Image,](https://products.aspose.app/html/conversion/html-to-image) [EPUB to PDF,](https://products.aspose.app/html/conversion/epub-to-pdf) [SVG to PDF,](https://products.aspose.app/svg/conversion/svg-to-pdf) [MHTML to PDF,](https://products.aspose.app/html/conversion/mhtml-to-pdf) or [MD to HTML.](https://products.aspose.app/html/conversion/md-to-html) Just select the file, choose the format to convert, and you’re done. Try our forceful Converters for free now!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion" target="_blank">![Text "Banner Free Online Converters"](converters.png#center)</a> 