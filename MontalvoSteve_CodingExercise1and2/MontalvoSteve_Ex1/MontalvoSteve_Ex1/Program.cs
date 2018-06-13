using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array List for Coding Excersise 1 in Project and Portfolio II May is Fruits and Vegetables
            string[] sports = { "Soccer", "Football", "Baseball", "Tennis", "Water Polo", "Weight Lifting", "Cheerleading", "Basketball", "Polo", "Cricket", "Ice Skating", "Snowboarding", "Skateboarding", "Swimming", "Diving", "Horse Racing", "Pole Jumping", "Hammer Throw", "Sleding", "Roller Derby" };

            //Boolean to keep the program running until user chooses to stop
            bool ProgramIsRunning = true;

            //to keep the program running loop
            while (ProgramIsRunning)
            {
                Console.Clear();
                //Menu options
                Console.WriteLine("--------Menu--------\n");
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("1. Alphabetize the list from A-Z.");
                Console.WriteLine("2. Alphabetize the list from Z-A.");
                Console.WriteLine("3. Randomly choose a fruit or vegitable and delete it.");
                Console.WriteLine("4. Exit \n");
                Console.Write("Selection: ");

                // Capture user response
                string userInput = Console.ReadLine();
                // call method from UserResponseValidation Class to validate that user response is not null or whitespace
                userInput = UserValidation.IsNullOrWhiteSpace(userInput.ToLower());

                // loop to validate that the user has a correct menu response and perform the action required.
                switch (userInput)
                {
                    case "1":
                    case "1.":
                    case "alphabetize the list from a-z":
                        {
                            //Clear the page so you can clearly see what is going on.
                            Console.Clear();
                            Console.WriteLine("--------Alphabetize (A-Z)--------\n");
                            //Test to make sure that the array is not empty
                            if (sports.Length != 0 )
                            {
                                Console.WriteLine("You have chosen to alphabetize the list.");
                                Console.WriteLine();
                                //Sort Array A-Z
                                Array.Sort(sports);
                                //Loop to go through the array and write it on the console.
                                foreach (var sport in sports)
                                {
                                    //Display result
                                    Console.WriteLine($"{sport} ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is nothing in the list to sort.");

                            }
                            //space to keep the display nice
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                    case "2.":
                    case "alphabetize the list from z-a":
                        {
                            //Clear the page so you can clearly see what is going on.
                            Console.Clear();
                            Console.WriteLine("--------Alphabetize (Z-A)--------\n");
                            //Test to make sure the array is not empty
                            if (sports.Length != 0)
                            {
                                Console.WriteLine("You have chosen to alphabetize the list in reverse.");
                                Console.WriteLine();
                                //Sort Array A-Z
                                Array.Sort(sports);
                                //Reverse the order of the array
                                Array.Reverse(sports);
                                //Loop to go through the array and write it on the console.
                                foreach (var sport in sports)
                                {
                                    //Display result
                                    Console.WriteLine($"{sport} ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is nothing in the list to sort.");
                            }
                            //space to keep the display nice
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                    case "3.":
                    case "randomly choose a fruit or vegitable and delete it":
                        {
                            Console.Clear();
                            Console.WriteLine("--------Deleting Fruit and Veggitables--------\n");
                            //Test to make sure that the array is not empty.
                            if (sports.Length != 0)
                            {
                                Random rnd = new Random();
                                foreach (var sport in sports)
                                {
                                    int i = rnd.Next(0, sports.Length);
                                    Console.WriteLine($"{sports[i]} is being removed.");
                                    sports = sports.Where(w => w != sports[i]).ToArray();
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is nothing in the list to remove.");
                            }
                            //space to keep the display nice
                            Console.WriteLine();
                        }

                        break;
                    case "4":
                    case "4.":
                    case "exit":
                        {
                            Console.Clear();
                            Console.WriteLine("--------Exit--------\n");
                            //user message to let them know they have chosen to exit the program.
                            Console.WriteLine("You have chosen to exit the program.");
                            // Program bool change to false to exit the program.
                            ProgramIsRunning = false;
                        }
                        break;
                    default:
                        {
                            //Message to the user that they havent chosen a valid menu option
                            Console.WriteLine("You have not chosen a valid menu option!");

                        }
                        break;

                }
                //to pause the code so the result can be seen.
                Utility.PauseBeforeContinuing();
            }
        }
    }
}
