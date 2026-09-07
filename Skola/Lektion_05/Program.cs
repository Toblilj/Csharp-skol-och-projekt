namespace types;



class Vehicle
{
   public string manufacturer="";
    public string model="";

    public  int modelYear;

    public int milage;

    public void Accelerate()
    {
        Console.WriteLine("Jag gasar");
    }
}


public struct Customer
{
    public string firstName= "";
    public string lastName = "";
    public int age;

    public Customer()  //kopia av structen.
    {
    }
}

public string GetFullName()
    {
        return $"{firstName} {lastName} ";
    }


    public struct point
{
    public int x;
    public int y;
}


//record bra för o lagra data dvs variabler. 
public record product
{
    public string itemnumber="";
    public string name= "";
    public int numberInStock;
}

class Program
{
    static void Main(string[] args)
    {
        var volvo= new Vehicle();
        volvo.model="XC40";
        volvo.manufacturer="Volvo";
        volvo.modelYear=2023;
        volvo.milage=1000;
        volvo.Accelerate();


        var ford=new Vehicle();
        ford.model="F150";
        ford.manufacturer="Ford";
        ford.modelYear=2022;
        ford.milage=5000;
        ford.Accelerate();
    
volvo.model="Amazon";

Console.WriteLine(ford.model, ford.Accelerate);
        Console.WriteLine(volvo.model, volvo.Accelerate);

        var michael= new Customer();
        michael.firstName="Michael";
        michael.lastName="Jackson";
        michael.age=50;

        Console.WriteLine(Customer.firstName);

        var product=new product();
        product.itemnumber="1234";
        

    }
    }


