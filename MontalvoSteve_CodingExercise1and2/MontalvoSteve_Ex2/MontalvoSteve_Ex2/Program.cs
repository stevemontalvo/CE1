using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //June Sports Topic answer to question
            string questionAnswer = "Baseball";

            //boolean to keep program running
            bool ProgramIsRunning = true;

            while (ProgramIsRunning)
            {
                Console.WriteLine("This sport is called America's past time.");
                Console.Write("Selection: ");
                string userAnswer = Console.ReadLine();
                userAnswer = UserValidation.IsNullOrWhiteSpace(userAnswer);
                if (userAnswer.Any(char.IsUpper) == true)
                {
                    switch(userAnswer)
                        {
                        case "Baseball":
                            {
                                Console.WriteLine($"Congratulations you have chosen the correct answer of {questionAnswer}!");
                                ProgramIsRunning = false;
                                Utility.PauseBeforeContinuing();
                            }
                            break;

                        }
                   
                    switch (userAnswer.ToLower())
                    {
                        case "baseball":
                            {
                                Console.WriteLine("You are very close!");
                                Console.WriteLine("HINT: You must put a capital letter in the beginning of the word Only");
                            }
                            break;
                      
                        default:
                            {
                                Console.WriteLine("You have not chosen the correct answer.");
                                Console.WriteLine("HINT: This sport involves a bat and a ball with bases.");
                            }
                            break;
                    }
                }
                if (userAnswer.Any(char.IsUpper) == false)
                {
                    switch (userAnswer)
                    {
                        case "baseball":
                            {
                                Console.WriteLine("You are so close!");
                                Console.WriteLine("You must put a capital letter in the beginning of the word");
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("You have not chosen the correct answer.");
                                Console.WriteLine("HINT: This sport involves a bat and a ball with bases.");
                            }
                            break;
                       
                    }
                }

            }
        }
    }
}
