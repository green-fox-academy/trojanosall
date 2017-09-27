using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibonacciMaker;
using NUnit.Framework;

namespace FibonacciMakerTest
{
    [TestFixture]

    public class Class1
    {       
        [Test]
        public void TestFibonacci_WhenGetNumber_ThenGoodOutput()
        {
            //arrange
            int n = 11;

            //act
            int output = 89;

            //assert
            Assert.AreEqual(output, Program.Fibonacci(n));
        }

        [Test]
        public void TestFibonacci_WhenGetNulla_ThenNullaOutput()
        {
            //arrange
            int n = 0;

            //act
            int output = 0;

            //assert
            Assert.AreEqual(output, Program.Fibonacci(n));
        }

    }
}
