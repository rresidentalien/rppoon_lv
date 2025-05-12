namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("FERT", "Cara Hadrijana 10b", 100000000);
            Memento memento1 = account.StoreState();

            CareTaker caretaker = new CareTaker();
            caretaker.PreviousStates.Add(memento1);

            account.ChangeOwnerAddress("Kneza Trpimira 2a");
            Memento memento2 = account.StoreState();
            caretaker.PreviousStates.Add(memento2);

            account.UpdateBalance(1);
            Memento memento3 = account.StoreState();
            caretaker.PreviousStates.Add(memento3);

            Console.WriteLine("Current state:");
            Console.WriteLine(account.ToString());

            account.RestoreState(caretaker.PreviousStates[0]);
            Console.WriteLine("Restored state:");
            Console.WriteLine(account.ToString());
        }
    }
}
