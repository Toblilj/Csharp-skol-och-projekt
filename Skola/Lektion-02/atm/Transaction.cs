namespace skånskaBanken;


//lägga i en egen class?? 
public enum TransactionTypeEnum
{
    Insättning,
    Uttag,
}


//---------------------Transaction---------------------

//skapar en privat metod som är lokal för filen/classen för att hantera skapandet av transaktioner för trans historiken.
// använder oss av transactiontypeEnum för att basically skapa ett objekt med viss data. 
public void AddTransactions(int amount, TransactionTypeEnum transactionType)
    {
           //Här skapar vi en ny insättning varje gång vi anropar deposit.
      //vi skapar ny information här som pushas till vårt objekt vi skapat som med informationen vi har deklarerat.
    var tran= new Transaction();
        tran.transactionValue=amount;
        tran.transactionType=transactionType; //Här har vi samma för att ha ett dynamisk värde och inte ett hårdkodat ett.
        tran.transactionDate=DateTime.Now;
        //efter att vi här har skapat en transaktion med dessa variabler för uttag/insättning så behöver vi lägga till datan i vårat accoun obejct 
        //vlket vi gör överst.
        transactions.Add(tran);
    }





//logiken för transaktioner.
//här har vi variabler för Transaction som vi sedan sätter i en lista och fyller med värden på dom tomma variablerna
public class Transaction
{
    
public DateTime transactionDate;

public int transactionValue;
public TransactionTypeEnum  transactionType;


//här hämtar vi transaktionerna.
public string getTransactions()
    {
        return $"Date: {transactionDate.ToShortDateString} typ {transactionType} amount {transactionValue}";
    }


}
