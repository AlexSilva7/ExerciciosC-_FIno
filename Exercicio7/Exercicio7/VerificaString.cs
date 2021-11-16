
using System;
using System.Linq;

namespace Exercicio7
{
    public static class VerificaString
    {

        public static int semRepeticao(List<string> myList)
        {
            int contador = 0;
            foreach (string str in myList)
            {

                if (!(myList.Count(x => x == str) > 1))
                {
                    contador++;
                }

            }
            return contador;
        }
    }
}