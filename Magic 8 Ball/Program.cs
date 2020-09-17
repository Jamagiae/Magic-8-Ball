using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic_8_Ball
{
    class Program
    {
        //First Magic 8 Ball is nothing more than a random number generator.
        //So we are going to create an object that will basically be a random number
        static Random randomObject = new Random();

         public static void Main(string[] args)
        {
            QuestionLoop();
        }
        static String GetQuestionFromUser()
        {
            Console.Write("What question do you have? ");
            string questionString = Console.ReadLine();
            return questionString;
        }
        static void QuestionLoop()
        {
            while(true)
            {
                int numberOfSecondsToSleep = randomObject.Next((5) + 1);//This will cause them to sleep from 1-5 milliseconds (not long enough)
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                string questionString = GetQuestionFromUser();
                Console.WriteLine("Hmmm... Let me think...");
                Thread.Sleep(numberOfSecondsToSleep = 1000);//need to multiply by 1000 so that it converts from millisecods to seconds.
                int randomNumber = randomObject.Next(10);

                if (questionString.ToLower() == "quit")
                {
                    break;//jumps us out of the while loop
                }

                if (questionString.ToLower() == "ninja")
                {
                    Console.WriteLine("Shhh... we don't speak of the inviible");
                    break;
                }


                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Yes");
                            break;
                        }

                    case 1:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("No");
                            break;
                        }

                    case 2:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Bad Idea");
                            break;
                        }

                    case 3:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("That's a mystery for the ages");
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("i would make donut instead.");
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Your teacher is a ninja. Be nice.");
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("42. It's the answer to everything");
                            break;
                        }
                    case 7:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Stop asking questions and make me a pizza.");
                            break;
                        }
                    case 8:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Maybe");
                            break;
                        }
                    case 9:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("This isn't Canada, speack English.");
                            break;
                        }
                    case 10: 
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("");
                            break;
                        }
                }
            }
        }
    }
}

