namespace Library
{
    public class Hacha : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public Hacha()
        {
            Ataque = 30;
            Defensa = 0;
            Curacion = 0;
            EsMagico = false;
        }
    }
}