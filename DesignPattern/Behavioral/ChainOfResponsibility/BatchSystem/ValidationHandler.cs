namespace DesignPattern.Behavioral.ChainOfResponsibility.BatchSystem
{
    public  class ValidationHandler : BatchHandler
    {
        public override void Process(List<string> data)
        {
            Console.WriteLine("[ValidationHandler] Validation Start");

            // 간단한 검증 로직 (null 또는 빈 값 제거)
            data.RemoveAll(string.IsNullOrWhiteSpace);

            if (data.Count == 0)
            {
                Console.WriteLine("[ValidationHandler] Validating");
                return;
            }

            Console.WriteLine("[ValidationHandler] Validation done");

            base.Process(data);
        }
    }
}
