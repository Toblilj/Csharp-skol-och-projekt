namespace skånskaBanken;


//TO DO
//Inkludera så programmet sparar ditt saldo-Sparas medans programmet körs klar för stunden 
//  hantera återkommande kund/ny kund, dvs värde om du har föregående saldo på banken eller ej.- senare implementation
//Lägg till för att se transaktionshistorik- 


//vi skapar en enum utanför våra classer för den används i alla classer och då är det snyggare o renare att inte nästla den.
//en enum är en speciell class till för att deklarera/representera en grupp av constants, dvs fasta variabler som inte förändras.
public enum TransactionTypeEnum
{
    Insättning,
    Uttag,
}

public class  Account()
{

public string accountNumber="";
    
   public string firstName="";
    public string lastName="";
  
     public int pinNumber;
   
int balance; 
 
List <Transaction> transactions=[]; 


public void Deposit(int amount)
{
   //tar balance och adderar till amount.
    balance += amount;
     AddTransactions(amount, TransactionTypeEnum.Insättning);
      }
public void WithDraw( int amount)
{
 //sätter vi checken först, om balance är mindre än amount så kastar vi ett fel annars går vi ur till nästa steg.
       if(balance < amount)
        {
            throw new Exception("Du har för lite på kontot för att göra ditt uttag, sätt in mer pengar och försök igen.");
        }
        //utanför min loop.
        balance -= amount;
        AddTransactions(amount, TransactionTypeEnum.Uttag);
    


}

//vi samlar nu all 

//skapar en privat metod som är lokal för filen/classen för att hantera skapandet av transaktioner för trans historiken.
// använder oss av transactiontypeEnum för att basically skapa ett objekt med viss data. 
private void AddTransactions(int amount, TransactionTypeEnum transactionType)
    {
           //Här skapar vi en ny insättning varje gång vi anropar deposit.
      //vi skapar ny information här som pushas till vårt objekt vi skapat som med informationen vi har deklarerat.
    var tran= new Transaction();
        tran.transactionValue=amount;
        tran.transactionType="Insättning";
        tran.transactionDate=DateTime.Now;
        //efter att vi här har skapat en transaktion med dessa variabler för uttag/insättning så behöver vi lägga till datan i vårat accoun obejct 
        //vlket vi gör överst.
        transactions.Add(tran);
    }

    

//Metod för att ta emot user data ifrån min RegisterAccount
public void SetAccountDetails(string accountNumber, string firstName, string lastName)
    {
        //vi använder this. för att ppeka specifikt på att strängen accountNumber ska sättas till variabeln som tillhör classen account. 
        //likadant på övriga 2 variabler.
        this.accountNumber=accountNumber;
        this.firstName=firstName;
        this.lastName=lastName;
    }



//här vill jag skapa en sträng/metod whatever som hanterar account logik?
public string AccountInfo()
    {
        var info= $"Accnumber: {accountNumber} Name: {firstName} balance: {balance}";
        return info;
    }


} //-------------Stänger classen här!!



//logiken för transaktioner.
//här har vi variabler för Transaction som vi sedan sätter i en lista och fyller med värden på dom tomma variablerna
public class Transaction
{
    
public DateTime transactionDate;

public int transactionValue;
public String transactionType;


//här hämtar vi transaktionerna.
public string getTransactions()
    {
        return $"Date: {transactionDate.ToShortDateString} typ {transactionType} amount {transactionValue}";
    }


}