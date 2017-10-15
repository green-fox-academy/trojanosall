using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seconds;
using NUnit.Framework;

namespace SecondsTest
{
    [TestFixture]
    public class SecondsMakerTester
    {
        SecondsMaker mySecondsMaker = new SecondsMaker();

        [TestCase]
        public void TestWhenListHaveOnlyOneElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] {5});

            //act
            List<int> output = null;

            //assert
            Assert.AreEqual(output, SecondsMaker.Seconds(test));
        }

        [TestCase]
        public void TestWhenListHaveThreeElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] {-5, 5, 7});

            //act
            List<int> output = new List<int>(new int[] { 5 });

            //assert
            Assert.AreEqual(output, SecondsMaker.Seconds(test));
        }

        [TestCase]
        public void TestWhenListHaveOnlyNegativeElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] {-5, -5, -7, -7});

            //act
            List<int> output = new List<int>(new int[] { -5, -7 });

            //assert
            Assert.AreEqual(output, SecondsMaker.Seconds(test));
        }
    }
}
