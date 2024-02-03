

namespace CotacaoDoDolar_MembrosEstaticos.domain
{
    public class conversor
    {
       private static double taxa = 0.06;  
        
        public static double ConversorDeMoeda(double cotacao, double quantia)
        {
            double valor = cotacao * quantia;
            return valor + valor * taxa;
        }


    }
}
