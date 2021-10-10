using System;

namespace ConsoleUI.Messages
{
    /// <summary>
    /// Standard messages to display
    /// </summary>
    public class StandardMessages
    {
        /// <summary>
        /// Welcome message
        /// </summary>
        public static void WelcomeMessage()
        {
            Console.WriteLine("SOLID Principles");
            Console.WriteLine("The S in SOLID - Single Responsibility Principle (SRP)");
            Console.WriteLine("Welcome to SRPDemo application!");
            Console.WriteLine();
        }

        /// <summary>
        /// End the application
        /// </summary>
        public static void EndApplication()
        {
            Console.Write("Press Enter to close...");
            Console.ReadLine();
        }

        /// <summary>
        /// Display validation error message
        /// </summary>
        /// <param name="fieldName">Name of field to display a validation error message for</param>
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}
