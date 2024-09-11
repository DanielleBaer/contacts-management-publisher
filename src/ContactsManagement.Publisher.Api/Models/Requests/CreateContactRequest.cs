using ContactsManagement.Publisher.Domain.Enums;
using ContactsManagement.Publisher.Domain.Models;

namespace ContactsManagement.Publisher.Api.Models.Requests;

public record CreateContactRequest : CreatedContactMessageRequest
{
    internal override ContactMessage ToMessage() => base.ToMessage() with
    {
        Action = ContactsManagementAction.Create,
    };
}
