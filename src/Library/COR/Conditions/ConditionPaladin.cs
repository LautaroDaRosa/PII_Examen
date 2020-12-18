namespace Library
{
    public class ConditionPaladin : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.paladin.ToString());
        }
    }
}