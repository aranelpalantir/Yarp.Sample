using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;
using Yarp.ReverseProxy.Health;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("customerRateLimiterPolicy", opt =>
    {
        opt.PermitLimit = 4;
        opt.Window = TimeSpan.FromSeconds(12);
        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        opt.QueueLimit = 2;
    });
});
builder.Services.Configure<TransportFailureRateHealthPolicyOptions>(o =>
{
    o.DetectionWindowSize = TimeSpan.FromSeconds(30);
    o.MinimalTotalCountThreshold = 5;
    o.DefaultFailureRateLimit = 0.5;
});

var app = builder.Build();
app.UseRateLimiter();
app.MapReverseProxy();
app.Run();