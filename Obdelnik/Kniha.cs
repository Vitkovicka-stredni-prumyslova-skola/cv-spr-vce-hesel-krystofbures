<<<<<<< HEAD
namespace ConsoleApp
{
    public class Kniha
=======
namespace Dedicnost
{
    public class Kniha 
>>>>>>> 1a726c145ff16eb9719cf7331b6e7869f0d7f5a2
    {
        public string Nazev;
        public string Autor;
        public int RokVydani;
<<<<<<< HEAD

        public Kniha(string nazev, string autor, int rokVydani) 
        {
            this.Nazev = nazev;
            this.Autor = autor;
            this.RokVydani = rokVydani;

            Knihovna.PridatKnihu(this);
        }


        public virtual string VypisInformace()
        {
            return "Název: " + Nazev + ", Autor: " + Autor + ", Rok vydání: " + RokVydani;
        }

    }

    public class Ebook : Kniha 
    {
        public double VelikostSouboru;
        public string Format;

        public Ebook(string nazev, string autor, int rokVydani, string Format, double VelikostSouboru) : base(nazev, autor, rokVydani)
        {
            this.VelikostSouboru = VelikostSouboru;
            this.Format = Format;
=======

        public Kniha(string nazev, string autor, int rokVydani) 
        {
            this.Nazev = nazev;
            this.Autor = autor;
            this.RokVydani = rokVydani;
        }


        public virtual string VypisInformace()
        {
            return "Název:" + Nazev + ", Autor: " + Autor + ", Rok vydání: " + RokVydani;
        }

    } 

      public class Ebook : Kniha 
    {
        public double VelikostSouboru;
        public string Format;

        //Konstruktor pro Ebook base = přistup k členum konstruktorů
        public Ebook(string nazev, string autor, int rokVydani, string Format, double VelikostSouboru) : base(nazev, autor, rokVydani)
        {
            this.VelikostSouboru = velikostSouboru;
            this.Format = format;
>>>>>>> 1a726c145ff16eb9719cf7331b6e7869f0d7f5a2
        }

        public override string VypisInformace()
        {
<<<<<<< HEAD
            return base.VypisInformace() + ", Velikost Souboru: " + VelikostSouboru + ", formát: " + Format;
        }
    }

    public static class Knihovna
    {
        public static int PocetKnih;

        public static List<Kniha> knihovna = new List<Kniha>();
        
        public static void PridatKnihu(Kniha kniha)
        {
            knihovna.Add(kniha);
=======
            return base.VypisInformace() + ", Velikost Souboru: " + velikostSouboru + ", formát: " + format;
        }

        public static class Knihovna
    {
        public static int PocetKnih;

        //vytváří statickou proměnnou knihovna, která je seznamem objektů typu 
        public static List<Kniha> knihovna = new List<Kniha>();
        
        // přidává objekt typu Kniha do statického seznamu knihovna a zvyšuje čítač knih
        public static void PridatKnihu(Kniha kniha)
        {
            //Přidá objekt kniha do seznamu knihovna
            knihovna.Add(kniha);
            // zvyšuje proměnnou PocetKnih o 1 
>>>>>>> 1a726c145ff16eb9719cf7331b6e7869f0d7f5a2
            PocetKnih++;
        }
    }
}
