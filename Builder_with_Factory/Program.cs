using Builder_with_Factory;

public class Program
{
    static void Main(string[] args)
    {
        ShapeBuilder rectangleBuilder = new RectangleBuilder();

        Artist artist = new Artist(rectangleBuilder);

        artist.ConstructShape();

        artist.GetShape();


        Console.WriteLine("================================");


        ShapeBuilder circleShapeBuilder = new CircleShapeBuilder();

        Artist artist1 = new Artist(circleShapeBuilder);

        artist1.ConstructShape();

        artist1.GetShape();

    }
}


public interface IShape : IFactory
{
    void Draw();
}

public interface IColor : IFactory
{
    void Fill();
}

public interface IFactory
{
}

public class RedColor : IColor
{
    public void Fill()
    {
        Console.WriteLine("Red Color Fill");
    }
}

public class GreenColor : IColor
{
    public void Fill()
    {
        Console.WriteLine("Green Color Fill");
    }
}

public class BlueColor : IColor
{
    public void Fill()
    {
        Console.WriteLine("Blue Color Fill");
    }
}

public class CircleShape : IShape
{
    public void Draw()
    {
        Console.WriteLine("Circle Shape Draw");
    }
}

public class SquareShape : IShape
{
    public void Draw()
    {
        Console.WriteLine("Square Shape Draw");
    }
}

public class RectangleShape : IShape
{
    public void Draw()
    {
        Console.WriteLine("Rectangle Shape Draw");
    }
}


class ShapeFactory : AbstractFactory
{

    public override IFactory GetAbstractFactory(string name)
    {
        if (name == "rectangle")
        {
            return new RectangleShape();
        }
        else if (name == "circle")
        {
            return new CircleShape();
        }

        return new SquareShape();
    }
}

class ColorFactory : AbstractFactory
{

    public override IFactory GetAbstractFactory(string name)
    {
        if (name == "red")
        {
            return new RedColor();
        }
        else if (name == "blue")
        {
            return new BlueColor();
        }

        return new GreenColor();
    }
}

public abstract class AbstractFactory
{
    public abstract IFactory GetAbstractFactory(string name);
}

public static class FactoryProducer
{
    public static AbstractFactory GetFactory(string factoryName)
    {
        if (factoryName == "SHAPE")
        {
            return new ShapeFactory();
        }

        return new ColorFactory();
    }
}