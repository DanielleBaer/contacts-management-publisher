using ContactsManagement.Publisher.Domain.Enums;
using System.Text.Json.Serialization;

namespace ContactsManagement.Publisher.Domain.Models;

public record ContactMessage
{
    [JsonIgnore]
    public Guid MessageId { get; init; }

    [JsonIgnore]
    public DateTime EmmitedAt { get; init; }

    [JsonIgnore]
    public ContactsManagementAction Action { get; init; }

    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Ddd { get; set; }

    public string? PhoneNumber { get; set; }
}
