using WorkerService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddSeq();
        });
    })
    .Build();

await host.RunAsync();

