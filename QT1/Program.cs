using System;

class Program
{
    static void Main()
    {
        //solicita a classe do personagem
        Console.Write("Digite a classe do personagem (Guerreiro, Arqueiro, Mago): ");
        string? classe = Console.ReadLine()?.Trim();

        //solicita o valor de defesa da armadura
        Console.Write("Digite o valor de defesa da armadura: ");
        int defesa;
        while (!int.TryParse(Console.ReadLine(), out defesa) || defesa < 0)
        {
            Console.Write("Valor de defesa inválido. Digite novamente: ");
        }

        //solicita a penalidade de agilidade
        Console.Write("Digite a penalidade de agilidade: ");
        int penalidade;
        while (!int.TryParse(Console.ReadLine(), out penalidade) || penalidade < 0)
        {
            Console.Write("Penalidade de agilidade inválida. Digite novamente: ");
        }

        //verifica se a armadura é adequada para a classe
        string resultado = VerificarArmadura(classe, defesa, penalidade);
        Console.WriteLine(resultado);
    }

    static string VerificarArmadura(string classe, int defesa, int penalidade)
    {
        switch (classe.ToLower())
        {
            case "guerreiro":
                if (defesa > 50 && penalidade < 20)
                    return "Armadura adequada";
                break;

            case "arqueiro":
                if (defesa > 30 && penalidade < 10)
                    return "Armadura adequada";
                break;

            case "mago":
                if (defesa > 20 && penalidade < 40)
                    return "Armadura adequada";
                break;

            default:
                return "Classe desconhecida";
        }

        return "Armadura não adequada";
    }
}
