namespace TicketSystem.Api.Dtos;

public record class ReadTicketDto(
    int Id, 
    string Description,
    DateTime SubmissionTime,
    DateTime CompletionDeadline
    );
