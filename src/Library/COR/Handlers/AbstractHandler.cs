namespace Library
{
    /// <summary>
    /// Clase abstracta que hace uso del patron COR, forma parte de la cadena de responsabilidad
    /// ya que si su atributo "condition" que implementa la interfaz "ICondition" es verdadero
    /// se encarga de lo que se haya solicitado, en caso contrario le envía la solicitud
    /// al siguiente "handler" para que se encargue de la misma si es posible.
    /// Toda la carpeta COR se encuentra vinculada al patrón.
    /// </summary>
    ///
    /// Cumple con el patrón Polimorfismo, ya que las operaciones "Handle", y "handleRequest" son 
    /// operaciones polimórficas, ya que las implementan múltiples objetos de todos los tipos/clases 
    /// que heredan de AbstractHandler (por ejemplo las clases "HandlerDemonio" y "HandlerElfo").
    /// 
    /// Cumple con el patrón Creator ya que agrega objetos de las clases que implementan la interfaz
    /// "ICondition" en el atributo propio "condition".
    public abstract class AbstractHandler
    {
        private ICondition condition;
        public AbstractHandler Successor { get; set; }
        public int diferenciador;

        protected AbstractHandler(ICondition condition)
        {
            this.condition = condition;
        }

        public virtual Personaje Handle(string request)
        {
            if (this.condition.IsSatisfied(request))
            {
                return this.handleRequest(request);
            }
            else
            {
                if (this.Successor != null)
                {
                    return this.Successor.Handle(request);
                }
                else
                {
                    return null;
                }
            }
        }

        protected abstract Personaje handleRequest(string request);
    }
}