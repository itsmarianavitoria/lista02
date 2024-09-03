using System;

class Program
{
    static void Main()
    {
        //solicita a porcentagem de vida do jogador
        Console.Write("Digite a porcentagem de vida do jogador: ");
        int vida;
        while (!int.TryParse(Console.ReadLine(), out vida) || vida < 0 || vida > 100)
        {
            Console.Write("Porcentagem de vida inválida. Digite novamente (0 a 100): ");
        }

        //solicita o número de armadilhas conhecidas
        Console.Write("Digite o número de armadilhas conhecidas: ");
        int armadilhas;
        while (!int.TryParse(Console.ReadLine(), out armadilhas) || armadilhas < 0)
        {
            Console.Write("Número de armadilhas inválido. Digite novamente: ");
        }

        //solicita a distância do aliado em metros
        Console.Write("Digite a distância do aliado em metros: ");
        int distanciaAliado;
        while (!int.TryParse(Console.ReadLine(), out distanciaAliado) || distanciaAliado < 0)
        {
            Console.Write("Distância do aliado inválida. Digite novamente: ");
        }

        //decide a ação a ser tomada
        string acao = DecidirAcao(vida, armadilhas, distanciaAliado);
        Console.WriteLine(acao);
    }

    static string DecidirAcao(int vida, int armadilhas, int distanciaAliado)
    {
        //decide a ação com base nas condições fornecidas
        if (vida > 50 && armadilhas < 3)
        {
            return "Seguir em frente";
        }
        else if (vida < 50 && armadilhas < 2 && distanciaAliado < 10)
        {
            return "Tentar resgate rápido";
        }
        else
        {
            return "Recuar";
        }
    }
}
