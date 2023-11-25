using System.Text.Json;
using cadastro_funcionarios_back.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_funcionarios_back.Controllers;
[ApiController]
[Route("[controller]")]

public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioRepository _repository;

    public FuncionarioController(IFuncionarioRepository repository)
    {
        _repository = repository;
    }
    [HttpGet]
    public IActionResult Get()
    {
        var funcionarios = _repository.Get();
        return funcionarios.Any() ? Ok(funcionarios) : Ok(JsonSerializer.Serialize("[]"));
    }
}
