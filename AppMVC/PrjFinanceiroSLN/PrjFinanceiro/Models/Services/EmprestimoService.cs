namespace PrjFinanceiro.Models.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        public decimal CalcularJurosSimples(decimal valor, double taxa)
        {
            return valor + (valor * (decimal)taxa);
        }

        public decimal CalcularJurosCompostos(decimal valor, double taxa, int meses)
        {
            decimal taxaDecimal = (decimal)taxa;

            return valor * (decimal)Math.Pow(
                (double)(1 + taxaDecimal), meses);
        }
    }
}
