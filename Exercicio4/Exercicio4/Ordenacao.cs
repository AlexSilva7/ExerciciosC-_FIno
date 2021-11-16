using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public static class Ordenacao
    {
        public static Int32[] MenorParaMaior(Int32[] myArray)
        {
            Int32[] newArray = myArray.OrderBy(i => i).ToArray();

            /*
            //Console.Write("Array: ");
            for (var i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            //Console.Write("\nArray ordenado: ");
            for (var i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            */

            return newArray;
        }

        public static Int32[] MaiorParaMenor(Int32[] myArray)
        {
            Int32[] newArray = myArray.OrderByDescending(i => i).ToArray();
            return newArray;
        }

    }
}
