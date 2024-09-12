using ContactsManagement.Publisher.Api.Models.Requests;
using ContactsManagement.Publisher.Domain.Interfaces;
using ContactsManagement.Publisher.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactsManagement.Publisher.Api;

[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IContactsManagementService _contactsManagementService;
    private readonly IContactsPublisher _publisher;

    public ContactsController(
        IContactsManagementService contactsManagementService,
        IContactsPublisher publisher)
    {
        _contactsManagementService = contactsManagementService;
        _publisher = publisher;
    }

    [HttpPost("/api/[controller]:create")]
    public async Task<IActionResult> PublishCreateAsync(
        [FromBody] CreateContactRequest request,
        CancellationToken cancellationToken)
    {
        await _contactsManagementService.ExecuteAsync(request.ToMessage(), cancellationToken);

        return Created(string.Empty, null);
    }

    [HttpPost("/api/[controller]:update")]
    public async Task<IActionResult> PublishUpdateAsync(
        [FromBody] UpdateContactRequest request,
        CancellationToken cancellationToken)
    {
        await _contactsManagementService.ExecuteAsync(request.ToMessage(), cancellationToken);

        return Created(string.Empty, null);
    }

    [HttpPost("/api/[controller]:delete")]
    public async Task<IActionResult> PublishDeleteAsync(
        [FromBody] DeletedContactMessageRequest deletedContactMessage)
    {
        await _publisher.PublishDeleteAsync(DeletedContactMessageRequest.ToMessage(deletedContactMessage, HttpContext));

        return Created(string.Empty, null);
    }
}
