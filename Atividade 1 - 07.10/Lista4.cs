using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1___07._10
{
    internal class Lista4
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
            }
        }
        private static void exercicio1()
        {
            int numero;
            Console.WriteLine("Digite um número:\n");
            numero = Convert.ToInt32(Console.ReadLine());   
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " é par!");
            }
            else
            {
                Console.WriteLine(numero + " é ímpar!");
            }
            Console.ReadKey();
        }
        private static void exercicio2()
        {
            double idade;
            Console.WriteLine("Digite sua idade:\n");
            idade = Convert.ToDouble(Console.ReadLine());
            if (idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Você é criança!");
            }
            else if (idade >= 13 && idade <= 17)
            {
                Console.WriteLine("Você é adolescente!");
            }
            else if (idade >= 18 && idade <= 64)
            {
                Console.WriteLine("Você é adulto!");
            }
            else if (idade >= 65)
            {
                Console.WriteLine("Você é idoso!");
            }
            else {}
            Console.ReadKey();
        }
        private static void exercicio3()
        {
            double nota;
            Console.WriteLine("Digite a nota do aluno");
            nota = Convert.ToDouble(Console.ReadLine());
            if (nota >= 6 && nota <= 10)
            {
                Console.WriteLine("Aluno Aprovado!!");
            }
            else if (nota >= 4 && nota <= 5.9)
            {
                Console.WriteLine("Aluno em Recuperação!!");
            }
            else if (nota < 4)
            {
                Console.WriteLine("Aluno Reprovado!!");
            }
            else {}
            Console.ReadKey();
        }
        private static void exercicio4()
        {
            double peso, altura, IMC;
            Console.WriteLine("Digite seu peso:\n");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura(cm):");
            altura = Convert.ToDouble(Console.ReadLine());
            IMC = peso / (altura * altura);

        }
    }
}
