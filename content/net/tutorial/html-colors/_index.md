---
title: HTML Color Codes | HEX, RGB, RGBA, HSL and HSLA values
linktitle: HTML Color Codes
type: docs
weight: 10
description: You will find information about HTML color codes for your website - HTML color names with hex color codes, RGB, RGBA, HSL and HSLA values.
keywords: html colors, html color codes, color names, HTML color names, hex colors, hex code, hex color codes, rgb, rgb color, rgba, hsl, hsla, color values, color codes
lastmod: "2022-03-28"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

## **HTML Colors**

HTML colors are the colors used to display web pages on the web.  They are closely linked to the methods of describing and defining these colors using their respective color codes. For example, HTML colors may be specified as the common English color names, or with HEX values, RGB triplets, HSL, RGBA, and HSLA values. 

Colors play an essential role in forming the perceived value of web content and the emotions a person experiences when viewing it. In HTML and XHTML, colors can be used for text, background, frame borders, tables, and individual table cells.

  

 ## **HTML Color Names**

<a href="https://www.w3.org/TR/css-color-4/#named-colors" rel='noopener nofollow' target="_blank">W3C</a> specification of color names distinguishes basic and extended colors. The 16  basic colors are aqua, black, blue, fuchsia, gray, green, lime, maroon, navy, olive, purple, red, silver, teal, white, and yellow. Modern browsers support <a href="https://www.w3.org/TR/css-color-4/#named-colors" rel='noopener nofollow' target="_blank">147 HTML color names</a>.

The figure illustrates 16  basic colors with HEX and RGB codes:

![Text "16 basic HTML colors with HEX codes and RGB codes"](basic-html-colors.png#center)

## **HTML Color Codes**

HTML color codes are a means of representing a color format that a computer can read and display. Color codes are used in HTML and CSS to create web design color schemes. They are mainly used by web designers, front-end developers, programmers and digital illustrators.

### **RGB Colors**

**RGB** (Red, Green, Blue) is an additive color model that describes how any color is encoded using three basic ones.  It is the basis of the color displayed by light on TV screens, computers, image scanners, video projectors, digital cameras and mobile devices.

![Text "RGB colors as an additive color model"](rgb-additive-color-model.png#center)

The values R, G and B are the intensity (in the range from 0 to 255), respectively, of the red, green and blue components of the determined color. That is, a bright blue color can be defined as (0,0,255), red as (255,0,0), bright green - (0,255,0), black - (0,0,0), and white - (255,255,255). RGB is a popular color code model in photography, television, and computer graphics.
Since there are 256 different quantity options for each color. So, there can be 256^3 = 16,777,216 different RGB colors in total. Mixing these three colors would give you a RGB color code represented, for example, like this RGB(125,50,210).

One of the most typical ways to convey color is through visual systems such as diagrams or graphical models where each color has its own individual set of coordinates. For example, the RGB color system can be represented as a cube with 255 discrete points on each side:

![Text "The RGB cube as a graphical model for representing the RGB color system"](rgb-cube.png#center)

### **HEX Colors**

HEX codes are the most used color codes. HEX codes are three-byte hexadecimal numbers (six variables). The six-digit color number is structured into three groups of two digits which specify the amount of Red, Green, and Blue in the additive color. Each two-digit hex pair can have a value from 00 to FF. This gives over 16 million possible colors.

The code is expressed as follows: #RRGGBB, where each of the two-digit values is a range of each of the three colors (red, green, blue), with which you select the final value representing each color. For example, #00FF00 is displayed as green, because the green component is set to its maximum value (FF) and the others are set to 00.

### **RGBA Colors**

**RGBA**(Red, Green, Blue, Alpha) color values are an extension of RGB color values with an alpha channel that determines the opacity of the color. The alpha parameter is a number between 0.0, meaning "fully transparent", and 1.0, meaning "fully opaque". For example, rgba(255, 0, 0) is displayed as pure red, rgba(255, 0, 0, 0.5) is displayed as red with 50% opacity.

The figure shows RGBA values of name "YellowGreen" color, with different transparent:

![Text "RGBA values of name "YellowGreen" color, with different transparent"](rgba.png#center)

For an RGBA value, unlike RGB values, there is no hexadecimal notation.

### **HSL Colors**

Many people consider the RGB color code is non-intuitive and hardware-oriented. The **HSL**(Hue, Saturation, Lightness) color model was developed in the 1970s by computer graphics researchers to more closely match how human vision perceives color-producing attributes. In the HSL model, colors of each hue are arranged in a radial slice around a central axis of neutral colors, ranging from black at the bottom to white at the top. The HSL representation rearranges the colors to make them more intuitive than the RGB representation. It is often used for computer graphics applications such as color pickers and image analysis.

The figure shows a 3D graphical interpretation of the HSL model (a), the image is taken from commons.wikimedia.org/wiki/. Figure (b) shows a 2D graphical interpretation of the HSL model for a lightness value of 50%.

![Text "The HSL color model"](hsl-color.png#center)

HSL is a representation of the RGB color model in cylindrical coordinates. Hue defines the basic color. Hue is basically any color on the color wheel; it's a degree on the color wheel from 0 to 360. So, 0 is red, 120 is green, 240 is blue. Saturation is the intensity or purity of a color. It determines how vivid the color will be. Zero percent is gray, and 100 percent is a fully saturated color. Lightness is the amount of brightness or light in color. Lightness determines how much black or white tint the color has. For example, 50 percent has no tint, zero percent is entirely black, and 100 percent is fully white.

**HSL Color Examples**

The table below represents one hue. Red color has been chosen from the color circle. Hue=0. The X-axis of the table represents the saturation (100%, 75%, 50%, 25%, 0%). The Y-axis represents lightness. 50% is “normal”.

![Text "HSL Examples: a set of different colors for Hue=0, Red"](hsl-examples.png#center)

### **HSLA Colors**

**HSLA**(Hue, Saturation, Lightness, Alpha) color values are an extension of HSL color values with an alpha channel that determines the opacity of the color. The HSLA color value is specified with hue, saturation, lightness, and alpha, where the alpha parameter specifies the opacity. The alpha parameter is a number between 0.0, meaning "fully transparent", and 1.0, meaning "fully opaque". For example, hsla(0, 100%, 50%, 1) is displayed as pure red, hsla(0, 100%, 50%, 0.5)  is displayed as red with 50% opacity:

![Text "HSLA color codes for Red with different opacity"](hsla-color.png#center)

## **Conclusion**
HTML colors can be defined by a name, RGB, RGBA, HEX, HSL or HSLA values and applied to the background or text in HTML documents. 

The figure below illustrates how to specify teal color  by name, RGB, RGBA, HEX, HSL and HSLA values:

![Text "Teal Color is represented by name, HEX, RGB, RGBA, HSL and HSLA values"](html-colors.png#center)

{{% alert color="primary" %}} 
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/color-wheel" target="_blank">**Color Wheel Picker**</a>  that allows you to create a set of colors in the HEX color code. You can use this free online application to find color harmonies by using the rules of color combinations, but also it is essential to experiment with color. Color Wheel Picker suggests an excellent way to experiment with color and create exciting color combinations independently. The application runs for computers, tablets and mobile devices. So make your unique palette for any project! 
{{% /alert %}} 

<a href="https://products.aspose.app/html/color-wheel" target="_blank">![Text "Banner Color Wheel Picker"](../color-wheel-picker.png#center)</a> 







