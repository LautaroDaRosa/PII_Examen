namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Orco".
    public class HandlerOrco : AbstractHandler
    {
        public HandlerOrco(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Orco orco = new Orco("Orco "+this.diferenciador);
            this.diferenciador += 1;
            return orco;
        }
    }
}