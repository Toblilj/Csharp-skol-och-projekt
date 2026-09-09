namespace skånskaBanken;

public class account()
{
    
}

public class Transaction
{
    
public DateTime transactionDate;

public int transactionValue;
public String transactionType;



public string getTransactions()
    {
        return $"Date: {transactionDate.ToShortDateString} typ "; 
    }

    internal bool GetTransactionInfo()
    {
        throw new NotImplementedException();
    }
}