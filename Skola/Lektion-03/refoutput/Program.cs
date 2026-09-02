namespace refoutput;



//Ref keyword, läs på om det! 
class Program {
static void Main()
{

int age= 25;
var refResult=DemoRef(ref age);

Console.WriteLine($"Local age = {age}");
Console.WriteLine($"ref age = {refResult}");

int outAge;

int outResult=DemoOut(age, out  outAge);

Console.WriteLine($"Local age = {age}");
Console.WriteLine($"ref age = {refResult}");
Console.WriteLine($"out variable {outAge}");
Console.WriteLine($"out result = {outResult}");

}

static int DemoRef(ref int age)
    {
        age++;
        return age;
    }



//out keyword,läs på! 
static int DemoOut(int age, out int newAge)
    {
        newAge= age;
        newAge++;
        return newAge;
    }
    }