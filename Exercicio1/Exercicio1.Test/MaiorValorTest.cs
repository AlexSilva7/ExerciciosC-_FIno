
using Xunit;

namespace Exercicio1.Teste
{
    public class MaiorValorTest
    {
        [Fact]
        public void PrimeiraPosicao()
        {
            Assert.Equal("MAIOR VALOR = 10", MaiorValor.Maior(10, 5, 0));
        }

        [Fact]
        public void SegundaPosicao()
        {
            Assert.Equal("MAIOR VALOR = 20", MaiorValor.Maior(0, 20, 10));
        }

        [Fact]
        public void TerceiraPosicao()
        {
            Assert.Equal("MAIOR VALOR = 30", MaiorValor.Maior(10, 5, 30));
        }

        [Fact]
        public void TestaNumerosNegativos()
        {
            Assert.Equal("MAIOR VALOR = -10", MaiorValor.Maior(-10, -20, -30));
        }

        [Fact]
        public void DoisValoresIguais()
        {
            Assert.Equal("EXISTEM DOIS VALORES IGUAIS!", MaiorValor.Maior(10, 10, 0));
        }

        [Fact]
        public void TresValoresIguais()
        {
            Assert.Equal("OS TRES VALORES SAO IGUAIS", MaiorValor.Maior(10, 10, 10));
        }


    }
}

