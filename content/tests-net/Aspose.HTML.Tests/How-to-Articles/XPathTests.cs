using Aspose.Html;
using Aspose.Html.Dom;
using Aspose.Html.Dom.XPath;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.How_to_Articles
{
    public class XPathTests : TestsBase
    {
        public XPathTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("how-to-articles/xpath");
        }


        [Fact(DisplayName = "Use XPath")]
        public void XPathUsageTest1()
        {
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "xpath-image.htm")))
            {
                var result = doc.Evaluate("//img", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node node;
                while ((node = result.IterateNext()) != null)
                {
                    var img = (HTMLImageElement)node;
                    Output.WriteLine(img.Src);
                }
                Assert.True(doc.QuerySelectorAll("img").Length > 0);
            }
        }


        [Fact(DisplayName = "Use XPath")]
        public void XPathUsageTest2()
        {
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "xpath-image.htm")))
            {
                var result = doc.Evaluate("//main//img", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node node;
                while ((node = result.IterateNext()) != null)
                {
                    var img = (HTMLImageElement)node;
                    Output.WriteLine(img.Src);
                }
                Assert.True(doc.QuerySelectorAll(".ad").Length > 0);
            }
        }


        [Fact(DisplayName = "Use XPath")]
        public void XPathUsageTest3()
        {            
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "xpath-image.htm")))
            {
                var result = doc.Evaluate("//main/div[position() mod 2 = 1]//img", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node node;
                while ((node = result.IterateNext()) != null)
                {
                    var img = (HTMLImageElement)node;
                    Output.WriteLine(img.Src);
                }
                Assert.True(doc.QuerySelectorAll("div").Length > 0);
            }            
        }


        [Fact(DisplayName = "Use XPath")]
        public void XPathUsageTest4()
        {            
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "xpath-image.htm")))
            {
                var result = doc.Evaluate("//main/div[position() mod 2 = 1]//img[@class = 'photo']", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node node;
                while ((node = result.IterateNext()) != null)
                {
                    var img = (HTMLImageElement)node;
                    Output.WriteLine(img.Src);
                }
                Assert.True(doc.QuerySelectorAll(".photo").Length > 0);
            }
        }


        [Fact(DisplayName = "Use XPath in XML")]
        public void XPathUsageInXMLTest1()
        {
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "cars.xml")))
            {
                var dealers = doc.Evaluate("//Dealer", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node dealer;

                while ((dealer = dealers.IterateNext()) != null)
                {
                    Output.WriteLine(dealer.TextContent);
                }
                Assert.True(doc.QuerySelectorAll("Car").Length > 0);
            }
        }


        [Fact(DisplayName = "Use XPath in XML")]
        public void XPathUsageInXMLTest2()
        {
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "cars.xml")))
            {
                var dealers = doc.Evaluate("//Dealer[descendant::Car[descendant::Model > 2005]]", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node dealer;

                while ((dealer = dealers.IterateNext()) != null)
                {
                    Output.WriteLine(dealer.TextContent);
                }
                Assert.True(doc.QuerySelectorAll("Cars").Length > 0);
            }
        }


        [Fact(DisplayName = "Use XPath in XML")]
        public void XPathUsageInXMLTest3()
        {
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "cars.xml")))
            {
                var dealers = doc.Evaluate("//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node dealer;

                while ((dealer = dealers.IterateNext()) != null)
                {
                    Output.WriteLine(dealer.TextContent);
                }
                Assert.True(doc.QuerySelectorAll("Name").Length > 0);
            }
        }


        [Fact(DisplayName = "Use XPath in XML")]
        public void XPathUsageInXMLTest4()
        {
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "cars.xml")))
            {
                var dealers = doc.Evaluate("//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node dealer;

                while ((dealer = dealers.IterateNext()) != null)
                {
                    var dealerInfo = doc.Evaluate("concat('Dealer name: ', Name/text(), ' Telephone: ', Telephone/text())", dealer, doc.CreateNSResolver(doc), XPathResultType.String, null);
                    Output.WriteLine(dealerInfo.StringValue);
                }
                Assert.True(doc.QuerySelectorAll("Type").Length > 0);
            }
        }


        [Fact(DisplayName = "Use XPath in XML")]
        public void XPathUsageInXMLTest5()
        {
            using (var doc = new HTMLDocument(Path.Combine(DataDir, "cars.xml")))
            {
                var dealers = doc.Evaluate("//Dealer[descendant::Car[descendant::Model > 2005 and descendant::Price < 25000]]", doc, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                Node dealer;

                while ((dealer = dealers.IterateNext()) != null)
                {
                    var dealerInfo = doc.Evaluate("concat('Dealer name: ', Name/text(), ' Telephone: ', Telephone/text())", dealer, doc.CreateNSResolver(doc), XPathResultType.String, null);
                    Output.WriteLine(dealerInfo.StringValue);

                    var carIds = doc.Evaluate(".//Car[descendant::Model > 2005 and descendant::Price < 25000]/@CarID", dealer, doc.CreateNSResolver(doc), XPathResultType.Any, null);
                    Node carId;

                    while ((carId = carIds.IterateNext()) != null)
                    {
                        Output.WriteLine("Car id: " + carId.TextContent);
                    }
                }
                Assert.True(doc.QuerySelectorAll("Price").Length > 0);
            }
        }
    }
}
