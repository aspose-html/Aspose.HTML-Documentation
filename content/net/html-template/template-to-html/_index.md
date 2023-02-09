---
title: Convert Template to HTML - C# Examples
linktitle: Convert Template to HTML 
description: In this article, you learn how to populate an HTML template from XML or JSON data sources and consider examples to illustrate this feature.
keywords: html template, template to html, convert template to html, template markup, html page template
lastmod: 2023-02-10
weight: 20
type: docs
url: /net/convert-template-to-html/
---

Aspose.HTML for .NET offers a set of [ConvertTemplate()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converttemplate/) methods that are used to convert an HTML template into an HTML document. The methods take several parameters, such as the path to the template file, the data source, and the load options, and return an HTML document. The HTML template is a piece of HTML code that contains placeholders for dynamic data. These placeholders are referred to as expressions and they are enclosed within double curly braces, like this: {{expression}}. The data source provides the actual values for these expressions. The ConvertTemplate() method substitutes the expressions in the template with values from the data source, generating a complete HTML document. This method can be used with various data source types, such as XML and JSON.

This article describes how to convert template to HTML in C# examples using Aspose.HTML for .NET library.

## **Convert Template to HTML by a single line of code**

Once you have prepared an HTML Template, you can convert Template to HTML in your C# application literally with a single line of code! To make this, you need to pass the required parameters to the [ConvertTemplate](https://reference.aspose.com/html/net/aspose.html.converters/converter/converttemplate/#converttemplate_11) (`sourcePath`, `data`, `options`, `outputPath`) method.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Loading;
...
    // Convert template to HTML
    Converter.ConvertTemplate(
        Path.Combine(DataDir, "template.html"),
        new TemplateData(Path.Combine(DataDir, "data-source.json")),
        new TemplateLoadOptions(),
        Path.Combine(OutputDir, "template-with-single-line.html")
    );
{{< /highlight >}}

## **Convert Template to HTML**

Let's use the ConvertTemplate(`HTMLDocument`, `TemplateData`, `TemplateLoadOptions`, `string`) method to convert an HTML template into a real HTML document. The method takes four parameters:

1. `HTMLDocument` object is used as a source for the template.
2. `TemplateData` object holds the data that will be used to populate the template.
3. `TemplateLoadOptions` object provides options for loading the template.
4. A `string` parameter is used to specify the full HTML file path as output conversion result.

The method uses the information from these parameters to generate an HTML document.

{{< highlight java >}}
using System.IO;
using Aspose.Html.IO;
using Aspose.Html.Saving;  
using Aspose.Html.Converters;  
...

    // Prepare a path to an HTML source file
    var sourcePath = Path.Combine(DataDir, "template.html");

    // Prepare a path to an xml template data file
    var templateDataPath = Path.Combine(DataDir, "templateData.xml");

    // Define TemplateData object instance
    var templateData = new TemplateData(templateDataPath);

    // Prepare a path to the result file
    var resultPath = Path.Combine(OutputDir, "result.html");

    // Define default TemplateLoadOptions object
    var options = new TemplateLoadOptions();

    // Initialize an HTML document as conversion source
    var document = new HTMLDocument(sourcePath, new Configuration());

    // Convert template to HTML
    Converter.ConvertTemplate(document, templateData, options, resultPath);

    // Clear resources
    document.Dispose();
{{< /highlight >}}

The code creates an instance of the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class and uses the [Converter.ConvertTemplate method()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converttemplate/#converttemplate_7) to convert a template file (template.html) to an HTML document using a data source file (templateData.xml). The method takes four parameters: the `HTMLDocument` object, the `TemplateData` object created using the data source file, the `TemplateLoadOptions` object, and the file path for the resulting HTML document. The resulting HTML document is saved to the specified file path (result.html). After the conversion, the `document` object is disposed.

## **Convert Template to HTML on-the-fly**

If your case involves specifying data and creating a template on-the-fly, you have to follow a few steps:

1. Prepare an HTML Template and save it to a file. The ConvertTemplate() method takes the template file's path as a parameter (`sourcePath`).
2. Prepare a JSON & XML data source and save it to a file. The [TemplateData()](https://reference.aspose.com/html/net/aspose.html.converters/templatedata/templatedata/) constructor takes the path to this data file and creates a data object (`data`) for the ConvertTemplate()method.
3. Initialize an instance of the [TemplateLoadOptions](https://reference.aspose.com/html/net/aspose.html.loading/templateloadoptions/) class to determine whether the template and data item names match, regardless of case or not (`options`).
4. Invoke the [ConvertTemplate()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converttemplate/#converttemplate_11) method and pass `sourcePath`, `data`, `options`, and `outputPath` for it. OutputPath is a path for data-filled template file saving. 

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Loading;
...

	// Prepare a path to an HTML Template file
	string sourcePath = Path.Combine(OutputDir, "template.html");           
	
	// Prepare an HTML Template and save it to the file
	var template = @"
		<table border=1>
			<tr>
				<th>Person</th>
				<th>Address</th>
			</tr>
			<tr>
				<td>{{FirstName}} {{LastName}}</td>
				<td>{{Address.Street}} {{Address.Number}}, {{Address.City}}</td>
			</tr>
		</table>
		";
	File.WriteAllText(sourcePath, template);
	
	// Prepare a path to JSON data source file
	string jsonPath = Path.Combine(OutputDir, "data-source.json");
	
	// Prepare a JSON data source and save it to the file
	var data = @"{
		'FirstName': 'John',
		'LastName': 'Doe',
		'Address': {
			'City': 'Dallas',
			'Street': 'Austin rd.',
			'Number': '200'
			}
		}";
	File.WriteAllText(jsonPath, data);
	
	// Prepare a path to the output file (data-filled template file)
	string outputPath = Path.Combine(OutputDir, "template-output.html");
	
	// Invoke Converter.ConvertTemplate in order to populate 'template.html' with the data source from 'data-source.json' file
	Converter.ConvertTemplate(sourcePath, new TemplateData(jsonPath), new TemplateLoadOptions(), outputPath);

{{< /highlight >}}

{{% alert color="primary" %}} 

Aspose.HTML offers free online **[Converters](https://products.aspose.app/html/conversion)** for converting HTML, XHTML, MHTML, EPUB, XML and Markdown files to a variety of popular formats. You can easily convert [HTML to PDF](https://products.aspose.app/html/conversion/html-to-pdf), [HTML to JPG](https://products.aspose.app/html/conversion/html-to-jpg), [SVG to PDF](https://products.aspose.app/svg/conversion/svg-to-pdf), [MHTML to PDF](https://products.aspose.app/html/conversion/mhtml-to-pdf) or [MD to HTML.](https://products.aspose.app/html/conversion/md-to-html) Just select the file, choose the format to convert, and you’re done. It’s fast and completely free!

You can download the complete examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)

{{% /alert %}}