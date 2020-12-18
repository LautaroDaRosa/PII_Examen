namespace Library
{
    public class HandlerDefault : AbstractHandler
    {
        public HandlerDefault(ICondition condition) : base(condition)
        {
        }

        protected override Personaje handleRequest(string request)
        {
            throw new FormatoInvalidoException("Formato inválido, el tipo de raza no existe.");
        }
    }
}