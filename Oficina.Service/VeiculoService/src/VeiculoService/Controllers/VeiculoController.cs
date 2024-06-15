using Microsoft.AspNetCore.Mvc;

namespace VeiculoService.Controllers;

[ApiController]
[Route("[controller]")]
public class VeiculoController : ControllerBase
{
    [HttpGet]
    public string Get() => "Novo Veiculo";
}
