using System;

    class Persons{
        private int x;
       // private string y;

        public int X{
            get {return x;}
            set {
                if(value==20){
                    x=value;
                }
            }
        }
        
    }
class Displays{
    static void Main3(string[] args){
        Persons p=new Persons();
        p.X=20;

        Console.WriteLine(p.X);
    }
}