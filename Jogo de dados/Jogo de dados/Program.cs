using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class JogarDados
    {
        public static void Main(string[] args)
        {
            Menu.Main(args);
            JogarDados jogo = new JogarDados();
            jogo.IniciarJogo();
        }
    }
}