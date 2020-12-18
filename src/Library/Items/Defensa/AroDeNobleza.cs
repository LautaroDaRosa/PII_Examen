namespace Library
{
    public class AroDeNobleza : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public AroDeNobleza()
        {
            Ataque = 0;
            Defensa = 5;
            Curacion = 0;
            EsMagico = false;
        }
    }
}