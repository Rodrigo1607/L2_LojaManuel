using Application;
using Domain;
using Moq;

namespace PacoteServiceTest
{
    public class PacoteTest
    {
        private PacoteService _pacoteService;
        [Fact]
        public void PacoteItems_DeveRetornarTrue()
        {
            // Arrange
            var mockRepository = new Mock<IPacoteRepository>();
            mockRepository.Setup(repo => repo.GetCaixas()).Returns(new List<Caixa>
            {
                new Caixa("Caixa 1", 30, 40, 80),
                new Caixa("Caixa 2", 80, 50, 40),
                new Caixa("Caixa 3", 50, 80, 60)
            });
        
        _pacoteService = new PacoteService(mockRepository.Object);

            var pedido = new Pedido(1, new List<Produto>
        {
            new Produto(1, "Produto 1", 20, 30, 50),
            new Produto(2, "Produto 2", 10, 20, 30)
        });

            // Act
            var result = _pacoteService.PacoteItems(pedido);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);

        }
    }
}