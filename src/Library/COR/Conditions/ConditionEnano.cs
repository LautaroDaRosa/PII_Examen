namespace Library
{
    public class ConditionEnano : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.enano.ToString());
        }
    }
}