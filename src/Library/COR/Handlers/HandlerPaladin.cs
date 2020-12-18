namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Paladin".
    public class HandlerPaladin : AbstractHandler
    {
        public HandlerPaladin(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Paladin paladin = new Paladin("Paladin "+this.diferenciador);
            this.diferenciador += 1;
            return paladin;
        }
    }
}