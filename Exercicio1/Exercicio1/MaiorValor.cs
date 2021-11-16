using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public static class MaiorValor
    {
        public static string Maior(Int32 a, Int32 b, Int32 c)
        {

            if (a == b & a == c & b == c)
            {
                return "OS TRES VALORES SAO IGUAIS";
            }

            if (a == b | a == c | b == c)
            {
                return "EXISTEM DOIS VALORES IGUAIS!";
            }

            if (a > b)
            {
                if (a > c)
                {
                    return "MAIOR VALOR = " + a;
                }
                else
                {
                    return "MAIOR VALOR = " + c;
                }
            }
            else
            {
                if (b > c)
                {
                    return "MAIOR VALOR = " + b;
                }
                else
                {
                    return "MAIOR VALOR = " + c;
                }
            }
        }
    }
}
