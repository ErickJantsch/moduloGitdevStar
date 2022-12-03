using System;

namespace ModuloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Atividade:
             * Crie um programa que receba dois valores e calcule a soma desses valores.
             * Ao final exiba o rtesultado no console.
             */


            #region Base


            Console.WriteLine("Digite 1 para iniciar o programa ou digite  para sair");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 0)
            {
                int a, b;
                Console.WriteLine("Informe o valor dos valores dos numeros a serem somados");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int resultado = Soma(a, b);
                Console.WriteLine("A soma dos valores e igual a " + resultado );
                Console.WriteLine("Se deseja repetir ou aperte 0 para sair");
                opcao = int.Parse(Console.ReadLine());
            }
            #endregion

            static





        }
    }
}
