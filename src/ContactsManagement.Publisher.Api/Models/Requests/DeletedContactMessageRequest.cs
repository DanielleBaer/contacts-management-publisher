using System.ComponentModel.DataAnnotations;

namespace ContactsManagement.Publisher.Api.Models.Requests;

public record DeletedContactMessageRequest
{
    [Required]
    public Guid MessageId { get; init; }

    [Required]
    public DateTime EmmitedAt { get; init; }

    [Required]
    public DeleteMessageRequest? Data { get; init; }
}
