namespace Library
{
    public class ConditionDragon : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return request.Equals(PersonajesEnum.dragon.ToString());
        }
    }
}