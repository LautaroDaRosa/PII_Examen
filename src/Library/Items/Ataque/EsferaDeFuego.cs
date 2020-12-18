namespace Library
{
    public class EsferaDeFuego : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public EsferaDeFuego()
        {
            Ataque = 10;
            Defensa = 0;
            Curacion = 0;
            EsMagico = false;
        }
    }
}