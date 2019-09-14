using System;

class Quicksort{
    public static void Qsort(char[] items){
        qs(items, 0, items.Length-1);
    }

    static void qs(char[] items, int left, int right){
        int i, j;
        char x, y;

        i = left;
        j = right;
        x = items[(left+right)/2];

        do {
            while((items[i] < x) && (i < right)) i++;
            while((x < items[j]) && (j > left)) j--;

            if(i <= j){
                y = items[i];
                items[i] = items[j];
                items[j] = y;
                i++; j--;
             }
        } while(i <= j);
        if(left < j) qs(items, left, j);
        if(i < right) qs(items, i, right);
    }
}

class QSDemo{
    static void Main(){
        char[] a = { 'd', 'x', 'a','r','p', 'j','i'};
        int i;

        Console.Write("Original array: ");
        for(i=0; i < a.Length; i++){
            Console.Write(a[i]);
        }
        Console.WriteLine();

        Quicksort.Qsort(a);

        Console.Write("Sorted array: ");
        for(i=0; i < a.Length; i ++){
            Console.Write(a[i]);
        }
    }
}