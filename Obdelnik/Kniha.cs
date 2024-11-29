namespace Dedeicnost
{
    public abstract class Kniha
    {
        public string Nazev;
        public string Autor;
        public int RokVydani; 
        public static string VypsiInformaci();

        //Konstruktor
        public Kniha(string nazev, string autor, int rokVydani)
        {
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokVydani;
        }

        public virtual string VypisInformaci()
        {
            return Console.WriteLine(nazev", " + autor", " + rokVydani);
        }
    } 

     public class Ebook : Kniha
    {
        public double VelikostSouboru;
        public string Format;

        public override string VypisInformaci()
        {
            return Console.WriteLine(nazev", " + autor", " + rokVydani", " + VelikostSouboru", " + Format);
        }

    }
}