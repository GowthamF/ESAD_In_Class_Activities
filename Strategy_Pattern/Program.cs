public class Program
{
    static void Main(string[] args)
    {
        Students poStudents = new PostGraduateStudents();
        poStudents.OfferPrograms();
        poStudents.PerformEvent();
        poStudents.DisplayStudents();

        poStudents.SetFestival(new CodeFest());
        poStudents.PerformEvent();

    }
}


public interface IFestival
{
    void PerformEvent();
}

public interface IPrograms
{
    void OfferPrograms();
}

public class CodeFest : IFestival
{
    public void PerformEvent()
    {
        Console.WriteLine("Performing CodeFest");
    }
}

public class RoboFest : IFestival
{
    public void PerformEvent()
    {
        Console.WriteLine("Performing RoboFest");
    }
}

public class GameFest : IFestival
{
    public void PerformEvent()
    {
        Console.WriteLine("Performing GameFest");
    }
}

public class DoctoralPrograms : IPrograms
{
    public void OfferPrograms()
    {
        Console.WriteLine("Offering Doctoral");
    }
}

public class MScPrograms : IPrograms
{
    public void OfferPrograms()
    {
        Console.WriteLine("Offering Msc");
    }
}

public class BScPrograms : IPrograms
{
    public void OfferPrograms()
    {
        Console.WriteLine("Offering Bsc");
    }
}

public abstract class Students
{
    public IPrograms Programs;
    public IFestival Festival;


    public abstract void DisplayStudents();


    public void OfferPrograms()
    {
        Programs.OfferPrograms();
    }

    public void PerformEvent()
    {
        Festival.PerformEvent();
    }

    public void SetProgram(IPrograms program)
    {
        Programs = program;
    }

    public void SetFestival(IFestival festival)
    {
        Festival = festival;
    }
}

public class UndergraduateStudents : Students
{
    public UndergraduateStudents()
    {
        Programs = new BScPrograms();
        Festival = new CodeFest();
    }


    public override void DisplayStudents()
    {
        Console.WriteLine("Displaying Undergrads");
    }
}


public class PostGraduateStudents : Students
{
    public PostGraduateStudents()
    {
        Programs = new MScPrograms();
        Festival = new RoboFest();
    }


    public override void DisplayStudents()
    {
        Console.WriteLine("Displaying PostGraduates");
    }
}