using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogarDados
{
    internal class gameLevel
    {
        public static string level(string levelgame)
        {
            int op;

            switch (op)
            {
                case 0:
                    return "Opção inválida";
                case 1:
                    return "You need izi game";
                case 2:
                    return "You need normal game";
                case 3:
                    return "You need hard game";
            }
        }

    }
}