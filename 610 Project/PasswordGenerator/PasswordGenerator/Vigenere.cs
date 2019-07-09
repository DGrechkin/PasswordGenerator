using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Vigenere
    {   //Encription Method
        public string Encryption(string password)
        {
            Random random = new Random();

            int keyNumber = random.Next(10); //Randomly peeks a key
            string key = SetOfKeys(keyNumber);

            int tableNumber = random.Next(10); //Randomly peeks a table
            char[] table = SetOfVigenereTables(tableNumber);

            int displacementNumber = random.Next(10); //Randomly peeks a displacement
            int displacement = SetOfDisplacements(displacementNumber);

            char[] charPassword = password.ToCharArray(); //parse original password to set of chars
            char[] charEncPass = new char[charPassword.Length]; //array for encrypted chars
            
            int keyIndex;
            int newIndex;
            int tableIndex;
            int counter = 0;

            foreach (char c in charPassword)
            {
                keyIndex = Array.IndexOf(table, key[counter]); //index of key character
                tableIndex = Array.IndexOf(table, c); //index of the original password character in the table
                newIndex = (displacement + keyIndex + tableIndex) % table.Length; //calculation of encripted char index
                charEncPass[counter] = table[newIndex]; //encripted char
                counter++;
            }

            string encryptedPassword = new string(charEncPass); 
            encryptedPassword = encryptedPassword + keyNumber + tableNumber + displacementNumber; //add to the end of password numbers of key, table, and displacement

            return encryptedPassword;
        }

        public string Decryption (string password)
        {
            int[] itemsNumbers = GetIndexes(ref password); //extract numbers of displacement, table, key
            int displacement = SetOfDisplacements(itemsNumbers[0]);
            char[] table = SetOfVigenereTables(itemsNumbers[1]);
            string key = SetOfKeys(itemsNumbers[2]);

            char[] charPassword = password.ToCharArray(); //encripted password to chars
            char[] charDecPass = new char[charPassword.Length]; //array for decrypted 

            int keyIndex;
            int newIndex;
            int tableIndex;
            int counter = 0;

            foreach (char c in charPassword)
            {
                keyIndex = Array.IndexOf(table, key[counter]); //index of key character
                tableIndex = Array.IndexOf(table, c); //index of the encripted password character in the table
                newIndex = tableIndex - displacement - keyIndex; //calculation of original char index
                Module(ref newIndex); //Calculation of module
                charDecPass[counter] = table[newIndex]; //decrypted char
                counter++;
            }
            
            string decryptedPassword = new string(charDecPass);

            return decryptedPassword;
        }

        private int[] GetIndexes (ref string password)
        {
            int[] indexes = new int[3]; //peek last three digits from encrypted password
            for (int i = 0; i < 3; i++)
            {
                int stringIndex = password.Length - 1; //index of the last char
                char lastIndex = password[stringIndex]; //last char
                int itemNumber = (int)Char.GetNumericValue(lastIndex); //parse the char to int
                indexes[i] = itemNumber;
                password = password.Remove(stringIndex); //remove last char from password
            }
            return indexes;
        }

        private void Module(ref int index)
        {
            if (index < 0)
            {
                index = index + 94; //add number of symbols in the table in case if index is below 0
                Module(ref index);
            }
        }

        //Set of 10 keys. Length 128 - 384 symbols.
        private string SetOfKeys(int index)
        {
            string[] keys = new string[10];

            keys[0] = "U2jsz80pU0fNx0xdXTRU70djy18z2j0oa5NW3GTAr86k93fd7G4d7ms0ICiah" +
                "R05ib3m9b4q1aOZz6L8Q87ep74P53P5ihxceL660Ixaxmduskkqc9rl37HWdown1wFf" +
                "41qZuo48O8ceMfhvbUM8xx0sUjqbVQ6Hjn49q9lwfmm1ZOjng2q8cado6kxd1V15MZ6" +
                "k2t173IDsH0kbcz871hhusNs49AcsR3pL7rxZo4Rjrw1j05dJhx9rRA7g2v8pikxsg6" +
                "e9qpjzxrOzc857bIj30a3h5u878Eeqze99uyg7cxtlq50e7n6Lmt9jxk";

            keys[1] = "jsmWldU3wkBjbdGnpUjOnH3kMxxFQVinj3s7PktccgY0wVgckHe4dbvZzICgX" +
                "ibn3YlsWfkChc2jijjaQjgpmDhWm4uv3BIjDg4RVEreFXjDxpWundBcjQVFJomljN1J" +
                "Xp0jqWZX4hduetfncLrQ2nliMTTIsrXw0ljR5ZJpgooMC7EpFKlJUmxD3iHr7WzYRYS" +
                "dVBMBnd9mzriJ6xrFbjeENneRRkrPFyHQvLLoxfejchgacrqSsC8oRru3tsjptGXTIH" +
                "6k5CdwnJxqCfolugHUBEonHMJmqbvEofNzxyrSgHbtvjtUExqBEggYeRh7iaqQtioSW" +
                "fgpULwIkCmByAueKachKXDkjgY";

            keys[2] = "fz0oIs47MdkuhusuS8blzt05s90e1Uk522t9cn23l15YQr23S7u72n1S8dg8I" +
                "3cxsN752oqA68cqdKa0084U0aLg067aJ3Ek19czQsn4lKaINetbzSx6dyxii4r7TM5H" +
                "4tjn26n20U2tC2ihF2vZ99fm6xmr77O2b3PmxB92a93IV77no4O5G4s26HHfe780Rr5" +
                "nt9rrxb8w0639DpCQpksuzkx1iLh17q19r7mc4ljq7mjnGXer310Q6btXvfBx0lFyjI" +
                "leE56pWTZl13P8g98nk45Lk2plF742Ju6087V71fam5o4mygu85Mmll31gtiq9z59E5" +
                "9bgvjRefobgteqwbfd63g73zr9zjM92btjQq";

            keys[3] = "nvy23o0CB35374b46c29R7t3Cy0wmi2o7B1cllf39Av66szmGdWp3euwLMkC5" +
                "89hjfp18899sARal7z1kg53vkEb1Ijo832J1a3Yf23qeb6r5kwqjD0kgpdodYogokU4" +
                "x85d3Tldz58g9VQ280tZh9648erv7bObk2t7YudPDweTw4gb8tzynNy5Wi4g1pk4hm";

            keys[4] = "unheqPMabFc9EnuaSXp5CfMi0z2rwu4G8bWhvrdgJl7LiOtoodGIlwxlvyZNw" +
                "swwweakVtfxIRjjIWcuspJUwInd0kDhf2kztNTYSEXcgslzzCcesxdIbdckuRGjWOaH" +
                "qS4caqpowcw4itg7Wc5qJp8wNxtXfCrfI87ovCfTRttBYwvbYf0mooRHxeeSbMzwm77" +
                "B4ujms0TvILovog3lZFbzbkVwNtGuQdfBhGu56foD90S3Vodyj5jxkmlLs5pqtzfShi" +
                "AhrY6cbPfVBWg9MxQGxd2zg78Taw4hgcwtyke";

            keys[5] = "u9fb7MypwsdJ32ja77p4F4zeP8Aie8082s5z90o5scsirfeeQvnrgrddod6yt" +
                "gznsx9909cl0z1uZwp0x1s139DetF1rWa338g9v26qk90Yt0I39bc90esfmi371cm5j" +
                "hntP8i9jk1xbo0uoK9lweBs8ta2A3t8971glMml10rkgbr3Z4iq2w4n38rnm65tn0N8" +
                "aSfUj967PuN8nj98T08yda7aSkompx2880i";

            keys[6] = "UiRwpIHgs5RJcYsYoTJA2K7v0vD3rH9rz4gcoEfJfojn184xkWglGbvA6x94S" +
                "QqCH970ihDkUlTgm4dOkxJuaAYbhjTpimZjW63m4fd8qk9Gxrk3IOpbdiQGqxJg87pn" +
                "bVkzkY144zjw";

            keys[7] = "ofUemaqhhuyvojaNJokicgC7UbX3pTLv48rFZ9Ogr8dzffzqaqq3hZ8huynBh" +
                "wqduuqqk4OhCTzhhBdIm4ifM18l0iCtpneuxcJjxxyzRpjecwloO5fgKiazwqIppcuX" +
                "wJohreAfXrrggBlgikipoFyEqhrgDfgouls9afipEcsaflPH7jv0xSpxfkVnpixys0o" +
                "2i5c7vp3tviauunbXyG6vp7R3YclDilJumoyDc990wnT71fbo8Ll4t6WfwRGp";

            keys[8] = "zseppkjihgyruhwvc5lafjgtjmL9jqnlsyakdtbymhugy39v9tlhH0yfno4xk" +
                "Invlagkglmkw1koylstikypqd8ql1vodomkysn1b79zQvzve5p2ageldWfaobpzksFy" +
                "aL7jxag2y21bahxsj4y2kmf5kxml6ZnpuvhekkyllddhEolgohfaiimkhwrckn8p3Ak" +
                "fcizoay7fqtuaxV2ycxvfdUkc3yt2hbdzdHarwbldrxuedaiip255zexsvfa7uutv4n" +
                "Rwby5zxzb6lfglgrrcqsccoxxx6iimvsyu2vu4zez34cyuk59ortfr";

            keys[9] = "7zpltokkha9fbQ74nawNh5wbVdGvgxykaVBlutcdM6N1eudc0tVgrBlvnakms" +
                "io1jBPDvEdzyqvymttFcaaZoiAevDxKe5k9m1YpsLpTmdjke2Dz9dmnxuLEAm1mjSdd" +
                "sXKJyxVCmF1KgmlfcsdlFtz2ZrRwzepr6nb9YE2db9ta00upmmzfTqgqsmhdpXbQyzk" +
                "lhIvnQcZLcpsYmDjlydjycpZk";

            string key = keys[index];

            return key;
        }

        //Set of 10 ASCII tables
        private char[] SetOfVigenereTables (int index)
        {
            char[][] tables = new char[10][];

            tables[0] = new char[] { '!', '|', 'G', 'L', 'q', 'X', ']', '@', 'Z', 'W',
                '0', '#', ')', '}', 'f', 'w', '+', 'c', '[', 'l', '{', '/', '?', 'F',
                'p', ':', 'd', 'r', 'B', 'o', 'U', '3', 'K', 'x', 'V', 'E', 'n', 'i',
                '$', 'C', 'A', 't', '5', '\'', '*', 'P', '4', 'S', 'e', '7', '^', '>',
                'k', '=', '&', 'I', 'H', '_', '`', 'M', 'T', 'b', '.', 'a', ';', '2',
                '<', 'u', '\\', 'h', '8', 'R', '-', 'D', 'j', '9', 'm', 'J', 'g', 'N',
                ',', '1', 'z', 'Y', '%', '(', 's', 'O', 'Q', '\"', '6', 'v', 'y', '~' };

            tables[1] = new char[] { '}', ',', 'i', 'C', 'g', '+', 'Y', 'A', 'w', '<',
                ':', 'f', ')', 'E', '\'', 'v', 'J', 'e', '4', 'H', '&', 'O', 'r', 'Z',
                '@', 'T', 'z', '"', '{', '2', '|', '\\', '^', 'W', ']', 'x', '%', 'a',
                'P', 'G', '9', 'd', 's', 'm', '=', 'b', 't', '-', 'V', 'R', 'y', '!',
                ';', 'M', 'N', '1', '?', '_', 'X', 'B', 'q', '#', 'K', '~', '5', 'n',
                '3', 'L', '[', 'l', 'D', 'h', '*', '0', 'p', '.', 'S', 'k', 'o', '>',
                'Q', '$', 'I', '(', 'F', 'U', '/', '6', 'j', '8', '7', 'u', 'c', '`' };

            tables[2] = new char[] { ':', 'N', 'q', ']', '-', '1', 'L', '/', '*', 'O',
                'A', '#', '6', '.', 's', 'K', 'n', '\'', 'z', '4', '9', '\\', 'H', 'I',
                'b', '[', 'f', '0', '>', 'm', '+', '!', 'x', ';', 'F', '}', '<', 'W',
                '(', 'i', 'u', '3', 'e', 'E', 'P', 'Y', '&', 'j', 'J', 'U', 'B', 'a',
                'r', 'V', 'M', '|', '_', 'd', 'Q', 'o', '@', '^', '~', '`', 'y', 'S',
                '=', 'g', '?', '5', 'R', 'p', ',', 'T', 'k', 'X', 'Z', '%', 'G', 'h',
                'D', '2', '"', 't', 'C', 'c', 'l', ')', 'v', 'w', '$', '7', '8', '{' };

            tables[3] = new char[] { '!', '-', 'c', '^', '.', 'Q', 'g', ')', 'a', '<',
                '`', 'S', 'I', '0', '(', 'f', 'z', '#', '/', 'G', ',', '&', '|', '"',
                'v', 'P', 'w', 'p', ']', '>', 'j', '$', ';', '5', '6', 'F', 'e', 'D',
                '@', 'J', '[', 'o', '7', 'y', '%', '~', 'Z', 'm', 'u', 'V', 'N', '*',
                'U', 'C', 'b', '4', 'Y', 'i', '8', 'W', '?', 'l', '3', 'K', 's', '\'',
                'H', 'q', 'L', 'r', 'T', 'X', ':', 'E', '1', '_', '{', 't', 'A', 'M',
                '\\', 'O', '+', 'h', '}', 'k', 'd', 'x', '9', 'R', 'n', 'B', '=', '2' };

            tables[4] = new char[] { '!', ':', 'n', 'i', 'd', '.', 'w', ']', ')', 'B',
                'H', 'p', 'c', 'X', 'W', 'b', 'C', '%', '{', 'Q', '[', 'r', 't', 'f',
                'J', 'A', ';', 'E', '>', 'T', '=', '@', 'M', 'K', 'u', '2', 's', '7',
                'U', 'R', 'h', 'O', 'e', 'y', '8', 'k', 'D', '#', '9', '\\', '0', 'Y',
                'z', 'V', 'F', '^', '3', '?', 'q', 'N', '<', '\'', '5', 'L', '1', 'G',
                ',', '}', '$', 'l', 'I', 'a', '-', '/', '"', '4', 'Z', 'v', 'o', 'S',
                '_', 'g', '*', '6', 'P', 'j', '+', 'x', '(', 'm', '`', '~', '&', '|' };

            tables[5] = new char[] { 'O', 'K', '.', 'o', 'V', 'c', '8', 'z', 'w', '>',
                '-', '=', 'H', '<', 'P', ')', '?', ',', 'k', 'B', '$', 'v', 'e', 'X',
                '|', 'i', '[', 'm', '_', '0', 'I', '/', 'Y', 'E', 'x', ';', 'd', 'F',
                'G', 'T', '"', 'Q', '3', 'L', 'U', 't', '1', 'S', 'g', 'R', 'A', 'p',
                'D', 'q', 'N', '#', '~', 'Z', 'a', '6', ':', ']', 'j', 'f', '7', '+',
                'h', '4', 'J', '!', '@', '(', '\\', '`', '9', 'l', 's', 'n', '^', '\'',
                '5', '&', '}', 'b', 'C', '{', 'u', 'M', 'y', 'W', '*', '2', 'r', '%' };

            tables[6] = new char[] { '!', '/', 'C', '8', 's', '4', '9', 'L', 'Z', '1',
                'B', '_', '@', 'D', 'x', 'z', '+', 'Y', 'N', ',', 'e', '3', 'q', 'y',
                'p', '`', 'U', 'P', '^', '>', 'K', '$', 'A', 'F', ':', 'n', 'a', 'o',
                't', 'H', 'I', 'g', '[', ']', 'T', '#', '-', '\'', 'Q', 'R', '"', '.',
                '2', '<', '}', '{', '(', 'w', '~', '5', 'M', '?', '&', '0', 'i', 'c',
                'W', 'X', 'l', 'G', ')', '=', '6', 'j', 'f', 'k', 'O', '%', 'S', 'v',
                '|', '7', 'E', 'r', 'h', 'V', 'u', '*', 'm', '\\', 'd', ';', 'J', 'b' };

            tables[7] = new char[] { 'T', 'g', '.', '~', '*', 'C', 'K', '6', 'x', '`',
                'k', '<', '!', 'W', '8', 'z', '1', '%', 'v', 'i', 'N', '{', '[', ';',
                '}', 'G', 'Y', 'c', 'O', 'V', '0', 'f', '^', '&', 'e', 'y', ',', '7',
                'b', 'B', 'D', '4', 'Q', '/', 'P', '#', 'w', '\'', ':', '-', 'o', 'Z',
                '@', 'U', '|', 'X', ']', 's', '+', ')', 'a', '2', '_', '\\', 'M', 'L',
                'H', 'd', '?', '(', 'J', 'q', 'u', 'E', 'A', 'l', 'n', '9', 'p', '>',
                '"', 'F', '5', '=', 'r', 'j', 'R', 'm', 't', 'S', '3', 'I', 'h', '$' };

            tables[8] = new char[] { 'I', '&', 'G', 'h', 'x', 'd', '+', '$', 'w', '*',
                '7', 'V', 'm', '?', 'o', 'l', 'z', '8', '%', 'a', 'Y', 'R', '4', '5',
                'E', '0', ';', 'F', 'X', 'e', '.', '@', 'T', '{', 'c', 'D', 'P', '|',
                '2', '`', '6', 'U', 'v', 'f', 'k', '3', 'O', '>', 'b', '<', ')', 'j',
                '~', 'q', '_', 'g', '}', ']', 'u', 'Q', '[', '#', '\\', '^', 'A', 'L',
                'K', 'y', 'r', ':', '/', 'M', 'B', 'S', 'i', 'W', 'C', 'n', '!', 'p',
                '(', '-', 's', 't', 'H', 'J', '1', 'N', '=', 'Z', ',', '\'', '9', '"' };

            tables[9] = new char[] { 'K', 'T', '#', '\\', '+', '/', '>', 'S', '(', '*',
                'w', '`', 'F', 'v', '\'', 'B', '|', 'j', 'q', '!', '7', 'p', '2', 'C',
                '9', ':', 't', 'b', '=', 'W', '?', 'O', 'Q', 'n', 'i', 'M', '_', '{',
                ';', 'V', '@', '1', ')', '8', '4', '$', 'l', 'P', 'o', '~', 'R', 'h',
                'X', '^', '3', 's', '}', 'Z', 'e', '0', ']', 'a', 'J', 'G', 'u', '-',
                'A', 'N', 'Y', 'f', '6', 'r', '"', '%', ',', 'y', '&', 'H', 'U', '<',
                'm', 'k', 'I', '.', '[', 'c', 'L', 'x', 'd', 'z', '5', 'g', 'E', 'D' };

            char[] table = tables[index];

            return table;
        }

        //10 randomly peeked numbers 0 - 94 (number of chars in tables)
        private int SetOfDisplacements(int index)
        {
            int[] displacements = { 84, 41, 36, 2, 23, 79, 9, 8, 88, 10 };

            int displacement = displacements[index];
            
            return displacement;
        }
    }
}
