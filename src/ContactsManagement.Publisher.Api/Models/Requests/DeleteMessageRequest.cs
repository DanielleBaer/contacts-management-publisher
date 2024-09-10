using System.ComponentModel.DataAnnotations;

namespace ContactsManagement.Publisher.Api.Models.Requests;

public record DeleteMessageRequest
{
    [Required]
    public Guid Id { get; init; }

    [Required]
    public string? Name { get; init; }

    [Required]
    public string? PhoneNumber { get; init; }

    internal DeleteMessageRequest ToDomain() => new()
    {
        Id = Id,
        Name = Name,
        PhoneNumber = PhoneNumber,
    };
}
