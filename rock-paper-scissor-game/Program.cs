using System;
using System.Threading;

namespace rock_paper_scissor_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the rock, paper, scissor game");
            Thread.Sleep(1000);
            Console.WriteLine("you can choose to write rock or r, paper or p, scissor or s");
            var playAgain = "";
            while (playAgain == "" || playAgain == "yes")
            {
                Thread.Sleep(1000);
                Console.WriteLine("please choose an option");
                var userInput = "";
                while (userInput == "inaccurate" || userInput == "")
                {
                    userInput = Console.ReadLine();
                    var lowerCaseInput = userInput.ToLower();
                    var random = new Random();
                    var computerChoice = random.Next(2);
                    if (lowerCaseInput == "r" || lowerCaseInput == "rock")
                    {
                        if (computerChoice == 0)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose rock");
                            Thread.Sleep(1000);
                            Console.WriteLine("the result is a draw");
                        }
                        else if (computerChoice == 1)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose paper");
                            Thread.Sleep(1000);
                            Console.WriteLine("you lose");
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose scissor");
                            Thread.Sleep(1000);
                            Console.WriteLine("you win");
                        }
                    }
                    else if (lowerCaseInput == "p" || lowerCaseInput == "paper")
                    {
                        if (computerChoice == 0)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose rock");
                            Thread.Sleep(1000);
                            Console.WriteLine("you win");
                        }
                        else if (computerChoice == 1)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose paper");
                            Thread.Sleep(1000);
                            Console.WriteLine("the result is a draw");
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose scissor");
                            Thread.Sleep(1000);
                            Console.WriteLine("you lose");
                        }
                    }
                    else if (lowerCaseInput == "s" || lowerCaseInput == "scissor")
                    {
                        if (computerChoice == 0)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose rock");
                            Thread.Sleep(1000);
                            Console.WriteLine("you lose");
                        }
                        else if (computerChoice == 1)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose paper");
                            Thread.Sleep(1000);
                            Console.WriteLine("you win");
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("the computer chose scissor");
                            Thread.Sleep(1000);
                            Console.WriteLine("the result is a draw");
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("your choice isn't accurate");
                        Thread.Sleep(1000);
                        userInput = "inaccurate";
                        Console.WriteLine("please choose either rock or r, paper or p, scissor or s");
                    }
                }
                Console.WriteLine("would you like to play again? please answer with yes or no");
                while (playAgain == "" || playAgain == "inaccurate")
                {
                    playAgain = Console.ReadLine().ToLower();
                    if (playAgain == "yes")
                    {
                        Console.Clear();
                    }
                    else if (playAgain == "no")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("your choice isn't accurate");
                        Thread.Sleep(1000);
                        Console.WriteLine("please choose either yes or no");
                        playAgain = "inaccurate";
                    }
                }
            }
        }
    }
}
