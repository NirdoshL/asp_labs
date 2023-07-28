// Interface is blue-print of class..... Like Class is blue-print of object
//Object kastoh hunxa class le define garxa vaney ... Class Kastoh hunxa interface le dinxa
//eg: Phone class le call,sms,gps etc include garnai parxa vaney Interface create garne and
//interface ma vayeko sabai properties class le hold garnai parxa yo rules ho....
//Note : Class cannot have more than one inherited class but can have more than one interface
// eg: class Nirdosh: N,IN,IM where N=Inherited class IN,IM= two interface


interface Phone{
    public void call();
    public void sms();
    public void gps();
}

class Android:Phone 
{
//Interface call garyo kunai class le vaney teslay Implement garya vanxa not inherit.
//Phone ma vayeko sabai property Android define garnai parxa natra error fakxa and
//Android saga aafnai methods ni huna pauxa
   public void call(){
      Console.WriteLine("Calling......");
   }
   public void sms(){
      Console.WriteLine("Sending SMS......");
   }
   public void gps(){
      Console.WriteLine("Tracking Your Location......");
   }
   public void Settings(){
      Console.WriteLine("I am not interface");
   }

}

class MobilePhone{
    static void Main6(string[] args){
    Android realme=new Android();
    realme.call();
    realme.sms();
    realme.gps();
    realme.Settings();
    }
}