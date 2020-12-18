namespace Library
{
    public class ConditionOrco : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.orco.ToString());
        }
    }
}