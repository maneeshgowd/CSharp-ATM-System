using ATM_System.Interfaces;

namespace ATM_System.Services
{
    public struct Greetings : IGreetings
    {
        public readonly void EndGreet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Thankyou for banking with us :)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public readonly int WelcomeGreet()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n WELCOME TO YOUR BANKING :)");
            Console.WriteLine("\n Select any of the below option: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n 1. Withdraw \n 2. Deposit \n 3. Check balance \n 4. Change pin \n 5. Exit \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            return option;
        }

        public readonly double AmountGreet()
        {
            Console.Write("\n Enter amount: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public readonly short PinGreet()
        {
            Console.Write("\n Enter your pin: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        public readonly string DepositAmountAccGreet()
        {
            Console.Write("\n Enter account number: ");
            return Console.ReadLine()!.ToString();
        }

        public readonly short ChangePinGreet()
        {
            Console.Write("\n Enter new pin: ");
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}