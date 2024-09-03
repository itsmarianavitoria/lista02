using System;

class Program
{
    static void Main()
    {
        //solicita a classe do jogador
        Console.Write("Digite a classe do jogador (Guerreiro, Mago, Paladino): ");
        string classe = Console.ReadLine()?.Trim();

        //solicita o tipo de poção
        Console.Write("Digite o tipo de poção (Vida, Mana, Resistência): ");
        string tipoPocao = Console.ReadLine()?.Trim();

        //solicita a quantidade de poções
        Console.Write("Digite a quantidade de poções: ");
        int quantidade;
        while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 1)
        {
            Console.Write("Quantidade inválida. Digite novamente: ");
        }

        //preços das poções
        int precoUnitario = ObterPrecoUnitario(tipoPocao);
        
        //calcula o preço total com e sem desconto
        decimal precoSemDesconto = precoUnitario * quantidade;
        decimal precoComDesconto = CalcularPrecoComDesconto(classe, tipoPocao, precoUnitario, quantidade);

        //exibe os resultados
        Console.WriteLine($"Preço sem desconto: {precoSemDesconto:C}");
        Console.WriteLine($"Preço com desconto: {precoComDesconto:C}");
    }

    static int ObterPrecoUnitario(string tipoPocao)
    {
        switch (tipoPocao.ToLower())
        {
            case "vida":
                return 10; // exemplo de preço para poção de Vida
            case "mana":
                return 15; // exemplo de preço para poção de Mana
            case "resistência":
                return 20; // exemplo de preço para poção de Resistência
            default:
                throw new ArgumentException("Tipo de poção inválido");
        }
    }

    static decimal CalcularPrecoComDesconto(string classe, string tipoPocao, int precoUnitario, int quantidade)
    {
        decimal desconto = 0;

        switch (classe.ToLower())
        {
            case "guerreiro":
                if (tipoPocao.ToLower() == "vida")
                    desconto = 0.10m; // 10% de desconto para poções de Vida
                break;
            case "mago":
                if (tipoPocao.ToLower() == "mana")
                    desconto = 0.15m; // 15% de desconto para poções de Mana
                break;
            case "paladino":
                if (tipoPocao.ToLower() == "resistência")
                    desconto = 0.20m; // 20% de desconto para poções de Resistência
                break;
        }

        decimal precoTotal = precoUnitario * quantidade;
        return precoTotal * (1 - desconto);
    }
}
