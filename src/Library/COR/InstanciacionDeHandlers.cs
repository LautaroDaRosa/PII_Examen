namespace Library
{
    /// <summary>
    /// Clase que colabora con el patron COR, la misma instancia los handlers que estan 
    /// diseñados para formar la cadena de responsabilidad. 
    /// </summary>   
    /// 
    /// Cumple con el patrón Creator ya que agrega, contiene y guarda instancias de objetos 
    /// de las clases que heredan de "AbstractHandler" (HandlerDemonio, HandlerDragon, HandlerElfo, etc)
    /// y de las clases que implementan la interfaz "ICondition" (ConditionDemonio, ConditionDragon, 
    /// ConditionElfo, etc).
    /// 
    /// Cumple con el patrón Singleton, ya que posee el método "GetInstance" el cual permite acceder a
    /// la instancia ya creada de la clase o a crear una única instancia de la misma en el caso que no
    /// haya ninguna instancia existente, este patrón es muy útil en esta clase debido a que los 
    /// handlers deben instanciarse una vez sola, y luego se les da uso múltiples veces pero con una vez
    /// que se creen es suficiente, entonces utilizando el patrón Singleton se asegura que la clase
    /// se instancie una vez sola.
    public class InstanciacionDeHandlers
    {
        public AbstractHandler primerHandler;
        private static InstanciacionDeHandlers instance;
        
        public static InstanciacionDeHandlers GetInstance()
        {
            if(instance == null)
            {
                instance = new InstanciacionDeHandlers();
            }
            return instance;
        }        
        public void Crear()
        {
            AbstractHandler handlerDemonio = new HandlerDemonio(new ConditionDemonio());
            AbstractHandler handlerDragon = new HandlerDragon(new ConditionDragon());
            AbstractHandler handlerElfo = new HandlerElfo(new ConditionElfo());
            AbstractHandler handlerEnano = new HandlerEnano(new ConditionEnano());
            AbstractHandler handlerMago = new HandlerMago(new ConditionMago());
            AbstractHandler handlerOrco = new HandlerOrco(new ConditionOrco());
            AbstractHandler handlerFantasma = new HandlerFantasma(new ConditionFantasma());
            AbstractHandler handlerEsqueleto = new HandlerEsqueleto(new ConditionEsqueleto());
            AbstractHandler handlerPaladin = new HandlerPaladin(new ConditionPaladin());
            AbstractHandler handlerDefault = new HandlerDefault(new ConditionDefault());

            handlerDemonio.Successor = handlerDragon;
            handlerDragon.Successor = handlerElfo;
            handlerElfo.Successor = handlerEnano;
            handlerEnano.Successor = handlerMago;
            handlerMago.Successor = handlerFantasma;
            handlerFantasma.Successor = handlerEsqueleto;
            handlerEsqueleto.Successor = handlerPaladin;
            handlerPaladin.Successor = handlerOrco;
            handlerOrco.Successor = handlerDefault;            

            this.primerHandler = handlerDemonio;
        }
    }
}