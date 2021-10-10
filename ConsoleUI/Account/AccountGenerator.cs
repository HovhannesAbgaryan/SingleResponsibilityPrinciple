using System;

namespace ConsoleUI.Account
{
    /// <summary>
    /// Account generator
    /// </summary>
    public class AccountGenerator
    {
        /// <summary>
        /// Create account for user
        /// </summary>
        /// <param name="user">User to create account for</param>
        public static void CreateAccount(Person.Person user)
        {
            // Create a username for the person
            Console.WriteLine($"Your username is: { user.FirstName.Substring(0, 1) }{ user.LastName }");
        }
    }
}
