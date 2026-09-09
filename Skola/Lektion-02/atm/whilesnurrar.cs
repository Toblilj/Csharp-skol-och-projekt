
// namespace whilesnurrar;
// class Program
// {


// static void Main()
// {


// //Skapa ett meny alternativ för att visa saldot på kontot X 
// // Lägg till logik i main metoden för att lyssna på tangenten för visa saldo X
// //Skapa så man kommer tillbaka till menynen efter man gjort sättit in/tagit ut pengar/kollat sitt saldo X
// //Inkludera så programmet sparar ditt saldo, hantera återkommande kund/ny kund, dvs värde om du har föregående saldo på banken eller ej.
// //Lägg till fel hantering X
// //Lägg till för att se transaktionshistorik
// //lägg till logik för att avsluta x (halvklar)

// Console.WriteLine("välkomen till skånska banken");


// try
// {
//     // Deklarera en variabel för aktuellt saldo...
//     int balance = 0;
//     static List<int> transactions = [];
//     // List<int> transactions = new List<int>();
//      string? amount = null;

//     while (true)
//     {
//         PrintMenu();
//         //tar user input
//         var key = Console.ReadLine();

//         switch (key)
//         {
//             case "d":
//                 balance = Deposit(balance);
//    if (string.IsNullOrWhiteSpace(amount))
//                         {
//                             throw new Exception("Du måste ange ett heltals belopp som du vill sätta in!");
//                             // Console.WriteLine("Du måste ange ett heltals belopp som du vill sätta in!, försök igen");
//                             // continue;
//                         }
//                 break;

//             case "w":
//                 balance = WithDraw(balance);

//                 //ha en if-else här för throw new exception om man försöker ta ut mer än man har på kontot. isnullorwhitespace
//                 //krashar här vid fel input   
//                    if (string.IsNullOrWhiteSpace(amount))
//                         {
//                             throw new Exception("Du måste ange ett heltals belopp som du vill sätta in!");
//                             // Console.WriteLine("Du måste ange ett heltals belopp som du vill sätta in!, försök igen");
//                             // continue;
//                         }  
//                 break;

//             case "b":
//                 Console.WriteLine($"Du har såhär mycket i ditt saldo {DisplayBalance(balance)}");

//                 break;

//             case "t":
//                transactions();
//                break; 


//             case "x":
//                 Environment.Exit(0);
//                 break;

//             default:
//                 Console.WriteLine("Fel input-välj annat i menyn");
//                 break;
//         }

//     }
// }


// catch (Exception ex)
// {
//     Console.ForegroundColor= ConsoleColor.Red;
//     Console.WriteLine(ex.Message);
    
// }
// finally
// {
//     Console.WriteLine("klar!");
// }

// }




// //Metoder ||-.........................................................................................................

// // Enkel metod för att skriva ut saldot...
// static int DisplayBalance(int balance)
// {

//     Console.WriteLine($"Du har {balance} på ditt konto");
//     return balance;
// }


// //ändrar till static int istället för void då jag vill retunera något till min main metod.
// static int Deposit(int currentBalance)
// {
//     Console.WriteLine("Hur mycket vill du sätta in?");
//     var amount = Console.ReadLine();

//     if (int.TryParse(amount, out int depositAmount))
//     {
//         int newBalance = currentBalance + depositAmount;
//         Console.WriteLine($"Efter din insättning har du nu {newBalance}");
//         return newBalance;
//     }
//     else
//     {
//        throw new Exception("Din inmatning får enbart vara heltal");
//     }





// }
// static int WithDraw(int negBalance)
// {
//     Console.WriteLine("Hur mycket vill du ta ut?");
//     var amount = Console.ReadLine();

//     if (int.TryParse(amount, out int withdrawAmount))
//     {
//         int newBalance = negBalance - withdrawAmount;

//         Console.WriteLine($"Efter ditt uttag har du nu {newBalance}");
//         return newBalance;
//     }
//     else
//     {
//         throw new Exception("Din inmatning får enbart vara heltal");
//     }


// }

// static void PrintMenu()
// {
//     Console.WriteLine("-------------------------------------------------------------------");
//     Console.WriteLine("meny alternativ");
//     Console.WriteLine("för att avsluta programmet tryck på tangent X");
//     Console.WriteLine("för att sätta in pengar  tryck på tangent d");
//     Console.WriteLine("för att ta ut pengar  tryck på tangent w");
//     Console.WriteLine("för att visa saldo  tryck på tangent b");
//     Console.WriteLine("-------------------------------------------------------------------");
// }


// }
