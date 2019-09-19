/*using System;

class NonIntResultException : Exception{

    public NonIntResultException() : base(){ }
    public NonIntResultException(string str): base(str){ }
    public NonIntResultException(string str, Exception inner) : base(str, inner){ }
    public NonIntResultException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) : base(si, sc){ }

    public override string ToString() {
        return Message;
    }
}

class CustomExceptioDemo{
    static void Main(){
        int[] number = { 4, 8, 15, 32, 64, 127, 256, 512 };
        int[] denom = { 2, 0, 4, 4, 0, 8 };

        for(int i=0; i<number.Length; i++){
            try {
                if((number[i] % 2) != 0)
                    throw new NonIntResultException("OUtcome of " + number[i] + " / " + denom[i] + " is not even.");

                Console.WriteLine(number[i] + " / " + denom[i] + " is " + number[i]/denom[i]);
            }
            catch(DivideByZeroException){
                Console.WriteLine("Can't divide by Zero!");
            }
            catch(IndexOutOfRangeException){
                Console.WriteLine("No matching element found.");
            }
            catch(NonIntResultException exc){
                Console.WriteLine(exc);
            }

        }

    }
}*/