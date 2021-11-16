namespace Exercicio8
{
    public static class Tempo
    {
        public static int MinutosNatal(DateTime data)
        {
            DateTime natal = new DateTime(2021, 12, 25, 00, 00, 00);
            DateTime atual = data;

            int diferencaDias = natal.Subtract(atual).Days;
            int diferencaHoras = natal.Subtract(atual).Hours;
            int diferencaMinutos = natal.Subtract(atual).Minutes;

            int diferencaTotalMinutos = ((diferencaDias * 24) * 60) + (diferencaHoras * 60) + diferencaMinutos;

            return diferencaTotalMinutos;

        }
    }
}