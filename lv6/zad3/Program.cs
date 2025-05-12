namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoItem item = new ToDoItem("LV6", "finish lab tasks", DateTime.Now);
            Memento memento1 = item.StoreState();

            CareTaker caretaker = new CareTaker();
            caretaker.PreviousStates.Add(memento1);

            item.Rename("LV6 RPPOON");
            Memento memento2 = item.StoreState();
            caretaker.PreviousStates.Add(memento2);

            item.ChangeTask("finish 4 more tasks");
            Memento memento3 = item.StoreState();
            caretaker.PreviousStates.Add(memento3);

            Console.WriteLine("Current state:");
            Console.WriteLine(item.ToString());

            item.RestoreState(caretaker.PreviousStates[0]);
            Console.WriteLine("Restored state:");
            Console.WriteLine(item.ToString());
        }
    }
}
