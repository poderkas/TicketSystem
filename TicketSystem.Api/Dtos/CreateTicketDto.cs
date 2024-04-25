using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Api.Dtos;

public record class CreateTicketDto(
    [Required][StringLength(300)] string Description,
    DateTime SubmissionTime,
    DateTime CompletionDeadline
);