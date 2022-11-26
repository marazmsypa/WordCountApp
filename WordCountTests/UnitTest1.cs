using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCountLibrary;

namespace WordCountTests
{
    [TestClass]
    public class UnitTest1
    {
        WordCountClass testedObj = new WordCountClass();
        /// <summary>
        /// ввод пустого слова, возврат исключения
        /// </summary>
        [TestMethod]
        public void WordCount_EmptyWord_ReturnException()
        {
            string entryString = "";
            string entryWord = "";
            Assert.ThrowsException<Exception>(() => testedObj.WordCount(entryString, entryWord));

        }
        /// <summary>
        /// ввод неверного слова, возврат исключения
        /// </summary>
        [TestMethod]
        public void WordCount_WrongWord_ReturnException()
        {
            string entryString = "";
            string entryWord = "123";
            Assert.ThrowsException<Exception>(() => testedObj.WordCount(entryString, entryWord));

        }
        /// <summary>
        /// ввод неверной строки, возврат исключения
        /// </summary>
        [TestMethod]
        public void WordCount_WrongString_ReturnException()
        {
            string entryString = "ээй!!!21";
            string entryWord = "привет";
            Assert.ThrowsException<Exception>(() => testedObj.WordCount(entryString, entryWord));

        }
        /// <summary>
        /// ввод пустой строки и слова, возврат 0
        /// </summary>
        [TestMethod]
        public void WordCount_ZeroWordCountEnmptyString_ReturnZero()
        {
            string entryString = "";
            string entryWord = "привет";
            int countExpect = 0;
            int actualCount = testedObj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, actualCount);

        }
        /// <summary>
        /// ввод строки и слова, не находящегося в строке, возврат 0
        /// </summary>
        [TestMethod]
        public void WordCount_ZeroWordCountString_ReturnZero()
        {
            string entryString = "здравствуй Люба";
            string entryWord = "привет";
            int countExpect = 0;
            int actualCount = testedObj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, actualCount);

        }
        /// <summary>
        /// ввод строки и слова, находящегося в строке, возврат 1
        /// </summary>
        [TestMethod]
        public void WordCount_OneWordCountString_ReturnOne()
        {
            string entryString = "привет Люба";
            string entryWord = "привет";
            int countExpect = 1;
            int actualCount = testedObj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, actualCount);

        }
        /// <summary>
        /// ввод строки и слова, находящегося в строке два раза, возврат 2
        /// </summary>
        [TestMethod]
        public void WordCount_TwoWordCountString_ReturnOne()
        {
            string entryString = "привет Люба привет";
            string entryWord = "привет";
            int countExpect = 2;
            int actualCount = testedObj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, actualCount);
        }

        /// <summary>
        /// ввод строки и слова, находящегося в строке 4 раза, возврат 4
        /// </summary>
        [TestMethod]
        public void WordCount_FourWordCountString_ReturnOne()
        {
            string entryString = "лишь утратив все до конца мы обретаем все все все";
            string entryWord = "все";
            int countExpect = 4;
            int actualCount = testedObj.WordCount(entryString, entryWord);
            Assert.AreEqual(countExpect, actualCount);
        }
    }
}
