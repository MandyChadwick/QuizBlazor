using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace QuizBlazor.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        // This gives the WebAssembly client its HttpClient
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        // You MUST have this line at the bottom, or the client app won't start!
        await builder.Build().RunAsync();
    }
}