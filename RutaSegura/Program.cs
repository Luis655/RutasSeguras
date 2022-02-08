using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using RutaSegura.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var clientHandler = new HttpClientHandler();
clientHandler.ServerCertificateCustomValidationCallback = 
(message, cert, chain, errors) => true;
builder.Services.AddSingleton(new HttpClient(clientHandler){
    BaseAddress = new Uri("http://localhost:5264")
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
