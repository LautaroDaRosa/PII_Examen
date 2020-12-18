namespace Library
{
    /// <summary>
    /// Clase excepción que se encarga del error al quitar un item que no posee a un personaje.
    /// </summary>
    public class QuitarItemException : System.Exception
    {
        public QuitarItemException() : base() 
        {
        }
        public QuitarItemException(string message) : base(message) 
        {     
        }
    }
}