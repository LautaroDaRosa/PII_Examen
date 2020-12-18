namespace Library
{
    public class ConditionDemonio : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.demonio.ToString());
        }
    }
}