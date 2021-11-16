using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public static class Ordenacao
    {
        public static Int32[] MenorParaMaior(Int32[] myArray)
        {
            Int32[] newArray = myArray.OrderBy(i => i).ToArray();
            return newArray;
        }

        public static Int32[] MaiorParaMenor(Int32[] myArray)
        {
            Int32[] newArray = myArray.OrderByDescending(i => i).ToArray();
            return newArray;
        }

    }
}
