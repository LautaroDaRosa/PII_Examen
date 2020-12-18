namespace Library
{
    /// <summary>
    /// Interfaz que implementan las clases que representan los hechizos del Libro de hechizos,
    /// todos los hechizos comparten los atributos de ataque, defensa y curacion, los mismos
    /// tendrán efecto cuando el personaje ataque, defienda o se cure.
    /// </summary>
    public interface IHechizo
    {
        int Ataque{get;set;}
        int Defensa{get;set;}
        int Curacion{get;set;}
    }
}