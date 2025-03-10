public class Author
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public DateOnly DateOfBirth { get; private set; }

    public Author(string name, string surname, DateOnly dateOfBirth)
    {
        this.Name = name;
        this.Surname = surname;
        this.DateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return $"{Name} {Surname} ({DateOfBirth:dd.MM.yyyy.})";
    }
}
