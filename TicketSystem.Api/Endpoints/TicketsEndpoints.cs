using TicketSystem.Api.Data;
using TicketSystem.Api.Dtos;
using TicketSystem.Api.Entities;
using TicketSystem.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace TicketSystem.Api.Endpoints;

public static class TicketsEndpoints
{
    const string GetTicketEndpointName = "GetTicket";

    public static RouteGroupBuilder MapTicketsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("tickets")
                       .WithParameterValidation();

        // GET /tickets
        group.MapGet("/", async (TicketSystemContext dbContext) => 
            await dbContext.Tickets
                     .Select(ticket => ticket.ToReadTicketDto())
                     .AsNoTracking()
                     .ToListAsync());

        // GET /tickets/1
        group.MapGet("/{id}", async (int id, TicketSystemContext dbContext) =>
        {
            Ticket? ticket = await dbContext.Tickets.FindAsync(id);

            return ticket is null ? 
                Results.NotFound() : Results.Ok(ticket.ToReadTicketDto());
        })
        .WithName(GetTicketEndpointName);

        // POST /tickets
        group.MapPost("/", async (CreateTicketDto newTicket, TicketSystemContext dbContext) =>
        {
            Ticket ticket = newTicket.ToEntity();

            dbContext.Tickets.Add(ticket);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(
                GetTicketEndpointName, 
                new { id = ticket.Id }, 
                ticket.ToReadTicketDto());
        });

        // PUT /tickets
        group.MapPut("/{id}", async (int id, UpdateTicketDto updatedTicket, TicketSystemContext dbContext) =>
        {
            var existingTicket = await dbContext.Tickets.FindAsync(id);

            if (existingTicket is null)
            {
                return Results.NotFound();
            }

            dbContext.Entry(existingTicket)
                     .CurrentValues
                     .SetValues(updatedTicket.ToEntity(id));

            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // DELETE /tickets/1
        group.MapDelete("/{id}", async (int id, TicketSystemContext dbContext) =>
        {
            await dbContext.Tickets
                     .Where(ticket => ticket.Id == id)
                     .ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}