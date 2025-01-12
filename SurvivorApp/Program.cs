using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SurvivorApp;
using SurvivorApp.Services;
using Microsoft.Extensions.Configuration;



var builder = WebAssemblyHostBuilder.CreateDefault(args);



builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { 
  BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});
builder.Services.AddSingleton<PersonService>();

await builder.Build().RunAsync();
