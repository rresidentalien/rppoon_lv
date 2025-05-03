namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> emailAddresses = new List<string>();

            emailAddresses.Add("person@company.hr");
            emailAddresses.Add("stranger@world.com");
            emailAddresses.Add("student@college.edu");
            emailAddresses.Add("what??.com");

            EmailValidator validator = new EmailValidator();
            foreach(var email in emailAddresses)
            {
                Console.Write(email);
                if (validator.IsValidAddress(email))
                {
                    Console.Write(" is valid!");
                }
                else
                {
                    Console.Write(" is not valid :(");
                }
                Console.Write("\n");
            }
        }
    }
}
