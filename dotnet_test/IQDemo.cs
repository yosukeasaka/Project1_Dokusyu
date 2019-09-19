/*using System;

class SimpleQueue : ICharQ{
    char[] q;
    int putloc, getloc;

    public SimpleQueue(int size) {
        q = new char[size + 1];
        putloc = getloc = 0;
    }

    public void Put(char ch) {
        if (putloc == q.Length - 1){
            Console.WriteLine(" -- Queue is full.");
            return;
        }

        putloc++;
        q[putloc] = ch;
    }

    public char Get()
    {
        if (getloc == putloc){
            Console.WriteLine(" -- Queue is empty");
            return (char) 0;
        }

        getloc++;
        return q[getloc];
    }
}

class CircularQueue :ICharQ{
    char[] q;
    int putloc, getloc;

    public CircularQueue(int size){
        q = new char[size+1];
        putloc = getloc = 0;
    }

    public void Put(char ch){
        if(putloc+1 == getloc | ((putloc==q.Length-1) & (getloc == 0))){
            Console.WriteLine(" -- Queue is full.");
            return;
        }

        putloc++;
        if(putloc==q.Length) putloc = 0;
        q[putloc] = ch;
    }

    public char Get(){
        if (getloc == putloc){
            Console.WriteLine(" -- Queue is empty");
            return (char) 0;
        }

        getloc++;
        if(getloc==q.Length) getloc = 0;
        return q[getloc];
    }
}

class DynQueue : ICharQ{
    char[] q;
    int putloc, getloc;
    
    public DynQueue(int size){
        q = new char[size+1];
        putloc = getloc = 0;
    }

    public void Put(char ch){
        if(putloc+1 == getloc | ((putloc==q.Length-1) & (getloc==0))){
            char[] t = new char[q.Length * 2];
            int i;
            for(i=1; putloc != getloc; i++){
                t[i] = Get();
            }

            getloc = 0;
            putloc = i - 1;
            q = t;
        }
        putloc++;
        if(putloc==q.Length) putloc = 0;
        q[putloc] = ch; 
    }

    public char Get(){
        if(getloc == putloc){
            Console.WriteLine(" -- Queue is empty.");
            return (char) 0;
        }

        getloc++;
        if(getloc==q.Length) getloc =0;
        return q[getloc];
    }
}

class IQDemo {
    static void Main(){
        SimpleQueue q1 = new SimpleQueue(10);
        DynQueue q2 = new DynQueue(5);
        CircularQueue q3 = new CircularQueue(10);

        ICharQ iQ;
        char ch;
        int i;
        iQ = q1;
        for(i=0; i < 10; i++){
            iQ.Put((char) ('A' +i));
        }

        Console.Write("Contents of fixed-size queue: ");
        for(i=0; i < 10; i++){
            ch = iQ.Get();
            Console.Write(ch);
        }
        Console.WriteLine();

        iQ = q2;
        for(i=0; i < 10; i++){
            iQ.Put((char) ('Z' - i));
        }

        Console.Write("Contents of dynamic quque: ");
        for(i=0; i < 10; i++){
            ch = iQ.Get();
            Console.Write(ch);
        }
        Console.WriteLine();

        iQ = q3;
        for(i=0; i < 10; i++){
            iQ.Put((char) ('A' + i));
        }

        Console.Write("Contents of circular quque: ");
        for(i=0; i < 10; i++){
            ch = iQ.Get();
            Console.Write(ch);
        }
        Console.WriteLine();

        Console.WriteLine("Store and consume from" + " circular queue.");

        for(i=0; i < 20; i++){
            iQ.Put((char) ('A' +i));
            ch = iQ.Get();
            Console.Write(ch);
        }

    }
}*/