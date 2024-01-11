// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Security.Cryptography;

public interface IPizza
{
    void GetPizzaType();
}
public class Pizza : IPizza
{
    public void GetPizzaType()
    {
        Console.WriteLine("Normal Pizza created");
    }
}
public abstract class PizzaDecorator : IPizza
{
    protected IPizza decoratedPizza;
    public PizzaDecorator(IPizza decoratedPizza)
    {
        this.decoratedPizza = decoratedPizza;
    }
    public void GetPizzaType()
    {
        decoratedPizza.GetPizzaType();
    }
}
public class TomatoPizzaDecorator : PizzaDecorator
{
    public TomatoPizzaDecorator(IPizza decoratedPizza): base(decoratedPizza) { }
    public void GetPizzaType()
    {
        decoratedPizza.GetPizzaType();
        SetTomatoBase(decoratedPizza);
    }
    private void SetTomatoBase(IPizza decoratedPizza)
    {
        Console.WriteLine("pizza with tomato base created");
    }
}

public class Demo
{
    static void Main()
    {
        IPizza p = new Pizza();
        IPizza tomatobase = new TomatoPizzaDecorator(new Pizza());
        Console.WriteLine("Pizza with NOrmal base");
        p.GetPizzaType();
        Console.WriteLine("Pizza with Tomato base");
        tomatobase.GetPizzaType();
    }
}