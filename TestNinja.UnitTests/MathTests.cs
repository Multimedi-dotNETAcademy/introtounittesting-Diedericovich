
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class MathTests
    {
        //onderstaande kan 1 of meerdere methodes in Unit Testing hergebruiken

        private Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        // Test methods - usually- follow this convention
        // MethodName_Scenario_ExpectedResult
        //GivenTheseArguments_WhenMethodCalled_ThenExpectedResult
        // het moet duidelijk zijn wat de naam is, wat die doet en wat je test

        [Test]

        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            // ARRANGE  /    GIVEN
            int numA = 5;
            int numB = 7;
            Math myMathClass = new Math();


            // ACT      /    WHEN
            int result = myMathClass.Add(numA, numB);

            //ASSERT    /    THEN
            Assert.AreEqual(12, result);
            // Assert.That(result, Is.EqualTo(12));
            // beiden doen exact hetzelfde; evengoed;

        }

        // Testcases allow for input of parameters to be filled in

        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(4, 4, 4)]
        public void Max_WhenCalled_ReturnBiggerNumber(int numA, int numB, int expectedResult)
        {                       
            //ACT
            int result = _math.Max(numA, numB);

            //ASSERT
            Assert.AreEqual(expectedResult, result);
        }
          
        [Test]

        public void GetOddNumbers_WhenGivenLimitHigherThanZero_ReturnOddArray()
        {
            var expectedResult = new[] { 1, 3, 5 };

            IEnumerable<int> result = _math.GetOddNumbers(5);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.AreEqual(expectedResult, result);
        }


    }

    
    
}
