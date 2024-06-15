using Microsoft.AspNetCore.Mvc;

namespace ClienteService.Controller;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    [HttpGet("{id}")]
    public string Get(int id) => $"Cliente {id}";
}
