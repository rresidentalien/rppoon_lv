// <summary>
/// Class used for automated voting on quotes. Serves as a bot for
/// testing and demonstration purposes. Utilises a random generator
/// to decide how many and which type of votes (up / down) to cast.
/// </summary>
public class AutomaticVoter
{
    private Random random;
    private int votesToCast;
    
    public AutomaticVoter(Random random)
    {
        this.random = random;
    }

    private double AdjustProbability(Quote quote)
    {
        double change = 0;
        if (quote.Text.Length > 140)
        {
            change += 0.1;
        }

        if (quote.GetTags().Count < 3)
        {
            change += quote.GetTags().Count * 0.1;
        }

        if (change > 1.0)
        {
            change = 1.0;
        }

        return change;
    }

    private void CastVotes(Quote quote, double totalUpvoteProbability)
    {
        for (int i = 0; i < votesToCast; i++)
        {
            if (this.random.NextDouble() < totalUpvoteProbability)
            {
                quote.Upvote();
            }
            else
            {
                quote.Downvote();
            }
        }
    }
    
    public void HandleQuote(Quote quoteToHandle)
    {
        double baseUpvoteProbability = 0.5;
        double totalUpvoteProbability = baseUpvoteProbability + AdjustProbability(quoteToHandle);

        votesToCast = random.Next(0, 101);

        CastVotes(quoteToHandle, totalUpvoteProbability);
    }
}