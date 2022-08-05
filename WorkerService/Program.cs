using WorkerService;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<INumberService<int>, MagicNumberGenerator>();
        services.AddHostedService<Worker>();
        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddSeq();
        });
    })
    .Build();

await host.RunAsync();

