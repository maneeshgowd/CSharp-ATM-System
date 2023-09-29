namespace ATM_System.Exceptions
{
    public class InvalidPinException : Exception
    {
        public InvalidPinException(string message) : base(message)
        {

        }
        public InvalidPinException(string message, Exception exception) : base(message, exception)
        {

        }
    }

    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {

        }

        public InsufficientBalanceException(string message, Exception exception) : base(message, exception)
        {

        }
    }

    public class InvalidAccountNumberException : Exception
    {
        public InvalidAccountNumberException(string message) : base(message)
        {

        }

        public InvalidAccountNumberException(string message, Exception exception) : base(message, exception)
        {

        }
    }

    public class InvalidDepositAmountException : Exception
    {
        public InvalidDepositAmountException(string message) : base(message)
        {

        }
        public InvalidDepositAmountException(string message, Exception exception) : base(message, exception)
        {

        }
    }

    public class InvalidPinLengthException : Exception
    {
        public InvalidPinLengthException(string message) : base(message)
        {

        }
        public InvalidPinLengthException(string message, Exception exception) : base(message, exception)
        {

        }
    }

    public class InvalidWithdrawlAmountException : Exception
    {
        public InvalidWithdrawlAmountException(string message) : base(message)
        {

        }
        public InvalidWithdrawlAmountException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
