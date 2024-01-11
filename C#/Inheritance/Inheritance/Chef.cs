
namespace Inheritance
{
    public class Chef
    {
        public void MakeChicken ()
        {
            Console.WriteLine("The chef make chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef make salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The special dish is Momo ");

        }
    }

}
