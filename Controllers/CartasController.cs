using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Avaliacao.Models;
using Avaliacao.Repositories;

namespace Avaliacao.Controllers;

[ApiController]
[Route("[controller]")]
public class CartasController : ControllerBase
{
    static CartasRepository _cartasRepository = new CartasRepository();

    [HttpPost("enviarCartaPapaiNoel")]
    public IActionResult Post(CartaModel carta)
    {
        _cartasRepository.Adicionar(carta);

        return Ok(new {
            success = "true",
            message = "Carta enviada ao Papai Noel com sucesso!"
        });
    }

    [HttpGet("buscarCartaPorCidade")]
    public IActionResult Get(string cidade)
    {  
       var cartasPorCidade = _cartasRepository.ListarPorCidade(cidade);

        if (cartasPorCidade.ToList().Count == 0) return BadRequest(new {
            success = "false",
            message = "Não encontrei nenhuma carta na cidade informada :/"
        });

        return Ok(cartasPorCidade);
    }
}

