using System;
using System.IO;

class ReadChars{
    static void Main(){
        string str;
        Console.Out.WriteLine("Enter some characters.");
        str = Console.In.ReadLine();
        Console.WriteLine("You enterd: " + str);
    }
}