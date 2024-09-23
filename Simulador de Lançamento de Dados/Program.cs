
		Random random = new Random();
		bool rolardado = true;
		Console.Write("Bem-vindo ao lançador de dado");
		Console.WriteLine("\nDeseja jogar ?");
		string escolha = Console.ReadLine().ToLower();
		if (escolha == "não")
		{
			rolardado = false;
			Console.WriteLine("OK!");
		}

		while (rolardado)
		{
			Random randNum = new Random();
			int dado = randNum.Next(1, 6);
			Console.Write($"O dado caiu no numero {dado} \n");
			Console.WriteLine("Deseja jogar novamente?");
			string escolha1 = Console.ReadLine().ToLower();
			if (escolha1 == "não")
			{
				rolardado = false;
				Console.WriteLine("OK!");
			}

			Console.WriteLine();
		}
	