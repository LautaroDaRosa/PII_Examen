using System;

namespace Library
{
    /// <summary>
    /// Interfaz que hace uso del patrón Observable, las clases que implementan esta interfaz
    /// son clases que otorgan información a todos las clases que implementen la interfaz
    /// "IObserver" y esten suscritos a la clase Observable, de esta manera se puede enviar
    /// información en el momento oportuno a múltiples destinos de forma eficiente.
    /// </summary>
    ///
    /// Cumple con el patrón Polimorfismo, ya que las operaciones "Subscribe", "Unsubscribe", 
    /// y "NotifyObservers" son operaciones polimórficas, ya que las implementan múltiples 
    /// objetos de todas las clases que implementan esta interfaz, aunque sólo "TorreDeLosCaídos"
    /// implementa esta interfaz cumple con el patrón ya que en lugar de preguntar por el tipo
    /// del objeto usa lógica condicional para ejecutar código que varía segun el tipo.
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void NotifyObservers(Personaje ganador, Personaje perdedor);
    }
}