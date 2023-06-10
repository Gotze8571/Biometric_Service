using BiometricBackgroundService;
using Serilog;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => {
        services.AddHostedService<Worker>();
    })
    .Build();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Users/DELL/OneDrive/Documents/logs/Biometric/Biometric.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

host.Run();
