---
title: Aspose.HTML for Java 22.7 Release Notes
weight: 80
type: docs
url: /java/aspose-html-for-java-22-7-release-notes
---
{{% alert color="primary" %}}

This page contains release notes for 
Aspose.HTML for Java 22.7

{{% /alert %}}

We are honored to announce the Jule release of Aspose.HTML for Java.

In this release, we added facility converter HTML to text

## **Public API and Backward Incompatible Changes**

### **Added APIs**

* Class [com.aspose.html.converters.Converter](https://reference.aspose.com/html/java/com.aspose.html.converters/Converter#convertHTML-com.aspose.HTMLDocument-com.aspose.saving.TextSaveOptions-java.lang.String-)

Added the following
methods



```java
convertHTML(HTMLDocument document, TextSaveOptions options, java.lang.String outputPath)
convertHTML(java.lang.String sourcePath, Configuration configuration, TextSaveOptions options, java.lang.String outputPath)
convertHTML(java.lang.String content, java.lang.String baseUri, Configuration configuration, TextSaveOptions options, java.lang.String outputPath)
convertHTML(java.lang.String content, java.lang.String baseUri, TextSaveOptions options, java.lang.String outputPath)
convertHTML(java.lang.String sourcePath, TextSaveOptions options, java.lang.String outputPath)
convertHTML(Url url, Configuration configuration, TextSaveOptions options, java.lang.String outputPath)
convertHTML(Url url, TextSaveOptions options, java.lang.String outputPath)
```