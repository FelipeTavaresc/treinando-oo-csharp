namespace ConsoleAppEx04
{
    public class ConversorDeMoedas
    {
        private static double Iof = 6.0;
        public static double CotacaoEmReais(double cotacao, double quantidadeDolares)
        {
            double dolarComIOF = quantidadeDolares + (quantidadeDolares * Iof) / 100;
            return cotacao * dolarComIOF;
        }
    }
}
