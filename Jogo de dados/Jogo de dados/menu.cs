using System;

namespace Program
{
    public class Menu
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Jogo de dados legal");
            //Console.WriteLine(level.gameLevel(1));
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
        }

    }
}