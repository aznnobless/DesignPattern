namespace DesignPattern.Behavioral.ChainOfResponsibility.BatchSystem
{
    public class HandlerChain
    {
        private List<BatchHandler> _chain;

        public HandlerChain()
        {
            _chain = new List<BatchHandler>();
        }

        public void AddHandler(BatchHandler handler)
        {
            _chain.Add(handler);
        }

        public BatchHandler? Build()
        {
            for(int i = 0; i < _chain.Count - 1 ; i++)
            {
                _chain[i].Next(_chain[i + 1]);
            }

            return _chain.Count > 0 ? _chain[0] : null;
        }
        
    }
}
