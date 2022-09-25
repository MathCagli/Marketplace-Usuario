using AutoMapper;
using MrktUsuario.Application.DTO;
using MrktUsuario.Domain.Repository;
using MrktUsuario.Domain.Models;

namespace MrktUsuario.Application.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository pedidoRepository;
        private readonly IMapper mapper;

        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            this.pedidoRepository = pedidoRepository;
            this.mapper = mapper;
        }

        public async Task<PedidoOutputDto> Criar(PedidoInputDto dto)
        {
            var pedido = this.mapper.Map<Pedido>(dto);
            await this.pedidoRepository.Save(pedido);
            return this.mapper.Map<PedidoOutputDto>(pedido);
        }

        public async Task<List<PedidoOutputDto>> ListarTodos()
        {
            var pedido = await this.pedidoRepository.GetAll();
            return this.mapper.Map<List<PedidoOutputDto>>(pedido);
        }

        public async Task<PedidoOutputDto> BuscarPorID(string id)
        {
            var pedido = await this.pedidoRepository.Get(id);
            return this.mapper.Map<PedidoOutputDto>(pedido);
        }

        public async Task<PedidoOutputDto> Atualizar(PedidoOutputDto dto)
        {
            var pedido = this.mapper.Map<Pedido>(dto);
            await this.pedidoRepository.Update(pedido);
            return this.mapper.Map<PedidoOutputDto>(pedido);
        }

        public async Task<string> Remover(string id)
        {
            var pedido = await this.pedidoRepository.Get(id);
            await this.pedidoRepository.Delete(pedido);
            return id;
        }
    }
}