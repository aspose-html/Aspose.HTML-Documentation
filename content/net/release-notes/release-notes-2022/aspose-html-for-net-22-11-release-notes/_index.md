---
title: Aspose.HTML for .NET 22.11 Release Notes
weight: 20
type: docs
url: /net/aspose-html-for-net-22-11-release-notes
---
  {{% alert color="primary" %}} 

This page contains release notes information for Aspose.HTML for .NET 22.11.

{{% /alert %}} 

As per regular monthly update process of all APIs being offered by Aspose, we are honored to announce the November release of Aspose.HTML for .NET.

In this release, we have improved various parts of the parsing and rendering algorithms, here are some of them:

* Improved the TTF fonts processing.
* Improved working with memory.
* Improved the tables rendering.

## **Improvements and Changes**

| **Key**      | **Summary**                                                                                            | **Category**  |
| ------------ | ------------------------------------------------------------------------------------------------------ | ------------- |
| HTMLNET-4095 | Converting from HTML to PDF is causing ‘Nullable object must have a value’ exception                   | Bug           |
| HTMLNET-4112 | System.NullReferenceException when converting Markdown to PNG                                          | Bug           |
| HTMLNET-4085 | HTMLCollection not advancing enumerator                                                                | Investigation |
| HTMLNET-4084 | Export HTML as Flattened PDF document                                                                  | Investigation |
| HTMLNET-4082 | Converting from HTML to PDF is not wrapping text                                                       | Bug           |
| HTMLNET-4049 | Provide HTML Renderer to allow getting rendered HTML from source HTML after executing JavaScript in it | Bug           |
| HTMLNET-4081 | Html checkbox data binding                                                                             | Bug           |

## **Public API and Backward Incompatible Changes**

### **Added APIs**

```

namespace Aspose.Html.Saving
{
    public class HTMLSaveOptions : SaveOptions
	{
	    /// <summary>
        /// This option controls whether to serialize the value of the <see cref="HTMLInputElement"/>'s or the <see cref="HTMLTextAreaElement"/>'s "value" property into the "value" attribute.
        /// </summary>
        public bool SerializeInputValue { get; set; }
	}
}

namespace Aspose.Html.Rendering.Pdf
{
	public class PdfRenderingOptions : RenderingOptions
	{
		/// <summary>
        /// Specifies the behavior of form fields in the output PDF document.
        /// </summary>
        public FormFieldBehaviour FormFieldBehaviour { get; set; }
	}
}
```

In this release, the functionality for working with MD format has been expanded. It is located in the Aspose.Html.Toolkit.Markdown namespace.