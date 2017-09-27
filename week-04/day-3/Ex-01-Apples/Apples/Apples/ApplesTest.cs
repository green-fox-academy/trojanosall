using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apples
{
    [TestFixture]

    public class ApplesTest
    {
        Apples apples = new Apples();

        [TestCase]
        public void TestApple_WhenApple_ThenApple()
        {
            string output = "apple";
            Assert.AreEqual(output, apples.GetApple());
        }

        [TestCase]
        public void TestApple_WhenApples_ThenFailedTest()
        {
            string output = "apples";
            Assert.AreEqual(output, apples.GetApple());            
        }

        [TestCase]
        public void TestApple_WhenApple_ThenFailedTest2()
        {
            string output = "Apple";
            Assert.AreEqual(output, apples.GetApple());
        }

        [TestCase]
        public void TestApple_WhenNothing_ThenFailedTest3()
        {
            string output = "";
            Assert.AreEqual(output, apples.GetApple());
        }
    }
}
