namespace Library
{
    public class ConditionDefault : ICondition
    {
        public bool IsSatisfied(string request)
        {
            return true;
        }
    }
}