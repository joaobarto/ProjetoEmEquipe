
        Console.Write("Digite a quantidade de segundos para o cronômetro: ");
        if (int.TryParse(Console.ReadLine(), out int segundos) && segundos > 0)
        {
            Console.WriteLine($"Cronômetro iniciado para {segundos} segundos...");

            for (int i = segundos; i > 0; i--)
            {
                Console.WriteLine($"Tempo restante: {i} segundos");
                Thread.Sleep(1000); // Espera 1 segundo
            }

            Console.WriteLine("O tempo acabou!");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido de segundos.");
        }




