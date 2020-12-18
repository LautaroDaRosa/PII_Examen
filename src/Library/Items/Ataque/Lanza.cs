namespace Library
{
    public class Lanza : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public Lanza()
        {
            Ataque = 15;
            Defensa = 0;
            Curacion = 0;
            EsMagico = false;
        }
    }
}