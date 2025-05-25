namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVisitor buyVisitor = new BuyVisitor();

            IItem book1 = new Book("Jane Eyre", 19.99);
            IItem book2 = new Book("Dorian Gray", 19.99);
            IItem vhs1 = new VHS("Solo", 9.99);
            IItem dvd1 = new DVD("Windows 95", DVDType.SOFTWARE, 59.99);
            IItem dvd2 = new DVD("Dune 2", DVDType.MOVIE, 29.99);

            List<IItem> items = new List<IItem>();
            items.Add(book1);
            items.Add(book2);
            items.Add(vhs1);
            items.Add(dvd1);
            items.Add(dvd2);

            foreach(var item in items)
            {
                Console.WriteLine(item.Accept(buyVisitor));
            }

            IVisitor rentVisitor = new RentVisitor();
            foreach (var item in items)
            {
                Console.WriteLine(item.Accept(rentVisitor));
            }

            Cart cart = new Cart(buyVisitor);
            cart.AddItem(book1);
            cart.AddItem(book2);
            cart.AddItem(vhs1);
            cart.AddItem(dvd1);
            cart.AddItem(dvd2);
            Console.WriteLine(cart.Accept());
        }
    }
}
