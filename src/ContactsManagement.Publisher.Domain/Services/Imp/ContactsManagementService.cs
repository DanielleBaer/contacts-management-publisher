using ContactsManagement.Publisher.Domain.Models;

namespace ContactsManagement.Publisher.Domain.Services.Imp;

internal class ContactsManagementService : IContactsManagementService
{
    public ContactsManagementService()
    {    
    }

    public Task ExecuteAsync(ContactMessage contactMessage)
    {
        throw new NotImplementedException();
    }
}
