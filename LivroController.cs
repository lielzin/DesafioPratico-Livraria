using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Request;
using MyFirstApi.Communication.Responses;
using MyFirstApi.Enum;

namespace MyFirstApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivroController : ControllerBase
{
    
    [HttpGet]
    [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get([FromRoute] int id)
    {
        var response = new Livro
        {
            Id = 1,
            Titulo = "O Senhor dos Anéis",
            Autor = "J.R.R. Tolkien",
            Genero = GeneroLivro.Romance,
            Preco = 49.10M,
            QuantidadeEstoque = 10
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterLivroJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterLivroJson request)
    {
        var response = new RequestRegisterLivroJson
        {
            Titulo = request.Titulo,
            Autor = request.Autor,
            Genero = request.Genero,
            Preco = request.Preco,
            QuantidadeEstoque = request.QuantidadeEstoque
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUptadeLivroProfileJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }
}