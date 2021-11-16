using Xunit;

namespace Exercicio6.Test
{
    public class TrataFraseTest
    {
        [Fact]
        public void Teste1()
        {
            Assert.Equal("Aqui Eh Vasco!", TrataFrase.Tratamento("Aqui eh vasco!"));
        }

        [Fact]
        public void Teste2()
        {
            Assert.Equal("0jackson 1gosta 2de 3ajax", TrataFrase.Tratamento("0jackSon 1Gosta 2de 3Ajax"));
        }

        [Fact]
        public void Teste3()
        {
            Assert.Equal("Plataforma Impact", TrataFrase.Tratamento("pLATafOrMa iMPaCT"));
        }
    }
}