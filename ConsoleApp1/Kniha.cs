namespace ConsoleApp
{
    public class Kniha
    {
        //Vytvoření vylstnosti třidy kniha
        public string Nazev;
        public string Autor;
        public int RokVydani;

        //Knostruktor pro přeměnu vlastnsoti na paramtry
        public Kniha(string nazev, string autor, int rokVydani) 
        {
            this.Nazev = nazev;
            this.Autor = autor;
            this.RokVydani = rokVydani;

            Knihovna.PridatKnihu(this);
        }
        

        //Vypis informací   VIRTUAL - metoda co muže byt přepsana a upravena
        public virtual string VypisInformace()
        {
            return "Název: " + Nazev + ", Autor: " + Autor + ", Rok vydání: " + RokVydani;
        }

    }

    //Třída Ebook která dědí od třídy Kniha
    public class Ebook : Kniha 
    {
        public double VelikostSouboru;
        public string Format;

        //Knostruktor pro přeměnu vlastnsoti na paramtry BASE - umožňuje děděné třídě přístup k členům vyšší třídy (nemusíse použít pokud zakladní třída nemá parametry)
        public Ebook(string nazev, string autor, int rokVydani, string Format, double VelikostSouboru) : base(nazev, autor, rokVydani)
        {
            this.VelikostSouboru = VelikostSouboru;
            this.Format = Format;
        }

        //Vypis informací
        public override string VypisInformace()
        {
            return base.VypisInformace() + ", Velikost Souboru: " + VelikostSouboru + ", formát: " + Format;
        }
    }

    public static class Knihovna
    {
        public static int PocetKnih = 0;

        //Tento kód vytváří statický seznam knih který je přístupný z celé třídy
        public static List<Kniha> knihovna = new List<Kniha>();
        
        //Tento kód definuje statickou metodu PridatKnihu, která přidá Knihu
        public static void PridatKnihu(Kniha kniha)
        {
            knihovna.Add(kniha);
            //Zvýší počet knih o 1
            PocetKnih++;
        }
    }
}