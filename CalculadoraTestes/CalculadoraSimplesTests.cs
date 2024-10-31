using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraSimplesTests
{
	private CalculosSimples _calc;
	
	public CalculadoraSimplesTests()
	{
		_calc = new CalculosSimples();
	}
	
	[Theory]
	[InlineData(1, 2, 3)]
	[InlineData(2, 3, 5)]
	[InlineData(3, 4, 7)]
	[InlineData(4, 5, 9)]
	public void SomarDoisNumerosTrazerResultado(int num1, int num2, int esperado)
	{
		// Arrange
		// Act
		var result = _calc.Soma(num1, num2);
		//Assert
		Assert.Equal(result, esperado);
	}
	
	[Theory]
	[InlineData(2, 1, 1)]
	[InlineData(5, 3, 2)]
	[InlineData(3, 0, 3)]
	[InlineData(4, 3, 1)]
	public void subtrairDoisNumerosTrazerResultado(int num1, int num2, int esperado)
	{
		// Arrange
		// Act
		var result = _calc.Subtracao(num1, num2);
		//Assert
		Assert.Equal(result, esperado);
	}
	
	[Theory]
	[InlineData(2, 1, 2)]
	[InlineData(5, 3, 15)]
	[InlineData(3, 3, 9)]
	[InlineData(4, 3, 12)]
	public void MultiplicarDoisNumerosTrazerResultado(int num1, int num2, int esperado)
	{
		// Arrange
		// Act
		var result = _calc.multiplicacao(num1, num2);
		//Assert
		Assert.Equal(result, esperado);
	}
	
	[Theory]
	[InlineData( 2, 1, 2)]
	[InlineData(15, 3, 5)]
	[InlineData( 3, 3, 1)]
	[InlineData(12, 3, 4)]
	public void DividirDoisNumerosTrazerResultado(int num1, int num2, int esperado)
	{
		// Arrange
		// Act
		var result = _calc.divisao(num1, num2);
		//Assert
		Assert.Equal(result, esperado);
	}
}