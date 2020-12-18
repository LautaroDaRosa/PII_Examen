namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Demonio".
    public class HandlerDemonio : AbstractHandler
    {
        public HandlerDemonio(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Demonio demonio = new Demonio("Demonio "+this.diferenciador);
            this.diferenciador += 1;
            return demonio;
        }
    }
}