//  class Program
// {
// static void Main()
//     {
//         // Deklarera en variabel för aktuellt saldo...
//         int balance;
//         // Insättning...
//         Console.WriteLine("Hur mycket vill du sätta in?");
//         // Deklarera en variabel för insättningen...
//         var amount = Console.ReadLine();

//         if (string.IsNullOrWhiteSpace(amount))
//         {
//             Console.WriteLine("DU MÅSTE ANGE HUR MYCKET DU VILL SÄTTA IN!!!");
//             Environment.Exit(0);
//         }

//         balance = int.Parse(amount);

//         //kallar på vår metod.
//         DisplayBalance(balance);

//         Console.WriteLine("Hur mycket vill du ta ut?");
//         amount = Console.ReadLine();


//         if (string.IsNullOrWhiteSpace(amount))
//         {
//             Console.WriteLine("Du måsta ange beloppet som du vill ta ut!");
//             Environment.Exit(0);
//         }

//         Console.WriteLine($"Du vill ta ut {amount} Kr");



//         if(int.TryParse(amount , out int result)) {
            
//              if (balance < result)
//         {
//             Console.WriteLine("Du har inte tillräckligt på kontot");
//             Environment.Exit(0);
//         }
//         balance -= result;
//         // balance = balance - int.Parse(amount);

//         DisplayBalance(balance);
//         }else
//         {
//             Console.WriteLine("de gick inge vidare");
//         }


//     }

//     // Enkel metod för att skriva ut saldot...
//     static void DisplayBalance(int balance)
//     {
//         Console.WriteLine($"Du har {balance} på ditt konto");
//     }

// }