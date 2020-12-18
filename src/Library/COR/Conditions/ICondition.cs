namespace Library
{
    /// Cumple con el patrón Polimorfismo, ya que la operación "IsSatisfied" es una
    /// operación polimórfica, ya que la implementan múltiples objetos de todos los tipos/clases 
    /// que heredan de ICondition (por ejemplo las clases "ConditionDemonio" y "ConditionElfo").
    public interface ICondition
    {
        bool IsSatisfied(string request);
    }
}