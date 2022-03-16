---
title: Working With HTML Color | Background Color and Text Color 
linktitle: Working With HTML Color
type: docs
weight: 20
description: In this article, we'll cover how to add a color of your HTML text, background, border or iFrame using HEX color codes, HTML color names, RGB and HSL values.
keywords: html colors, color names, hex colors, rgb, rgba, hsl, hsla, background color, text color, border color, color values, color codes
lastmod: "2022-03-17"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

## **How to Use HTML Color**

Design is not a central feature of HTML, so, there is no special HTML color tag. Adding color to a web page is a part of inline CSS styling. To set the text or background color in HTML you need to use the `style` attribute. You can apply the `style` attribute with the HTML `<p>`, `<h1>` or `<h2>`  tags and etc. Keep in mind, that the usage of a style attribute overrides any style set in the HTML `<style>` tag or external style sheet.

## **Text Color**

You can use the `style` attribute to change the text color and then set the value using the `color` property. The `color` property sets the foreground color value for an element's text and text decoration. The `color` property accepts color names, RGB, RGBA, HEX, HSL, or HSLA values.

### **Text Color Using HTML Color Names**

The color name depicts the specific name for the HTML color. Modern browsers support <a href="https://www.w3.org/TR/css-color-4/#named-colors" rel='noopener nofollow' target="_blank">140+ HTML color names</a>, and you can use any of them for your elements. For example, you can colorize text as shown in the following example:

```html
<html>
	<body>
		<h1 style="color:DarkCyan;">How to set text color using HTML color names?</h1>
		<h3 style="color:DarkRed;">Add a style attribute to the text element you want to colorize and use the color name to specify the color.</h3>
        <h4 style="color:DarkBlue;">There are over 140 named colors to choose from that you can use.</h4>
	</body>
</html>
```

The rendered HTML code looks as follows:

![Text "The image renders the html code above"](text-color.png#center)

### **Text color using RGB, RGBA or HEX color codes**

For coloring HTML text, you can use RGB or HEX that are the most used color codes. The RGB value determines the HTML color by mixing red, green, and blue values. The HEX color value works almost the same as RGB but looks different. If you want to know more about RGB, RGBA and HEX codes, please visit the [HTML Colors](https://docs.aspose.com/html/net/tutorial/html-colors/) article.

Using RGB or HEX color codes is the most common way to add color to web pages. It is necessary to add a `style` attribute to the text element you want to color. In the example below, we use the `<h1>`, `<h2>` and `<h3>` elements to apply the `color` property with RGB, RGBA and HEX codes:

```html
<html>
	<body>
		<h1 style="color:rgb(50,150,200);">How to use Text Color?</h1>
		<h2 style="color:rgba(220,30,100,1);"> To colorize HTML text, add a style attribute to the text element you want to color and apply the color property to specify the color using RGB, RGBA or HEX code.</h2>
        <h3 style="color:#1A8D7E"> You can use the style attribute with the HTML text element tags.</h3>
	</body>
</html>
```

 The rendered HTML code is as follows:

![Text "The image renders the html code for setting text color using HEX or RGB color codes"](text-color-hex-rgb.png#center)

### **Text color using HSL or HSLA color codes**

HSL(hue, saturation, lightness) is a representation of the RGB color model in cylindrical coordinates. Hue defines the basic color and measures it in degrees from 0 to 360 on the RGB color wheel. For example, red is 0 or 360, green is at 120, and blue is at 240. Saturation is the intensity or purity of a color, and it is defined in percentages from 0 (black and white) to 100 (vivid color). Lightness is the amount of brightness or light in color. It is defined in percentages from 0 (black) to 100 (white).

HSLA color values are an extension of HSL color values with an alpha channel that determines the opacity of the color. The HSLA color value is specified with hue, saturation, lightness, and alpha, where the alpha parameter specifies the opacity. The alpha parameter is a number between 0.0, meaning "fully transparent", and 1.0, meaning "fully opaque".

```html
<html>
	<body>
		<h1 style="color:hsl(200,100%,40%);">HSL and HSLA color codes</h1>
		<p  style="color:hsla(200,100%,40%,0.9); font-size:18px;">HSL(hue, saturation, lightness) is a representation of the RGB color model in cylindrical coordinates.</p>
		<p  style="color:hsla(200,100%,40%,0.6); font-size:18px;">HSLA color values are an extension of HSL color values with an alpha channel that determines the opacity of the color.</p>       
	</body>
</html>
```

The rendered HTML code looks as follows:

![Text "The image renders the html code for setting text color using HSL and HSLA color codes"](text-color-hsl-hsla2.png#center)

  

 ## **Background Color**

<a href="https://www.w3.org/TR/css-color-4/#named-colors" rel='noopener nofollow' target="_blank">W3C</a> specification of color names distinguishes basic and extended colors. The 16  basic colors are aqua, black, blue, fuchsia, gray, green, lime, maroon, navy, olive, purple, red, silver, teal, white, and yellow. Modern browsers support <a href="https://www.w3.org/TR/css-color-4/#named-colors" rel='noopener nofollow' target="_blank">147 HTML color names</a>.

```html
<html>
	<body>
		p>The color name is "YellowGreen":</p>
		<h2 style="background-color:rgb(154, 205, 50);">rgb(154, 205, 50)</h2>
		<h2 style="background-color:#9ACD32;">#9ACD32</h1>
		<h2 style="background-color:hsl(80, 61%, 50%);">hsl(80, 61%, 50%)</h2>

		<p>RGBA values of name "YellowGreen" color, with different transparent:</p>
		<h2 style="background-color:rgba(154, 205, 50, 0.2);">rgba(154, 205, 50, 0.2)</h2>
		<h2 style="background-color:rgba(154, 205, 50, 0.5);">rgba(154, 205, 50, 0.5)</h2>
		<h2 style="background-color:rgba(154, 205, 50, 0.8);">rgba(154, 205, 50, 0.8)</h2>

		<p>HSLA values of name "YellowGreen" color, with different transparent:</p>
		<h2 style="background-color:hsla(80, 61%, 50%, 0.2);">hsla(80, 61%, 50%, 0.2)</h2>
		<h2 style="background-color:hsla(80, 61%, 50%, 0.5);">hsla(80, 61%, 50%, 0.5)</h2>
		<h2 style="background-color:hsla(80, 61%, 50%, 0.8);">hsla(80, 61%, 50%, 0.8)</h2>
	</body>
</html>
```


The rendered HTML code looks as follows:

![Text "The image renders the html code for setting background color using HEX, RGB, RGBA, HSL and HSLA color codes"](background-color.png#center)

It's important to note that the `background-color` property provides a color for the background of the text, but not for the whole document. If you wish to change the HTML color for the whole page, you should use the `bgcolor` attribute in the opening tag of the `<body>` section:
```html
<html>
	<body bgcolor="#e0e0e0">
		<p>The color name is "YellowGreen":</p>

		<h2 style="background-color:rgb(154, 205, 50);">rgb(154, 205, 50)</h2>
		<h2 style="background-color:rgba(154, 205, 50, 1.0);">rgba(154, 205, 50, 1.0)</h2>
		<h2 style="background-color:#9ACD32;">#9ACD32</h2>
		<h2 style="background-color:hsl(80, 61%, 50%);">hsl(80, 61%, 50%)</h2>
		<h2 style="background-color:hsla(80, 61%, 50%, 1.0);">hsla(80, 61%, 50%, 1.0)</h2>
	</body>
</html>
```
![Text "The image renders the html code for setting background color using HEX, RGB, RGBA, HSL and HSLA color codes"](background-color-body.png#center)

{{% alert color="primary" %}} 
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/color-wheel" target="_blank">**Color Wheel Picker**</a>  that allows you to create a set of colors in the HEX color code. You can use this free online application to find color harmonies by using the rules of color combinations, but also it is essential to experiment with color. Color Wheel Picker suggests an excellent way to experiment with color and create exciting color combinations independently. The application runs for computers, tablets and mobile devices. So make your unique palette for any project! 
{{% /alert %}} 

<a href="https://products.aspose.app/html/color-wheel" target="_blank">![Text "Banner Color Wheel Picker"](color-wheel-picker.png#center)</a> 







