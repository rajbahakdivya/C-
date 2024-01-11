
using System;
using static Program;

class Program
{
    public delegate void VoidDelegate();

    public delegate void VoidDelegateWithParams(string msg);
    public delegate int CalculateDelegate(int a, int b);

    public static void Main(string[] args)
    {
        CalculateDelegate del = Subtract;
        //del += Add;
        Myclass.ExecuteDelegate(del);
    }

    public static int Add(int a, int b)
    { return a + b; }
    public static int Subtract(int a, int b)
    { return a - b; }


}
class Myclass
{
    public static void ExecuteDelegate(CalculateDelegate del)
    {
        Console.WriteLine(del(5, 2));
    }
}

