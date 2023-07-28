 abstract class Nirdosh{  //Class Name defining abstract method should also be of type abstract
        abstract public void callme(); //Abstract method has no defination in it
}

class Lamichhane:Nirdosh 
// The class that inherits abstract (base i.e Nirdosh) class must have to use all its abstract properties 
// if not used mark this class(Lamichhane) also an abstract class.
// In our case there is only one abstract method within base class(Nirdosh) so no need to mark 
// this class(lamichhane) as abstract class.
//Note: Instance of abstract class is never allowed. 
{

    public override void callme() 
    //Always use override keyword to define the inherited abstract property
    {
      Console.WriteLine("Nirdosh"); //defination of abstract class
    }

    public void  Display(){
        callme();
        Console.WriteLine("Lamichhane");

    }

}

class MainSystem{
    static void Main1(string[] args){
        Lamichhane L= new Lamichhane();
        L.Display();
    }
}