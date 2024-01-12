using BethanysPieShopHRM.Client.Data;
using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IEmployeeStore, EmployeeStoreClient>();

await builder.Build().RunAsync();
