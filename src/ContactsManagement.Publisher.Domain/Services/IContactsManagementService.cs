using ContactsManagement.Publisher.Domain.Models;

namespace ContactsManagement.Publisher.Domain.Services;

public interface IContactsManagementService
{
    Task ExecuteAsync(ContactMessage contactMessage, CancellationToken cancellationToken = default);
}
