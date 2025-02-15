namespace DesignPattern.Behavioral.ChainOfResponsibility.SimpleCase
{
    public class Request
    {
        private int _number;

        public Request(int number)
        {
            _number = number;
        }

        public int Number { get { return _number; } }

        public override string ToString()
        {
            return $"[Trouble : {_number}]";
        }
    }
}
