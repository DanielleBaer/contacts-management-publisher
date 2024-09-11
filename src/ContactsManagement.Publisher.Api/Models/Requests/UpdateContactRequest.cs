using ContactsManagement.Publisher.Domain.Enums;
using ContactsManagement.Publisher.Domain.Models;

namespace ContactsManagement.Publisher.Api.Models.Requests;

public record UpdateContactRequest : CreatedContactMessageRequest
{
    internal override ContactMessage ToMessage() => base.ToMessage() with
    {
        Action = ContactsManagementAction.Update,
    };
}
