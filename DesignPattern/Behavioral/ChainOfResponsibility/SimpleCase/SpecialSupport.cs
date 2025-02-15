namespace DesignPattern.Behavioral.ChainOfResponsibility.SimpleCase
{
    public class SpecialSupport : SupportHandler
    {
        private int _number;

        public SpecialSupport(string name, int number) : base(name)
        {
            _number = number;
        }

        protected override bool Resolve(Request trouble)
        {
            if (trouble.Number == _number)
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
