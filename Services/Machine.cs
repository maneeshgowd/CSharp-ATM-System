using ATM_System.Constants;
using ATM_System.Exceptions;
using ATM_System.Interfaces;
using Models;

namespace ATM_System.Services
{
    class Machine
    {
        private readonly IGreetings _greetings;
        public Machine(IGreetings greetings)
        {
            _greetings = greetings;
        }
        private void Withdraw()
        {
            double amount = _greetings.AmountGreet();

            if (amount < 500 && amount > 25000)
                throw new InvalidWithdrawlAmountException(ExceptionConstants.WithdrawlAmount);

            int pin = _greetings.PinGreet();

            List<Account> accounts = FileSystem.ReadFileAsync();

            int account = accounts.FindIndex(acc => acc.Pin == pin);

            if (account == -1)
                throw new InvalidPinException(ExceptionConstants.InvalidPin);

            var balance = accounts[account].Balance - amount;

            if (balance < 1000)
                throw new InsufficientBalanceException(ExceptionConstants.InsufficientBalance);

            accounts[account].Balance -= amount;

            FileSystem.WriteFileAsync(accounts);

            Console.WriteLine($"\n Amount {amount} withdrawn successfully!");
        }

        private void Deposit()
        {
            double amount = _greetings.AmountGreet();

            if (amount > 50000 && amount < 500)
                throw new InvalidDepositAmountException(ExceptionConstants.DepositAmount);

            int pin = _greetings.PinGreet();

            List<Account> accounts = FileSystem.ReadFileAsync();

            int debitor = accounts.FindIndex(acc => acc.Pin == pin);

            if (debitor == -1)
                throw new InvalidPinException(ExceptionConstants.InvalidPin);

            string accountNumber = _greetings.DepositAmountAccGreet();

            int creditor = accounts.FindIndex(acc => acc.AccountNumber == accountNumber);

            if (creditor == -1)
                throw new InvalidAccountNumberException(ExceptionConstants.InvalidAccountNumber);

            var creditorBalance = accounts[debitor].Balance - amount;

            if (creditorBalance < 1000)
                throw new InsufficientBalanceException(ExceptionConstants.InsufficientBalance);

            accounts[debitor].Balance -= amount;

            accounts[creditor].Balance += amount;

            FileSystem.WriteFileAsync(accounts);

            Console.WriteLine($"\n Amount of {amount} transferred successfully!");
        }

        private void CheckBalance()
        {
            int pin = _greetings.PinGreet();

            List<Account> accounts = FileSystem.ReadFileAsync();

            Account account = accounts.Find(acc => acc.Pin == pin) ?? throw new InvalidPinException(ExceptionConstants.InvalidPin);

            Console.WriteLine($"\n Your account balance is: {account.Balance}");
        }

        private void ChangePin()
        {
            int pin = _greetings.PinGreet();

            List<Account> accounts = FileSystem.ReadFileAsync();

            int account = accounts.FindIndex(acc => acc.Pin == pin);

            if (account == -1)
                throw new InvalidPinException(ExceptionConstants.InvalidPin);

            int newPin = _greetings.ChangePinGreet();

            if (newPin < 1000 && newPin > 99999)
                throw new InvalidPinLengthException(ExceptionConstants.PinConstraint);

            accounts[account].Pin = newPin;

            FileSystem.WriteFileAsync(accounts);

            Console.WriteLine("\n Pin changed successfully!");
        }

        public void PerformOperation()
        {
            while (true)
            {
                int option = _greetings.WelcomeGreet();

                switch (option)
                {
                    case 1:
                        Withdraw();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        CheckBalance();
                        break;
                    case 4:
                        ChangePin();
                        break;

                    default:
                        _greetings.EndGreet();
                        return;
                }
            }
        }
    }
}