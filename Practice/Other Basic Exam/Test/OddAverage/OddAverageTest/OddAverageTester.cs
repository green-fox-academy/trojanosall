using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OddAverage;

namespace OddAverageTest
{
    [TestFixture]

    public class OddAverageTester
    {
        OddAverageMaker myOddAverageMaker = new OddAverageMaker();

        [TestCase]
        public void TestOddAverageMakerWhenListHaveOnlyOneElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] { 5 });

            //act
            int output = 5;

            //assert
            Assert.AreEqual(output, OddAverageMaker.oddAverage(test));
        }

        [TestCase]
        public void TestOddAverageMakerWhenListHaveNegativeElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] { -5,5,7,9 });

            //act
            int output = 4;

            //assert
            Assert.AreEqual(output, OddAverageMaker.oddAverage(test));
        }

        [TestCase]
        public void TestOddAverageMakerWhenListHaveOnlyNegativeElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] { -5, -5, -7, -7 });

            //act
            int output = -6;

            //assert
            Assert.AreEqual(output, OddAverageMaker.oddAverage(test));
        }
    }
}
