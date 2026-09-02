// namespace atm;

// class Program
// {
//     static void Main()
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

//         displayBalance(balance);

//         Console.WriteLine("Hur mycket vill du ta ut?");
//         amount = Console.ReadLine();
//         Console.WriteLine($"Du vill ta ut {amount} Kr");

//        if( CheckBalance(balance, int.Parse(amount)))
//         {
//             Console.WriteLine($"Du har tillräckligt på {balance} för ditt utagg");
//         } else
//         {
//             Console.WriteLine($"Du har för lite på {balance} för att göra ditt uttag");
//              Environment.Exit(0);
//         }
       
//         balance -= int.Parse(amount);
//         // balance = balance - int.Parse(amount);

//           displayBalance(balance);
//     }
//     static bool CheckBalance( int balance, int amount)

//     {
//       if(balance < amount )
//         {
           
//             return false;
//         }  else
//         {
           
//             return true;
//         }



//     } 

// //här skapar vi en metod för att vi upprepar balance och saldo console write line flera gånger i min main metod.
// static void displayBalance(int balance)
//     {
//         Console.WriteLine($"Du har {balance} på ditt konto");
//     }



// }




