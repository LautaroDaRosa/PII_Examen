namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Mago".
    public class HandlerMago : AbstractHandler
    {
        public HandlerMago(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Mago mago = new Mago("Mago "+this.diferenciador);
            this.diferenciador += 1;
            return mago;
        }
    }
}