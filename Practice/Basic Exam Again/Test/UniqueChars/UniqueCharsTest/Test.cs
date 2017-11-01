using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueChars;

namespace UniqueCharsTest
{
    [TestFixture]

    public class Test
    {
        static void Main(string[] args)
        {
            
        }

        [TestCase]
        public void TestUniqueCharMaker_WhenTestWordHaveWhiteSpace()
        {
            //arrange
            string userinput = "ku tyuka";

            //act
            List<char> resultList = new List<char>
            {
                {'t'},
                {'y'},
                {'a'}
            };
            
            //assert
            Assert.AreEqual(resultList, UniqueChars.Program.UniqueCharacters(userinput));
        }

        [TestCase]
        public void TestUniqueCharMaker_WhenThereIsUpperCharacterInTheString()
        {
            //arrange
            string userinput = "ku Tyuka";

            //act
            List<char> resultList = new List<char>
            {
                {'t'},
                {'y'},
                {'a'}
            };

            //assert
            Assert.AreEqual(resultList, UniqueChars.Program.UniqueCharacters(userinput));
        }

        [TestCase]
        public void TestUniqueCharMaker_WhenThereAreMoreSameCharacterInARow()
        {
            //arrange
            string userinput = "kuuuuUU Tyuka";

            //act
            List<char> resultList = new List<char>
            {
                {'t'},
                {'y'},
                {'a'}
            };

            //assert
            Assert.AreEqual(resultList, UniqueChars.Program.UniqueCharacters(userinput));
        }
    }
}
