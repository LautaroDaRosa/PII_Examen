namespace Library
{
    /// <summary>
    /// Clase excepción que se encarga del error al no encontrar el archivo, verifica que la ruta
    /// del mismo sea correcta.
    /// </summary>
    public class ArchivoNoEncontradoException : System.Exception
    {
        public ArchivoNoEncontradoException() : base() 
        {

        }
        public ArchivoNoEncontradoException(string message) : base(message) 
        {

        }


    }
}
