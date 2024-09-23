Console.WriteLine("Digite o  1º número:");
		if(double.TryParse(Console.ReadLine(), out double num1))
	{
		Console.WriteLine("Digite o 2º número:");
        if (double.TryParse(Console.ReadLine(), out double num2))
			
		Console.Write("Qual a operação?");	
		string operacao = Console.ReadLine();
		
		double resultado = 0;
		bool operacaoValida = true;
			
		switch (operacao)
		{
			case "+":
			    resultado = num1 + num2;
				break;
			case "-":
				resultado = num1 - num2;
			    break;
			case "*":
				resultado = num1 * num2;
				break;
			case "/":
				if ( num2 != 0)
			    resultado = num1 / num2;
				else 
					operacaoValida = false;
		        break;
			default:
			   operacaoValida = false;
		        break;
		}
			if (operacaoValida)
				Console.WriteLine($"Resultado: {resultado}");
			else
				Console.WriteLine("Operação inválida ou divisão por zero");
	}	
