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
            Console.WriteLine("Escolha o exercicio que deseja executar:\n\nExercício 1: Verificação de Número Par ou Ímpar\r\n\r\nExercício 2: Classificação de Idade\r\n\r\nExercício 3: Verificação de Notas\r\n\r\nExercício 4: Cálculo de IMC\r\n\r\nExercício 5: Maior de Dois Números\r\n\r\nExercício 6: Verificação de Voto\r\n\r\nExercício 7: Cálculo de Desconto\r\n\r\nExercício 8: Classificação de Temperatura\r\n\r\nExercício 9: Cálculo de Média de Três Números\r\n\r\nExercício 10: Verificação de Ano Bissexto");
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
            if (IMC < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            else if (IMC >= 18.5 &&  IMC <= 24.9)
            {
                Console.WriteLine("Você está no peso normal!");
            }
            else if (IMC >= 25 &&  IMC <= 29.9)
            {
                Console.WriteLine("Você está acima do peso!");
            }
            else
            {
                Console.WriteLine("Você está obeso!");
            }
            Console.ReadKey();
        }
        private static void exercicio5()
        {
            double n1, n2;
            Console.WriteLine("Digite dois números:\n");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine(n1 + " é maior");
            }
            else if (n1 == n2)
            {
                Console.WriteLine("Os números são iguais");
            }
            else
            {
                Console.WriteLine(n2 + " é maior");
            }
            Console.ReadKey();
        }
        private static void exercicio6()
        {
            double idade;
            Console.WriteLine("Digite sua idade:\n");
            idade = Convert.ToDouble(Console.ReadLine());
            if (idade >= 18 && idade <= 70)
            {
                Console.WriteLine("Você é OBRIGADO a votar!!");
            }
            else if (idade >= 16 && idade <= 17)
            {
                Console.WriteLine("O seu voto é facultativo!!");
            }
            else if (idade > 70)
            {
                Console.WriteLine("O seu voto é facultativo!!");
            }
            else if (idade < 16)
            {
                Console.WriteLine("Você não tem idade para votar!!");
            }
            else { }
            Console.ReadKey();
        }
        private static void exercicio7()
        {
            double compra, desconto;
            Console.WriteLine("Digite o valor da sua compra:\n");
            compra = Convert.ToDouble(Console.ReadLine());
            desconto = 0.1;
            
            if (compra > 100)
            {
                Console.WriteLine("Desconto de 10% aplicado\nTotal:\nR$" + (compra - compra * desconto));
            }
            else 
            {
                Console.WriteLine("Compra efetuada com sucesso!\nTotal:\nR$" + compra);
            }
            Console.ReadKey();

        }
        private static void exercicio8()
        {
            double temperatura;
            Console.WriteLine("Digite a temperatura:\n");
            temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura < 15)
            {
                Console.WriteLine("A Temperatura atual é " + temperatura + "°C, o clima esta Frio!");
            }
            else if (temperatura >= 15 && temperatura <= 25)
            {
                Console.WriteLine("A Temperatura atual é " + temperatura + "°C, o clima esta Agradável!");
            }
            else
            {
                Console.WriteLine("A Temperatura atual é " + temperatura + "°C, o clima esta Quente!");
            }
            Console.ReadKey();
        }
        private static void exercicio9()
        {
            double n1, n2, n3, resultado;
            Console.WriteLine("Digite três números:\n");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            resultado = (n1 + n2 + n3) / 3;

            if (resultado > 7)
            {
                Console.WriteLine("Aprovado!! Média: " + resultado);
            }
            else
            {
                Console.WriteLine("Reprovado!! Média: " + resultado);
            }
            Console.ReadKey();
        }
        private static void exercicio10()
        {
            double ano;
            Console.WriteLine("Digite um ano:\n");
            ano = Convert.ToDouble(Console.ReadLine());
            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.WriteLine(ano + ", é um ano bissexto.");
            }
            else
            {
                Console.WriteLine(ano + ", não é um ano bissexto.");
            }
            Console.ReadKey();
        }

    }
}
