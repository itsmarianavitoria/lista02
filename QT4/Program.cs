using System;

class Program
{
    static void Main()
    {
        //solicita a quantidade de mana do jogador
        Console.Write("Digite a quantidade de mana do jogador: ");
        int mana;
        while (!int.TryParse(Console.ReadLine(), out mana) || mana < 0)
        {
            Console.Write("Quantidade de mana inválida. Digite novamente: ");
        }

        //solicita a vida atual do inimigo em porcentagem
        Console.Write("Digite a vida atual do inimigo em porcentagem: ");
        int vidaInimigo;
        while (!int.TryParse(Console.ReadLine(), out vidaInimigo) || vidaInimigo < 0 || vidaInimigo > 100)
        {
            Console.Write("Vida do inimigo inválida. Digite novamente: ");
        }

        //solicita o nível do jogador
        Console.Write("Digite o nível do jogador: ");
        int nivel;
        while (!int.TryParse(Console.ReadLine(), out nivel) || nivel < 0)
        {
            Console.Write("Nível do jogador inválido. Digite novamente: ");
        }

        //verifica se o ataque especial deve ser realizado
        string resultado = VerificarAtaqueEspecial(mana, vidaInimigo, nivel);
        Console.WriteLine(resultado);
    }

    static string VerificarAtaqueEspecial(int mana, int vidaInimigo, int nivel)
    {
        //verifica as condições para realizar o ataque especial
        if (mana > 30 && vidaInimigo < 50 && nivel > 5)
        {
            return "Ataque Especial realizado";
        }
        else if (mana <= 30)
        {
            return "Mana insuficiente";
        }
        else if (vidaInimigo >= 50)
        {
            return "Vida do inimigo muito alta";
        }
        else if (nivel <= 5)
        {
            return "Nível insuficiente";
        }
        else
        {
            return "Condições não atendidas";
        }
    }
}
