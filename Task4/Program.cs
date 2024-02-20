public class Car
{
    public string Make;
    public string Model;
    public int Year;
    public double Mileage;
    public double Fuel;
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        Mileage = 0;
        Fuel = 0;
    }

    public void Drive(double miles)
    {
        double fuelNeeded = miles / 20.0;
        if (Fuel < fuelNeeded)
        {
            Console.WriteLine("Insufficient fuel to drive. Please refuel.");
        }
        else
        {
            Fuel -= fuelNeeded;
            Mileage += miles;
            Console.WriteLine($"Drove {miles} miles. Current mileage: {Mileage} miles");
        }
    }

    public void AddFuel(double gallons)
    {
        Fuel += gallons;
        Console.WriteLine($"Added {gallons} gallons of fuel. Current fuel level: {Fuel} gallons");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", "Camry", 2020);

        myCar.AddFuel(10);
        myCar.Drive(100);
        myCar.AddFuel(5);
        myCar.Drive(50);
    }
}
