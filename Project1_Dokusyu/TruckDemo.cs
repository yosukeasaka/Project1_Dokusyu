using System;

class Vehicle
{
    public int Passengers {get; protected set;}
    public int FuelCap {get; protected set;}
    public int Mpg {get; protected set;}

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

class Truck : Vehicle{

    public Truck( int p, int f, int m, int c) : base(p, f, m){
        CargoCap = c;
    }

    public int CargoCap{ get; protected set; }
}


class TruckDemo
{
    static void Main()
    {
        Truck semi = new Truck (2, 200, 7, 44000);
        Truck pickup = new Truck(3, 28, 15, 2000);

        double gallons;
        int dist = 252;

        gallons = semi.FuelNeeded(dist);
        Console.WriteLine("Semi can carry " + semi.CargoCap  + " pounds.");
        Console.WriteLine("To go " + dist + " miles semi needs " + gallons + " gallons of fuel.");
        gallons = pickup.FuelNeeded(dist);
        Console.WriteLine("Pickup can carry " + pickup.CargoCap + " pounds.");
        Console.WriteLine("To go " + dist + " miles pickup needs " + gallons + " gallons of fuel.");

    }
}
