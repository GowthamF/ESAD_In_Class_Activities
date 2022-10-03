public class Program
{
    static void Main(string[] args)
    {
       Beverages tea = new Tea();
        tea.PrepareRecepie();

        Beverages coffee = new Coffee();
        coffee.PrepareRecepie();

    }
}


abstract class Beverages
{
    public abstract void Brew();
    public abstract void AddCondiments();

    public void PrepareRecepie()
    {
        BoilWater();
        Brew();
        AddCondiments();
        PourInCup();
        
    }

    void BoilWater()
    {
        Console.WriteLine("Boiling Water.");
    }

    void PourInCup()
    {
        Console.WriteLine("Pour into cup.");
    }
}

class Tea : Beverages
{
    public override void AddCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }

    public override void Brew()
    {
        Console.WriteLine("Steeping the Tea");
    }
}

class Coffee : Beverages
{
    public override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }

    public override void Brew()
    {
        Console.WriteLine("Steeping the coffee through filter");
    }
}