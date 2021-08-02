---
title: Aspose.HTML for .NET 21.8 Release Notes
weight: 50
type: docs
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.HTML for .NET 21.8.

{{% /alert %}}

As per regular monthly update process of all APIs being offered by Aspose, we are honored to announce the August release of Aspose.HTML for .NET.

In this release we have made many improvements to our web page saver, here are some of them:

* Increased the accuracy of absolutely positioned elements rendering.
* Introduced the new resource handling option, which allows to ignore certain resources.
* Improved the saved resource naming algorithm.
* Increased the performance of web page saver.
* Improved the rendering of deeply nested HTML elements.

## **Improvements and Changes**

| **Key** | **Summary** | **Category** |
| :- | :- | :- |
| HTMLNET-3255 | Add functionality to modify PDF file properties while exporting from HTML | Feature |
| HTMLNET-3261 | HTML to PDF - System.ArgumentException: 'Incompatible unit types.' | Bug |
| HTMLNET-3106 | High memory usage while converting some MHT files to PDF/TIFF | Bug |
| HTMLNET-3249 | HTML to PDF, ArgumentOutOfRangeException is thrown | Bug |

## **Public API and Backward Incompatible Changes**

### **Added APIs**

```
namespace Aspose.Html.Saving
{
    public enum ResourceHandling
    {
        /// <summary>
        /// Resource will not be saved.
        /// </summary>
        Ignore
    }
}
```