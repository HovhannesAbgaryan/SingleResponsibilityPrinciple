using System;

namespace ConsoleUI.Person
{
    /// <summary>
    /// Capture person data
    /// </summary>
    public class PersonDataCapture
    {
        /// <summary>
        /// Capture person data
        /// </summary>
        /// <returns>Person with captured data</returns>
        public static Person Capture()
        {
            // Ask for person information
            var output = new Person();

            Console.Write("What is your first name? ");
            output.FirstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
