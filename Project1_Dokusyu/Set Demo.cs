using System;

class Set{
    char[] members; 
    public int Length{get; private set;}

    public Set(){
        Length = 0;
    }

    public Set(int size){
        members = new char[size];
        Length = 0;
    }

    public Set(Set s){
        members = new char[s.Length];
        for(int i=0; i < s.Length; i++) members[i] = s[i];
        Length = s.Length;
    }

    public char this[int idx]{
        get {
            if(idx >= 0 & idx < Length) return members[idx];
            else return (char) 0;
        }
    }

    int find(char ch){
        int i;

        for(i=0; i < Length; i++){
            if(members[i] == ch) return i;
        }
        return -1;
    }

    public static Set operator +(Set ob, char ch){
        if(ob.find(ch) != -1){
            return new Set(ob);
        } else {
            Set newset = new Set(ob.Length+1);

            for(int i=0; i < ob.Length; i++){
                newset.members[i] = ob.Length+1;
            }
            newset.members[i] = ob.Length+1;
            newset.members[newset.Length-1] = ch;

            return newset;
        }
    }

    public static Set operator -(Set ob, char ch){
        Set newset = new Set();
        int i = ob.find(ch);

        for(int j=0; j < ob.Length; j++){
            if(j != i) newset = newset + ob.members[i];
        }
        return newset;
    }

    public static Set operator +(Set ob1, Set ob2){
        Set newset = new Set(ob1);

        for(int i=0; i < ob2.Length; i++){
            newset = newset + ob2[i];
        }
        return newset;
    }

    public static Set operator -(Set ob1, Set ob2){
        Set newset = new Set(ob1);

        for(int i=0; i < ob2.Length; i++){
            newset = newset - ob2[i];
        }
        return newset;
    }
}