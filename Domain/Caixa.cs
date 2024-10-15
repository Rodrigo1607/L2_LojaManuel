namespace Domain
{
    public class Caixa
    {
        public string Nome { get; private set; }
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Comprimento { get; private set; }

        public Caixa(string nome, decimal altura, decimal largura, decimal comprimento)
        {
            Nome = nome;
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }
    }
}
