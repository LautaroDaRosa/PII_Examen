namespace Library
{
    public class Mazo : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public Mazo()
        {
            Ataque = 25;
            Defensa = 0;
            Curacion = 0;
            EsMagico = false;
        }
    }
}