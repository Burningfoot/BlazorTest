using BlazorTest.Client;
using BlazorTest.Client.ViewModels;
using BlazorTest.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<BaseViewModel>();
builder.Services.AddTransient<AnimalListViewModel>();
builder.Services.AddTransient<FirstPageViewModel>();
builder.Services.AddTransient<SecondPageViewModel>();

await builder.Build().RunAsync();
