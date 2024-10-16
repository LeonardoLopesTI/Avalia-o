using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1___07._10
{
    internal class Lista3
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

        private static void exercicio1()
        {
            int n1, n2, n3, resultado;
            Console.WriteLine("Digite três números:\n");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            resultado = n1 + n2 + n3;
            Console.WriteLine("A soma dos três número é:\n" + resultado);
            Console.ReadKey();
        }
        private static void exercicio2()
        {
            int n1, n2, n3, n4, media;
            Console.WriteLine("Digite as notas do aluno:\n");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média do aluno é:\n");
            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine(media);
            Console.ReadKey();
        }
        private static void exercicio3()
        {
            Console.WriteLine("Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome\n");
            {
                string nome;
                do
                {
                    Console.WriteLine("Digite um nome:\n");
                    nome = Console.ReadLine();
                }
                while (nome != "João");
                Console.ReadKey();
            }
        }
        private static void exercicio4()
        {
            int inicio = 35;
            int fim = 98111;
            int contadorPares = 0;

            for (int i = inicio; i <= fim; i++)
            {
                if (i % 2 == 0)
                {
                    contadorPares++;
                }

            }
        Console.WriteLine("A quantidade de números pares entre " + inicio + " e " + fim + " é:\n" + contadorPares);
            Console.ReadKey();
        }
        private static void exercicio5()
        {
            int soma = 0;
            for (int i = 1; i <= 5000; i += 2)
            {
                soma += i;
            }
            Console.WriteLine("A soma dos números ímpares de 1 a 5000 é:\n" +  soma);
            Console.ReadKey();
        }
        private static void exercicio6()
        {
            int numero;
            Console.WriteLine("Digite um número:\n");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + i * numero + "\n");
            }
            Console.ReadKey();
        }
    }
}