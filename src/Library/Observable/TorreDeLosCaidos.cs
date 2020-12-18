using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase que cumple con el patrón Observable implementando la interfaz "IObservable", 
    /// representa la "Torre de los caídos" que comunica a todos los personajes cuando un 
    /// personaje muere, de esta manera todos los personajes que se encuentran en la lista "observers"
    /// obtienen la información que necesitan.
    /// </summary>
    /// 
    /// Cumple con el patrón Creator ya que agrega objetos de la clases que implementan la interfaz
    /// "IObserver" en el atributo propio "observers".
    public class TorreDeLosCaidos : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        public void NotifyObservers(Personaje ganador, Personaje perdedor)
        {
            foreach (var observer in this.observers)
            {
                observer.Update(ganador, perdedor);
            }       
        }

        public void Subscribe(IObserver observer)
        {
            if (!observers.Contains(observer))
            {
                this.observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }       
        }
    }
}