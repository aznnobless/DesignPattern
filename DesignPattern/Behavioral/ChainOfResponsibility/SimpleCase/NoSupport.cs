namespace DesignPattern.Behavioral.ChainOfResponsibility.SimpleCase
{
    public class NoSupport : SupportHandler
    {
        public NoSupport(string name) : base(name)
        {

        }

        protected override bool Resolve(Request trouble)
        {
            return false;
        }
    }
}
