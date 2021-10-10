using ConsoleUI.Account;
using ConsoleUI.Messages;
using ConsoleUI.Person;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display welcome message
            StandardMessages.WelcomeMessage();

            //Capture user data
            var user = PersonDataCapture.Capture();

            //Validate user data
            bool isUserValid = PersonValidator.Validate(user);

            //If user data is valid
            if (isUserValid)
                //create account for user
                AccountGenerator.CreateAccount(user);

            //End the application
            StandardMessages.EndApplication();
        }
    }
}
