// namespace whilesnurrar;
// class Program
// {

// static void Main()

// //Skapa ett meny alternativ för att visa saldot på kontot X 
// // Lägg till logik i main metoden för att lyssna på tangenten för visa saldo X
// // Skapa metoder för att kunna sätta in och ta ut pengar som anropas ifrån vår while loop  X
// //Skapa så man kommer tillbaka till menynen efter man gjort sättit in/tagit ut pengar/kollat sitt saldo 
// //Inkludera så programmet sparar ditt saldo, hantera återkommande kund/ny kund, dvs värde om du har föregående saldo på banken eller ej.


//     {
//         //påbörja vår meny..
//         Console.WriteLine("-------------------------------------------------------------------");
//         Console.WriteLine("välkomen till skånska banken");
//         Console.WriteLine("meny alternativ");
//         Console.WriteLine("för att avsluta programmet tryck på tangent X");
//         Console.WriteLine("för att sätta in pengar  tryck på tangent d");
//          Console.WriteLine("för att ta ut pengar  tryck på tangent w");
//           Console.WriteLine("för att visa saldo  tryck på tangent b");
//         Console.WriteLine("-------------------------------------------------------------------");    
    
//     // Deklarera en variabel för aktuellt saldo...
//         int balance = 0;

//         while (true)
//         {
//             //tar user input
//             var key = Console.ReadLine();
// //loopar för att kolla värden
//             if (string.IsNullOrWhiteSpace(key) || key == "x")
//             {
//                 Environment.Exit(0);
//             }
//             else if (key == "d")
//             {
//                 //här vill vi sätta deposit metoden sen
//                 // Console.WriteLine("Hur mycket vill du sätta in?");
//                 // var amount = Console.ReadLine();
//                 balance=Deposit (balance);

//                 // if (string.IsNullOrWhiteSpace(amount))
//                 // {
//                 //     Console.WriteLine("Du måste ange ett heltals belopp som du vill sätta in!");
//                 //     Environment.Exit(0);
//                 // }

//                 // if (int.TryParse(amount, out int result))
//                 // {
//                 //     balance += result;
//                 //     DisplayBalance(balance);
//                 // }
//                 // else if
//                 // {
//                 //     Console.WriteLine("Tyvärr förstår inte jag vad du menar");
//                 //     Environment.Exit(0);
//                 // }
//             }
//             else if (key == "w")
//             {
//                 //här sätter vi withdraw metoden
//                 // Console.WriteLine("Hur mycket vill du ta ut?");
//                 // var amount = Console.ReadLine();
//                 balance= WithDraw(balance);


//                 // if (string.IsNullOrWhiteSpace(amount))
//                 // {
//                 //     Console.WriteLine("Du måste ange ett heltals belopp som du vill ta ut!");
//                 //     Environment.Exit(0);
//                 // }

//                 // if (int.TryParse(amount, out int result))
//                 // {
//                 //     balance -= result;
//                 //     DisplayBalance(balance);
//                 // }
//                 // else
//                 // {
//                 //     Console.WriteLine("Tyvärr förstår inte jag vad du menar");
//                 //     Environment.Exit(0);
//                 // }
//             } else if (key == "b")
//             {
//                Console.WriteLine($"Du har såhär mycket i ditt saldo {balance}");
                
//             } else
//             {
//                 Console.WriteLine("Jag förstår inte ditt val");
//                 Environment.Exit(0);
//             }
//         }
//     }

//     // Enkel metod för att skriva ut saldot...
//     static void DisplayBalance(int balance)
//     {
//         Console.WriteLine($"Du har {balance} på ditt konto");
//     }
//         //  Skapa metoder för att kunna sätta in och ta ut pengar som anropas ifrån vår while loop

//         //ändrar till static int istället för void då jag vill retunera något till min main metod.
//     static int Deposit( int  currentBalance)
//     {
//          Console.WriteLine("Hur mycket vill du sätta in?");
//                 var amount = Console.ReadLine();

//                 if(int.TryParse(amount, out int depositAmount)){
//             int newBalance = currentBalance + depositAmount;

//             Console.WriteLine($"Efter din insättning har du nu {newBalance}");
//                 }
//                 else
//         {
//               Console.WriteLine($"Du har såhär mycket i ditt saldo {currentBalance}");
//               Console.WriteLine("Jag förstår inte ditt val");
//                 Environment.Exit(0);
//         }    
//             return currentBalance;

            
        

//     }
//     static int WithDraw( int negBalance)
//     {
//         Console.WriteLine("Hur mycket vill du ta ut?");
//                 var amount = Console.ReadLine();

//                 if(int.TryParse(amount, out int withdrawAmount)){
//             int newBalance = negBalance - withdrawAmount;

//             Console.WriteLine($"Efter ditt uttag har du nu {newBalance}");
//                 }
//                 else
//         {
//               Console.WriteLine($"Du har såhär mycket i ditt saldo {negBalance}");
//               Console.WriteLine("Jag förstår inte ditt val");
//                 Environment.Exit(0);
//         }    
//              return negBalance;

//     }
       



// }
            