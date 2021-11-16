using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public static class verificaValor
    {
        public static string Maior_Menor(List<Int32> myList)
        {
            Int32 maior = myList.Max();
            Int32 menor = myList.Min();

            if(maior == menor)
            {
                return "VALORES IGUAIS NA LISTA";
            }

            return "MAIOR: " + maior + " \tMENOR: " + menor;

        }

    }

}


/*
            bool valid = false;
            Int32 a = 0;
            Int32 i;

            do
            {
                Console.Write("\nDIGITE O {0} VALOR DA LISTA: ", posicao);
                string input = Console.ReadLine();
                valid = Int32.TryParse(input, out i);
                if (valid)
                {
                    a = Int32.Parse(input);
                }
                else
                {
                    Console.Write("Valor invalido! Digite um numero!\n");
                }
            } while (!valid) ;

            return a;
            */