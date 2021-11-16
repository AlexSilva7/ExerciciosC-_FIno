
using System;
using Xunit;

namespace Exercicio2.Test
{
    public class MaiorValorTest
    {
        [Fact]
        public void PrimeiraPosicao()
        {
            Assert.Equal("120", Exercicio2.Maior(new Int32[5] { 120, 15, 55, 100, 10 }));
        }

        [Fact]
        public void SegundaPosicao()
        {
            Assert.Equal("150", Exercicio2.Maior(new Int32[5] { 20, 150, 55, 100, 10 }));
        }

        [Fact]
        public void TerceiraPosicao()
        {
            Assert.Equal("525", Exercicio2.Maior(new Int32[5] { 20, 15, 525, 100, 10 }));
        }

        [Fact]
        public void TestaNumerosNegativos()
        {
            Assert.Equal("-10", Exercicio2.Maior(new Int32[5] { -20, -15, -55, -100, -10 }));
        }

        [Fact]
        public void ValoresIguais()
        {
            Assert.Equal("EXISTEM VALORES IGUAL NO ARRAY!", Exercicio2.Maior(new Int32[5] { 20, 20, 55, 100, 10 }));
        }

        [Fact]
        public void arrayMaior()
        {
            Assert.Equal("100", Exercicio2.Maior(new Int32[10] { 70, 15, 55, 100, 10, 0, -50, -70, -200, 90 }));
        }
    }
}

