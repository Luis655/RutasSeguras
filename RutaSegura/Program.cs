using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using RutaSegura.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlazorCRUD.Client.Auth;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<System.Net.Http.HttpClient>();
builder.Services.AddAuthenticationCore();
builder.Services.AddScoped<Autorizaciones>();
builder.Services.AddScoped<AuthenticationStateProvider, Autorizaciones>(provider => provider.GetRequiredService<Autorizaciones>());
builder.Services.AddScoped<ILoginService, Autorizaciones>(provider => provider.GetRequiredService<Autorizaciones>());

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
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
        endpoints.MapBlazorHub();
        endpoints.MapFallbackToPage("/Host");

    }
    );
  }

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();


