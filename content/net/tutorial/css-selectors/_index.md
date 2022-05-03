---
title: CSS Selectors | CSS and HTML Examples
linktitle: CSS Selectors
type: docs
weight: 30
description: In this article discover how to effectively apply CSS Selectors to select the elements you want to style.
keywords: css selector, css selectors, css attribute selector, css id selector, css class selector, css type selector, css element selector, css pseudo selector, css universal selectors, css conbinator selector, css selectors examples
lastmod: "2022-04-29"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />
{{% alert color="primary" %}} 
For more information on how to use CSS Selectors to navigate an HTML document, please visit the [**How-to Articles**](https://docs.aspose.com/html/net/how-to-articles/) chapter. The articles in this chapter answer popular questions and contain C# examples that provide the necessary information about using the Aspose.HTML class library to solve specific tasks.

To learn how to use the [QuerySelector()](https://apireference.aspose.com/html/net/aspose.html.dom/document/methods/queryselector) and [QuerySelectorAll()](https://apireference.aspose.com/html/net/aspose.html.dom/document/methods/queryselectorall) methods to query DOM elements that match a CSS selector, please see the article [**How to use CSS Selector**](https://docs.aspose.com/html/net/how-to-articles/how-to-use-css-selector/). In this article, discover how to effectively apply selectors to select the elements you want to style. 

{{% /alert %}} 

In this article discover how to effectively apply selectors to select the elements you want to style. You will cover basic selectors, combinator selectors, attribute selectors, and pseudo selectors. Knowledge of CSS selectors will be useful for both front-end developers, web designers, and all developers who use CSS and work with (X)HTML documents. 

## **CSS Selectors**

CSS selectors are used to selecting the HTML elements you want to style and apply a set of CSS rules. There are a few different types of CSS Selectors. 
- [Basic Selectors](/html/net/css-selectors/#basic-selectors) select elements based on name, id, class, or  select all the elements on the web page.
- [Attribute Selectors](/html/net/css-selectors/#attribure-selectors) select the HTML elements that have a specific attribute or attribute with a specified value.
- [Group Selectors](/html/net/css-selectors/#group-selectors) select elements grouped into comma-separated lists.
- [Combinator Selectors](/html/net/css-selectors/#combinator-selectors) select elements based on a specific relationship between them. Elements can be matched based on how they are positioned relative to each other in the markup code or how they are nested in the Document Object Model.
- [Pseudo Selectors](/html/net/css-selectors/#pseudo-selectors) select elements or a part of an element based on a certain state. Pseudo-classes are used in CSS selectors to permit formatting based on information that is not contained in the document tree.

You can combine CSS selectors in many ways to achieve great specificity and flexibility. 

 ## **Basic Selectors**

Basic CSS selectors select HTML elements according to its id, class, type, or select all the elements on the web page.

### **Type Selector or CSS Element Selector**

The Type Selector or Element Selector specifies to which elements a rule should apply, by naming the type of the element, such as `<h1>`. In other words, the Element Selector selects HTML elements based on the element name.

**CSS**
```css
h1 {
	text-align: center;	
	color: DarkRed;
} 
```
**HTML Example**
```html
<h1>Aspose.HTML for .NET</h1>
<p>Aspose.HTML for .NET is a cross-platform class library that enables your applications to perform a wide range of HTML manipulation tasks.</p>
```

![Text "Rendered result of applying CSS Element Selector."](css-element-selector.png#center)

### **ID Selector**

The ID Selector selects a specific element using the `id` attribute of an HTML element. An element will be selected if its `id` attribute exactly matches the value specified in the ID Selector.

**CSS**

```css
#demo {
  	background-color: #fcded4;
	font-size: 24pt;
}
```
**HTML Example**
```html
<p id="demo">This paragraph has a special ID on it!</p>
<p>This is just a regular paragraph.</p>
```

![Text "Rendered result of applying CSS ID Selector."](css-id-selector.png#center)

### **Class Selector**

The Class Selector matches HTML elements with a specific `class` attribute. You can use the `class` attribute for all HTML elements that are valid in the `body` section of an HTML document, including the `<body>` element itself. To select elements with a specific class, write a dot (.) character, followed by the class name. For example, if we want all elements with a class of `"main"` to have a different background color, text color and font size we would use the following CSS rule:

**CSS**

```css
.main {
	background-color: #d4e9fc;	
	color: red;
    font-size: 16pt;
} 
```
**HTML Example**
```html
<h1>CSS Class Selector</h1>
<p>The class attribute and its value can be used to create a CSS selector that refers to the selected web element.</p>
<p class="main">The dot (.) is used to indicate the class attribute to create the CSS Class selector.</p>
```

![Text "Rendered result of applying CSS Class Selector"](css-class-selector.png#center)

### **Universal Selector**

The Universal Selector is used to select all the elements on the web pages. For example, if we want every element to have a center text-align and blue text color, we would use the following CSS rule:

**CSS**

```css
* {
    text-align: center;
    color: #0154a2;
}
```
**HTML Example**

```html
<h1>CSS Universal Selector</h1>
<p>The Universal Selector selects all elements. The star symbol will target every single element on the page.</p>
```

![Text "Rendered result of applying CSS Universal Selector."](css-universal-selector.png#center)

## **Attribute Selectors**

CSS Attribute Selectors provide a simple and efficient way to apply styles to HTML elements based on the presence of a particular attribute or attribute value. This is a great way to style HTML elements by grouping them based on certain attributes, and the Attribute Selector will select those elements with similar attributes. You can create an Attribute Selector by putting the attribute in square brackets:

| **CSS Selector**     | **Example**       | **Description**                                              |
| -------------------- | ----------------- | ------------------------------------------------------------ |
| [attribute]          | [translate]       | Selects all elements with an attribute name of *translate*.  |
| [attribute=value]    | [translate=no]    | Selects all elements with `translate="no"`. Represents elements with an attribute name of *translate* whose value is exactly *no*. |
| [attribute~=value]   | [title~=flower]   | Selects all elements with a *title* attribute containing the word *flower*. |
| [attribute\|=value]  | [lang\|=de]       | Selects all elements with a *lang* attribute value equal to *"de"* or starting with *"de-"*. It is often used for language subcode matches. |
| [attribute^=value]   | a[href^="#"]      | Selects every `<a>` element whose *href* attribute value  is prefixed, begins with *"#"* (internal links). |
| [attribute$=value]   | a[href$=".html"]  | Selects every `<a>` element whose *href* attribute value is suffixed (followed) by value, ends with *".html"*. |
| [attribute**=*value] | a[href*="aspose"] | Selects every `<a>` element whose *href* attribute value contains the  *"aspose"* anywhere in the URL. |

Let's consider one of the CSS Attribute Selectors as an example:

**CSS**

```css
h3[class*="1"] {
    background-color: #b4e8fd;
}
```
**HTML Example**

```html
<h3 class="test-1">CSS Attribute Selector</h3>
<h3>CSS Attribute Selector</h3>
<h3 class="12">CSS Attribute Selector</h3>
```

![Text "Rendered result of applying CSS Attribute Selector"](css-attribute-selector.png#center)

## **Group Selectors**

You can style many selectors if you like. Just separate the selectors with a comma, as shown in the following example:

**CSS**

```css
h1, h2, h3 {
    color: #36C;
    font-family: helvetica;    
}
```
**HTML Example**
```html
<h1>CSS Group Selector (,)</h1>
<h2>The defined style will apply to h1, h2 and h3 elements.</h2>
<h3>The order of the list doesn't matter.</h3>
```

![Text "Rendered result of applying CSS Group Selector"](css-group-selector.png#center)

## **Combinator Selectors**

Combining selectors select elements based on the relationship among them. There are four different Combinators in CSS: descendant selector (space), child selector (>), adjacent sibling selector (+), and general sibling selector (~):

| **CSS Selector** | **Example** | **Description**                                              |
| ---------------- | ----------- | ------------------------------------------------------------ |
| element element  | div p       | The `" "` (space) Combinator selects all `<p>` elements that are descendants of the first `<div>` element. |
| element>element  | div > span  | The `>` Combinator selects all `<span>` elements where the parent is a `<div>` element. |
| element+element  | div + p     | Selects the first `<p>` element that is placed immediately after `<div>` elements. The `+` combinator matches the second element only if it *immediately* follows the first element. |
| element~element  | div ~ p     | The `~` Combinator selects siblings. This means that it selects every `<p>` element that is preceded by a `<div>` element. |

Let's consider one of the CSS Combinators Selectors as an example. The Child Selector (>) selects all elements that are the children of a specified element. Elements matching the second selector must be direct children of elements matching the first selector:

**CSS**

```css
div > p {
	background-color: #d4e9fc;
}
```
**HTML Example**
```html
<div>
    <p>CSS Child Selector (>). Paragraph 1 is in a div.
    <section>
        <p>Paragraph 2 is in a div but inside a section element. It is not a direct child of the div element that matches the first selector. Therefore, there is no background color!</p>
    </section>
    </p>
</div>
<p>Paragraph 3 is not in the div at all.</p>
```

![Text "Rendered result of applying CSS Child Selector"](css-combinator-selector.png#center)

## **Pseudo Selectors**

Pseudo Selectors allow elements to be formatted based on information other than the element's position in the document tree. Pseudo-Class and Pseudo-Element selectors are preceded by a colon `:`  and `::`.

The Pseudo-Class is used to define a special state for an element. For example, it can be used to style an element when the user hovers over it, or to style differently visited and unvisited links. A CSS Pseudo-Element is used to style specified parts of an element. For example, `p::first-letter` can be used to change the first letter of a paragraph.

Let's consider one of the CSS Pseudo-Element Selectors as an example:

**CSS**

```css
p::first-letter {
	font-size: 130%;
	color: red;
	font-family: arial; 	
}
```
**HTML Example**
```html
<p>Pseudo-Element Selectors</p>
<p>A CSS Pseudo-Element is used to style specified parts of an element.</p>
<p>For example, p::first-letter can be used to change the first letter of a paragraph.</p>
```

![Text "Rendered result of applying CSS Pseudo Selector"](css-pseudo-selector.png#center)

{{% alert color="primary" %}} 

Aspose.HTML offers free online <a href="https://products.aspose.app/html/applications" target="_blank">**HTML Web Applications**</a> that  are an online collection of free converters, mergers, downloaders, SEO tools, HTML code generators, URL tools and more. The applications work on any operating system with a web browser and do not require any additional software installation. Easily convert, merge, encode, generate HTML code, download videos, extract data from the web, or analyze web pages in terms of SEO wherever you are. Use our collection of HTML Web Applications to perform your daily matters and make your workflow seamlessly!

{{% /alert %}} 
