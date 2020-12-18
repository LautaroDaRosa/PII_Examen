namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Esqueleto".
    public class HandlerEsqueleto : AbstractHandler
    {
        public HandlerEsqueleto(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Esqueleto esqueleto = new Esqueleto("Esqueleto "+this.diferenciador);
            this.diferenciador += 1;
            return esqueleto;
        }
    }
}