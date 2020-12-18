namespace Library
{
    public class ConditionEsqueleto : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.esqueleto.ToString());
        }
    }
}