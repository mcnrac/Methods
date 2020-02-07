using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name followed by a space, then last name. Please do not enter a numeric value or special character.");
            try
            {
                //implement the user input into a variable
                string Name = Console.ReadLine();

                if (System.Text.RegularExpressions.Regex.IsMatch(Name, "[a-zA-Z]" + " " + "[a-zA-Z]"))
                {
                    DisplayMessage(ref Name);
                }

                else
                {
                    // ask the user to enter a name with the correct format with no numeric value or special characters
                    Console.WriteLine("Please enter your first name, followed by a space and then your last name. Please also do not enter a numeric value or special character.");
                }
            }
            catch
            {
                //if error occurs ask the user to enter a valid name
                Console.WriteLine("Please enter a valid name");
            }
        }
        private static void DisplayMessage(ref string Name)
        {
            //Display Hello name of the user
            Console.WriteLine("Hello" + " " + Name + "!");
        }
    }
}
