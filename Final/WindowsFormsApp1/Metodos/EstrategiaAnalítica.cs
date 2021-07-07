using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Metodos
{
    class EstrategiaAnalitica : IEstrategia
    {
        Controlador controlador;

        double tLimite;
        double t0;
        double h;

        double[] vecActual;

        private double func(double t)
        {
            return 56000 * Math.Log(40 - t) + 2800 * t - 206577.2494;
        }

        public void calcular()
        {
            controlador.xGraficoAN = new List<double>();
            controlador.yGraficoAN = new List<double>();

            vecActual = new double[2];

            vecActual[0] = t0;
            vecActual[1] = func(vecActual[0]);
            controlador.xGraficoAN.Add(vecActual[0]);
            controlador.yGraficoAN.Add(vecActual[1]);

            while (vecActual[0]<tLimite)
            {
                vecActual[0] += h;
                vecActual[1] = func(vecActual[0]);

                controlador.xGraficoAN.Add(vecActual[0]);
                controlador.yGraficoAN.Add(vecActual[1]);
            }

            controlador.solAnalitica = Math.Round(vecActual[1],4).ToString();
        }

        public double calcular(double x)
        {
            return func(x);
        }


        public EstrategiaAnalitica(Controlador controlador)
        {
            this.controlador = controlador;

            h = controlador.getH();
            t0 = controlador.getT0();
            tLimite = controlador.getTLimite();
        }
    }
}
