namespace DesignPattern.Behavioral.ChainOfResponsibility.BatchSystem
{
    public class TransformationHandler : BatchHandler
    {
        public override void Process(List<string> data)
        {
            Console.WriteLine("[TransformationHandler] Data Massage Start");

            for (int i = 0; i < data.Count; i++)
            {
                data[i] = data[i].ToUpper(); 
            }

            Console.WriteLine("[TransformationHandler] Data Massage End");
            base.Process(data);
        }
    }
}
