// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.ChainOfResponsibility.BatchSystem;
using DesignPattern.Behavioral.ChainOfResponsibility.SimpleCase;
using DesignPattern.Behavioral.Iterator.Simple;
using DesignPattern.Behavioral.Strategy.Simple;

Console.WriteLine("Hello, World!");
RunStrategyCase();
//ChainOfResponsibilityBatchSystem();


void RunStrategyCase()
{
    var data = new List<int>{ 5,3,8,4,2 };

    var sortService = new SortService();

    sortService.SetStrategy(new MergeSortStrategy());

    sortService.ExecuteSort(data);

    foreach(var item in data)
    {
        Console.WriteLine(item);
    }
}


void RunSimpleIteratorCase()
{

    int[] numbers = { 1, 2, 3, 4, 5 };

    MyCollection collection = new MyCollection(numbers);

    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
}

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