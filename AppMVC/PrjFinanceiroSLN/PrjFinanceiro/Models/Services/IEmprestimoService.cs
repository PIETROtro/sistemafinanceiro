namespace PrjFinanceiro.Models.Services
{
    public interface IEmprestimoService
    {
        decimal CalcularJurosSimples(decimal valor, double taxa);

        decimal CalcularJurosCompostos(decimal valor, double taxa, int meses);
    }
}
