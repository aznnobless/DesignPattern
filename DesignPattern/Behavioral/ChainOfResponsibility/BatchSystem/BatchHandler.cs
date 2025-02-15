namespace DesignPattern.Behavioral.ChainOfResponsibility.BatchSystem
{
    public abstract class BatchHandler
    {
        protected BatchHandler NextStep;

        public void Next(BatchHandler nextHander)
        {
            NextStep = nextHander;
        }

        public virtual void Process(List<string> data)
        {
            NextStep?.Process(data);
        }

    }
}
