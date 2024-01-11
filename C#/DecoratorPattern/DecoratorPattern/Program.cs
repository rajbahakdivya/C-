using DecoratorPattern;

class Program
{
     static void Main(string[] args)
    {
        IPizza pizza= new Pizza();


       IPizza tomatoDecorator= new TomatoDecorator ( new Pizza());

        Console.WriteLine("Pizza with NOrmal base");
        pizza.GetPizzaType();
        Console.WriteLine("Pizza with Tomato base");
       tomatoDecorator.GetPizzaType();
       // IPizza onionDecorator = new CheeseDecorator(cheeseDecorator);

      //  IPizza tomatoDecorator = new CheeseDecorator(onionDecorator);

        //Console.WriteLine(cheeseDecorator .GetPizzaType());
        //Console.ReadLine();
    }
}
