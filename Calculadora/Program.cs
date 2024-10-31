using Calculadora.Services;

CalculadoraFinanceira calcuFinanc = new CalculadoraFinanceira();
CalculosSimples calc = new CalculosSimples();

bool ativo = true;
while (ativo)
{
	Console.Clear();
	Console.WriteLine("Calculadora");
	Console.WriteLine("Escolha uma opção:");
	Console.WriteLine("1. Somar");
	Console.WriteLine("2. Subtrair");
	Console.WriteLine("3. Multiplicar");
	Console.WriteLine("4. Dividir");
	Console.WriteLine("5. Calcular Juros Simples");
	Console.WriteLine("6. Calcular Juros Compostos");
	Console.WriteLine("7. Calcular Pagamento de Empréstimo");
	Console.WriteLine("8. Sair");
	int escolha = int.Parse(Console.ReadLine());
	if (escolha == 8) break;
	teste(escolha);
}

void teste(int escolha)
{
		switch (escolha)
	{
		case 1:
			Console.Write("Valor 1: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.Write("Valor 2: ");
			int num2 = int.Parse(Console.ReadLine());

			int resultSoma = calc.Soma(num1, num2);
			Console.WriteLine($"Resultado da Soma: {resultSoma:F0}");
			Console.ReadKey();
			break;
		case 2:
			Console.Write("Valor 1: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Valor 2: ");
			num2 = int.Parse(Console.ReadLine());

			int resultSubtracao = calc.Subtracao(num1, num2);
			Console.WriteLine($"Resultado da Subtração: {resultSubtracao:F0}");
			Console.ReadKey();
			break;
		case 3:
			Console.Write("Valor 1: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Valor 2: ");
			num2 = int.Parse(Console.ReadLine());

			int resultMultiplicacao = calc.multiplicacao(num1, num2);
			Console.WriteLine($"Resultado da Multiplicação: {resultMultiplicacao:F0}");
			Console.ReadKey();
			break;
		case 4:
			Console.Write("Valor 1: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Valor 2: ");
			num2 = int.Parse(Console.ReadLine());

			decimal resultDivisao = calc.divisao(num1, num2);
			Console.WriteLine($"Resultado da Divisão: {resultDivisao:F2}");
			Console.ReadKey();
			break;
		case 5:
			Console.Write("Capital (R$): ");
			double capital = double.Parse(Console.ReadLine());
			Console.Write("Taxa de Juros (%): ");
			double taxa = double.Parse(Console.ReadLine());
			Console.Write("Tempo (meses): ");
			double tempo = double.Parse(Console.ReadLine());
			double result = calcuFinanc.JurosSimples(capital, taxa, tempo);
			Console.WriteLine($"Valor Juros Simples: R$ {result:F2}");
			Console.ReadKey();
			break;
		case 6:
			Console.Write("Capital (R$): ");
			capital = double.Parse(Console.ReadLine());
			Console.Write("Taxa de Juros (%): ");
			taxa = double.Parse(Console.ReadLine());
			Console.Write("Tempo (meses): ");
			tempo = double.Parse(Console.ReadLine());
			result = calcuFinanc.JurosCompostos(capital, taxa, tempo);
			Console.WriteLine($"Valor Juros Compostos: R$ {result:F2}");
			Console.ReadKey();
			break;
		case 7:
			Console.Write("Valor Presente (R$): ");
			double valorPresente = double.Parse(Console.ReadLine());
			Console.Write("Taxa de Juros (%): ");
			taxa = double.Parse(Console.ReadLine());
			Console.Write("Tempo (meses): ");
			tempo = double.Parse(Console.ReadLine());
			result = calcuFinanc.CalcularPagamentoParcelado(valorPresente, taxa, tempo);
			Console.WriteLine($"Pagamento Mensal: R$ {result:F2}");
			Console.ReadKey();
			break;
		default:
			Console.WriteLine("Opção inválida.");
			Console.ReadKey();
			break;
	}

}