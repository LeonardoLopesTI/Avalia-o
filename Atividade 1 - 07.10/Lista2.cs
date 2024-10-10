using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1___07._10
{
    internal class Lista2
    {
        public static void escolherExercicio()
        {
            Console.WriteLine("Escolha o exercicio que deseja executar: ");
            int exercicio = Convert.ToInt32(Console.ReadLine());
            switch (exercicio)
            {
                case 1:
                    exercicio1();
                    break;
                case 2:
                    exercicio2();
                    break;

            }

        }

        static void exercicio1()
        {
            double numero;
            Console.WriteLine("Digite um numero:\n");
            numero = Convert.ToDouble(Console.ReadLine());
            if (numero > 20)
            Console.WriteLine("O número digitado é:\n" + numero);
            Console.ReadKey();
        }
        static void exercicio2()
        {
            double numero;
            Console.WriteLine("Digite um numero:\n");
            numero = Convert.ToDouble(Console.ReadLine());
            if (numero > 10)
                Console.WriteLine("O número é maior que 10");
            else numero < 10;

            Console.WriteLine("O número é menor que 10");  
        }
    } 
}
