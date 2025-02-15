namespace DesignPattern.Behavioral.ChainOfResponsibility.SimpleCase
{
    public abstract class SupportHandler
    {
        private string _name;
        private SupportHandler _next;

        public SupportHandler(string name)
        {
            _name = name;
        }

        public SupportHandler Next(SupportHandler next)
        {
            _next = next;

            return next;
        }

        public void Process(Request trouble)
        {
            if (Resolve(trouble))
            {
                Done(trouble);
            }
            else if (_next != null)
            {
                _next.Process(trouble);
            }
            else
            {
                Fail(trouble);
            }
        }

        protected abstract bool Resolve(Request trouble);


        public override string ToString()
        {
            return $"[{_name}]";
        }

        public void Done(Request trouble)
        {
            Console.WriteLine($"{trouble} is resolved by {this}");
        }

        public void Fail(Request trouble)
        {
            Console.WriteLine($"{trouble} cannot be resolved.");
        }
    }
}
