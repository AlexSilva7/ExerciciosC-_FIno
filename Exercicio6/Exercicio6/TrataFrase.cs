using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public static class TrataFrase
    {
        public static string Tratamento(string frase)
        {
            string[] palavras = frase.Split(" ");

            string fraseAux = "";

            foreach (string palavra in palavras)
            {
                char aux = char.ToUpper(palavra[0]);
                string aux2 = palavra.Substring(1).ToLower();

                fraseAux += aux + aux2 + " ";

            }

            fraseAux = fraseAux.Substring(0, fraseAux.Length - 1);

            return fraseAux;

        }
    }
}


