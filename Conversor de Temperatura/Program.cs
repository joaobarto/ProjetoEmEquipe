	Console.WriteLine("Escolha a conversão:");
		Console.WriteLine("1. Celsius para Fahrenheit");
		Console.WriteLine("2. Celsius para Kelvin");
		Console.WriteLine("3. Fahrenheit para Celsius");
		Console.WriteLine("4. Kelvin para Celsius");
		Console.Write("Opção: ");
		string opcao = Console.ReadLine();
		Console.Write("Temperatura: ");
		if (double.TryParse(Console.ReadLine(), out double temperatura))
		{
			switch (opcao)
			{
				case "1":
					Console.WriteLine($"Fahrenheit: {(temperatura * 9 / 5) + 32:F2}");
					break;
				case "2":
					Console.WriteLine($"Kelvin: {temperatura + 273.15:F2}");
					break;
				case "3":
					Console.WriteLine($"Celsius: {(temperatura - 32) * 5 / 9:F2}");
					break;
				case "4":
					Console.WriteLine($"Celsius: {temperatura - 273.15:F2}");
					break;
				default:
					Console.WriteLine("Opção inválida.");
					break;
			}
		}
		else
		{
			Console.WriteLine("Temperatura inválida.");
		}