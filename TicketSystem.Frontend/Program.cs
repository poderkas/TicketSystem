using TicketSystem.Frontend.Clients;
using TicketSystem.Frontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

var ticketSystemApiUrl = builder.Configuration["TicketSystemApiUrl"] ?? 
    throw new Exception("TicketSystemApiUrl is not set");

builder.Services.AddHttpClient<TicketsClient>(
    client => client.BaseAddress = new Uri(ticketSystemApiUrl));

builder.Services.AddHttpClient<TicketsClient>(
    client => client.BaseAddress = new Uri(ticketSystemApiUrl));    

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();
