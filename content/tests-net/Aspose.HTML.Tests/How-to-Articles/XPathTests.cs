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
        public void CSSSelectorUsageTest1()
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
        public void CSSSelectorUsageTest2()
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
        public void CSSSelectorUsageTest3()
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
        public void CSSSelectorUsageTest4()
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
    }
}
