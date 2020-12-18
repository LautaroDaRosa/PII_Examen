namespace Library
{
    public class ItemCompuesto : IItems
    {
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int Curacion{get;set;}
        public bool EsMagico{get;set;}
        public ItemCompuesto(IItems item1, IItems item2)
        {   
            Ataque = item1.Ataque + item2.Ataque;
            Defensa = item1.Defensa + item2.Defensa;
            Curacion = item1.Curacion + item2.Curacion;
            EsMagico = item1.EsMagico || item2.EsMagico;
        }
    }
}