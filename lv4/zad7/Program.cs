namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistrationValidator validator = new RegistrationValidator();
            bool isValid = false;

            while (!isValid)
            {
                isValid = validator.IsUserEntryValid(UserEntry.ReadUserFromConsole());
            }
        }
    }
}
