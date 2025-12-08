using System;

namespace Program
{
    public class JogarDados
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Menu.Main(args));

            Random random = new Random();
            int soma1 = 0;
            int soma2 = 0;
            string jogador1 = "";
            string jogador2 = "";

            for (int rodada = 1; rodada <= 5; rodada++)
            {
                Console.WriteLine($"\nRodada {rodada}:");

                int dado1 = random.Next(1, 7);
                Console.WriteLine($"{jogador1} tirou {dado1}");
                soma1 += dado1;

                int dado2 = random.Next(1, 7);
                Console.WriteLine($"{jogador2} tirou {dado2}");
                soma2 += dado2;

                if (dado1 > dado2)
                {
                    Console.WriteLine($"{jogador1} vence a rodada!");
                }
                else if (dado2 > dado1)
                {
                    Console.WriteLine($"{jogador2} vence a rodada!");
                }
                else
                {
                    Console.WriteLine("A rodada terminou empatada!");
                }
            }
        }
    }
}