using Microsoft.AspNetCore.Mvc;
using SpiderNetApi.Models;

namespace SpiderNetApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MissoesController : ControllerBase
{
    // Simulação de banco de dados em memória
    private static List<MissaoAranha> _missoes = new List<MissaoAranha>();

    // GET: api/missoes
    [HttpGet]
    public ActionResult<IEnumerable<MissaoAranha>> Get()
    {
        return Ok(_missoes);
    }

    // POST: api/missoes
    [HttpPost]
    public IActionResult Post([FromBody] MissaoAranha novaMissao)
    {
        // Validação do Nível de Perigo (1 a 10)
        if (novaMissao.NivelPerigo < 1 || novaMissao.NivelPerigo > 10)
        {
            return BadRequest("O NivelPerigo deve estar entre 1 e 10.");
        }

        _missoes.Add(novaMissao);
        return CreatedAtAction(nameof(Get), new { id = novaMissao.Id }, novaMissao);
    }
}