

using Inheritance3;

class Program
{
    static void Main(string[] args)
    {
   

        Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();

        Console.WriteLine("Enter your age");
        int age= int.Parse(Console.ReadLine());

        Person user = new Person(name, age);


        Console.WriteLine($"User Details: Name:{name} \n Age:{age}" );
    }
}