using Domain;

namespace Application
{
    public interface IPacoteService
    {
        Dictionary<string, List<Produto>> PacoteItems(Pedido pedido);
    }
}
