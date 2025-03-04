public class QuoteFilter
{
    public IList<Quote> ExtractAboveAverageRated(IList<Quote> quotes)
    {
        IList<Quote> aboveAverageRatedQuotes = new List<Quote>();

        if (quotes is null || quotes.Count == 0)
            return aboveAverageRatedQuotes;

        double averageVotes = CalculateAverageVotes(quotes);

        foreach (Quote quote in quotes)
        {
            if (quote.Votes > averageVotes)
            {
                aboveAverageRatedQuotes.Add(quote);
            }
        }
        return aboveAverageRatedQuotes;
    }

    public double CalculateVotesSum(IList<Quote> quotes)
    {
        double voteSum = 0.0;
        foreach (Quote quote in quotes)
        {
            voteSum += quote.Votes;
        }

        return voteSum;
    }

    public double CalculateAverageVotes(IList<Quote> quotes)
    {
        return CalculateVotesSum(quotes) / quotes.Count;
    }

    public IList<Quote> ExtractMostUpvotedPerAuthor(IList<Quote> quotes)
    {
        return quotes.GroupBy(m => m.author).Select(m => m.OrderByDescending(n => n.Votes).First()).ToList();
    }
}