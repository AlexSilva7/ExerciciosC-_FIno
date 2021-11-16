
namespace Exercicio2
{
    public static class Exercicio2
    {
        public static string Maior(Int32[] myArray)
        {
            Int32 aux = myArray[0];
            
            for (var x = 0; x < myArray.Length; x++)
            {
                for (var j = 0; j < myArray.Length; j++)
                {
                    if (x != j & myArray[x] == myArray[j])
                    {
                        return "EXISTEM VALORES IGUAL NO ARRAY!";
                    }
                }
            }

            //Console.Write("\nVALORES DO ARRAY: ");

            for (var i = 0; i < myArray.Length; i++)
            {
                //Console.Write(myArray[i] + " ");

                if (myArray[i] > aux)
                {
                    aux = myArray[i];
                }
            }

            return aux.ToString();

        }

    }
}


