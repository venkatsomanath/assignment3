using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;
namespace test1
{
    public class test
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input8and5_Returns13()
            {


                double number1 = 8;
                double number2 = 5;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetAddition();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input8and7_Returns15()
            {


                double number1 = 8;
                double number2 = 7;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetAddition();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input8and9_Returns17()
            {


                double number1 = 8;
                double number2 = 9;

                double expectedResult = number1 + number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetAddition();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input8and5_Returns3()
            {


                double number1 = 8;
                double number2 = 5;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetSubtraction();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input8and6_Returns2()
            {


                double number1 = 8;
                double number2 = 6;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetSubtraction();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input8and4_Returns4()
            {


                double number1 = 8;
                double number2 = 4;

                double expectedResult = number1 - number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetSubtraction();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input8and5_Returns40()
            {


                double number1 = 8;
                double number2 = 5;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetMultiplication();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input8and6_Returns48()
            {


                double number1 = 8;
                double number2 = 6;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetMultiplication();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input7and5_Returns35()
            {

                double number1 = 7;
                double number2 = 5;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetMultiplication();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input6and3_Returns2()
            {


                double number1 = 6;
                double number2 = 3;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetDivision();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input6and2_Returns3()
            {


                double number1 = 6;
                double number2 = 2;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetDivision();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input8and4_Returns2()
            {


                double number1 = 8;
                double number2 = 4;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetDivision();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input1and3_Returns0point33()
            {


                double number1 = 1;
                double number2 = 3;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetDivision();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input2and1_Returns2()
            {


                double number1 = 2;
                double number2 = 1;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetDivision();


                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input9and3_Returns3()
            {


                double number1 = 7;
                double number2 = 3;

                double expectedResult = number1 * number2;

                Calc testCalc = new Calc(number1, number2);


                double actualResult = testCalc.GetDivision();


                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}

