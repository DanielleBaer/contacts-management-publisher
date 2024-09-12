using ContactsManagement.Publisher.Domain.Models;

namespace ContactsManagement.Publisher.Domain.Interfaces;

public interface IContactsPublisher
{
    Task PublishCreateAsync(ContactsPublishableMessage contactsPublishableMessage, CancellationToken cancellationToken = default);

    Task PublishUpdateAsync(ContactsPublishableMessage contactsPublishableMessage, CancellationToken cancellationToken = default);

    Task PublishDeleteAsync(ContactsPublishableMessage contactsPublishableMessage, CancellationToken cancellationToken = default);
}
