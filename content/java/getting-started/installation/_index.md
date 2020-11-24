---
title: Installation
type: docs
weight: 50
url: /java/installation/
---

## **Installing Aspose.HTML for Java from Aspose Repository**
Aspose hosts all Java APIs on [Aspose Repository](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/). You can easily use Aspose.HTML for Java API directly in your Maven or Gradle Projects with simple configurations.

Link for current version: [https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-html/20.9](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-html/20.9)
### **Specify Aspose Repository Configuration**
First you need to specify Aspose Repository configuration / location in your Maven pom.xml as follows:

{{< highlight java >}}
 <repositories>
     <repository>
         <id>snapshots</id>
         <name>repo</name>
         <url>http://repository.aspose.com/repo/</url>
     </repository>
</repositories>
{{< /highlight >}}

for Gradle in you build.gradle script as follows:

{{< highlight groovy >}}
 repositories {
     maven {
         url = uri('https://repository.aspose.com/repo/')
     }
 }
{{< /highlight >}}

### **Define Aspose.HTML for Java API Dependency**
Then define Aspose.HTML for Java API dependency in your pom.xml as follows:

{{< highlight java >}}
 <dependencies>
    <dependency>
        <groupId>com.aspose</groupId>
        <artifactId>aspose-html</artifactId>
        <version>20.9</version>
        <classifier>jdk16</classifier>
    </dependency>
</dependencies>
{{< /highlight >}}

for Gradle in you build.gradle script as follows:

{{< highlight groovy >}}
compile(group: 'com.aspose', name: 'aspose-html', version: '20.9', classifier: 'jdk16')
{{< /highlight >}}

After performing above steps, Aspose.HTML for Java dependency will finally be defined in your Maven Project.

_