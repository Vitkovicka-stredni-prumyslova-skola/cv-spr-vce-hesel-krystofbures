namespace Dedicnost
{
    public class Kniha 
    {
        public string Nazev;
        public string Autor;
        public int RokVydani;

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
        }

        public override string VypisInformace()
        {
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
            PocetKnih++;
        }
    }
}
