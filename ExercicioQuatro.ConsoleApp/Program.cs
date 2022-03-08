using System;

namespace ExercicioQuatro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro siena = new Carro();
            Console.Write("Informe os km iniciais: \n> ");
            siena.quilometragemInicial = int.Parse(Console.ReadLine());
            Console.Write("Informe os km finais: \n> ");
            siena.quilometragemFinal = int.Parse(Console.ReadLine());
            Console.Write("Informe quantos litros de combustível foram gastos: \n> ");
            siena.combustivelConsumido = double.Parse(Console.ReadLine());

            siena.consumo = siena.CalcularConsumo(siena.quilometragemInicial, siena.quilometragemFinal, siena.combustivelConsumido);

            Console.WriteLine("Nesta viagem, foram consumidos " + siena.consumo + " litros de combustível");
            Console.ReadKey();
        }
    }
}