namespace Domain
{
    public class Pedido
    {
        public int Id { get; private set; }
        public List<Produto> Produtos { get; private set; }

        public Pedido(int id, List<Produto> produtos)
        {
            Id = id;
            Produtos = produtos ?? new List<Produto>();
        }
    }
}
