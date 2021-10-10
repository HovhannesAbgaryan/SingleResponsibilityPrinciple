using ConsoleUI.Messages;

namespace ConsoleUI.Person
{
    /// <summary>
    /// Validator for person
    /// </summary>
    public class PersonValidator
    {
        /// <summary>
        /// Validate person data
        /// </summary>
        /// <param name="person">Person to validate</param>
        /// <returns>true, if person data is valid; otherwise - false</returns>
        public static bool Validate(Person person)
        {
            // Checks to be sure the first name is valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            // Checks to be sure the last name is valid
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
