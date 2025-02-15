namespace DesignPattern.Behavioral.ChainOfResponsibility.SimpleCase
{
    public class LimitSupport : SupportHandler
    {
        private int _limit;

        public LimitSupport(string name, int limit) : base(name)
        {
            _limit = limit;
        }

        protected override bool Resolve(Request trouble)
        {
            if (trouble.Number < _limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
