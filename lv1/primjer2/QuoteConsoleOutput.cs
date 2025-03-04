public class QuoteConsoleOutput
{
    private ConsoleColor primaryColor;
    private ConsoleColor secondaryColor;

    public QuoteConsoleOutput(ConsoleColor primaryColor, ConsoleColor secondaryColor)
    {
        this.primaryColor = primaryColor;
        this.secondaryColor = secondaryColor;
    }

    public void PrintQuote(Quote quote)
    {
        Console.ForegroundColor = primaryColor;
        Console.WriteLine(quote.ToString());
        Console.ResetColor();
    }

    public void PrintQuotes(IList<Quote> quotes)
    {
        quotes.OrderBy(m => m.Votes);
        for (int i = 0; i < quotes.Count; i++)
        {
            if (i < 3)
            {
                Console.ForegroundColor = primaryColor;
            }
            else
            {
                Console.ForegroundColor = secondaryColor;
            }
            Console.WriteLine(quotes[i].ToString());
        }
        Console.ResetColor();
    }

    public void SetPrimaryColor(ConsoleColor primaryColor)
    {
        this.primaryColor = primaryColor;
    }

    public void SetSecondaryColor(ConsoleColor secondaryColor)
    {
        this.secondaryColor = secondaryColor;
    }

    public static void Test()
    {
        QuotesDatabase database = new QuotesDatabase();
        QuoteConsoleOutput consoleOutput = new QuoteConsoleOutput(ConsoleColor.Red, ConsoleColor.Blue);
        consoleOutput.PrintQuotes(database.GetQuotes());

        consoleOutput.SetPrimaryColor(ConsoleColor.Magenta);
        Quote quote = new Quote("James", "Joyce", new DateOnly(1882, 2, 2), "Hold to the now, the here, through which all future plunges to the past.");
        consoleOutput.PrintQuote(quote);
    }
}
