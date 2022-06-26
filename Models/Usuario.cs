namespace ProjetoBiblioteca.Models
{
    public class Usuario
    {   
        public static int ADMIN = 0;
        public static int PADRAP = 1;


        public int Id {get;set;}

        public string Nome {get;set;}

        public string Login {get;set;}

        public string Senha {get;set;}

        public int Tipo {get;set;}
    }
}