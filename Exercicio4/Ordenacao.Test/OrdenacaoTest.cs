using System;
using Xunit;

namespace Exercicio4.Test
{
    public class OrdenacaoTest
    {
        [Fact]
        public void ValoresPositivos()
        {
            Assert.Equal(new Int32[5]{10, 15, 20, 55, 100}, Ordenacao.MenorParaMaior(new Int32[5]{ 20, 15, 55, 100, 10 }));
        }

        [Fact]
        public void ValoresNegativos()
        {
            Assert.Equal(new Int32[5] { -100, -55, -20, -15, -10 }, Ordenacao.MenorParaMaior(new Int32[5] { -20, -15, -55, -100, -10 }));
        }

        [Fact]
        public void ValoresMistos()
        {
            Assert.Equal(new Int32[5] { -7, 0, 12, 80, 80 }, Ordenacao.MenorParaMaior(new Int32[5] { 2*40, 10*8, 0, -7, 25/2 }));
        }

    }
}