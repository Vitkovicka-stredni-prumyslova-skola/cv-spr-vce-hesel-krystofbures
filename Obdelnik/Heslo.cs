namespace SpravceHesel
{
    interface IHeslo
    {
        public int DelkaHesla();
        public int MaxDelkaHesla();
        public int MinDelkaHesla(); 
    }

    class Heslo : IHeslo
    {
        private string heslo;
         public static int  maxDelkaHesla = 20;
        private static int  minDelkaHesla = 8;

        int DelkaHesla(){
            return 0;
        }
        int MaxDelkaHesla(){
            return maxDelkaHesla;
        }
        int MinDelkaHesla(){
            return minDelkaHesla;
        } 
    }
}