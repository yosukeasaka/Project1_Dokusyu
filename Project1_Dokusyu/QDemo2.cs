using System;

class SimpleQueue
{
    char[] q;
    int putloc, getloc;

    public SimpleQueue(int size)
    {
        q = new char[size + 1];
        putloc = getloc = 0;
    }

    public SimpleQueue(SimpleQueue ob){
        putloc = ob.putloc;
        getloc = ob.getloc;
        q = new char[ob.q.Length];

        for(int i=getloc+1; i <= putloc; i++){
            q[i] = ob.q[i];
        }
    }

    public SimpleQueue(char[] a){
        putloc = 0;
        getloc = 0;
        q = new char[a.Length+1];

        for(int i = 0; i< a.Length; i++) Put(a[i]);
    }

    public void Put(char ch)
    {
        if (putloc == q.Length - 1)
        {
            Console.WriteLine(" -- Queue is full.");
            return;
        }

        putloc++;
        q[putloc] = ch;
    }

    public char Get()
    {
        if(getloc == putloc)
        {
            Console.WriteLine(" -- Queue is empty");
            return (char)0;
        }

        getloc++;
        return q[getloc];
    }
}

class QDemo2
{
    static void Main()
    {
        SimpleQueue q1 = new SimpleQueue(10);

        char[] name = {'T', 'o', 'm'};

        SimpleQueue q2 = new SimpleQueue(name);
        char ch;
        int i;

        for (i = 0; i < 10; i++){
            q1.Put((char)('A' + i));
        }

        SimpleQueue q3 = new SimpleQueue(q1);

        Console.Write("Contests of q1: ");
        for (i = 0; i < 10; i++)
        {
            ch = q1.Get();
            Console.Write(ch);
        }

        Console.WriteLine("\n");

        Console.Write("Contests of q2: ");
        for(i=0; i < 3; i++)
        {
            ch = q2.Get();
            Console.Write(ch);
        }
        Console.WriteLine("\n");

        Console.Write("Contents of q3: ");
        for (i = 0; i < 10; i++)
        {
            ch = q3.Get();
            Console.Write(ch);
        }
        

    }
}