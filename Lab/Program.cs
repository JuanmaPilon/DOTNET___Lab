using Lab.Components;
using Microsoft.EntityFrameworkCore;
using Lab.Data;
using Lab.Components.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<LabContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LabContext") ?? throw new InvalidOperationException("Connection string 'LabContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Agregar el servicio de ProtectedBrowserStorage
builder.Services.AddSingleton<UserSessionService>(); // Registrar el servicio de sesión

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



app.Run();
