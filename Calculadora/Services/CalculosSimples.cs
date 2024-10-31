using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
	public class CalculosSimples
	{
		public int Soma(int num1, int num2)
		{
			var result = num1 + num2;
			return result;
		}
		
		public int Subtracao(int num1, int num2)
		{
			var result = num1 - num2;
			return result;
		}
		
		public int multiplicacao(int num1, int num2)
		{
			var result = num1 * num2;
			return result;
		}
		
		public decimal divisao(int num1, int num2)
		{
			var result = 0;
			if(num1 != 0 && num2 != 0)
			{
				result = num1 / num2;
			}
			
			return result;				
		}
	}
}