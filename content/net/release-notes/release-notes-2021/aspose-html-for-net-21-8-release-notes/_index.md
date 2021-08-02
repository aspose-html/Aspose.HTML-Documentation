---
title: Aspose.HTML for .NET 21.8 Release Notes
weight: 50
type: docs
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.HTML for .NET 21.8.

{{% /alert %}}

As per regular monthly update process of all APIs being offered by Aspose, we are honored to announce the August release of Aspose.HTML for .NET. 

In this release we have made many improvements to our MHTML processing algorithm, here are some of them:

* Introduced the ability to change properties of the output PDF documents.
* Increased the accuracy of font relative size calculation algorithm.
* Updated the MHTML parsing algorithm , now it can handle deeply nested resources.
* Improved the MHTML resource encoding detection algorithm.
* Updated the CSS cascading algorithm according to the latest documentation.
* Improved rendering of the nested IFrame documents.




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