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
            Console.WriteLine("Escolha o exercicio que deseja executar:\n\nExercício 1: Escrever Programa que Mostre \"Olá, Mundo!\"\r\n\r\nExercício 2: Programa de Boas-Vindas Personalizada\r\n\r\nExercício 3: Informar Nome e Salário do Funcionário\r\n\r\nExercício 4: Somatório de Dois Números Inteiros\r\n\r\nExercício 5: Média de Notas do Aluno em uma Matéria\r\n\r\nExercício 6: Antecessor e Sucessor de um Número Inteiro\r\n\r\nExercício 7: Dobro e Terça Parte de um Número Real\r\n\r\nExercício 8: Conversão de Distância em Metros para Outras Medidas\r\n\r\nExercício 9: Conversão de Reais para Dólares\r\n\r\nExercício 10: Cálculo da Área da Parede e Quantidade de Tinta");
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
                    exercicio10();
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
            int numero;

            int antecessor, sucessor;

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            antecessor = numero - 1;
            sucessor = numero + 1;
            Console.WriteLine("O antecessor de " + numero + " é " + antecessor + " e o sucessor é " + sucessor);
            Console.ReadKey();

        }
        static void exercicio7()
        {
            int numero, dobro, divido;
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            dobro = numero + numero;
            divido = (numero) / 3;
            Console.WriteLine("O dobro de " + numero + " é " + dobro + " e o seu 1/3 é " + divido);
            Console.ReadKey();
        }
        static void exercicio8()
        {
            int metros, km, hm, dam, dm, cm, mm;
            Console.WriteLine("Digite a distância desejada: ");
            metros = int.Parse(Console.ReadLine());
            km = (metros) / 1000;
            hm = (metros) / 100;
            dam = (metros) / 10;
            dm = (metros) * 10;
            cm = (metros) * 100;
            mm = (metros) * 1000;
            Console.WriteLine(metros + "m em outras medidas é: \n" + km + "km\n" + hm + "hm\n" + dam + "dam\n" + dm + "dm\n" + cm + "cm\n" + mm + "mm");
            Console.ReadKey();
        }

        static void exercicio9()
        {
            double carteira, dolar;
            Console.WriteLine("Qual é a sua quantia de dinheiro atual: \n");
            carteira = int.Parse(Console.ReadLine());
            dolar = (carteira) / 3.45;
            Console.WriteLine("A sua quantia atual é R$" + carteira + "\nCom essa quantia você pode comprar US$" + dolar);
            Console.ReadKey();
        }
        static void exercicio10()
        {
            double largura, altura, area, tinta;
            Console.WriteLine("Digite a largura da parede:\n");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite altura da mesma:\n");
            altura = double.Parse(Console.ReadLine());
            area = largura * altura;
            tinta = area / 2;
            Console.WriteLine("A área da parede é:\n" + area + "\nA quantidade de tinta usada será:\n" + tinta + "L");
            Console.ReadKey();
        }

    }
}
