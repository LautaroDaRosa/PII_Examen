namespace Library
{
    public class ConjuroDefensivo : IHechizo
    {
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int Curacion{get;set;}
        public ConjuroDefensivo()
        {
            Ataque = 0;
            Defensa = 15;
            Curacion = 0;
        }
    }
}