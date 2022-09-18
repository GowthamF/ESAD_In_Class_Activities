using ConsoleApp3;

public class Program
{
    static void Main(string[] args)
    {
        VehicleBuilder busBuilder = new BusBuilder();

        VehicleAssembler assembler = new VehicleAssembler(busBuilder);

        assembler.AssembleVehicle();

        assembler.GetVehicle();


        Console.WriteLine("================================");


        VehicleBuilder carBuilder = new CarBuilder();

        VehicleAssembler assembler2 = new VehicleAssembler(carBuilder);

        assembler2.AssembleVehicle();

        assembler2.GetVehicle();

    }
}


