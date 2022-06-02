using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ObraFacil.Data;
using Microsoft.EntityFrameworkCore;
using ObraFacil;
using ObraFacil.Infra.Contexts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton(new ObraFacilContext(builder.Configuration.GetConnectionString("DefaultConnection")));


await builder.Build().RunAsync();

