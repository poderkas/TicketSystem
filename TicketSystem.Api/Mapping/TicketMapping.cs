using TicketSystem.Api.Dtos;
using TicketSystem.Api.Entities;

namespace TicketSystem.Api.Mapping;

public static class TicketMapping
{
    public static Ticket ToEntity(this CreateTicketDto ticket)
    {
        return new Ticket()
        {
            Description = ticket.Description,
            SubmissionTime = ticket.SubmissionTime,
            CompletionDeadline = ticket.CompletionDeadline
        };
    }

    public static Ticket ToEntity(this UpdateTicketDto ticket, int id)
    {
        return new Ticket()
        {
            Id = id,
            Description = ticket.Description,
            SubmissionTime = ticket.SubmissionTime,
            CompletionDeadline = ticket.CompletionDeadline
        };
    }

     public static ReadTicketDto ToReadTicketDto(this Ticket ticket)
    {
        return new(
            ticket.Id,
            ticket.Description,
            ticket.SubmissionTime,
            ticket.CompletionDeadline
        );
    }
}