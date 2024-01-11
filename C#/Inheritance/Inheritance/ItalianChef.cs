

namespace Inheritance
{
    public class ItalianChef : Chef
    {
        public void MakePizza()
        {
            Console.WriteLine("The chef can make pizza");

        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The special dish is Pasta ");

        }
    }
}
