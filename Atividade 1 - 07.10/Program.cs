using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1___07._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercicio que deseja executar: ");
            Console.WriteLine();
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
            Console.WriteLine("Olá, Mundo!!!");

            Console.ReadKey();
        }
        static void exercicio2()
        {
            string nome;

            Console.WriteLine("Digite seu nome: \n");
            
            nome = Console.ReadLine();
            
            Console.WriteLine("Seja Bem vindo " + nome);
            
            Console.ReadKey();
        }
        static void exercicio3()
        {
            string nome, salario;

            Console.WriteLine("Digite seu nome: \n");
           
            nome = Console.ReadLine();
           
            Console.WriteLine("Digite seu salário \n");
           
            salario = Console.ReadLine();
            
            Console.WriteLine("Seja Bem vindo " + nome);
            
            Console.WriteLine("Seu salário é: R$" + salario);
            
            Console.ReadKey();

        }
        static void exercicio4()
        {
            int num1 = 5;

            int num2 = 131;

            double total = num1 + num2;

            Console.WriteLine("O total da soma entra os números inteiros é: " + total, "\n"); 
            
            Console.ReadKey();

        }

        static void exercicio5()
        {
            string materia;

            int nota1, nota2, media;

            Console.WriteLine("Digite a máteria desejada: \n");
            materia = Console.ReadLine();

            Console.WriteLine("Digite as notas do aluno em " + materia, "\n");
            nota1 = int.Parse(Console.ReadLine());
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A média do aluno em " + materia, " é: \n");
            media = (nota1 + nota2) / 2;
            Console.WriteLine(media);

            Console.ReadKey();
        }

        static void exercicio6()
        {
            string numero;

            int antecessor, sucessor;

            Console.WriteLine("Digite um número: ");
            numero = Console.ReadLine();
            antecessor = numero - 1;
            sucessor = numero + 1;
            Console.WriteLine("O antecessor de " + numero, " é " +  antecessor, " e o sucessor é " + sucessor);
            Console.ReadKey();
        }

    }
}
