using ConsoleApp;

namespace ConsoleApp
{

  class Program
  {
    public static void Main(String[] args){
      

      Kniha kniha1 = new Kniha("Babička", "Němcová", 1885);
      Kniha kniha2 = new Kniha("To", "Kning", 1997);
     Kniha kniha3 = new Kniha("To", "Kning", 1997);
    Console.WriteLine(kniha1.VypisInformace()) ;
    Console.WriteLine(kniha2.VypisInformace()) ;
    Console.WriteLine(kniha3.VypisInformace()) ;

   Console.WriteLine("POčet knih v kniohovně:" + Knihovna.PocetKnih);
Console.WriteLine("POčet knih v kniohovně:" + Knihovna.knihovna.Count);
foreach (var item in Knihovna.knihovna)
{
    Console.WriteLine(item.VypisInformace()) ;
}
      
    }
  }
}