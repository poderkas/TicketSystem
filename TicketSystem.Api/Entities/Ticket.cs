namespace TicketSystem.Api.Entities;

public class Ticket
{
    public int Id { get; set; }

    public required string Description { get; set; }

    public DateTime SubmissionTime { get; set; }

    public DateTime CompletionDeadline { get; set; }
}
