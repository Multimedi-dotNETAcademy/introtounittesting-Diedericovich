using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    class HtmlFormatterTester
    {
        private HtmlFormatter _htmlFormatter;

        [SetUp]

        public void Setup()
        {
            _htmlFormatter = new HtmlFormatter();
            
        }

        [Test]

        public void FormatAsBold_WhenCalled_ReturnStringAsStrong()
        {
            string content = "boldContent";
            string result = _htmlFormatter.FormatAsBold(content);

            Assert.AreEqual(result,$"<strong>{content}</strong>");
            
        }


    }
}
