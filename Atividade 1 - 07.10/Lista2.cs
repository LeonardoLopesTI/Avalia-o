using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                case 3:
                    exercicio3();
                    break;
                case 4:
                    exercicio4();
                    break;
                case 5:
                    exercicio5();
                    break;
                case 6:
                    exercicio6();
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
            {
                Console.WriteLine("O número é MAIOR que 10!");
            }
            else
            {
                Console.WriteLine("O número é MENOR que 10!");
            }
                Console.ReadKey();

          
        }
        static void exercicio3()
        {
            int A, B, C;
           Console.WriteLine("Digite o valor de A, B & C:\n ");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            if(C > A + B)
            {
              Console.WriteLine("A soma de A & B é: " + (A+B) + "\nEssa soma é menor que o valor de C\nC = " + C);
            }
            else { }
            Console.ReadKey();
        }
        static void exercicio4()
        {
            int N1, N2;
            Console.WriteLine("Digite o valor dos dois números:\n");
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());
            if (N1 + N2 > 10)
            {
                Console.WriteLine("A soma de N1 + N2 é:\n" + (N1 + N2));
            }
            else { }
            Console.ReadKey();
        }
        static void exercicio5()
        {
            string Nome, Sexo, E_C, Tempo;
            Console.WriteLine("Bem vindo,\nDigite seu nome:\n");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual é o seu Gênero?\n");
            Sexo = Console.ReadLine();
            Console.WriteLine("Fale seu Estado Civil\n");
            E_C = Console.ReadLine();
            if (Sexo == "F" && E_C == "Casada")
            {
                Console.WriteLine("Quanto tempo você é casada?\n");
                int T_C = Convert.ToInt32(Console.ReadLine());
            }
            else { }
            Console.ReadKey();


        }
        static void exercicio6()
        {

        }
    }   
}
