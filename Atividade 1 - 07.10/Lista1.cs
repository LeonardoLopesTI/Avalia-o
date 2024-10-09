using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1___07._10
{
    internal class Lista1
    {
        public static void escolherExercicio()
        {
            Console.WriteLine("Escolha a atividade que deseja executar: ");
            Console.WriteLine();
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Atividade1()
                        break;
            }
        }
    }
}
