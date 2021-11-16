
using System;
using System.Collections.Generic;
using Xunit;

namespace Exercicio3.Test
{
    public class verificaValorTest
    {
        [Fact]
        public void TestaPositivos()
        {
            Assert.Equal("MAIOR: 100 \tMENOR: 10", verificaValor.Maior_Menor(new List<Int32> { 20, 15, 55, 100, 10 }));
        }

        [Fact]
        public void TestaNegativos()
        {
            Assert.Equal("MAIOR: -10 \tMENOR: -100", verificaValor.Maior_Menor(new List<Int32> { -20, -15, -55, -100, -10, -50 }));
        }

        [Fact]
        public void ValoresIguais()
        {
            Assert.Equal("VALORES IGUAIS NA LISTA", verificaValor.Maior_Menor(new List<Int32> { 10, 10, 10}));
        }

    }
}

