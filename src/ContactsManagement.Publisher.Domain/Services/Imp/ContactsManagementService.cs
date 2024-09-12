using ContactsManagement.Publisher.Domain.Enums;
using ContactsManagement.Publisher.Domain.Interfaces;
using ContactsManagement.Publisher.Domain.Models;

namespace ContactsManagement.Publisher.Domain.Services.Imp;

internal class ContactsManagementService : IContactsManagementService
{
    private readonly Dictionary<ContactsManagementAction, Func<ContactsPublishableMessage, CancellationToken, Task>> _publisherActions;

    public ContactsManagementService(IContactsPublisher publisher)
    {
        _publisherActions = new()
        {
            [ContactsManagementAction.Create] = publisher.PublishCreateAsync,
            [ContactsManagementAction.Update] = publisher.PublishUpdateAsync,
        };
    }

    public async Task ExecuteAsync(ContactMessage contactMessage, CancellationToken cancellationToken = default)
    {
        // TO DO - build message here
        var message = new ContactsPublishableMessage();

        await _publisherActions[contactMessage.Action].Invoke(message, cancellationToken);
    }
}
