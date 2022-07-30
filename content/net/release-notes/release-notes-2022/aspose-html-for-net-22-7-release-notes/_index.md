---
title: Aspose.HTML for .NET 22.7 Release Notes
weight: 60
type: docs
url: /net/aspose-html-for-net-22-7-release-notes
---
  {{% alert color="primary" %}} 

This page contains release notes information for Aspose.HTML for .NET 22.7.

{{% /alert %}} 

As per regular monthly update process of all APIs being offered by Aspose, we are honored to announce the July release of Aspose.HTML for .NET.

In this release, we have improved various parts of the parsing and rendering algorithms, here are some of them:

* Improved memory handling when processing images.
* Improved processing of the readonly and disabled properties for textbox in HTML.
* Improved processing the current user fonts path.



## **Improvements and Changes**

| **Key**      | **Summary**                                                                | **Category** |
| ------------ | -------------------------------------------------------------------------- | ------------ |
| HTMLNET-3712 | Memory is not released after HTML to PDF conversion            | Bug          |
| HTMLNET-3927 | Textboxes are editable in PDF even though they are set as readonly and disabled property for textbox in HTML| Bug          |
| HTMLNET-2796 | Epub to png produces OutOfMemory | Bug          |
| HTMLNET-3578 | HTML to PNG - IndexOutOfRangeException error | Bug          |


## **Public API and Backward Incompatible Changes**


### **Removed APIs**

```
namespace Aspose.Html.Saving
{
    public enum HTMLSaveFormat
    {
       HTML = 0;
    }
}


In this release, the functionality for working with videos has been removed.
```