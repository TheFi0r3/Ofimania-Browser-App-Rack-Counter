using Ofimania_Browser_App_Rack_Counter.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Blazored.SessionStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddHttpContextAccessor();

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<HttpClient>();

builder.Services.AddTransient<ItemRackService>();
builder.Services.AddTransient<ItemCountService>();

builder.Services.AddScoped<RackStockService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
