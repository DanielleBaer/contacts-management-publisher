using ContactsManagement.Publisher.Api.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactsManagement.Publisher.Api;

[ApiController]
public class ContactsController : ControllerBase
{
    public ContactsController()
    {      
    }

    [HttpPost("/api/[controller]:create")]
    public async Task<IActionResult> PublishCreateAsync(
        [FromBody] CreateContactRequest request,
        CancellationToken cancellationToken)
    {
        return Created(string.Empty, null);
    }

    [HttpPost("/api/[controller]:update")]
    public async Task<IActionResult> PublishUpdateAsync(
        [FromBody] UpdateContactRequest request,
        CancellationToken cancellationToken)
    {
        return Created(string.Empty, null);
    }

    [HttpPost("/api/[controller]:delete")]
    public async Task<IActionResult> PublishDeleteAsync(
        [FromBody] DeleteMessageRequest request)
    {
        return Created(string.Empty, null);
    }
}
