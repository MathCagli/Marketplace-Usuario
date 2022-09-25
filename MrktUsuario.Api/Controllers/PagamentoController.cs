using MediatR;
using Microsoft.AspNetCore.Mvc;
using MrktUsuario.Application.DTO;
using MrktUsuario.Application.Handler.Command;
using MrktUsuario.Application.Handler.Query;

namespace MrktUsuario.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly IMediator mediator;

        public PagamentoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("Criar")]
        public async Task<IActionResult> Criar(PagamentoInputDto dto)
        {
            var result = await this.mediator.Send(new CriarPagamentoCommand(dto));
            return Created($"{result.Pagamento.Id}", result.Pagamento);
        }

        [HttpGet("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new ListarTodosPagamentosQuery()));
        }

        [HttpGet("BuscarPorID/{id}")]
        public async Task<IActionResult> BuscarPorID(string id)
        {
            return Ok(await this.mediator.Send(new BuscarPorIDPagamentoQuery { Id = id }));
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Atualizar(PagamentoOutputDto dto)
        {
            var result = await this.mediator.Send(new AtualizarPagamentoCommand(dto));
            return Ok(result);
        }

        [HttpDelete("Remover/{id}")]
        public async Task<IActionResult> Remover(string id)
        {
            return Ok(await this.mediator.Send(new RemoverPagamentoCommand { Id = id }));
        }
    }
}