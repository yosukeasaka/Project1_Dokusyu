using System;

class Vehicle
{
    public int Passengers;
    public int FuelCap;
    public int Mpg;

    public Vehicle(int p, int f, int m)
    {
        Passengers = p;
        FuelCap = f;
        Mpg = m;
    }

    public int Range()
    {
        return FuelCap * Mpg;
    }

    public double FuelNeeded(int miles)
    {
        return (double) miles / Mpg;
    }
}


class VehicleDemo
{
    static void Vehicle_main()
    {
        Vehicle minivan = new Vehicle(7, 16, 21);
        Vehicle sportscar = new Vehicle(2, 14, 12);
        double gallons;
        int dist = 252;

        gallons = minivan.FuelNeeded(dist);
        Console.WriteLine("Minivan can carry " + minivan.Passengers + " with range of " + minivan.Range() + " miles.");
        Console.WriteLine("To go " + dist + " miles minivan needs " + gallons + " gallons of fuel.");
        gallons = sportscar.FuelNeeded(dist);
        Console.WriteLine("Sports Car can carry " + sportscar.Passengers + " with range of " + sportscar.Range() + " miles.");
        Console.WriteLine("To go " + dist + " miles sports car needs " + gallons + " gallons of fuel.");

    }
}
