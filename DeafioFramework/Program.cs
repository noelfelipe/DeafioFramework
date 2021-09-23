using DesafioFramework.Controller;
using System;
using DeafioFramework.Model;

namespace DeafioFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número : ");
            int num = Convert.ToInt32(Console.ReadLine());
            var numeroControler = new NumeroController();
            var numeros = numeroControler.VerficaPrimoeDivisores(new ModelNumero { Numero = num });
            Console.WriteLine("===============================================");
            Console.WriteLine("Número de Entrada: " + numeros.Numero + "\n" +
                              "Números divisores: " + numeros.DivisoresEmLinha + "\n" +
                              "Divisores Primos: " + numeros.NumerosPrimosEmLinha);
            Console.WriteLine("===============================================");
        }
    }
}
