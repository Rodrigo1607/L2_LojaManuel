namespace Application
{
    public class PacoteDTO
    {
        public int PedidoId { get; set; }
        public List<ProdutoDto> Produtos { get; set; }
    }
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Comprimento { get; set; }
    }
}
