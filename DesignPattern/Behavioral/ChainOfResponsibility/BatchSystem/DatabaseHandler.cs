namespace DesignPattern.Behavioral.ChainOfResponsibility.BatchSystem
{
    public class DatabaseHandler : BatchHandler
    {
        public override void Process(List<string> data)
        {
            Console.WriteLine("[DatabaseHandler] Connecting to DB");

            foreach (var item in data)
            {
                Console.WriteLine($"[DatabaseHandler] Storing into DB: {item}");
            }

            Console.WriteLine("[DatabaseHandler] Persist completed");
        }
    }
}
