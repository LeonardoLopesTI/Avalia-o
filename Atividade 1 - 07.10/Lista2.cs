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
            Console.WriteLine("Escolha o exercicio que deseja executar:\n\nExercício 1: Imprimir Número Maior que 20\r\n\r\nExercício 2: Verificar se Valor é Maior que 10\r\n\r\nExercício 3: Verificar se a Soma de A + B é Menor que C\r\n\r\nExercício 4: Soma de Dois Números e Verificação de Resultado\r\n\r\nExercício 5: Solicitar Tempo de Casamento com Base no Sexo e Estado Civil\r\n\r\nExercício 6: Verificar se um Número é Par ou Ímpar\r\n\r\nExercício 7: Cálculo com Dois Valores Inteiros A e B\r\n\r\nExercício 8: Dobro ou Triplo de um Número com Base em sua Sinalização\r\n\r\nExercício 9: Ordenar 3 Valores do Maior para o Menor\r\n\r\nExercício 10: Ordenar 3 Valores do Menor para o Maior\r\n\r\nExercício 11: Calcular Duração de um Jogo de Xadrez em Horas");
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
                case 7:
                    exercicio7();
                    break;
                case 8:
                    exercicio8();
                    break;
                case 9:
                    exercicio9();
                    break;
                case 10:
                    exercico10();
                    break;
                case 11:
                    exercicio11();
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
            string Nome, Sexo, E_C;
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
            int numero;
            Console.WriteLine("Digite um número:\n");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número digitado é PAR!");
            }
            else
            {
                Console.WriteLine("O número digitado é ÍMPAR!");
            }
            Console.ReadKey();
        }
        static void exercicio7()
        {
            int A, B, C;
            Console.WriteLine("Digite o Valor de A & C:\n");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            if (A == B)
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }
            Console.WriteLine("O valor de C é:\n" + C);
            Console.ReadLine();
        }
        static void exercicio8()
        {
            int numero, resultado;
            Console.WriteLine("Digite um número:\n");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                resultado = numero * 2;
            }
            else
            {
                resultado = numero * 3;
            }
            Console.WriteLine("O resultado é:\n" + resultado);
            Console.ReadLine();
        }
        static void exercicio9()
        {
            int n1, n2, n3;
            Console.WriteLine("Digite três números:\n");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            int[] numeros = { n1, n2, n3 };
            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.Write("Os números em ordem descrescente são:\n");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
                Console.ReadKey();
            }
        }
        static void exercico10()
        {
            int n1, n2, n3;
            Console.WriteLine("Digite três números:\n");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            int[] numeros = { n1, n2, n3 };
            Array.Reverse(numeros);
            Array.Sort(numeros);

            Console.Write("Os números em ordem crescente são:\n");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
                Console.ReadKey();
            }
        }
        static void exercicio11()
        {
            int Inicio, Fim, Duração;
            Console.WriteLine("Digite a hora de inicio do jogo:\n");
            Inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a hora de fim do jogo:\n");
            Fim = Convert.ToInt32(Console.ReadLine());
            if (Fim >= Inicio)
            {
                Duração = Fim - Inicio;
            }
            else
            {
                Duração = (24 - Inicio) + Fim;
            }
            Console.WriteLine("A duração do jogo é: " + Duração + " horas");

            if (Duração <= 24)
            {
                Console.WriteLine("Horas restantes até o limite de 24 horas: " + (24 - Duração));
            }
            else 
            {
                Console.WriteLine("Horas excedentes ao limite de 24 horas: " + (Duração - 24));
            }
            Console.ReadKey ();
        }
    }   
}
