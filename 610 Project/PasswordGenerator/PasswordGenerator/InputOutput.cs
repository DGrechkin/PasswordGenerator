using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class InputOutput
    {
        //Method for writing passwords into a file
        public void WritePassword (string name, string password, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("==================");
                sw.WriteLine(name);
                sw.WriteLine("------------------");
                sw.WriteLine(password);
            }
        }

        //This method allows to update password by name
        public void RewritePassword (string name, string password, string path)
        {
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd(); //Copies and stores the whole document in the string
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string change;
                string line;
                while ((line = sr.ReadLine()) != null) //Reads the whole document line by line
                {
                    if (line == name) //If a line equls to value of name...
                    {
                        sr.ReadLine(); //...miss one line, which equals "------------------"...
                        change = sr.ReadLine(); //...take old password...
                        text = text.Replace(change, password); //... and replace old password with the new one.
                    }
                }
            }

            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.Write(text); //Rewrites the whole file with new password
            }
        }

        //Return password from the file
        public string ReadPassword (string name, string path)
        {
            string password = "Password not found!";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null) //Reads the file line by line
                {
                    if (line == name)
                    {
                        sr.ReadLine(); //Miss one line, "------------------"
                        password = sr.ReadLine();
                    }
               
                }
            }
            return password;
        }
    }
}
