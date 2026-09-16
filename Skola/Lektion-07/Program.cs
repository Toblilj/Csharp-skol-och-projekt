/*Övning

Gå tillbaka till vår InvoiceApp och för varje klass ska ni implementerar egenskaper (properties). Fundera på vilka ska vara skrivskyddade och vilka behöver kunna manipuleras.

Fundera på vilka klasser behöver dedikerade konstruktorer. Skapa konstruktorer där det behövs.



*/

//en main class där jag kallar på alla grejer.
namespace:InvoiceApp;

public class program
{
    public void main()
    {
        Console.WriteLine("Ange ditt för namn här: ");
        String inputFirstName=Console.ReadLine();

        Console.WriteLine("Ange ditt efter namn här");
        String inputLastName=Console.ReadLine();

        Console.WriteLine("Ange adress");
        String inputAdress=Console.ReadLine();

        //randomisa customer id
        String generatorId="c"+ new Random () .Next(1000, 9999);

        //Här fyller vi vår class/skapar vårat objekt, som vi deklarerar i vår customer class, dvs här sätter vi värdena på variablerna som vi kallar på i constructorn. 
        Customer c=new Customer(inputFirstName, inputLastName, inputAdress, generatorId);
    }
}


//börjar med alla classer jag vill ha

//en class för kund registry
    public class Customer
    {
        public string firstName {get; set;}
                public string lastName {get; set;}
        public string adress {get; set;}
        public string customerId {get; private set;}

        public Customer (string firstName, string lastName, string adress, string customerId)
    {
        this.firstName=firstName;
        this.lastName=lastName;
        this.adress=adress;
        this.customerId=customerId;

    }
         
    }
//class för transactions historikt
    public class Transaction
    {
        
    }

//en class för invoice genering och sammanställning av datan

    public class Invoice
    {
        
    }

    




