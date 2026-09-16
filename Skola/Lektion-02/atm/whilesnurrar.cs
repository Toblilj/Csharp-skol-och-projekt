
namespace skånskaBanken;




//Inkludera så programmet sparar ditt saldo, hantera återkommande kund/ny kund, dvs värde om du har föregående saldo på banken eller ej.
//information måste läggas till
//registrera uppgifter (kund) måste läggas till.---Hur gör jag detta? Jag har ju variabler i mitt account objekt för att sparar värden till ett konto men inget som sätter värdet på dom. 



class Program
{
    //kallar på en kopia av vår account class i BankAccountTwo filen
    static Account account = new Account();
    
 // Deklarera en variabel för aktuellt saldo...

    static int balance = 0;
          static   List<int> transactions = [];
   

    //denna får ha värdet null och den ligger utanför allt för att vara tillgänglig till allt i min main metod.
      static string? amount = null;

static void Main()
{


Console.WriteLine("välkomen till skånska banken");

    App();

     


}







// //Metoder ||-.........................................................................................................


static void App()
{
             //allt detta vill vi bygga in i en metod så vi bara gör ett metodanrop i vår main metod. 
        try
            {
    while (true)
    {
        PrintMenu();
        //tar user input
        var key = Console.ReadLine();

        switch (key)
        {
            //case för deposit 
            case "d":
        //bygg upp caset med att först ta user input i en variabel det vill säga amount.
        Console.WriteLine("Hur mycket vill du sätta in? ");
        amount=Console.ReadLine();

            if (int.TryParse(amount, out int depositAmount))
        {
            balance = Account.Deposit(balance,depositAmount);
            //såhär behöver jag ta min användares input (amount) konvertera det ifrån en sträng till en int, som sedan skickas till min deposit metod och lägger till i currentBalance grejen och skickas tillbaka. 
            }
        else
        {
            throw new Exception("Din inmatning får enbart vara heltal");
            }
                break;
 
                

            case "w":

               Console.WriteLine("Hur mycket vill du ta ut?");
                        amount = Console.ReadLine();
                  if (int.TryParse(amount, out int newAmount))
        {
            balance = Account.WithDraw(balance,newAmount);
            //såhär behöver jag ta min användares input (amount) konvertera det ifrån en sträng till en int, som sedan skickas till min deposit metod och lägger till i currentBalance grejen och skickas tillbaka. 
            }
        else
        {
            throw new Exception("Din inmatning får enbart vara heltal");
            }

              
                break;

            case "b":
                Console.WriteLine($"Du har såhär mycket i ditt saldo {DisplayBalance(balance)}");

                break;

            case "t":
            //    transactions(); 
               break; 


            case "x":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Fel input-välj annat i menyn");
                break;
        }

    }
}


catch (Exception ex)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    
}
finally
{
    Console.WriteLine("klar!");
}

}


//Metod för registrering av konto där vi hanterar att dom skriver in rätt data, och checkar att alla 3 fält har fyllts i och sedan felhanterar efter vid fel input, dvs vi hanterar det igenom throw och isnullorwhitespace.
static void RegisterAccount()
    {
        Console.WriteLine("Ange ditt kontonumer följt av förnamn och efternamn");
        //vi använder string? här för att värdet kan vara null, dvs tomt. den får lov att vara det. 
        string? info=Console.ReadLine();
        //if check för tom inmatning,spaces eller om vi får något som är mindre än 3 strängar. 
        if (!string.IsNullOrWhiteSpace(info))
        {
            var result=info.Split("");
            if(result.Length != 3)
            {
                throw new Exception("Du måste mata in uppgifterna med mellanslag");
            }
            //passerar vi checken här så skickar vi in datan ifrån info in till result som är som en array.
             account.accountNumber=result[0];
        account.firstName=result[1];
        account.lastName=result[2];
        }
       
    }

    
// Enkel metod för att skriva ut saldot...
static int DisplayBalance(int balance)
{

    Console.WriteLine($"Du har {balance} på ditt konto");
    return balance;
}

   static void Deposit(string amount)
    {
        if (!int.TryParse(amount, out int result))
        {
            throw new Exception("Kan inte tolka din inmatning som heltal");
        }
        account.Deposit(result);
    }
    public void WithDraw(string amount)
    {
        if (!int.TryParse(amount, out int result))
        {
            throw new Exception("Tyvärr förstår inte jag vad du menar");
        }
        account.WithDraw(result);
    }

static void PrintMenu()
{
    Console.WriteLine("-------------------------------------------------------------------");
    Console.WriteLine("meny alternativ");
    Console.WriteLine("för att avsluta programmet tryck på tangent X");
    Console.WriteLine("för att sätta in pengar  tryck på tangent d");
    Console.WriteLine("för att ta ut pengar  tryck på tangent w");
    Console.WriteLine("för att visa saldo  tryck på tangent b");
    Console.WriteLine("För att registrera uppgifter tryck på k");
     Console.WriteLine("För att se transaktioner tryck på t");
    Console.WriteLine("-------------------------------------------------------------------");
}

}

