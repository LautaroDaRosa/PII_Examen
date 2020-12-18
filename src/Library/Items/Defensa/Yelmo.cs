namespace Library
{
    public class Yelmo : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public Yelmo()
        {
            Ataque = 0;
            Defensa = 15;
            Curacion = 0;
            EsMagico = false;
        }
    }
}