using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpacemanConsoleGame
{
    class Game
    {

        //properties
        public string Codeword { get; set; }

        public string CurrentWord { get; set; }
        //string currentWord;
        public int MaxGuess { get; set; }
        public int CurrentWrongGuess { get; set; }
        public string[] CodewordsList { get; set; }
        string[] codewordsList = { "cat", "horse", "fish", "turtle", "dolphin", "kangoroo", "rabarbar" };
        Ufo ufo1 = new Ufo();





        //Constructor: randomly picks codeword, asigns few variables
        public Game()
        {
            Random r = new Random();
            Codeword = codewordsList[r.Next(0, codewordsList.Length)];
            MaxGuess = 5;
            CurrentWrongGuess = 0;
            CurrentWord = Codeword;
            char[] word = CurrentWord.ToCharArray();
            for (int w = 0; w < word.Length; w++)
            {
                word[w] = '_';
            }
            CurrentWord = new string(word);

        }


        //Greetings method
        public void Greet()
        {
            string greeting = "Hello, Welcome in the Hanggame Space version!";
            Console.WriteLine(greeting);
        }

        //DidWin method
        public bool DidWin()
        {
            if (Codeword == CurrentWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DidLose()
        {
            if (CurrentWrongGuess == MaxGuess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dispaly()
        {
            Console.WriteLine(ufo1.Stringify());
            Console.WriteLine(CurrentWord);
            Console.WriteLine($"Current Wrong guess counter: {CurrentWrongGuess}");
        }

        public void Ask()
        {
            Console.WriteLine("Guess a letter...");
            string userInput = Console.ReadLine();
            while (userInput.ToCharArray().Length != 1)
            {
                Console.WriteLine("Write one letter at a time. Try again.");
                userInput = Console.ReadLine();
            }



            bool contain = Codeword.Contains(userInput);
            if (contain)
            {
                Console.WriteLine("Yeah! Your guess is correct!");
                

                char[] word = CurrentWord.ToCharArray();

                for (int i = 0; i < Codeword.Length; i++)
                {
                    int index = Codeword.IndexOf(userInput, i);
                    if (index >= 0)
                    {
                        word[index] = Convert.ToChar(userInput);
                    }

                }

                CurrentWord = new string(word);
                Console.WriteLine(CurrentWord);


            }
            else
            {
                Console.WriteLine("Wrong guess!");
                CurrentWrongGuess++;
                ufo1.AddPart();
                
            }


        }
    }
}
