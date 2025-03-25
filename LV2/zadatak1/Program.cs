using zadatak2;

namespace zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                diceRoller.InsertDie(new Die(6));
            }

            diceRoller.RollAllDice();
            IList<int> rolledNumbers = diceRoller.GetRollingResults();
            Console.WriteLine(string.Join(" ", rolledNumbers));
        }
    }
}
