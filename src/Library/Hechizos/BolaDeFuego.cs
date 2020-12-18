namespace Library
{
    public class BolaDeFuego : IHechizo
    {
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int Curacion{get;set;}
        public BolaDeFuego()
        {
            Ataque = 10;
            Defensa = 0;
            Curacion = 0;
        }
    }
}