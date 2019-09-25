using System;

class Encode{
    static void Main(){

        string msg = "This is a test";
        string encmsg = "";
        string decmsg = "";
        string key = "abcdefgi";
        int j = 0;

        //Original Message
        Console.Write("Original Message: " + msg);
        Console.WriteLine();

        //Encode Message
        for(int i=0; i < msg.Length; i++){
            encmsg = encmsg + (char) (msg[i] ^ key[j]);
            j++;
            if(j==8) j=0;
        }
        Console.Write("Encode Message: " + encmsg);
        Console.WriteLine();

        // Decode Message
        j = 0;
        for(int i=0; i < msg.Length; i++){
            decmsg = decmsg + (char) (encmsg[i] ^ key[j]);
            j++;
            if(j==8) j=0;
        }
        Console.Write("Decode Message: " + decmsg);

    } // end of Main()
} // end of class Encode