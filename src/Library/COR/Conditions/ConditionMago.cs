namespace Library
{
    public class ConditionMago : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.mago.ToString());
        }
    }
}