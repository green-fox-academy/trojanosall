using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumList;

namespace SumTest
{
    [TestFixture]

    public class SumTest
    {

        Sum sum = new Sum();

        [TestCase]
        public void TestSumList_WhenList_Empty_ThenNulla()
        {
            //arrange
            List<int> test = new List<int>(new int { });

            //act
            int output = 0;

            //assert
            Assert.AreEqual(output, Sum.SumListElement(test));
        }

        [TestCase]
        public void TestSumList_WhenOneElement_ThenOutput()
        {
            //arrange
            List<int> test = new List<int>{ 5 };

            //act
            int output = 5;

            //assert
            Assert.AreEqual(output, Sum.SumListElement(test));
        }

        [TestCase]
        public void TestSumList_WhenMultipleElement_ThenOutput()
        {
            //arrange
            List<int> test = new List<int> { -5, -12, 78, -5 };

            //act
            int output = 56;

            //assert
            Assert.AreEqual(output, Sum.SumListElement(test));
        }

        [TestCase]
        public void TestSumList_WhenNull_ThenZero()
        {
            //arrange
            List<int> test = null;

            //act
            int output = 0;

            //assert
            Assert.AreEqual(output, Sum.SumListElement(test));
        }
    }
}
