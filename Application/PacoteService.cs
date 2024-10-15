using Domain;

namespace Application
{
    public class PacoteService : IPacoteService
    {
        private readonly IPacoteRepository _pacoteRepository;

        public PacoteService(IPacoteRepository pacoteRepository)
        {
            _pacoteRepository = pacoteRepository;
        }

        public Dictionary<string, List<Produto>> PacoteItems(Pedido pedido)
        {
            var caixas = _pacoteRepository.GetCaixas();
            var resultado = new Dictionary<string, List<Produto>>();

            foreach (var caixa in caixas)
            {
                var produtosNaCaixa = new List<Produto>();
                foreach (var produto in pedido.Produtos)
                {
                    if (produto.Altura <= caixa.Altura && produto.Largura <= caixa.Largura && produto.Comprimento <= caixa.Comprimento)
                    {
                        produtosNaCaixa.Add(produto);
                    }
                }
                if (produtosNaCaixa.Count > 0)
                {
                    resultado.Add(caixa.Nome, produtosNaCaixa);
                }
            }
            return resultado;

        }
    }
}