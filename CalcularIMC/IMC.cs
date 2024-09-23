Calcular IMC
decimal peso;
		Console.WriteLine("Insira o seu peso em kilogramas: ");
		while (!decimal.TryParse(Console.ReadLine(), out peso) || peso <= 0)
		{
			Console.WriteLine("\nPor favor, insira um número válido.");
		}

		decimal altura;
		Console.WriteLine("Insira a sua altura em metros: ");
		while (!decimal.TryParse(Console.ReadLine(), out altura) || altura <= 0)
		{
			Console.WriteLine("\nPor favor, insira um número válido.");
		}

		decimal imc = peso / (altura * altura);
		Console.WriteLine("\nPossui algum dos problemas listados abaixo: \n");
		Console.WriteLine("1) Diabetes");
		Console.WriteLine("2) Problemas nas articulações (Ex.: artrite)");
		Console.WriteLine("3) Problemas cardíacos");
		Console.WriteLine("4) Obesidade");
		Console.WriteLine("5) Dores nas costas");
		Console.WriteLine("6) Ansiedade ou estresse");
		Console.WriteLine("\nEscolha um número de 1 a 6: ");
		int escolha;
		if (int.TryParse(Console.ReadLine(), out escolha))
		{
			switch (escolha)
			{
				case 1:
					Console.WriteLine($"O seu IMC é de: {imc:F2}.\n\n");
					Console.WriteLine("1) Diabetes\n");
					Console.WriteLine("   Sugestões de exercícios:\n");
					Console.WriteLine("   o Caminhadas rápidas");
					Console.WriteLine("   o Natação");
					Console.WriteLine("   o Treinamento de resistência (com pesos leves a moderados)");
					Console.WriteLine("   o Exercícios aeróbicos de baixa intensidade");
					Console.WriteLine("   o Yoga (ajuda no controle do estresse e glicemia)");
					break;
				case 2:
					Console.WriteLine($"O seu IMC é de: {imc:F2}.\n\n");
					Console.WriteLine("2) Problemas nas articulações (Ex.: artrite)\n");
					Console.WriteLine("   Sugestões de exercícios:\n");
					Console.WriteLine("   o Hidroginástica");
					Console.WriteLine("   o Caminhadas leves");
					Console.WriteLine("   o Ciclismo (com baixa resistência)");
					Console.WriteLine("   o Alongamentos e yoga");
					Console.WriteLine("   o Pilates (fortalecimento sem sobrecarga articular)");
					break;
				case 3:
					Console.WriteLine($"O seu IMC é de: {imc:F2}.\n\n");
					Console.WriteLine("3) Problemas cardíacos\n");
					Console.WriteLine("   Sugestões de exercícios:\n");
					Console.WriteLine("   o Caminhadas moderadas");
					Console.WriteLine("   o Bicicleta leve");
					Console.WriteLine("   o Natação");
					Console.WriteLine("   o Exercícios de alongamento");
					Console.WriteLine("   o Tai Chi (uma forma de exercício suave que também ajuda com equilíbrio)");
					break;
				case 4:
					Console.WriteLine($"O seu IMC é de: {imc:F2}.\n\n");
					Console.WriteLine("4) Obesidade\n");
					Console.WriteLine("   Sugestões de exercícios:\n");
					Console.WriteLine("   o Caminhadas e caminhadas rápidas");
					Console.WriteLine("   o Natação");
					Console.WriteLine("   o Exercícios em bicicleta ergométrica");
					Console.WriteLine("   o Exercícios aeróbicos de baixo impacto");
					Console.WriteLine("   o Hidroginástica");
					break;
				case 5:
					Console.WriteLine($"O seu IMC é de: {imc:F2}.\n\n");
					Console.WriteLine("5) Dores nas costas\n");
					Console.WriteLine("   Sugestões de exercícios:\n");
					Console.WriteLine("   o Caminhada em ritmo leve");
					Console.WriteLine("   o Natação ou hidroginástica");
					Console.WriteLine("   o Yoga com foco em alongamento e fortalecimento do núcleo");
					Console.WriteLine("   o Pilates (fortalecimento do núcleo)");
					Console.WriteLine("   o Exercícios de alongamento e mobilidade");
					break;
				case 6:
					Console.WriteLine($"O seu IMC é de: {imc:F2}.\n\n");
					Console.WriteLine("6) Ansiedade ou estresse\n");
					Console.WriteLine("   Sugestões de exercícios:\n");
					Console.WriteLine("   o Yoga");
					Console.WriteLine("   o Tai Chi");
					Console.WriteLine("   o Meditação guiada (combinada com alongamentos)");
					Console.WriteLine("   o Caminhadas ao ar livre");
					Console.WriteLine("   o Dança (para liberar endorfina)");
					break;
				default:
					Console.WriteLine("\nEscolha inválida. Tente novamente.");
					break;
			}
		}
		else
		{
			Console.WriteLine("\nPor favor, insira um número válido.");
		}
