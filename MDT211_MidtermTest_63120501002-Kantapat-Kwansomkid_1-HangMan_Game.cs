using System;

namespace MDT211_MidtermTest_63120501002-Kantapat-Kwansomkid_1-HangMan_Game
{
    class HangMan_Game
    {   
        static bool IsWord(string secreword, List<string> letterGuessed)
        {

            bool word = false;
            for (int i = 0; i < secreword.Length; i++)
            {
                string c = Convert.ToString(secreword[i]);
                if (letterGuessed.Contains(c))
                {
                    word = true;
                }

                else
                {
                    return word = false;
                }

            }
            return word;
        }
        static string Isletter(string secretword, List<string> letterGuessed)
        {
             string correctletters = "";

            for (int i = 0; i < secretword.Length; i++)
            {

                string c = Convert.ToString(secretword[i]);

                if (letterGuessed.Contains(c))
                {
                    correctletters += c;
                }
                else
                {
                    correctletters += "_ ";
                }

            }
            return correctletters;

        }
        static void GetAlphabet(string letters)
        {
            List<string> alphabet = new List<string>();

            for (int i = 1; i <= 26; i++)
            {
                char alpha = Convert.ToChar(i + 96);
                alphabet.Add(Convert.ToString(alpha));
            }

            int num = 49;
            Console.Foreground = Console.Magenta;
            Console.WriteLine("Input letter alphabet:");

            for (int i = 0; i < num; i++)
            {
                if (letters.Contains(letters))
                {
                    alphabet.Remove(letters);
                    num -= 1;
                }
                Console.Write("[" + alphabet[i] + "] ");
            }

            Console.WriteLine();

        }
        static void Main()
        {
            Console.Title = ("Play Game Hangman");

            string secretword = "Please Select Menu :";
            List<string> letterGuessed = new List<string>();


            int live = 5;
            Console.Foreground = Console.Write;
            Console.WriteLine("Welcome to Hangman Game");
            Console.Foreground = Console.Write;
            Console.WriteLine("1. Play game", secretword.Length);
            Console.Foreground = Console.Write;
            Console.WriteLine("2. Exit", live);
            Isletter(secretword, letterGuessed);
            while (live > 0)
            {
                Console.Foreground = Console.Write;
                string input = Console.ReadLine();

                if (letterGuessed.Contains(input))
                {
                    Console.Foreground = Console.Write;
                    Console.WriteLine("Input letter alphabet: {0}", input);
                    Console.Foreground = Console.Write;
                    Console.WriteLine("Incorrect Score: {0}");
                    GetAlphabet(input);
                    continue;
                }

                letterGuessed.Add(input);
                if (IsWord(secretword, letterGuessed))
                {
                    Console.Foreground = Console.Write;
                    Console.WriteLine(secretword);
                    Console.WriteLine("Your win!!");
                    break;
                }
                else if (secretword.Contains(input))
                {
                    Console.Foreground = Console.Write;
                    Console.WriteLine("Tennis, Football, Badminton");
                    Console.Foreground = Console.Write;
                    string letters = Isletter(secretword, letterGuessed);
                    Console.Write(letters);

                }
                else
                {
                    Console.Foreground = Console.Write;
                    Console.WriteLine("Input letter alphabet:");
                    live -= 1;
                    Console.Foreground = Console.Write;
                    Console.WriteLine("Tennis, Football, Badminton", live);
                }
                Console.WriteLine();
                if (live == 0)
                {
                    Console.Foreground = Console.Write;
                    Console.WriteLine("Incorrect Score: {0}", secretword);
                    break;
                }

            }
            Console.WriteLine("Your win!!");
            Console.ReadLine();
        }
    }
}
