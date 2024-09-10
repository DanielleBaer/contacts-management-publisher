using ContactsManagement.Publisher.Domain.Enums;

namespace ContactsManagement.Publisher.Api.Models.Requests;

public record CreateContactRequest : CreatedContactMessageRequest
{
    internal override ContactMessage ToMessage() => base.ToMessage() with
    {
        Action = ContactsManagementAction.Create,
    };
}
