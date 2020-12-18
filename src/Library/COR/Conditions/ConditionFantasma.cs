namespace Library
{
    public class ConditionFantasma : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.fantasma.ToString());
        }
    }
}