using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinMaxDiff;

namespace MinMaxDiffTest
{
    [TestFixture]
    public class MinMaxDiffTester
    {
        Program myMinMaxDiff = new Program();

        [TestCase]
        public void TestWhenListHaveOnlyOneElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] { 5 });

            //act
            int output = 0;

            //assert
            Assert.AreEqual(output, Program.minMaxDiff(test));
        }

        [TestCase]
        public void TestWhenListHaveNegativeElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] { -5, 5, 7, 9 });

            //act
            int output = 14;

            //assert
            Assert.AreEqual(output, Program.minMaxDiff(test));
        }

        [TestCase]
        public void TestWhenListHaveOnlyNegativeElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] { -5, -5, -7, -7 });

            //act
            int output = 2;

            //assert
            Assert.AreEqual(output, Program.minMaxDiff(test));
        }
    }
}
