using System;

class bubble{
    static void Main(){
        string[] ch = {"c", "g", "d", "e", "h", "u", "a", "b", "q", "z", "y"};
        int a, b;
        string t;
        int size = ch.Length;

        Console.Write("Original Array is: ");
        foreach(string c in ch) Console.Write(c + ", ");
        Console.WriteLine(); 

        for(a=0; a < size; a++){
            for(b=size-1; b >= a; b--){
                if(ch[b - 1].CompareTo(ch[b]) > 0){
                    t = ch[b-1];
                    ch[b-1] = ch[b];
                    ch[b] = t;

                }
            }
        }

        Console.Write("After Sorted Array is: ");
        foreach(string c in ch) Console.Write(c + ", ");
        Console.WriteLine(); 


    }
}