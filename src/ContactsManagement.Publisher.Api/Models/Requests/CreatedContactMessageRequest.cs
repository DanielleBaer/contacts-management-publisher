using System.ComponentModel.DataAnnotations;

namespace ContactsManagement.Publisher.Api.Models.Requests;

public abstract record CreatedContactMessageRequest
{
    [Required]
    public Guid MessageId { get; init; }

    [Required]
    public DateTime EmmitedAt { get; init; }

    [Required]
    public ContactMessageRequest Data { get; init; } = new();

    internal virtual ContactMessage ToMessage() => Data.ToDomain() with
    {
        MessageId = MessageId,
        EmmitedAt = EmmitedAt,
    };
}
