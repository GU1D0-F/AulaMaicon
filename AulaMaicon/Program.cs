using System;
using System.Collections.Generic;

namespace AulaMaicon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite a quantidade de simbolos do alfabeto: ");
            int TamanhoAlfabeto = Convert.ToInt32(Console.ReadLine());
            //List<string> alfabeto = new();
            string[] alfabeto = new string[TamanhoAlfabeto];
            for (int i = 0; i < TamanhoAlfabeto; i++)
            {
                Console.Write("Letra: ");
                string letra = Console.ReadLine();
                alfabeto[i] = letra;
                //alfabeto.Add(letra);
            }

            string alfabeto2;
            foreach (string letra in alfabeto)
            {
                alfabeto2 = string.Join(", ", letra);
            }

            String

            //Console.WriteLine(alfabeto2);
            //Console.Write("Digite uma cadeia: ");
            //string cadeia = Console.ReadLine();

            //string v = ComparaCadeiaComAlfabeto(alfabeto, cadeia);
            //Console.WriteLine(v);
            //Console.ReadLine();
        }

        public static string ComparaCadeiaComAlfabeto(List<string> alfabeto, string cadeia)
        {
            bool compara = alfabeto.Equals(cadeia);

            if (compara)
                return "Válido";
            else
                return "Invalido";
        }
    }
}
