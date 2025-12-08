using System;

namespace Program
{
    public class EndGame
    {
        public static void Main(string[] args, int soma1, int soma2, string jogador1, string jogador2)
        {
            Console.WriteLine("\nFim do jogo!");
            Console.WriteLine($"{jogador1} fez um total de {soma1} pontos.");
            Console.WriteLine($"{jogador2} fez um total de {soma2} pontos.");

            if (soma1 > soma2)
            {
                Console.WriteLine($"\n{jogador1} é o grande vencedor!");
            }
            else if (soma2 > soma1)
            {
                Console.WriteLine($"\n{jogador2} é o grande vencedor!");
            }
            else
            {
                Console.WriteLine("\nO jogo terminou empatado!");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}