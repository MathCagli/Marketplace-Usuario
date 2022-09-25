using AutoMapper;
using MrktUsuario.Application.DTO;
using MrktUsuario.Domain.Repository;
using MrktUsuario.Domain.Models;

namespace MrktUsuario.Application.Service
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoRepository pagamentoRepository;
        private readonly IMapper mapper;

        public PagamentoService(IPagamentoRepository pagamentoRepository, IMapper mapper)
        {
            this.pagamentoRepository = pagamentoRepository;
            this.mapper = mapper;
        }

        public async Task<PagamentoOutputDto> Criar(PagamentoInputDto dto)
        {
            var pagamento = this.mapper.Map<Pagamento>(dto);
            await this.pagamentoRepository.Save(pagamento);
            return this.mapper.Map<PagamentoOutputDto>(pagamento);
        }

        public async Task<List<PagamentoOutputDto>> ListarTodos()
        {
            var pagamento = await this.pagamentoRepository.GetAll();
            return this.mapper.Map<List<PagamentoOutputDto>>(pagamento);
        }

        public async Task<PagamentoOutputDto> BuscarPorID(string id)
        {
            var pagamento = await this.pagamentoRepository.Get(id);
            return this.mapper.Map<PagamentoOutputDto>(pagamento);
        }

        public async Task<PagamentoOutputDto> Atualizar(PagamentoOutputDto dto)
        {
            var pagamento = this.mapper.Map<Pagamento>(dto);
            await this.pagamentoRepository.Update(pagamento);
            return this.mapper.Map<PagamentoOutputDto>(pagamento);
        }

        public async Task<string> Remover(string id)
        {
            var pagamento = await this.pagamentoRepository.Get(id);
            await this.pagamentoRepository.Delete(pagamento);
            return id;
        }
    }
}