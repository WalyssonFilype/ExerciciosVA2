using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVA2.cs
{
    internal class Principal
    {
        public void Main(string[] args)
        {

            int opcao;

            Console.WriteLine("Questão - 1 ");
            Console.WriteLine("Questão - 2");
            Console.WriteLine("Questão - 3");
            Console.WriteLine("Escolha uma opcao");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Exercicios exercicio1 = new Exercicios();
                    exercicio1.Exercicios10();

                    break;
                case 2:

                    Exercicios exercicio2 = new Exercicios();
                    exercicio2.Exercicios11();
                    break;
                case 3:

                    Exercicios exercicio3 = new Exercicios();
                    exercicio3.Exercicios12();
                    break;
            }
        }
    }
}
