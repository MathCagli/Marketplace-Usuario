using MediatR;
using Microsoft.AspNetCore.Mvc;
using MrktUsuario.Application.DTO;
using MrktUsuario.Application.Handler.Command;
using MrktUsuario.Application.Handler.Query;

namespace MrktUsuario.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IMediator mediator;

        public PedidoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("Criar")]
        public async Task<IActionResult> Criar(PedidoInputDto dto)
        {
            var result = await this.mediator.Send(new CriarPedidoCommand(dto));
            return Created($"{result.Pedido.Id}", result.Pedido);
        }

        [HttpGet("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new ListarTodosPedidosQuery()));
        }

        [HttpGet("BuscarPorID/{id}")]
        public async Task<IActionResult> BuscarPorID(string id)
        {
            return Ok(await this.mediator.Send(new BuscarPorIDPedidoQuery { Id = id }));
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Atualizar(PedidoOutputDto dto)
        {
            var result = await this.mediator.Send(new AtualizarPedidoCommand(dto));
            return Ok(result);
        }

        [HttpDelete("Remover/{id}")]
        public async Task<IActionResult> Remover(string id)
        {
            return Ok(await this.mediator.Send(new RemoverPedidoCommand { Id = id }));
        }
    }
}