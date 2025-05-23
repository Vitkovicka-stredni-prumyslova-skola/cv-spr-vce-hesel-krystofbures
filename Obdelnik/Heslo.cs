namespace SpravceHesel
{
    interface IHeslo
    {
        int DelkaHesla();
        int MaxDelkaHesla();
        int MinDelkaHesla(); 
    }

    class Heslo : IHeslo
    {
        private String heslo;
        public static int  maxDelkaHesla = 20;
        private static int  minDelkaHesla = 8;
        
        string[] maleZnaky = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

        string[] velkeZnaky = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        
        string[] cislaZnaky = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        
        string[] specialniZnaky = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "{", "}", "[", "]", "|", "\\", ":", ";", "'", "\"", "<", ">", ",", ".", "?", "/", "~", "`"};


        public int DelkaHesla(){
            return 0;
        }
        public int MaxDelkaHesla(){
            return maxDelkaHesla;
        }
        public int MinDelkaHesla(){
            return minDelkaHesla;
        }

        public static String GeneraceHesla(int pocetZnakuHesla){
            //String [] seznamZnaku = maleZnaky 
            return "";
        }
    }
}