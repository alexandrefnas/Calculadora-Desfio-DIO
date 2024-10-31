using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes
{
	public class CalculadoraFinanceiraTests
	{
		private CalculadoraFinanceira _calc;
		public CalculadoraFinanceiraTests()
		{
			_calc = new CalculadoraFinanceira();
		}
		
		[Theory]
		[InlineData(1000,   1, 12, 1120)]
		[InlineData(2000,   2,  5, 2200)]
		[InlineData(1000,   2,  6, 1120)]
		[InlineData(1000, 0.8, 12, 1096)]
		public void CalcularjurosSimplesComValorCapitalTaxaTempoERetornarResultado(double num1, double num2, int num3, double esperado)
		{
			// Arrange
			// Act
			var result = _calc.JurosSimples(num1, num2, num3);
			//Assert
			Assert.Equal(result, esperado);
		}
		
		[Theory]
		[InlineData( 1000,   1, 10, 1104.62)]
		[InlineData( 2000, 0.3,  5, 2030.18)]
		[InlineData(15000, 0.3, 24, 16118.09)]
		[InlineData( 1000, 0.8, 12, 1100.34)]
		public void CalcularjurosCompostosComValorCapitalTaxaTempoERetornarResultado(double num1, double num2, int num3, double esperado)
		{
			// Arrange
			// Act
			var result = _calc.JurosCompostos(num1, num2, num3);
			//Assert
			Assert.Equal(result, esperado);
		}
		
		[Theory]
		[InlineData( 1000,   8,  6, 170.58)]
		[InlineData( 2000,   8,  5, 408.04)]
		[InlineData( 1500, 0.3, 10, 150.21)]
		[InlineData( 5000,   8, 12, 434.94)]
		public void CalcularPagamentoParceladoComValorPresenteTaxaTempoERetornarResultado(double num1, double num2, int num3, double esperado)
		{
			// Arrange
			// Act
			var result = _calc.CalcularPagamentoParcelado(num1, num2, num3);
			//Assert
			Assert.Equal(result, esperado);
		}
	}
}