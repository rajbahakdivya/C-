using GENERICS_METHOD;

class Program
{
    static void Main(string[] args)
    {
        int[] Number = new int[3];
        Number[0] = 11;
        Number[1]= 12;
        Number[2]= 13;

        String[] Names = {"A","B","C"};
        double[] Points = { 2.4, 2.3, 2.5 };

      
        Example.ShowArray(Names);
        Example.ShowArray(Points);

        Console.ReadLine();
    }
}