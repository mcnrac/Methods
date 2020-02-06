using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            try
            {
                //put the user input into a varible
                string Name = Console.ReadLine();

                if (System.Text.RegularExpressions.Regex.IsMatch(Name, "[a-zA-Z]" + " " + "[a-zA-Z]"))
                {
                    HelloFriend(ref Name);
                }

                else
                {
                    // ask the user to enter a name without numbers
                    Console.WriteLine("Please enter a name without symbols or numerical digits");
                }
            }
            catch
            {
                //if error occurs ask the user to enter a valid name
                Console.WriteLine("Please enter a valid name");
            }
        }
        private static void HelloFriend(ref string Name)
        {
            //Display Hello name of the user
            Console.WriteLine("Hello " + Name + "!");
        }
    }
}
