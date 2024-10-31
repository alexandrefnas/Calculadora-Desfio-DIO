using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
	public class CalculadoraFinanceira
	{
		public double JurosSimples(double capital, double taxa, double tempo)
		{
			var result = Math.Round(capital * (1 + (taxa / 100) * tempo), 2);
			return result;
		}

		public double JurosCompostos(double capital, double taxa, double tempo)
		{
			var result = Math.Round(capital * Math.Pow((1 + taxa / 100), tempo), 2);
			return result;
		}
		
		public double CalcularPagamentoParcelado(double valorPresente, double taxa, double tempo)
		{
			double taxaMensal = taxa / 100 / 12;
			var result = Math.Round(valorPresente * (taxaMensal * Math.Pow(1 + taxaMensal, tempo)) / (Math.Pow(1 + taxaMensal, tempo) - 1), 2);
			return result;
		}
	}
}