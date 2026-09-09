namespace WestcoastBank;

public class Account
{
    public string accountNumber;

    public string firstName;
    public string lastName;
    public int balance=0 ;
}

public class Transaction
{
    public DateTime transactionDate;
    public int transactionValue;
    public string transactionType;

    public string GetTransactionInfo()
    {
        return $"Date: {transactionDate.ToShortDateString()} Type: {transactionType} Amount: {transactionValue}";
    }
}