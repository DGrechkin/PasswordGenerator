using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PasswordProduction
    {
        private Random random = new Random();
        //Method GeneratePassword generates a password for two cases: with and without special characters
        public string GeneratePassword(char[] symbols, int passLength, string specialSymbols)
        {
            string password;

            if (string.IsNullOrEmpty(specialSymbols)) //String property that checks string for Null and Emptiness then returns Boolean
            {
                //First case, without special symbols
                password = Password(symbols, passLength);
                return password;
            }
            else
            {
                //Second case, with special symbols
                password = Password(symbols, passLength, specialSymbols);
                return password;
            }
        }

        //Method Password is cumulative and call methods below to generate the password.
        public string Password(char[] cset, int length)
        {
            char[] newPassword = Step1(cset, length); //Step1 generates char array of random letters from the unique alphabet
            newPassword = Step2(newPassword);         //Step2 changes random number (maximum half) of char sequence to upper case
            newPassword = Step3(newPassword);         //Step3 changes random number (maximum half) of char sequence to numbers

            return new string(newPassword);           //Returns string
        }
        //Reloaded method Password that contains special symbols variable
        public string Password(char[] cset, int length, string symbols)
        {
            char[] newPassword = Step1(cset, length);
            newPassword = Step2(newPassword);
            newPassword = Step3(newPassword);
            newPassword = Step4(newPassword, symbols); //Step4 changes random number of char sequence to special symbols, works only if there are some special symbols
            return new string(newPassword);
        }
        //Step1 generates char array of random letters from the unique alphabet
        private char[] Step1 (char[] cset, int length)
        {
            char[] pass = new char[length];

            for(int i = 0; i < length; i++)
            {
                pass[i] = cset[random.Next(cset.Length)];
            }

            return pass;
        }
        //Step2 changes random number (maximum half) of char sequence to upper case
        private char[] Step2 (char[] pass)
        {
            int repeats = random.Next((pass.Length / 2 - 1) + 1);
            for (int i = 0; i < repeats; i++)
            {
                int number = random.Next(pass.Length);
                pass[number] = char.ToUpper(pass[number]);
            }

            return pass;
        }
        //Step3 changes random number (maximum half) of char sequence to numbers
        private char[] Step3 (char[] pass)
        {           
            int repeats = random.Next((pass.Length / 2 - 1) + 1);

            for (int i = 0; i < repeats; i++)
            {
                int number = random.Next(pass.Length);
                char[] element = random.Next(10).ToString().ToCharArray();
                pass[number] = element[0];
            }

            return pass;
        }
        //Step4 changes random number of char sequence to special symbols
        private char[] Step4 (char[] pass, string symb)
        {
            char[] symbols = symb.ToCharArray();
            if (symbols.Length < pass.Length / 2) //If number of special symbols is less than a half of password length then each symbol will be processed
            {
                foreach (char symbol in symbols)
                {
                    int arg = Convert.ToInt32(pass.Length * 0.1); // Each special symbol may occur from maximum 10% of password's length times...
                    int repeats = random.Next(arg) + 1;  //...to at least 1 time.
                    for (int i = 0; i < repeats; i++)
                    {
                        int number = random.Next(pass.Length);
                        pass[number] = symbol;
                    }
                }
            }
            else //If number of special symbols is more than half of password length then maximum half of password may be changed by random special symbols 
            {
                int numberOfSymbols = random.Next((pass.Length / 2 - 1) + 1);
                for (int i = 0; i < numberOfSymbols; i++)
                {
                    int number = random.Next(pass.Length);
                    pass[number] = symbols[random.Next(symbols.Length)];
                }
            }
            return pass;
        }
    }
}
