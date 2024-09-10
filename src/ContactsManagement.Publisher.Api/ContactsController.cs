using ContactsManagement.Publisher.Api.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactsManagement.Publisher.Api;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    public ContactsController()
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> PublishCreateAsync(
        [FromBody] CreateContactRequest request,
        CancellationToken cancellationToken)
    {
        return Created(string.Empty, null);
    }

    [HttpPost]
    public async Task<IActionResult> PublishUpdateAsync(
        [FromBody] UpdateContactRequest request,
        CancellationToken cancellationToken)
    {
        return Created(string.Empty, null);
    }

    [HttpPost]
    public async Task<IActionResult> PublishDeleteAsync(
        [FromBody] DeleteMessageRequest request)
    {
        return Created(string.Empty, null);
    }
}
