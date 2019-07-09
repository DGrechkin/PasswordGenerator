using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace PasswordGenerator
{
    class EnglishWords
    {
        //Method to peek a word or several words
        public string GetWord ()
        {
            string word = LongWord(string.Empty);//Get the word
            return word;
        }
        //Method for changing of some symbols
        public string StrengthenWord(string word)
        {
            word = ChangeToSymbols(word);
            return word;
        }
        //Method for creation of a long word
        private string LongWord(string word)
        {
            string newWord = string.Empty;
            while (string.IsNullOrEmpty(newWord))
            {
                string tempWord = ExtractFromFile();
                if (tempWord.Length > 3) //words that less than 3 characters long are ommited
                    newWord = tempWord;
                else
                    System.Threading.Thread.Sleep(50); //Sleep allowes to change system variables and Random function produce a new value.
            }
            word += newWord;
            if (word.Length > 8) //Usually, passwords must be longer than 8 characters.
                return word;
            else
            {
                System.Threading.Thread.Sleep(50);
                return LongWord(word + '_');//Recursion
            }
        }

        private string ExtractFromFile()
        {
            Random random = new Random();
            string path = @"C:\Password Generator\words.txt";

            int lineNumber = random.Next(1, 466548);//466548 - number of lines in word.txt 3/20/2019
            string word = File.ReadLines(path).Skip(lineNumber - 1).Take(1).First(); //peek random line from the file
            return word;
        }
        //Set of symbols that can be changed
        private string ChangeToSymbols(string word)
        {
            Random random = new Random();
            char[] elements = word.ToCharArray();
            for(int i = 0; i < elements.Length; i++)
            {
                switch (elements[i])
                {
                    case 'a':
                        if (random.Next(2) == 1) //all symbols has a 50% chance to appear
                            elements[i] = '@';
                        break;
                    case 'l':
                        if (random.Next(2) == 1)
                            elements[i] = '1';
                        break;
                    case 'i':
                        if (random.Next(2) == 1)
                            elements[i] = '!';
                        break;
                    case 'g':
                        if (random.Next(2) == 1)
                            elements[i] = '8';
                        break;
                    case 's':
                        if (random.Next(2) == 1)
                            elements[i] = '$';
                        break;
                    case 'o':
                        if (random.Next(2) == 1)
                            elements[i] = '0';
                        break;
                    case 'j':
                        if (random.Next(2) == 1)
                            elements[i] = '?';
                        break;
                    case 'b':
                        if (random.Next(2) == 1)
                            elements[i] = '&';
                        break;
                    case 'q':
                        if (random.Next(2) == 1)
                            elements[i] = '9';
                        break;
                    case 'c':
                        if (random.Next(2) == 1)
                            elements[i] = 'C';
                        break;
                    case 'z':
                        if (random.Next(2) == 1)
                            elements[i] = 'Z';
                        break;
                    case 'p':
                        if (random.Next(2) == 1)
                            elements[i] = 'P';
                        break;
                    case 'k':
                        if (random.Next(2) == 1)
                            elements[i] = 'K';
                        break;
                    case 'x':
                        if (random.Next(2) == 1)
                            elements[i] = 'X';
                        break;
                    case 'v':
                        if (random.Next(2) == 1)
                            elements[i] = 'V';
                        break;
                    case 'u':
                        if (random.Next(2) == 1)
                            elements[i] = 'U';
                        break;
                }
            }
            word = new string(elements);
            return word;
        }
    }
}
