using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    class SetOfActions
    {
        //Set of main functions

        //New random set of symbols password 
        public static string GenerateNewPassword(int passLength, string specialSymbols)
        {
            SetOfSymbols set = new SetOfSymbols();
            char[] symbols = set.NewSetOfSymbols(set.NewAlphabet(97, 123)); //Generate a new set of symbols from the alphabet

            PasswordProduction pass = new PasswordProduction();
            string password;

            password = pass.GeneratePassword(symbols, passLength, specialSymbols); // Generate password
            return password;
        }

        public static string[] GeneratePronPassword()
        {
            EnglishWords ew = new EnglishWords();

            string originalWord = ew.GetWord();//Word before changing
            string word = ew.StrengthenWord(originalWord);//Word after changing

            return new string[] { originalWord, word };
        }

        public static string GetPassword(string getName, string path)
        {
            Vigenere vigenere = new Vigenere();
            InputOutput inputOutput = new InputOutput();

            string psswrd = inputOutput.ReadPassword(getName, path); //Get password
            psswrd = vigenere.Decryption(psswrd); //Decrypt the password
            return psswrd;
        }
        
        //Save password
        public static void SavePassword(string password, string name, string path)
        {
            Vigenere vigenere = new Vigenere();
            InputOutput inputOutput = new InputOutput();

            password = vigenere.Encryption(password); //Encrypt the password
            inputOutput.WritePassword(name, password, path); //Add password to file
        }

        //Update already existing password
        public static void UpdatePassword(string password, string name, string path)
        {
            Vigenere vigenere = new Vigenere();
            InputOutput inputOutput = new InputOutput();

            password = vigenere.Encryption(password); //Encrypt th password
            inputOutput.RewritePassword(name, password, path); //Update the password by name

        }
    }
}
