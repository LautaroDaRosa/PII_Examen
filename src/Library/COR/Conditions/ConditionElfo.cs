namespace Library
{
    public class ConditionElfo : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.elfo.ToString());
        }
    }
}