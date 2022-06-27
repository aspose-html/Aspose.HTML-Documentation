---
title: Aspose.HTML for .NET 22.6 Release Notes
weight: 70
type: docs
---
  {{% alert color="primary" %}} 

This page contains release notes information for Aspose.HTML for .NET 22.6.

{{% /alert %}} 

As per regular monthly update process of all APIs being offered by Aspose, we are honored to announce the May release of Aspose.HTML for .NET.

In this release, we have improved various parts of the parsing and rendering algorithms, here are some of them:



* Fixed the memory usage issue.
* Improved JS and AngularJS applications processing.
* Improved processing of the box-sizing property.
* Improved the rendering and page splitting layout algorithms.


## **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |


## **Public API and Backward Incompatible Changes**
### **Added APIs**
```
namespace Aspose.Html.Drawing
{
    /// <summary>
    /// Declare methods for color conversions
    /// </summary>
    public interface IConvertibleColor
    {
        /// <summary>
        /// Convert to CMYK color in the percentage format: cmyk(0%,0%,0%,0%)
        /// </summary>
        /// <returns>CMYK color string</returns>
        string ToCmykString();

        /// <summary>
        /// Convert to CMYK color in the decimal format: cmyk(0,0,0,0)
        /// </summary>
        /// <returns>CMYK color string</returns>
        string ToCmykStringDecimal();

        /// <summary>
        /// Convert to HEX color in the format: #000000
        /// </summary>
        /// <returns>HEX color string</returns>
        string ToHexString();

        /// <summary>
        /// Convert to HSLA color in the format: hsla(0,0%,0%,0)
        /// </summary>
        /// <returns>HSLA color string</returns>
        string ToHslaString();

        /// <summary>
        /// Convert to HSL color in the format: hsla(0,0%,0%)
        /// </summary>
        /// <returns>HSL color string</returns>
        string ToHslString();

        /// <summary>
        /// Convert to HSL color in the decimal format: hsl(0,0,0)
        /// </summary>
        /// <returns>HSL color string</returns>
        string ToHslStringDecimal();

        /// <summary>
        /// Convert to HWBA color in the format: hwba(0,0%,0%,0)
        /// </summary>
        /// <returns>HWBA color string</returns>
        string ToHwbaString();

        /// <summary>
        /// Convert to HWB color in the format: hwb(0,0%,0%)
        /// </summary>
        /// <returns>HWB color string</returns>
        string ToHwbString();

        /// <summary>
        /// Convert to HWB color in the decimal format: hwb(0,0,0)
        /// </summary>
        /// <returns>HWB color string</returns>
        string ToHwbStringDecimal();

        /// <summary>
        /// Convert to the Named color
        /// </summary>
        /// <returns>Named color string</returns>
        string ToName();

        /// <summary>
        /// Convert to the Natural color (NCola) in the percentage format with alpha channel
        /// </summary>
        /// <returns>Natural color string</returns>
        string ToNcolaString();

        /// <summary>
        /// Convert to the Natural color (NCol) in the percentage format
        /// </summary>
        /// <returns>Natural color string</returns>
        string ToNcolString();

        /// <summary>
        /// Convert to the Natural color (NCol) in the decimal format
        /// </summary>
        /// <returns>Natural color string</returns>
        string ToNcolStringDecimal();

        /// <summary>
        /// Convert to the RGBA color
        /// </summary>
        /// <returns>RGBA color string</returns>
        string ToRgbaString();

        /// <summary>
        /// Convert to the RGB color
        /// </summary>
        /// <returns>RGB color string</returns>
        string ToRgbString();

        /// <summary>
        /// Convert to LCH color in the percentage format: lch(0%,0%,0%)
        /// </summary>
        /// <returns>LCH color string</returns>
        string ToLchString();

        /// <summary>
        /// Convert to LCH color in the decimal format: lch(0,0,0)
        /// </summary>
        /// <returns>LCH color string</returns>
        string ToLchStringDecimal();

        /// <summary>
        /// Convert to OKLCH color in the percentage format: oklch(0%,0%,0%)
        /// </summary>
        /// <returns>OKLCH color string</returns>
        string ToOkLchString();

        /// <summary>
        /// Convert to OKLCH color in the decimal format: oklch(0,0,0)
        /// </summary>
        /// <returns>OKLCH color string</returns>
        string ToOkLchStringDecimal();

        /// <summary>
        /// Convert to LAB color in the percentage format: lab(0%,0%,0%)
        /// </summary>
        /// <returns>LAB color string</returns>
        string ToLabString();

        /// <summary>
        /// Convert to LAB color in the decimal format: lab(0,0,0)
        /// </summary>
        /// <returns>LAB color string</returns>
        string ToLabStringDecimal();

        /// <summary>
        /// Convert to OKLAB color in the percentage format: oklab(0%,0%,0%)
        /// </summary>
        /// <returns>OKLAB color string</returns>
        string ToOkLabString();

        /// <summary>
        /// Convert to OKLAB color in the decimal format: oklab(0,0,0)
        /// </summary>
        /// <returns>OKLAB color string</returns>
        string ToOkLabStringDecimal();
    }
}

namespace Aspose.Html.Converters
{
    /// <summary>
    ///The ColorConverter class parses colors (RGB, HEX, HSL, HWB, CMYK, NCOL, LCH, OKLCH, LAB, OKLAB) from a string and returns the <see cref="IConvertibleColor"/> interface for converting to various color spaces.
    /// </summary>
    public static class ColorConverter
    {
        /// <summary>
        /// Parses color from string representation and returns the <see cref="IConvertibleColor"/> interface to convert it to various color spaces.
        /// </summary>
        /// <param name="color">color string.</param>
        /// <returns><see cref="IConvertibleColor"/> interface.</returns>
        public static IConvertibleColor ConvertFrom(string color)
    }
}
```



