namespace Library
{
    /// <summary>
    /// Clase que almacena los datos de la historia, guarda el resultado de cada batalla y qué 
    /// personaje/s resultaron vencedor/es y qué personaje/s murieron a sus manos.
    /// Cumple con el principio SRP ya que su única responsabilidad es guardar la información que recibe
    /// sobre cada combate, en el string "Combates" almacena todos los datos que recibe y luego los envía
    /// para escribir la historia en un archivo.
    /// </summary>
    public class Historia : IObserver
    {   
        public string Combates;
        public void Update(Personaje ganador, Personaje perdedor)
        {
            Combates += $"{ganador.Nombre} ha derrotado a {perdedor.Nombre}" + "\n";
        }
    }
}