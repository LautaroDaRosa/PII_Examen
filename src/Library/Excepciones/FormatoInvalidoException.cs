namespace Library
{
    /// <summary>
    /// Clase excepción que se encarga de los errores a la hora de cargar los datos de los personajes 
    /// a partir de un archivo, verifica que al ingresar los datos el formato de los mismos sea correcto.
    /// </summary>
    public class FormatoInvalidoException : System.Exception
    {
        public FormatoInvalidoException() : base() 
        {
        }
        public FormatoInvalidoException(string message) : base(message) 
        {     
        }
    }
}