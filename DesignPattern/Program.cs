// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.ChainOfResponsibility.BatchSystem;
using DesignPattern.Behavioral.ChainOfResponsibility.SimpleCase;

Console.WriteLine("Hello, World!");

ChainOfResponsibilityBatchSystem();


void ChainOfResponsibilityBatchSystem()
{
    List<string> simpleBatchData = new List<string>()
    {
        "school",
        "development",
        "egg",
        "stock",
        "apple",
        "banana",
        "computer",
        "ai",
        "work"
    };

    // handler chain
    var handerChain = new HandlerChain();
    handerChain.AddHandler(new ValidationHandler());
    handerChain.AddHandler(new TransformationHandler());
    handerChain.AddHandler(new DatabaseHandler());

    BatchHandler chain = handerChain.Build();
    if (chain != null)
        chain.Process(simpleBatchData);

 }

void ChainOfResponsiblitySimpleCase()
{
    var thomas = new NoSupport("Thomas");
    var brandon = new LimitSupport("Brandon", 3);
    var utah = new OddSupport("Utah");
    var sreeni = new SpecialSupport("Sreeni", 1);
    var tuan = new SpecialSupport("Sreeni", 1);
    var geoff = new SpecialSupport("Geoff", 3);

    thomas.Next(brandon).Next(utah).Next(sreeni).Next(tuan).Next(geoff);

    var requests = new[]
    {
        new Request(1),
        new Request(2),
        new Request(3),
        new Request(4),
        new Request(1),
        new Request(4),
        new Request(5),
    };

    foreach (var request in requests)
    {
        Console.WriteLine($"Request : {request.Number}");
        thomas.Process(request);
    }
}