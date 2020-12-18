namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Fantasma".
    public class HandlerFantasma : AbstractHandler
    {
        public HandlerFantasma(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Fantasma fantasma = new Fantasma("Fantasma "+this.diferenciador);
            this.diferenciador += 1;
            return fantasma;
        }
    }
}