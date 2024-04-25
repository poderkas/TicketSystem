using Microsoft.EntityFrameworkCore;

namespace TicketSystem.Api.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<TicketSystemContext>();
        await dbContext.Database.MigrateAsync();
    }
}
