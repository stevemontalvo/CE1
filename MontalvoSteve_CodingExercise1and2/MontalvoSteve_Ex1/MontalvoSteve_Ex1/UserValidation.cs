using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex1
{
    class UserValidation
    {
        //method to make sure there is no null or white space chosen.
        public static string IsNullOrWhiteSpace(string userInput)
        {
            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Please enter a valid response: ");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
    }
}
