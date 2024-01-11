
using System.Collections;
using System.Collections.Generic;

class Listprogram
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("Hello");

        List<string> Fruits = new List<string>();
        Fruits.Add("Mango");
        Fruits.Add("Apple");
        Fruits.Add("Orange");


        list.AddRange(Fruits);
        list.Add("Orange");

        Console.WriteLine(list.Capacity);
        Console.WriteLine(list.Count);

        list.Insert(0, "Banana");

        list[0] = "Tomato";

        list.RemoveAt(1);
        list.Remove("Orange");
        list.Remove("Orange");
        // list.Clear();

        if (list.Contains("white"))
            Console.WriteLine("Success");
        else
            Console.WriteLine("Failure");





        foreach (string o in list) Console.WriteLine(o);





    }
}