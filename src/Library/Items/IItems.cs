namespace Library
{
    /// <summary>
    /// Interfaz que implementan las clases que representan a cada item, todos los items comparten
    /// un valor de ataque, defensa y curación, aunque alguno de estos atributos puede tener valor
    /// cero.
    /// </summary>
    public interface IItems
    {
        int Ataque{get;set;}
        int Defensa{get;set;}
        int Curacion{get;set;}
        bool EsMagico{get;set;}
    }
}