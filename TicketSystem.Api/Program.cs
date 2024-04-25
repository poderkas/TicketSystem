using TicketSystem.Api.Data;
using TicketSystem.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("TicketSystem");
builder.Services.AddSqlite<TicketSystemContext>(connString);

var app = builder.Build();

app.MapTicketsEndpoints();

await app.MigrateDbAsync();

app.Run();
