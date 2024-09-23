
        int numeroEscolhido = 55; 
        int palpite;
        int tentativa = 0; 
        bool acertou = false; 

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Escolha um número de 1 até 100.");

        
        while (!acertou)
        {
            string texto = Console.ReadLine();
            if (int.TryParse(texto, out palpite)) 
            {
                tentativa++; 

                if (palpite < numeroEscolhido)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.");
                }
                else if (palpite > numeroEscolhido)
                {
                    Console.WriteLine("Muito alto! Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você adivinhou o número escolhido! Errou {tentativa - 1} vezes.");
                    acertou = true;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        }


