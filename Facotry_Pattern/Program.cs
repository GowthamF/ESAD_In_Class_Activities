using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    //class LoginMain
    //{
    //    static void Main(string[] args)
    //    {
    //        var login1 = Login.Initialize();
    //        var validation = login1.validateUser("user", "password");
    //        var validation1 = login1.validateUser("user1", "password");
    //        Console.WriteLine(validation);
    //        Console.WriteLine(validation1);
    //        Console.ReadKey();
    //    }



    //}


    //public class Login
    //{
    //    private static Login instance;

    //    public static Login Initialize()
    //    {
    //        if (instance == null)
    //        {
    //            instance = new Login();
    //        }

    //        return instance;
    //    }


    //    public bool validateUser(string userName, string password)
    //    {
    //        if (userName == "user" && password == "password")
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //}


    public class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = FactoryProducer.GetFactory("SHAPE");

            IShape shape = (IShape)shapeFactory.GetAbstractFactory("rectangle");
            shape.Draw();

            IShape circleShape = (IShape)shapeFactory.GetAbstractFactory("circle");
            circleShape.Draw();

            IShape squareShape = (IShape)shapeFactory.GetAbstractFactory("square");
            squareShape.Draw();

            var colorFactory = FactoryProducer.GetFactory("COLOR");

            IColor redColor = (IColor)colorFactory.GetAbstractFactory("red");
            redColor.Fill();

            IColor greenColor = (IColor)colorFactory.GetAbstractFactory("green");
            greenColor.Fill();

            IColor blueColor = (IColor)colorFactory.GetAbstractFactory("blue");
            blueColor.Fill();
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

}
