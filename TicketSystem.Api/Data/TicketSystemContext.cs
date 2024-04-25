using TicketSystem.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace TicketSystem.Api.Data;

public class TicketSystemContext(DbContextOptions<TicketSystemContext> options)
    : DbContext(options)
{
    public DbSet<Ticket> Tickets => Set<Ticket>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>().HasData(
            new { Id = 1, Description = "ticket1", SubmissionTime = DateTime.UtcNow, CompletionDeadline = new DateTime(2030,11,05,0,0,0) },
            new { Id = 2, Description = "ticket2", SubmissionTime = DateTime.UtcNow, CompletionDeadline = new DateTime(2040,11,05,0,0,0) },
            new { Id = 3, Description = "ticket3", SubmissionTime = DateTime.UtcNow, CompletionDeadline = new DateTime(2024,11,05,0,0,0) },
            new { Id = 4, Description = "ticket4", SubmissionTime = DateTime.UtcNow, CompletionDeadline = new DateTime(2023,11,05,0,0,0) },
            new { Id = 5, Description = "ticket5", SubmissionTime = DateTime.UtcNow, CompletionDeadline = new DateTime(2060,11,05,0,0,0) }
        );
    }
}