using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace TicketSystem.Frontend.Models;

public class Ticket
{
    public int Id { get; set; }

    [Required]
    [StringLength(1000)]
    public required string Description { get; set; }
    public DateTime SubmissionTime { get; set; }
    
    [Required(ErrorMessage = "The CompletionDeadline field is required.")]
    public DateTime CompletionDeadline { get; set; }
}