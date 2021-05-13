using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("O que você deseja fazer: ");
            Console.WriteLine("1 Soma ");
            Console.WriteLine("2 Subtração ");
            Console.WriteLine("3 Multiplicação ");
            Console.WriteLine("4 Divisão ");
            Console.WriteLine("0 Sair ");

            Console.WriteLine("---------------------------------- ");

            Console.WriteLine("Selecione uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    {
                        Soma(getValores());
                        break;
                    }
                case 2:
                    {
                        Subtracao(getValores());
                        break;
                    }
                case 3:
                    {
                        Multiplicacao(getValores());
                        break;
                    }
                case 4:
                    {
                        Divisao(getValores());
                        break;
                    }

                case 0:
                    {
                        break;
                    }
            }
        }

        public static Entrada getValores()
        {

            Console.WriteLine("Primeiro Valor: ");
            float valor01 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor02 = float.Parse(Console.ReadLine());

            return new Entrada(valor01, valor02);
        }


        static void Soma(Entrada valores)
        {
            float resultado = valores.Valor01 + valores.Valor02;

            PrintResult(resultado);

        }

        static void Subtracao(Entrada valores)
        {
            float resultado = valores.Valor01 - valores.Valor02;
            PrintResult(resultado);
        }

        static void Multiplicacao(Entrada valores)
        {

            float resultado = valores.Valor01 * valores.Valor02;
            PrintResult(resultado);
        }


        static void Divisao(Entrada valores)
        {
            float resultado = valores.Valor01 / valores.Valor02;
            PrintResult(resultado);
        }


        public static void PrintResult(float resultado)
        {
            Console.WriteLine("");
            Console.WriteLine($"0 resultado é {resultado}");

            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }

    public class Entrada
    {

        public Entrada(float valor01, float valor02)
        {
            Valor01 = valor01;
            Valor02 = valor02;
        }
        public float Valor01 { get; set; }
        public float Valor02 { get; set; }
    }
}
