

using Inheritance2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two number for addition:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        AdvanceCalculator calculator = new AdvanceCalculator();
        Console.WriteLine(calculator.Add(number1,number2));

        //Console.WriteLine("sum of number is:"+sum);


        Console.WriteLine("\nEnter two numbers for multiplication:");
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        Console.WriteLine(calculator.Multiply(number3, number4));



        //int product = calc.Multiply(number3, number4);
        //Console.WriteLine($"Product of {number3} and {number4} is: {product}");
    }
}
