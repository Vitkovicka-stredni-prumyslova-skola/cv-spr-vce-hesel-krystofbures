namespace ConsoleApp
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
        }

        public override string VypisInformace()
        {
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
            PocetKnih++;
        }
    }
}