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

        public void FormatAsBold_WhenCallString_ReturnString()
        {
            string content = _htmlFormatter.FormatAsBold("content");

            string result = _htmlFormatter.FormatAsBold(content);

            Assert.AreSame(result,content);
            
        }


    }
}
