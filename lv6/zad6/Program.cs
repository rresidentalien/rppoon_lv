namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringChecker lengthChecker = new StringLengthChecker();
            StringChecker digitChecker = new StringDigitChecker();
            StringChecker upperChecker = new StringUpperCaseChecker();
            StringChecker lowerChecker = new StringLowerCaseChecker();

            /*lengthChecker.SetNext(digitChecker);
            digitChecker.SetNext(upperChecker);
            upperChecker.SetNext(lowerChecker);

            string[] testStrings = {
                "ab",
                "abcd",
                "Abcd",
                "Abcd1",
                "ABCD1",
                "abcd1"
            };

            foreach (string s in testStrings)
            {
                bool result = lengthChecker.Check(s);
                Console.WriteLine($"\"{s}\": {result}");
            }*/


            PasswordValidator validator = new PasswordValidator(lengthChecker);
            validator.AddChecker(digitChecker);
            validator.AddChecker(upperChecker);
            validator.AddChecker(lowerChecker);

            bool isValid = validator.Validate("Abcd1");
            Console.WriteLine(validator.Validate("Abcd1"));
        }
    }
}
