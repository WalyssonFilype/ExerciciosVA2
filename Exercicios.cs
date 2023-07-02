using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVA2.cs
{
    internal class Exercicios
    {

        public void Exercicios10()
        {
            double nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Informe o valor da primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da terceira nota:");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da quarta nota:");
            nota4 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media >= 6)
            {
                Console.WriteLine("Parabéns, aluno aprovado! Sua média foi de: " + media + ".");
            }
            else
                Console.WriteLine("Aluno reprovado com a média: " + media + ".");
        }

        public void Exercicios11()
        {
            int nivel, horasAula;
            double valorAula, salario;
            Console.WriteLine("Informe o nível do professor:");
            Console.WriteLine("1 - Nível 1");
            Console.WriteLine("2 - Nível 2");
            Console.WriteLine("3 - Nível 3");
            nivel = int.Parse(Console.ReadLine());
            switch (nivel)
            {
                case 1:
                    valorAula = 12.00;
                    break;
                case 2:
                    valorAula = 17.00;
                    break;
                case 3:
                    valorAula = 25.00;
                    break;
                default:
                    return;
            }
            Console.Write("Informe a quantidade de horas trabalhas pelo professor: ");
            horasAula = int.Parse(Console.ReadLine());
            salario = valorAula * horasAula;
            Console.WriteLine("O salário do professor foi de: R$ " + salario + ".");

        }

        public void Exercicios12()
        {
            int codigo, quantidade;
            double valor, total;
            string lanche;
            Console.WriteLine("Informe o código do pedido: ");
            Console.WriteLine("Código do Item |Especificação|Preço unitário");
            Console.WriteLine(" 100 | Cachorro quente | R$1,10");
            Console.WriteLine(" 101 | Bauru simples | R$1,30");
            Console.WriteLine(" 102 | Bauru c/ovo | R$1,50");
            Console.WriteLine(" 103 | Hamburger | R$1,10");
            Console.WriteLine(" 104 | Cheeseburger | R$1,30");
            Console.WriteLine(" 105 | Refrigerante | R$1,00");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            switch (codigo)
            {
                case 100:
                    lanche = "Cachorro quente";
                    valor = 1.10;
                    break;
                case 101:
                    lanche = "Bauru simples";
                    valor = 1.30;
                    break;
                case 102:
                    lanche = "Bauru c/ovo";
                    valor = 1.50;
                    break;
                case 103:
                    lanche = "Hamburger";
                    valor = 1.10;
                    break;
                case 104:
                    lanche = "Cheeseburger";
                    valor = 1.30;
                    break;
                case 105:
                    lanche = "Refrigerante";
                    valor = 1.00;
                    break;
                default:
                    Console.WriteLine("Código Inválido");
                    return;
            }
            total = valor * quantidade;
            Console.WriteLine("O código do item pedido é " + codigo + ", o pedido foi " + lanche + ", e o preço do item é R$ " + valor + ",com "+quantidade+ " unidades.");
            Console.WriteLine("Valor Total a ser pago: R$" + total + ".");
        }
    }
}
