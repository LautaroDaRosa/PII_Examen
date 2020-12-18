using System;

namespace Library
{
    /// <summary>
    /// Interfaz que hace uso del patrón Observable, las clases que implementan esta interfaz
    /// reciben información de una clase Observable que implemente la interfaz "IObservable" 
    /// si están suscritos a la misma, reciben la información mediante una actualización 
    /// del método "Update".
    /// </summary>
    ///
    /// Cumple con el patrón Polimorfismo, ya que la operación "Update" es una operación
    /// polimórfica, ya que la implementan múltiples objetos de tipo Personaje y de todos 
    /// los tipos/clases que heredan de Personaje.
    public interface IObserver
    {
        void Update(Personaje ganador, Personaje perdedor);
    }
}