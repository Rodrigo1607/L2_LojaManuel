using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace LojaManoel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacoteController : ControllerBase
    {
        private readonly PacoteService _pacoteService;
        public PacoteController(PacoteService pacoteService)
        {
            _pacoteService = pacoteService;
        }

        [HttpPost]
        public ActionResult<Dictionary<string, List<Produto>>> Pacote([FromBody] PacoteDTO pacoteDto)
        {
            var produtos = pacoteDto.Produtos.Select(p => new Produto(p.Id, p.Nome, p.Altura, p.Largura, p.Comprimento)).ToList();
            var pedido = new Pedido(pacoteDto.PedidoId, produtos);
            var resultado = _pacoteService.PacoteItems(pedido);
            return Ok(resultado);
        }


    }
}
