// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dois numeros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção: \n1- Adicionar \n2- Subtrair \n3- Multiplicar \n4- Dividir ");        

            switch(opcao)
            {
                case 1:
                Console.WriteLine(num1 + num2);
                break;
                case 2:
                Console.WriteLine(num1 - num2);
                break;
                case 3:
                Console.WriteLine(num1 * num2);
                break;
                case 4:
                Console.WriteLine(num1 / num2);
                break;
                case default:
                Console.WriteLine("Erro");
                break;
            }
        }
    }
}

 