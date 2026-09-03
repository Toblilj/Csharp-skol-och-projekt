namespace intro_arrays;

class Progam
{
    
static void Main()
    {
        

        //detta är en kö!
       Queue<string> comics = new Queue<string>();

       comics.Enqueue("Fantomen");
       comics.Enqueue("läderlappen");
       comics.Enqueue("X9");

        foreach (var comic in comics)
        {
            Console.WriteLine("Queue -----------------------------------");
        }





    }





}

//  Sätter position på variabeln i min writeline med {0}
// Console.writelin("blah blah {0}", variabel );