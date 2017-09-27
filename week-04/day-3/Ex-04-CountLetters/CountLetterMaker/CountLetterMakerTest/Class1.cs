using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountLetterMaker;

namespace CountLetterMakerTest
{
    [TestFixture]
    public class Class1
    {       
        [TestCase]
        public void TestCountLetter_WhenGetWord_ThenGoodOutput()
        {
            //arrange
            string UserInput = "kutyamutya";

            //act
            Dictionary<char, int> output = new Dictionary<char, int>()
            {
                { 'k', 1 },
                { 'u', 2 },
                { 't', 2 },
                { 'y', 2 },
                { 'a', 2 },
                { 'm', 1 },
            };

            //assert
            Assert.AreEqual(output, Program.CountLetterFuncion(UserInput));
        }

    }
}
