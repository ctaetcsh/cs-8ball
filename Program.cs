using System;

namespace _8Ball
{
    // Global varibles for this application
    class Varibles
    {
        public string playerName;
        public string askedQuestion;

        public ConsoleColor preColorFG = Console.ForegroundColor;
        public ConsoleColor preColorBG = Console.BackgroundColor;

        public Random randomNumber = new Random();

        // Responce Arrays
        public string[] responcesAffirmative1 = { "It is certain.", "It is decidedly so", "Without a doubt.", "Yes - definitely.", "You may rely on it." };
        public string[] responcesAffirmative2 = { "As I see it, yes.", "Most likely.", "Outlook Good.", "Yes.", "Signs point to yes." };
        public string[] responcesNonCommittal = { "Reply hazy, try again.", "Ask again later.", "Better not tell you know.", "Cannot predict now.", "Concentrate and ask again." };
        public string[] responcesNegative = { "Don't count on it.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Very doubtful." };
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Initalizes Program
            Varibles var = new Varibles();
            initProgram();

            // Introducing Player
            Console.Write("Hello! What is your name? ");
            Console.ForegroundColor = ConsoleColor.Gray;
            var.playerName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nice to meet you, {0}.", var.playerName);
            Console.WriteLine();

            // Repeatedly asks player question then produces a random result
            while (true)
            {
                Console.Write("What is your question for the 8 Ball, {0}? ", var.playerName);
                Console.ForegroundColor = ConsoleColor.Gray;
                var.askedQuestion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (var.askedQuestion == "exit")
                {
                    exitProgram();
                }

                switch (var.randomNumber.Next(4))
                {
                    case 0:
                        Console.WriteLine(var.responcesAffirmative1.GetValue(var.randomNumber.Next(4)));
                        Console.WriteLine();
                        break;

                    case 1:
                        Console.WriteLine(var.responcesAffirmative2.GetValue(var.randomNumber.Next(4)));
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine(var.responcesNonCommittal.GetValue(var.randomNumber.Next(4)));
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine(var.responcesNegative.GetValue(var.randomNumber.Next(4)));
                        Console.WriteLine();
                        break;


                }
            }
        }

        // Initalize program function
        static void initProgram()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(".NET 8 Ball | Created by ctaetcsh");
            Console.WriteLine("Inspired by Codegasm #2");
            Console.WriteLine("Ask the question 'exit' to leave.");
            Console.WriteLine();
        }

        // Exit program function
        static void exitProgram()
        {
            Varibles var = new Varibles();

            Console.WriteLine("Closing program in 500 milliseconds...");
            Console.ForegroundColor = var.preColorFG;
            Console.BackgroundColor = var.preColorBG;
            System.Threading.Thread.Sleep(500);
            Environment.Exit(1);
        }

    }
}
