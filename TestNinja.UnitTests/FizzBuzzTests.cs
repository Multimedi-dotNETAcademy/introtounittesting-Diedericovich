using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{   
       

    class FizzBuzzTests
    {
        [Test]

        public void GetOutput_GivenNumbersDividedByThree_ReturnFizzBuzz()
        {
            int intA = 3;
            string expectedResult = "Fizz";

            string result = FizzBuzz.GetOutput(intA);

            Assert.AreEqual(result, expectedResult);
        }

        [Test]

        public void GetOutput_GivenNumbersDividedByFive_ReturnFizzBuzz()
        {
            int intA = 5;
            string expectedResult = "Buzz";

            string result = FizzBuzz.GetOutput(intA);

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(7, "7")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(14, "14")]

        public void GetOutput_GivenNumbersDividedByThreeAndFive_ReturnFizzBuzz(int number, string expectedResult)
        {            

            string result = FizzBuzz.GetOutput(number);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
