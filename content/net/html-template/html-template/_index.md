---
title: HTML Template - C# Examples
linktitle: HTML Template 
description: In this article, you learn how to populate an HTML template from XML or JSON data sources and consider examples to illustrate this feature.
keywords: html template, template to html, data source, xml data source, json data source, template markup, html page template
weight: 10
type: docs
lastmod: 2021-09-03
url: /net/html-template/
aliases:
  - /net/template-syntax/
  - /net/converting-between-formats/html-template/
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

This is an example of an HTML template that uses inline expressions to bind data. The template includes a table with two columns for "Person" and "Address." The cells in the "Person" column display the values of {{FirstName}} and {{LastName}} from the data source. The cells in the "Address" column display the values of {{Address.Street}} {{Address.Number}} and {{Address.City}}. The curly-brace syntax is used to indicate an inline expression.

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

The `data_merge` attribute specifies the data source is a list of objects and the table should be repeated for each object in the list. The expressions inside the template, such as {{FirstName}}, {{LastName}}, {{Address.Street}}, and {{Address.Number}}, indicate the fields from the data source that should be inserted in the corresponding cells of the table.

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


## **Convert Template to HTML by a single line of code**

Once you have prepared an HTML Template, you can convert Template to HTML in your C# application literally with a single line of code! To make this, you need to pass the required parameters to the  [ConvertTemplate()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converttemplate/) (`sourcePath`, `data`, `options`, `outputPath`) method.

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

The above code snippet shows how to use the ConvertTemplate() method to create an HTML document based on a template and populate it with data from a JSON data source. The method takes four arguments: the path to the template file, the data source, the loading options for the template, and the path where the output HTML document should be saved. The resulting document will be populated with the data from the data source, using the inline expressions syntax to fill in the template.

{{% alert color="primary" %}} 
For more information on how to convert template to HTML, please visit the [**Convert Template to HTML**](/html/net/convert-template-to-html/) article.<br>
You can download the complete examples and data files from **[GitHub.](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)**
{{% /alert %}}