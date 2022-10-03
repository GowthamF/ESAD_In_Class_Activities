public class Program
{
    static void Main(string[] args)
    {
        Waiter waiter = new Waiter();

        IMenu juice = new Juice();
        IMenu meal = new Meal();
        IMenu dessert = new Dessert();


        IOrder juiceOrder = new JuiceOrder(juice);
        IOrder mealOrder = new MealOrder(meal);
        IOrder dessertOrder = new DessertOrder(dessert);

        waiter.SetCommand(juiceOrder, mealOrder,dessertOrder);

        waiter.onJuiceOrder();
        waiter.onMealOrder();
        waiter.onDessertOrder();

    }
}


public interface IOrder
{
    void Execute();
}

public interface IMenu
{
    void PrepareMenu();
}

public class Juice : IMenu
{
    public void PrepareMenu()
    {
        Console.WriteLine("Making Juice");
    }
}

public class Meal : IMenu
{
    public void PrepareMenu()
    {
        Console.WriteLine("Preparing Meal");
    }
}

public class Dessert : IMenu
{
    public void PrepareMenu()
    {
        Console.WriteLine("Preparing Dessert");
    }
}

public class JuiceOrder : IOrder
{
    IMenu _menu;

    public JuiceOrder(IMenu menu)
    {
        _menu = menu;
    }

    public void Execute()
    {
        _menu.PrepareMenu();
    }
}

public class MealOrder : IOrder
{
    IMenu _menu;


    public MealOrder(IMenu menu)
    {
        _menu = menu;
    }

    public void Execute()
    {
        _menu.PrepareMenu();
    }
}

public class DessertOrder : IOrder
{
    IMenu _menu;

    public DessertOrder(IMenu menu)
    {
        _menu = menu;
    }


    public void Execute()
    {
        _menu.PrepareMenu();
    }
}

public class Waiter
{
    IOrder _juiceOrder;
    IOrder _mealOrder;
    IOrder _dessertOrder;

    public void SetCommand(IOrder juiceOrder, IOrder mealOrder, IOrder dessertOrder)
    {
        _juiceOrder = juiceOrder;
        _mealOrder = mealOrder;
        _dessertOrder = dessertOrder;
    }


    public void onJuiceOrder()
    {
        _juiceOrder.Execute();
    }

    public void onMealOrder()
    {
        _mealOrder.Execute();
    }

    public void onDessertOrder()
    {
        _dessertOrder.Execute();
    }
}
