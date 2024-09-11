using ContactsManagement.Publisher.Domain.Models;

namespace ContactsManagement.Publisher.Api.Models.Requests;

public record ContactMessageRequest
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Ddd { get; set; }

    public string? PhoneNumber { get; set; }

    internal ContactMessage ToDomain() => new()
    {
        Id = Guid.NewGuid(),
        Name = Name,
        Email = Email,
        Ddd = Ddd,
        PhoneNumber = PhoneNumber,
    };
}
