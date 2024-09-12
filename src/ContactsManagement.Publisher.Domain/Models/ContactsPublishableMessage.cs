namespace ContactsManagement.Publisher.Domain.Models;

public record ContactsPublishableMessage
{
    public string? UserAgent { get; init; }

    public string? CorrelationId { get; init; }

    public string? Source { get; init; }

    public Guid MessageId { get; init; }

    public DateTime EmmitedAt { get; init; }

    public object? Message { get; init; }
}
