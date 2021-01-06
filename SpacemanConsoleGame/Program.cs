using System;

namespace SpacemanConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            bool restart = false;
            

            while (!(restart))
            {
                Console.Clear();
                Game one = new Game();
                one.Greet();
                one.Dispaly();



                while (!(one.DidWin() || one.DidLose()))
                {

                    one.Ask();
                    Console.Clear();
                    one.Dispaly();
                }

                if (one.DidWin())
                {
                    Console.WriteLine("Congrats!! You Win!!");
                }
                else
                {
                    Console.WriteLine("You lose!!");
                }
                Console.WriteLine("Once again? y/n");
                string decision = Console.ReadLine();
                while (!(decision == "y" || decision == "n"))
                {
                    Console.WriteLine("Write only one letter: y or n. Try again.");
                    decision = Console.ReadLine();
                }
                if (decision == "y")
                { restart = false; }
                else
                { restart = true; }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Good bye");

        }
    }
}
