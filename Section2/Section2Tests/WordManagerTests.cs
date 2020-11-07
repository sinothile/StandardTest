using NUnit.Framework;
using Section2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2Tests
{
    [TestFixture]
    public class WordManagerTests
    {
        [Test]
        public void Given_sentence_should_reverse_the_sentence()
        {
            //Arrange
            var sentence = "The Rain in Spain";
            var wordManager = new WordManager();

            //Act
            var actual = wordManager.ReverseSentence(sentence);

            //Assert
            var expected = "Spain in Rain The";
            Assert.AreEqual(actual, expected);
        }

    }
}
