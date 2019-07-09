using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PasswordGenerator
{
    // In this class a unique set of simbols generated for each new program run.
    class SetOfSymbols
    {
        //Returns a set of ASCII symbols in a given range
        public char[] NewAlphabet(int min, int max)
        {
            char[] alphabet = new char[max - min];
            for (int i = min; i < max; i++)
            {
                char c = (char)i;

                alphabet[i - min] = c;
            }
            return alphabet;
        }

        public char[] NewSetOfSymbols(char[] alphabet)
        {
            Random random = new Random();
            //Number of iterations is random and in range between 100 and 1000
            for (int i = 0; i < random.Next(100, 1000); i++)
            {
                int element1 = random.Next(alphabet.Length);
                int element2 = random.Next(alphabet.Length);
                while (element1 == element2)
                {
                    element2 = random.Next(alphabet.Length);
                }
                //Method Swap below
                Swap(ref alphabet[element1], ref alphabet[element2]);
            }

            return alphabet;
            
        }

        //Two random letters from the alphabet are swapped
        private void Swap (ref char c1, ref char c2)
        {
            char temp;
            temp = c1;
            c1 = c2;
            c2 = temp;
        }
    }
}
