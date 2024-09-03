using System;

class Program
{
    static void Main()
    {
        //solicita o número de inimigos derrotados
        Console.Write("Digite o número de inimigos derrotados: ");
        int inimigosDerrotados;
        while (!int.TryParse(Console.ReadLine(), out inimigosDerrotados) || inimigosDerrotados < 0)
        {
            Console.Write("Número de inimigos inválido. Digite novamente: ");
        }

        //solicita a duração da batalha em minutos
        Console.Write("Digite a duração da batalha em minutos: ");
        int duracaoBatalha;
        while (!int.TryParse(Console.ReadLine(), out duracaoBatalha) || duracaoBatalha < 0)
        {
            Console.Write("Duração da batalha inválida. Digite novamente: ");
        }

        //solicita se o jogador sofreu danos críticos
        Console.Write("O jogador sofreu danos críticos? (sim/não): ");
        string sofreuDanosCriticos = Console.ReadLine()?.Trim().ToLower();

        //calcula a pontuação final
        int pontuacaoFinal = CalcularPontuacao(inimigosDerrotados, duracaoBatalha, sofreuDanosCriticos);
        
        //exibe a pontuação final
        Console.WriteLine($"Pontuação final: {pontuacaoFinal} pontos");
    }

    static int CalcularPontuacao(int inimigosDerrotados, int duracaoBatalha, string sofreuDanosCriticos)
    {
        //calcula a pontuação inicial
        int pontuacao = inimigosDerrotados * 10;

        //subtrai pontos se a batalha durar mais de 5 minutos
        if (duracaoBatalha > 5)
        {
            pontuacao -= 10;
        }

        //subtrai pontos se o jogador sofreu danos críticos
        if (sofreuDanosCriticos == "sim")
        {
            pontuacao -= 10;
        }

        return pontuacao;
    }
}
