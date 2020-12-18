namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Elfo".
    public class HandlerElfo : AbstractHandler
    {
        public HandlerElfo(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Elfo elfo = new Elfo("Elfo "+this.diferenciador);
            this.diferenciador += 1;
            return elfo;
        }
    }
}