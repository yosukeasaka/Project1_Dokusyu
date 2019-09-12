using System;

class Ractangle{
    int side1;
    int side2;
    public Ractangle(int i, int j){
        side1 = i;
        side2 = j;
    }

    public int  RectInfo(out bool isSquare){
        if(side1==side2) isSquare = true;
        else isSquare = false;

        return side1 * side2;
    }
}

class OutDemo{
    static void Main(){
        Ractangle rect = new Ractangle(10, 23);
        int area;
        bool isSqr;

        area = rect.RectInfo(out isSqr);
        if(isSqr) Console.WriteLine("rect is a square.");
        else Console.WriteLine("rect is not square.");

        Console.WriteLine("Its area is " + area + ".");
    }
}