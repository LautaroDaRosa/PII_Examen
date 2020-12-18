namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Enano".
    public class HandlerEnano : AbstractHandler
    {
        public HandlerEnano(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Enano enano = new Enano("Enano "+this.diferenciador);
            this.diferenciador += 1;
            return enano;
        }
    }
}