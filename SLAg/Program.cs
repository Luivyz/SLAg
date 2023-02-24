using System;

namespace SLAg
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            bool continuar = true;
            do
            {
                Console.WriteLine("Exercicios de Vetores - opções");
                Console.WriteLine("1-Exercicio 1");
                Console.WriteLine("2-Exercicio 2");
                Console.WriteLine("3-Exercicio 3");
                Console.WriteLine("4-Exercicio 4");
                Console.WriteLine("5-Sair");
                Console.WriteLine("Escolha a opção de deseja");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: ex01(); break;
                    case 2: ex02(); break;
                    case 3: ex03(); break;
                    case 4: ex04(); break;
                }

            } while (continuar);


        }
        static void ex01()
        {
            int[] N = new int[5];
            N[0] = 7;
            N[1] = 9;
            N[2] = 3;
            N[3] = 0;
            N[4] = 6;

        }
        static void ex02()
        {

        }
        static void ex03()
        {

        }
        static void ex04()
        {

        }
    }
}
