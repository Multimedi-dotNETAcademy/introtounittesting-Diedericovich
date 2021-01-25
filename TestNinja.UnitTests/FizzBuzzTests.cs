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

        public void GetOutput_GivenNumbersDividedByThreeAndFive_ReturnFizzBuzz()
        {
            int intA = 3;
            string expectedResult = "Fizz";

            string result = FizzBuzz.GetOutput(intA);

            Assert.AreEqual(result, expectedResult);
        }

    }
}
