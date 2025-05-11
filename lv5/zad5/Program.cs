namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITheme lightTheme = new LightTheme();
            SharedNote labGroup1 = new SharedNote("Time: 8:00 AM tomorrow, Place: K3-1", lightTheme);
            labGroup1.AddName("Alpha");
            labGroup1.AddName("Bravo");
            labGroup1.AddName("Charlie");
            labGroup1.RemoveName("Alpha");

            ITheme darkTheme = new DarkTheme();
            SharedNote labGroup2 = new SharedNote("Time: 11:00 AM tomorrow, Place: K3-13", darkTheme);
            labGroup2.AddName("Delta");
            labGroup2.AddName("Echo");
            labGroup2.AddName("Foxtrot");

            labGroup1.Show();
            labGroup2.Show();

            Notebook notebook = new Notebook(darkTheme);
            notebook.AddNote(labGroup1);
            notebook.AddNote(labGroup2);
            notebook.Display();
            notebook.ChangeTheme(lightTheme);
            notebook.Display();
        }
    }
}
