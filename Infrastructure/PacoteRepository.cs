using Domain;

namespace Infrastructure
{
    public class PacoteRepository : IPacoteRepository

    {
        public List<Caixa> GetCaixas()
        {
            return new List<Caixa>
        {
            new Caixa("Caixa 1", 30, 40, 80),
            new Caixa("Caixa 2", 80, 50, 40),
            new Caixa("Caixa 3", 50, 80, 60)
        };
        }
    }
}
