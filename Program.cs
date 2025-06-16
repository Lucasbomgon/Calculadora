using System;
using System.ComponentModel.Design;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------------");
            

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
            Console.WriteLine("");
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            var soma = v1 + v2;

            Console.WriteLine($"Resultado: {soma}");
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {

            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            var Subtracao = v1 - v2;

            Console.WriteLine($"Resultado: {Subtracao}");
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            var Multiplicacao = v1 * v2;

            Console.WriteLine($"Resultado: {Multiplicacao}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            var Divisao = v1 / v2;

            Console.WriteLine($"Resultado: {Divisao}");
            Console.ReadKey();
            Menu();
        }
    }
}