using System;

class GeradorDeCaracteres
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao gerador de senhas aleatórias!");

        Console.Write("Digite o número de caracteres da senha que deseja gerar: ");
        int quantidade;
        while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
        {
            Console.Write("Por favor, insira um número válido: ");
        }

        string senhaAleatoria = GerarsenhaAleatoria(quantidade);
        Console.WriteLine($"Senha gerada: {senhaAleatoria}");
    }

    static string GerarsenhaAleatoria(int quantidade)
    {
        const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        char[] caracteres = new char[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            int indice = random.Next(caracteresPermitidos.Length);
            caracteres[i] = caracteresPermitidos[indice];
        }

        return new string(caracteres);
    }
}
