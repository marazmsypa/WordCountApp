using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCountLibrary
{
    public class WordCountClass
    {
        /// <summary>
        /// принимает на вход строку и слово и считает все вхождения этого слова в сроку 
        /// </summary>    
        /// <returns>
        /// число вхождений слова в строку 
        /// </returns>
        public int WordCount(string textString, string word)
        {
            int count = 0;
            textString = textString.ToLower();
            string regString = @"^[a-zа-я\s]*$";
            string regWord = @"^[a-zа-я]{2,}$";
            if (!Regex.IsMatch(textString, regString, RegexOptions.IgnoreCase))
            {
                throw new Exception("вы ввели неверную строку");
            }
            if (!Regex.IsMatch(word, regWord, RegexOptions.IgnoreCase))
            {
                throw new Exception("слово содержит неправильные символы или имеет длинну менее 2-х символов");
            }
            string words = "";
            foreach (char item in textString)
            {
                if (item != ' ')
                {            
                        words += item;                    
                }
                if (item == ' ')
                {
                    if (words == word)
                    {
                        count++;
                    }
                    words = "";
                }
            }
            if (words == word)
            {
                count++;
            }
            words = "";
            return count;
        }
    }
}
