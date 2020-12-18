namespace Library
{
    /// Cumple con el patrón Creator ya que guarda instancias de objetos de la clase "Dragon".
    public class HandlerDragon : AbstractHandler
    {
        public HandlerDragon(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            Dragon dragon = new Dragon("Dragon "+this.diferenciador);
            this.diferenciador += 1;
            return dragon;
        }
    }
}