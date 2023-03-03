---
title: Popular Use Cases for Message Handlers | C#
linktitle: Popular Use Cases for Message Handlers
type: docs
weight: 20
description: The article provides general information on creating custom message handlers for different popular use cases using Aspose.HTML for .NET - convert ZIP to PDF, convert ZIP to JPG, log a web request execution time, authentication.   
keywords: message handler, ZIP to PDF, ZIP to JPG, zip archive, web request, authentication
lastmod: "2023-02-17"
sitemap:
    changefreq: "monthly"
    priority: 0.8
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
In this chapter, we consider examples of how to create custom Message Handlers to implement a custom schema, work with a ZIP archive, authentication, and log an operation time.

A typical implementation does the following:

1. To write a custom message handler, derive from Aspose.Net.MessageHandler and override the Invoke() method. 
2. Add the custom message handler in the pipeline.
{{% /alert %}}

Suppose you want to convert an HTML(XHTML) document containing linked resources such as images, styles, scripts. In that case, you should pack all these resources along with your document into a single ZIP archive and convert, for instance, ZIP to PDF or ZIP to JPG. Aspose.HTML for .NET provides functionality for creating custom message handlers for working with ZIP archives.

Sometimes you need to get the total time taken for a Web request to flow through handlers, out to the endpoint, and receive the response. So, another popular use case for message handlers - logging the Web request execution time.

[Convert ZIP to PDF](/html/net/message-handlers/zip-to-pdf/) - In the article, you will find a message handler implementation for working with ZIP archives and an example of converting ZIP to PDF. 

[Convert ZIP to JPG](/html/net/message-handlers/convert-zip-to-jpg/) - This article provides an example of implementing a message handler for converting ZIP to JPG using Aspose.HTML for .NET.

[Web Request Execution Time](/html/net/message-handlers/web-request-execution-time/) - This article will consider an example of implementing a message handler for logging a Web request execution time.

[Network Timeouts](/html/net/message-handlers/network-timeouts/) - In this article, we will discuss how to set network timeouts in C# with practical examples.

[Convert ZIP to PDF - Execution Time Logging](/html/net/message-handlers/zip-to-pdf-time-logging/) - In this article, you will find an example of custom message handlers to convert ZIP to PDF and log the execution time of this conversion.

[Authentication](/html/net/message-handlers/authentication/) - In this article, you find a simple example of how to create a custom message handler for a Web request with password-based authentication schemes such as basic, digest, NTLM, and Kerberos. 

{{% alert color="primary" %}} 
Aspose.HTML offers a free online [**ZIP Converter**](https://products.aspose.app/html/conversion/zip) for converting ZIP files to a variety of popular formats. You can easily convert [ZIP to PDF](https://products.aspose.app/html/conversion/zip-to-pdf), ZIP to XPS,  [ZIP to JPG](https://products.aspose.app/html/conversion/zip-to-jpg), ZIP to DOCX, [ZIP to PNG](https://products.aspose.app/html/conversion/zip-to-png), ZIP to BMP, ZIP to TIFF, ZIP to GIF, ZIP to MD and ZIP to MHTML. Just select the file, choose the format to convert, and you’re done. It’s fast and completely free!
{{% /alert %}}





