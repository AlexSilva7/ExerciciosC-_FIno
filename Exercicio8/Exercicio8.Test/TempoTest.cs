using System;
using Xunit;

namespace Exercicio8.Test
{
    public class TempoTest
    {
        [Fact]
        public void Test1()
        {
            Equals( 56160 , Tempo.MinutosNatal(DateTime.Today));
        }

        [Fact]
        public void Test2()
        {
            Equals( 54720, Tempo.MinutosNatal(new DateTime(2021, 11, 17, 0, 0, 0)));
        }
    }
}