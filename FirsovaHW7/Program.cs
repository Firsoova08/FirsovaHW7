namespace FirsovaHW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Book unknownBook = new Book();
            //unknownBook.ShowInfo();
            //Book warAndPeace = new Book("Война и мир", "Толстой", 1869, true);
            //warAndPeace.ShowInfo();
            //Book masterAndMargarita = new Book("Мастер и Маргарита", "Булгаков", 1966, false);
            //masterAndMargarita.ShowInfo();


            //2
            //BankAccount account = new BankAccount("1234567890");

            //Console.WriteLine($"Счет: {account.AccountNumber}");
            //account.Deposit(1000);
            //account.Withdraw(500);
            //account.PrintBalance();

            //3
            Car myCar = new Car("Toyota camry 2.5", 250);
            myCar.PrintInfo();
            Console.WriteLine("\n--- Разгон ---");
            myCar.Accelerate(50);
            myCar.Accelerate(70);
            myCar.PrintInfo();
            Console.WriteLine("\n--- Торможение ---");
            myCar.Brake();
            myCar.PrintInfo();

        }
    }
}
