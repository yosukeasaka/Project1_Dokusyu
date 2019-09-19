/*using System;

class QueueFullException : Exception{
    public QueueFullException(string str) : base(str){}

    public override string ToString() {
        return "/n" + Message;
    }
}

class QueueEmptyException : Exception {
    public QueueEmptyException(string str) : base(str){}

    public override string ToString(){
        return "/n" + Message;
    }
}

class SimpleQueue
{
    public char[] q;
    public int putloc, getloc;

    public SimpleQueue(int size)
    {
        q = new char[size + 1];
        putloc = getloc = 0;
    }

    public void Put(char ch)
    {
        if (putloc == q.Length - 1)
        {
            throw new QueueFullException("Max length is " + (q.Length-1));
        }

        putloc++;
        q[putloc] = ch;
    }

    public char Get()
    {
        if (getloc == putloc)
        {
            throw new QueueEmptyException("Queue is empty.");
        }

        getloc++;
        return q[getloc];
    }
}

class QExcDemo
{
    static void Main()
    {
        SimpleQueue q = new SimpleQueue(10);
        char ch;
        int i;

        try{
            for(i=0; i < 11; i++){
                Console.Write("Attempting to store : " + (char)('A' + i));
                q.Put((char) ('A' + i));
                Console.WriteLine(" -- OK");
            }
            Console.WriteLine();
        }
        catch(QueueFullException exc){
            Console.WriteLine(exc);
        }
        Console.WriteLine();

        try{
            for(i=0; i < 11; i++){
                Console.Write("Getting next char: ");
                ch = q.Get();
                Console.WriteLine(ch);
            }
        }
        catch(QueueEmptyException exc ){
            Console.WriteLine(exc);
        }
    }
}*/