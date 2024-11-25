namespace SpravceHesel
{

  class Program
  {
    public static void Main(String[] args){
      Console.WriteLine(Heslo.maxDelkaHesla);

      Heslo mojeheslo = new Heslo();

      Console.WriteLine(mojeheslo.MaxDelkaHesla());
    }
  }
}