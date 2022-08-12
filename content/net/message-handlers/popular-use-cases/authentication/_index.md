---
title: Authentication | C# examples
linktitle: Authentication
type: docs
weight: 50
url: /net/message-handlers/authentication/
description: In this article, you find a simple C# example of how to create a custom message handler for a Web request with password-based authentication schemes such as basic, digest, NTLM, and Kerberos.   
keywords: authentication, authentication scheme, message handler, custom message handler, web request, C# example, basic authentication, http basic authentication, kerberos,  digest, NTLM
lastmod: "2022-02-28"
sitemap:
    changefreq: "weekly"
    priority: 0.8
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}}
In this article, you find a simple example of how to create a custom message handler for a Web request with password-based authentication schemes such as basic, digest, NTLM, and Kerberos. 
{{% /alert %}}

Authentication is the process of determining whether a client has the right to access a resource. The HTTP protocol supports authentication as a means to negotiate access to a protected resource. First, it checks the user’s credentials (username and password). If both are correct, then the user can enter into the system. Several authentication schemes for HTTP are described here in brief: basic authentication, digest, NTLM, and Kerberos.

## **Creating a Message Handler for HTTP Basic Authentication**

Basic Authentication is a method for an HTTP user agent (such as a web browser) to provide a username and password when making a request. Let's create a custom handler that you can use for Basic Authentication. Take the next steps:

1. Use the necessary Namespace, which is the [Aspose.Html.Net](https://reference.aspose.com/html/net/aspose.html.net/).
2. Define your own CredentialHandler class that will be derived from the [MessageHandler](https://reference.aspose.com/html/net/aspose.html.net/messagehandler/) class.
3. Override the Invoke() method to implement the custom message handler behaviour.

The following code snippet shows how to create a CredentialHandler to access on remote source with authorization using HTTP Basic Authentication:

{{< highlight java >}}
using Aspose.Html.Net;
...

    // This message handler used basic autentifications request
    public class CredentialHandler : MessageHandler
    {
        // Override the Invoke() method
        public override void Invoke(INetworkOperationContext context)
        {
            context.Request.Credentials =  new NetworkCredential("username", "securelystoredpassword");
            context.Request.PreAuthenticate = true;
    
            Next(context);
        }
    }
{{< /highlight >}}

It passes NetworkCredential to a Web Request object, which uses it to authenticate requests to an Internet server.

## **Adding the CredentialHandler to the Pipeline**

The key concept of message handlers' work is chaining them together. We have created the CredentialHandler and should add it to the pipeline to implement the example of HTTP Basic Authentication. Let’s consider the following C# example:

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Services;
...

	// Create an instance of the Configuration class
	using var configuration = new Configuration();
	
	// Add the CredentialHandler to the chain of existing message handlers
	var service = configuration.GetService<INetworkService>();
	var handlers = service.MessageHandlers;
	handlers.Insert(0, new CredentialHandler());
	
	// Initialize an HTML document with specified configuration
	using var document = new HTMLDocument("https://httpbin.org/basic-auth/username/securelystoredpassword", configuration);	
 {{< /highlight >}}

The Configuration() constructor initializes an instance of the Configuration class. After the configuration is created, the GetService <INetworkService>() and MessageHandlers.Insert() methods are invoked. The Insert() method adds the CredentialHandler at the first place in the collection of message handlers. Use the [HTMLDocument(`url, configuration`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/) constructor to initialize an HTML Document and implement the example for HTTP Basic Authentication.

## **Authentication Schemes**

### **Basic Authentication**

Basic Authentication is a standard authentication method supported by HTTP servers and almost every web browser, making it an excellent access control method.

However, a severe drawback of Basic Authentication is that username and password for the client are transferred in Base64 encoded plain text. Base64 is not a form of encryption and should be treated as sending the username and password in cleartext. Therefore,  if a resource needs to be protected, it is highly recommended that you use an authentication scheme other than Basic Authentication.
### **Digest**

Digest authentication is an authentication method that a web server can use to negotiate credentials, such as a username or password, with the user's web browser. It is intended to replace basic authentication.
 The Digest applies a hash function to the username and password before sending them over the network. Hashing the data makes it harder for a user's credentials to be stolen and reused with this authentication scheme. It can be used to verify a user's identity before sending sensitive information such as online banking transaction history.

### **NTLM**

NTLM (New Technology LAN Manager) authentication is a challenge-response scheme that is a more secure version of Digest authentication. NTLM uses Windows credentials to convert the request data instead of an unencoded username and password. NTLM authentication requires several exchanges between client and server. The server and any intermediate proxies must maintain persistent connections for authentication to complete successfully.

### **Kerberos**

Kerberos is a computer-network authentication protocol. It is developed to provide strong authentication for client/server requests using secret-key cryptography. It was created by MIT as a solution to these network security problems. The Kerberos protocol is considered secure. It has been widely used for decades and has proven safe as a user authentication mechanism. Kerberos uses strong cryptography to protect sensitive data.

The Kerberos name was taken from Greek mythology. Kerberos was a three-headed dog that guarded the gates of Hades. The three heads of the Kerberos protocol represent the client, network resource, and
Key Distribution Center (KDC), which is a trusted third-party Kerberos authentication service.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}





