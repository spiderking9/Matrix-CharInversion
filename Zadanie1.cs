using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace AgileroKrakow
{
    public class Zadanie1
    {
        public static string RemoveBadChars(string word)
        {
            //Check if you pass corect value
            if (word == null || word.Length == 0) return null;

            char[] chars = new char[word.Length];

            //initialize var for length of new array
            int myindex = 0;

            //change letters to lower and miss anything else
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];

                if ((int)c >= 65 && (int)c <= 90)
                {
                    chars[myindex] = (char)(c + 32);
                    myindex++;
                }
                else if ((int)c >= 97 && (int)c <= 122)
                {
                    chars[myindex] = c;
                    myindex++;
                }
            }

            //change size of new array and convert to string
            return new string(ChangeSizeOfArray(chars, myindex));
        }
        public static char[] ChangeSizeOfArray(char[] table, int size)
        {
            char[] charTable = new char[size];
            for (int i = 0; i < size; i++) charTable[i] = table[i];

            return charTable;
        }

        public static char[] CharToArray(string word)
        {
            char[] charTable = new char[word.Length];
            for (int i = 0; i < word.Length; i++) charTable[i] = word[i];

            return charTable;
        }

        public static string CharInversion(string word)
        {
            //remove what aren't letters
            word = RemoveBadChars(word);

            //Check if you pass corect value if not break method and show why
            if (word == null || word.Length == 0)
            {
                Console.WriteLine("Recommended type is string");
                return null;
            }

            //convert string to char table
            char[] charArray = CharToArray(word);

            //take length of string
            int len = word.Length - 1;

            //change places chars in charArray by xor, when will be middle it will stop
            for (int i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }

            //change first letter to upper
            charArray[0] = (char)(charArray[0] - 32);

            return new string(charArray);
        }

    }
}
