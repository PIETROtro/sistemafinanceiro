
using System;
using Xunit;
using PrjFinanceiro.Models.Services;

namespace PrjFinanceiro.Tests
{
    public class EmprestimoServiceTest
    {
        [Fact]
        public void CalcularJurosSimples_DeveRetornar1100()
        {
            var service = new EmprestimoService();

            decimal resultado =
                service.CalcularJurosSimples(1000m, 0.10);

            Assert.Equal(1100m, resultado);
        }

        [Fact]
        public void CalcularJurosCompostos_DeveRetornar126824()
        {
            var service = new EmprestimoService();

            decimal resultado =
                service.CalcularJurosCompostos(1000m, 0.02, 12);

            Assert.Equal(1268.24m, Math.Round(resultado, 2));
        }
    }
}
