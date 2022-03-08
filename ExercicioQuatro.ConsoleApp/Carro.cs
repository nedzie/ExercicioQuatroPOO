using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioQuatro.ConsoleApp
{
    internal class Carro
    {
        public int quilometragemInicial;
        public int quilometragemFinal;
        public double combustivelConsumido;
        public double consumo;

        public double CalcularConsumo(int quilometragemInicial, int quilometragemFinal, double combustivelConsumido)
        {
            consumo = (quilometragemFinal - quilometragemInicial) / combustivelConsumido;
            return consumo;
        }
    }
}
