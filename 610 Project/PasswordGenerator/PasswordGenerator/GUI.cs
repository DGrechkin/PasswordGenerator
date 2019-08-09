using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private string folderPath = 
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\My Applications\\Password Generator"; //Path to folder
        private string path; //Variable that used for storing path to passwords

        //Radio button for pronouncable password
        private void pronPass_radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton pronPass_radio = (RadioButton)sender;
            if (pronPass_radio.Checked)
            {
                length_field.Enabled = false; //disable length field
                specSymbols_field.Enabled = false; //disable special symbols field
                usersWord_field.Enabled = true; //enable user's word field
            }
        }

        //Radio button for random characters password
        private void charPass_radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton charPass_radio = (RadioButton)sender;
            if (charPass_radio.Checked)
            {
                length_field.Enabled = true;
                specSymbols_field.Enabled = true;
                usersWord_field.Enabled = false;
            }
        }

        //Actions when the form is loading
        private void GUI_Load(object sender, EventArgs e)
        {
            loadForm(); //Load the form
        }
        //Method, tat can be recalled later
        private async void loadForm()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (Properties.Settings.Default.FirstRunSetting) //Creates the options file if it doesn't exist
            {
                Properties.Settings.Default.FirstRunSetting = false;
                Properties.Settings.Default.PathToFile = folderPath + "\\Passwords.txt"; //Default directory for the passwords file
                Properties.Settings.Default.Save();
            }

            path = Properties.Settings.Default.PathToFile;
            path_field.Text = path;
         
            if (!File.Exists(path)) //Creates the passwords file if it doesn't exist
            {
                File.Create(path).Close();
            }
            else
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    setOfNames_field.Items.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "==================")
                        {
                            setOfNames_field.Items.Add(sr.ReadLine()); //take all names to the ComboBox
                        }
                    }
                }
            }

            //Download the words file.
            string path_words = folderPath + "\\words.txt"; //Directory, where the file with words is stored.
            if (!File.Exists(path_words)) //Download the words file if it doesn't exist
            {
                pronPass_radio.Enabled = false;

                using (WebClient wc = new WebClient())
                {
                    string url = "https://raw.githubusercontent.com/dwyl/english-words/master/words.txt";
                    Uri uri = new Uri(url);
                    await wc.DownloadFileTaskAsync(uri, path_words);
                }

                pronPass_radio.Enabled = true;
            }
        }
        
        //Generate button functions
        private void generate_button_Click(object sender, EventArgs e)
        {
            if (charPass_radio.Checked) //In case if radio button for random characters password is chosen
            {
                int length = (int)length_field.Value;
                string specSymbols = specSymbols_field.Text;

                string password = SetOfActions.GenerateNewPassword(length, specSymbols);
                pass_field.Text = password;
            }
            else if (pronPass_radio.Checked) //In case if radio button for pronounceable password is chosen
            {
                if (string.IsNullOrEmpty(usersWord_field.Text)) //If the user's word field is empty then one of the words from "words" file is peeked
                {
                    string[] password = SetOfActions.GeneratePronPassword();
                    pass_field.Text = password[1]; //Word with special symbols
                    originalWord_lable.Text = password[0]; //Original word
                }
                else //If there is a user's word then only some letters replaced by special symbols
                {
                    EnglishWords ew = new EnglishWords();
                    string password = ew.StrengthenWord(usersWord_field.Text);
                    pass_field.Text = password;
                }
            }
        }

        //Action, when one of the names is peeked from the list of the names
        private void setOfNames_field_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string name = cb.Text;
            string password = SetOfActions.GetPassword(name, path); //Load the password

            pass_field.Text = password;
        }

        //Save button functions
        private void save_button_Click(object sender, EventArgs e)
        {
            var names = setOfNames_field.Items; //list of names
            string name = setOfNames_field.Text; //choosen name
            string password = pass_field.Text;

            if (names.Contains(name)) //if name in the "names" list then password is updated
            {
                SetOfActions.UpdatePassword(password, name, path);
            }
            else//In other case the new name is added to the list and password is saved in the file with new name
            {
                SetOfActions.SavePassword(password, name, path);
                setOfNames_field.Items.Add(name);
            }
        }

        //Browse button functions
        private void browse_button_Click(object sender, EventArgs e)
        {
            string newPath;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) //if in dialog window was pressed OK
            {
                path_field.Text = folderBrowserDialog1.SelectedPath + @"\Passwords.txt";                               
                newPath = path_field.Text; //new path
                if (!File.Exists(newPath)) //If file "Password.txt" doesn't exists on the new path
                {
                    File.Move(path, newPath); //Move the password file to the new directory
                    path = newPath; //update global path variable

                    Properties.Settings.Default.PathToFile = newPath;
                    Properties.Settings.Default.Save();
                }
                else //If file "Password.txt" exists on the new path
                {
                    string message1 = "File \"Password.txt\" already exists on this path, would you like to use it instead of the one that you are trying to move?";
                    string title = "File Exists";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    DialogResult question1 = MessageBox.Show(message1, title, buttons, icon); //Rise dialod

                    if (question1 == DialogResult.Yes) //Use existing file with passwords
                    {
                        path = newPath; //update global path variable

                        Properties.Settings.Default.PathToFile = newPath;
                        Properties.Settings.Default.Save();

                        loadForm();
                    }
                    else //otherwise, rise another question.
                    {
                        string message2 = "Would you like to replace the old file by the new one?";
                        DialogResult question2 = MessageBox.Show(message2, title, buttons, icon);

                        if (question2 == DialogResult.Yes) //If yes, replace the old file with a new one.
                        {
                            File.Delete(newPath); //Delete old file
                            File.Move(path, newPath); //Move the password file to the new directory
                            path = newPath; //update global path variable

                            Properties.Settings.Default.PathToFile = newPath;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            path_field.Text = path;
                        }
                    }
                }
            }
        }

        private void pass_field_Click(object sender, EventArgs e)
        {
            pass_field.SelectAll();
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            string message = "Student: Dmitriy Grechkin\nSupervisor: Doctor Si Chen\nCSC610 - Independent Research\nSpring 2019\nWest Chester University";
            string title = "About";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, title, button, icon);
        }

        //Close the application
        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
