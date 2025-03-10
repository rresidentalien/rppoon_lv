public class Quote
{
    public Author author;
    public string Text { get; private set; }
    public int Votes { get; set; }
    private IList<string> Tags;


    public Quote(string authorName, string authorSurname, DateOnly authorDateOfBirth, string text)
    {
        author = new Author(authorName, authorSurname, authorDateOfBirth);
        this.Text = text;
        Tags = new List<string>();
    }

    public Quote(Author author, string text)
    {
        this.author = author;
        this.Text = text;
        Tags = new List<string>();
    }

    public void Upvote()
    {
        if (Votes < Int32.MaxValue)
        {
            ++Votes;
        }
    }
    public void Downvote()
    {
        if (Votes > 0)
        {
            --Votes;
        }
    }
    public void AddTag(string newTag)
    {
        Tags.Add(newTag.ToLower());
    }
    public IList<string> GetTags()
    {
        return Tags.AsReadOnly();
    }
    public override string ToString()
    {
        return $"'{Text}'" +
            $"\n- {author}" +
            $"\nTotal votes: {Votes}" +
            $"\nTags: {String.Join(", ", Tags)}";
    }

    public static void Test()
    {
        Author author = new Author("Charlotte", "Bronte", new DateOnly(1816, 4, 21));
        Quote quote = new Quote(author, "I am no bird; and no net ensnares me; I am a free human being, with an independent will; which I now exert to leave you.");
        quote.AddTag("Gothic");
        quote.AddTag("CLASSIC");
        quote.AddTag("Bildungsroman");

        for (int i = 0; i < 50; ++i)
        {
            quote.Upvote();
        }

        Console.WriteLine(quote);

        for (int i = 0; i < 60; ++i)
        {
            quote.Downvote();
        }

        Console.WriteLine("Votes: " + quote.Votes);
    }
}