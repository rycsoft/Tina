using Microsoft.AspNetCore.Mvc;

namespace Tina.Api.Controllers;

[Route("test")]
public sealed class TestController : ControllerBase
{
    [HttpGet("/hello/{user}")]
    public IActionResult hello(string user)
    {
        return Ok($"Hello, {user}!");
    }
}