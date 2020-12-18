namespace Library
{
    public class MascaraDeLaMuerte : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public MascaraDeLaMuerte()
        {
            Ataque = 0;
            Defensa = 10;
            Curacion = 0;
            EsMagico = false;
        }
    }
}