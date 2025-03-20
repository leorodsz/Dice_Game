using System;

namespace Studing
{
    public class JogarDados
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Jogo de dados");
            Console.WriteLine("Digite o nome do primeiro jogador: ");
            string jogador1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Jogo de dados");
            Console.WriteLine("Digite o nome do segundo jogador: ");
            string jogador2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Jogo de dados");
            Console.WriteLine($"{jogador1} e {jogador2}, neste jogo vocês terão várias rodadas. Quem tirar o número maior vence a rodada.");
            Console.WriteLine("Pressione qualquer tecla para começar...");
            Console.ReadKey();
            Console.Clear();

            Random dado = new Random();
            int soma1 = 0;
            int soma2 = 0;
            char jogar = 's'; // Variável corrigida para armazenar a resposta do jogador

            while (jogar == 's' || jogar == 'S')
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Jogo de dados");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine($"{jogador1}, aperte qualquer tecla para jogar o dado...");
                Console.ReadKey();
                int dado1 = dado.Next(1, 7);
                Console.WriteLine($"{jogador1} tirou {dado1}");
                soma1 += dado1;

                Console.WriteLine($"{jogador2}, aperte qualquer tecla para jogar o dado...");
                Console.ReadKey();
                int dado2 = dado.Next(1, 7);
                Console.WriteLine($"{jogador2} tirou {dado2}");
                soma2 += dado2;

                if (dado1 > dado2)
                {
                    Console.WriteLine($"{jogador1} venceu esta rodada!");
                }
                else if (dado1 < dado2)
                {
                    Console.WriteLine($"{jogador2} venceu esta rodada!");
                }
                else
                {
                    Console.WriteLine("Empate!");
                }

                Console.WriteLine("\nDeseja jogar novamente? (s/n)");
                jogar = Console.ReadKey().KeyChar; 
                Console.Clear(); 
            }

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