---
keywords: html template, template to html, data source, xml data source, json
  data source, template markup
lastmod: 2021-09-03
url: /net/converting-between-formats/html-template/
title: HTML Template | C#
description: In this article, you learn how to populate an HTML template from
  XML or JSON data sources and consider examples to illustrate this feature.
weight: 60
type: docs
aliases:
  - /net/template-syntax/
  - /net/html-template/
---
This article describes how to create an HTML document based on a template and populate it from a data source. Aspose.HTML provides the inline expressions syntax to work with templates and various data source types, such as XML and JSON.

## **Template markup**

The HTML template is a regular HTML file that contains some special inline expressions that specify the input data-source mapping to the HTML page markup. These inline expressions use double curled bracket notation. The template markers will be replaced with respective data values during the template processing following the rules described below.

### **Inline expressions**

Following is the list of supported inline expressions syntax.

#### **{{ ... }} - data-binding expression**

The *data-binding expression* is used to set values of the control element based on the information that is contained in the data source. 

The following is the basic syntax of the data-binding expression:

{{ data-binding expression  }}

The following demo shows how to use the data-binding expression to obtain information from the XML data source:

**XML Data Source**

{{< highlight html >}}

<Data>
    <FirstName>John</FirstName>    
    <LastName>Doe</LastName>    
    <Address>    
        <City>Dallas</City>    
        <Street>Austin rd.</Street>    
        <Number>200</Number>    
    </Address>
</Data>

{{< /highlight >}}

The data-binding expression in the HTML page template:

**HTML Template**

{{< highlight html >}}

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

{{< /highlight >}}

#### **{{#foreach ... }} - foreach directive expression**

The *foreach directive expression* is used to iterate through the list of elements in combination with *data-binding expression*.

The following demo shows how to get all persons from an XML data source and populate a template:

**XML Data Source**

{{< highlight html >}}

 <Data>
     <Persons>    
         <Person>    
             <FirstName>John</FirstName>    
 			<LastName>Doe</LastName>    
             <Address>    
                 <Number>200</Number>    
                 <Street>Austin rd.</Street>    
                 <City>Dallas</City>    
             </Address>    
             <Phone1>345-345-34-55</Phone1>    
             <Phone2>345-555-09-09</Phone2>    
         </Person>    
         <Person>    
             <FirstName>Jack</FirstName>    
             <LastName>Fox</LastName>    
             <Address>    
                 <Number>25</Number>    
                 <Street>Broadway</Street>    
                 <City>New York</City>    
             </Address>    
             <Phone1>081-544-12-15</Phone1>    
         </Person>    
         <Person>    
             <FirstName>Sherlock</FirstName>    
             <LastName>Holmes</LastName>    
             <Address>
                   <Number>65</Number>    
                   <Street>Baker str.</Street>    
                   <City>London</City>    
             </Address>    
             <Phone1>012-5344-334</Phone1>    
         </Person>    
     </Persons>
 </Data>

{{< /highlight >}}

The *foreach directive expression* in the HTML page template:

**HTML Template**

{{< highlight html >}}

 <table border=1 data_merge='{{#foreach Persons.Person}}'>
     <tr>    
         <th>Person</th>    
         <th>Address</th>    
     </tr>    
     <tr>    
         <td>{{FirstName}} {{LastName}}</td>    
         <td>{{Address.Street}} {{Address.Number}}, {{Address.City}}</td>    
     </tr>
 </table>
{{< /highlight >}}

{{% alert color="primary" %}} 

Please note that the current implementation only supports foreach directive expression for the following HTML elements: DIV, OL, UL and TABLE.

{{% /alert %}} 

## **Data Source**

As it was mentioned earlier, the data source could be represented in XML and JSON formats. The following are the examples of both data sources that are prepared for this article:

### **XML Data Source**

{{< highlight html >}}
 <Data>
     <FirstName>John</FirstName>\
     <LastName>Doe</LastName>\
     <Address>\
         <City>Dallas</City>\
         <Street>Austin rd.</Street>\
         <Number>200</Number>\
     </Address>
 </Data>
{{< /highlight >}}

### **JSON Data Source**

{{< highlight javascript >}}

 {
     'FirstName': 'John',\
     'LastName': 'Doe',\
     'Address': {\
         'City': 'Dallas',\
         'Street': 'Austin rd.',\
         'Number': '200'
     }
 }

{{< /highlight >}}

## **Usage Examples**

### **Convert Template to HTML by a single line of code**

Once you have prepared an HTML Template, you can convert Template to HTML in your C# application literally with a single line of code! To make this, you need to pass the required parameters to the  [ConvertTemplate](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converttemplate/methods/9) (`sourcePath`, `data`, `options`, `outputPath`) method.

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

### **Convert Template to HTML**

If your case involves specifying data and creating a template on-the-fly, you have to follow a few steps:

1. Prepare a JSON & XML data source and save it to a file. The [TemplateData()](https://apireference.aspose.com/html/net/aspose.html.converters/templatedata/constructors/1) constructor takes the path to this data file and creates a data object (`data`) for the ConvertTemplate()method.
2. Prepare an HTML Template and save it to a file. The ConvertTemplate() method takes the template file's path as a parameter (`sourcePath`).
3. Initialize an instance of the [TemplateLoadOptions](https://apireference.aspose.com/html/net/aspose.html.loading/templateloadoptions) class to determine whether the template and data item names match, regardless of case or not (`options`).
4. Invoke the [ConvertTemplate()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converttemplate/methods/9) method and pass `sourcePath`, `data`, `options`, and `outputPath` for it. OutputPath is a path for data-filled template file saving. 

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Loading;
...

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

// Prepare a path to the output file (data-filled template file)
string outputPath = Path.Combine(OutputDir, "template-output.html");

// Invoke Converter.ConvertTemplate in order to populate 'template.html' with the data source from 'data-source.json' file
Converter.ConvertTemplate(sourcePath, new TemplateData(jsonPath), new TemplateLoadOptions(), outputPath);

{{< /highlight >}}

{{% alert color="primary" %}} 

Aspose.HTML offers free online **[Converters](https://products.aspose.app/html/en/conversion)** for converting HTML, XHTML, MHTML, EPUB, XML and Markdown files to a variety of popular formats. You can easily convert [HTML to PDF](https://products.aspose.app/html/en/conversion/html-to-pdf), [HTML to JPG](https://products.aspose.app/html/en/conversion/html-to-jpg), [SVG to PDF](https://products.aspose.app/svg/en/conversion/svg-to-pdf), [MHTML to PDF](https://products.aspose.app/html/en/conversion/mhtml-to-pdf) or [MD to HTML](https://products.aspose.app/html/en/conversion/md-to-html). Just select the file, choose the format to convert, and you’re done. It’s fast and completely free!

You can download the complete examples and data files from **[GitHub](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)**.

{{% /alert %}}