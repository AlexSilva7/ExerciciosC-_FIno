using Xunit;

using System;

namespace Exercicio5.Test
{
    public class OrdenacaoTest
    {
        [Fact]
        public void ValoresPositivos()
        {
            Assert.Equal(new Int32[5] { 100, 55, 20, 15, 10 }, Ordenacao.MaiorParaMenor(new Int32[5] { 20, 15, 55, 100, 10 }));
        }

        [Fact]
        public void ValoresNegativos()
        {
            Assert.Equal(new Int32[5] { -10, -15, -20, -55, -100 }, Ordenacao.MaiorParaMenor(new Int32[5] { -20, -15, -55, -100, -10 }));
        }

        [Fact]
        public void ValoresMistos()
        {
            Assert.Equal(new Int32[5] { 80, 80, 12, 0, -7 }, Ordenacao.MaiorParaMenor(new Int32[5] { 2 * 40, 10 * 8, 0, -7, 25 / 2 }));
        }
    }
}