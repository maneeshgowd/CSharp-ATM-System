namespace ATM_System.Constants
{
    public record ExceptionConstants
    {
        public static readonly string InvalidPin = "Invalid Pin!";
        public static readonly string InvalidAccountNumber = "Invalid Account number!";
        public static readonly string PinConstraint = "Pin must be min of 4 digit and max of 5 digit long!";
        public static readonly string DepositAmount = "Deposit amount should be > 500 and < 50000.";
        public static readonly string WithdrawlAmount = "Minimum withdrawl is 500 and maximum is 25000.";
        public static readonly string InsufficientBalance = "Insufficient balance!";
    }
}
