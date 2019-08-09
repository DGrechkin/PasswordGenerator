# PasswordGenerator
Password generator program for Windows. This program is a part of my Independent Research class written on C#.
The program has different settings and two modes: first mode is a random character mode. The length and set of special symbols can be chosen by a user. In the second mode the program peeks an English word from a list of words that was downloaded and stored on the computer (C:\Users\[user name]\AppData\Local\My Applications\Password Generator) at the first run of the program and modifys it. User has an option to choose his/her own word.
All passwords can be stored on the computer in encrypted form. For encription Vigenere's algorithm with some modifications was used.

Project structure:
1. Program.cs - is the class that contains Main() method;
2. GUI.cs & GUI.Designer.cs - classes of Windows Forms interface;
3. EnglishWords.cs - the class that is responsible for peeking of a word from the list of words and modifying it;
4. InputOutput.cs - the class that is responsible for reading from and writing to a text file with passwords;
5. PasswordProduction.cs - the class contains methods for production of a random characters possword;
6. SetOfActions.cs - the class that contains calls of methods for programs functionality;
7. SetOfSymbols.cs - the calss generates a unique set of characters for password production;
8. Vigenere.cs - the class that contains Vigenere algorithm used for encryption.
