using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Blazored.SessionStorage;

using Ofimania_Browser_App_Rack_Counter.Data;
using Ofimania_Browser_App_Rack_Counter.Services;
using Sybase_Data_Access;
using Sybase_Data_Access.Models;
using Sybase_Data_Access.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddHttpContextAccessor();

//Singleton Services
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<LoginFormService>();
builder.Services.AddScoped<HttpClient>();

//Transient Services
builder.Services.AddTransient<ItemRackService>();
builder.Services.AddTransient<ItemCountService>();

//Scoped Services
builder.Services.AddScoped<RackStockService>();
builder.Services.AddScoped<RackStoreService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

//API Services
builder.Services.AddSingleton<ISQLDataAccess, SQLDataAccess>();

builder.Services.AddScoped<IRackMovilData, RackMovilData>();
builder.Services.AddScoped<IProductoData, ProductoData>();
builder.Services.AddScoped<IEnc_InventarioData, Enc_InventarioData>();
builder.Services.AddScoped<IAlmacenData, AlmacenData>();
builder.Services.AddScoped<IPasilloData, PasilloData>();
builder.Services.AddScoped<ISeccionData, SeccionData>();
builder.Services.AddScoped<IUbicacionData, UbicacionData>();
builder.Services.AddScoped<IProducto_ReferenciaData, Producto_ReferenciaData>();

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
