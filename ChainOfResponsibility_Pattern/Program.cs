public class Program
{
    static void Main(string[] args)
    {
        BestGradeHandler bestGradeHandler = new BestGradeHandler();
        MeritGradeHandler meritGradeHandler = new MeritGradeHandler();
        AverageGradeHandler averageGradeHandler = new AverageGradeHandler();
        FailGradeHandler failGradeHandler = new FailGradeHandler();

        bestGradeHandler.SetSuccessor(meritGradeHandler);
        meritGradeHandler.SetSuccessor(averageGradeHandler);
        averageGradeHandler.SetSuccessor(failGradeHandler);

        Console.Write("Enter marks for Grade = ");
        var mark=Console.ReadLine();
        
        var marks = mark != null ? double.Parse(mark) : 0;

        bestGradeHandler.ProcessRequest(new GradeRequest(marks));
        

    }
}


public abstract class GradeHandler
{
    protected GradeHandler? Successor;

    public void SetSuccessor(GradeHandler successor)
    {
        Successor = successor;
    }

    abstract public void ProcessRequest(GradeRequest request);
}

public class GradeRequest
{
    public double Mark
    {
        get; set;
    }

    public GradeRequest(double mark)
    {
        Mark = mark;
    }
}

public class BestGradeHandler : GradeHandler
{
    private const double maxMarks = 100;
    private const double minMarks = 79;

    public override void ProcessRequest(GradeRequest request)
    {
        if (request.Mark > minMarks && request.Mark <= maxMarks)
        {
            Console.WriteLine("A");
        }
        else
        {
            if (Successor != null)
            {
                Successor.ProcessRequest(request);
            }
        }
    }
}

public class MeritGradeHandler : GradeHandler
{
    private const double maxMarks = 80;
    private const double minMarks = 60;

    public override void ProcessRequest(GradeRequest request)
    {
        if (request.Mark >= minMarks && request.Mark < maxMarks)
        {
            Console.WriteLine("B");
        }
        else
        {
            if (Successor != null)
            {
                Successor.ProcessRequest(request);
            }
        }
    }
}

public class AverageGradeHandler : GradeHandler
{
    private const double maxMarks = 60;
    private const double minMarks = 39;

    public override void ProcessRequest(GradeRequest request)
    {
        if (request.Mark > minMarks && request.Mark <= maxMarks)
        {
            Console.WriteLine("C");
        }
        else
        {
            if (Successor != null)
            {
                Successor.ProcessRequest(request);
            }
        }
    }
}

public class FailGradeHandler : GradeHandler
{
    private const double maxMarks = 40;

    public override void ProcessRequest(GradeRequest request)
    {
        if (request.Mark < maxMarks)
        {
            Console.WriteLine("F");
        }
        else
        {
            if (Successor != null)
            {
                Successor.ProcessRequest(request);
            }
        }
    }
}