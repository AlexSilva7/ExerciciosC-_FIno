using System.Collections.Generic;
using Xunit;

namespace Exercicio7.Test
{
    public class VerificaStringTest
    {
        [Fact]
        public void Teste1()
        {
            Assert.Equal(1, VerificaString.semRepeticao(new List<string> { "Python", "Python", "C#", "C#", "Java" }));
        }

        [Fact]
        public void Teste2()
        {
            Assert.Equal(4, VerificaString.semRepeticao(new List<string> { "Alura", "Khan", "Udemy", "Dio" }));
        }

        [Fact]
        public void Teste3()
        {
            Assert.Equal(2, VerificaString.semRepeticao(new List<string> { "Jackson", "Cliliano", "Jackson", "Cliliano", "Fino", "Gary" }));
        }

        [Fact]
        public void Teste4()
        {
            Assert.Equal(0, VerificaString.semRepeticao(new List<string> { "Python", "Python", "C#", "C#", "Java", "Java" }));
        }
    }
}