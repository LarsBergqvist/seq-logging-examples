namespace WorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly INumberService<int> _numberService;
    public Worker(ILogger<Worker> logger, INumberService<int> numberService)
    {
        _logger = logger;
        _numberService = numberService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            var result = _numberService.GetNumber();
            _logger.LogInformation("Number service returned: {Number}", result.Value);
            await Task.Delay(5000, stoppingToken);
        }
    }
}

