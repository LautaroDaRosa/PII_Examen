namespace Library
{
    public class Espada : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public Espada()
        {
            Ataque = 20;
            Defensa = 0;
            Curacion = 0;
            EsMagico = false;
        }
    }
}