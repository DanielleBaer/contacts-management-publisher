using ContactsManagement.Publisher.Domain.Models;
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

    internal static ContactsPublishableMessage ToMessage(DeletedContactMessageRequest contactMessage, HttpContext httpContext) => new()
    {
        UserAgent = "Test",
        CorrelationId = Guid.NewGuid().ToString(),
        Source = httpContext.Request.Path,
        MessageId = contactMessage.MessageId,
        EmmitedAt = contactMessage.EmmitedAt,
        Message = contactMessage.Data!.ToDomain(),
    };
}
