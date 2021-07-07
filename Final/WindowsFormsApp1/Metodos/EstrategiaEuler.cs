using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Metodos
{
    class EstrategiaEuler : IEstrategia
    {
        Controlador controlador;
        List<double[]> iteraciones = new List<double[]>();

        double h;
        double lambda;
        double A;
        double L;
        double x;
        double t0;
        double Q0;
        double tLimite;

        double[] vecAnterior;
        double[] vecActual;

        public double func(double t)
        {
            return lambda * A * 100 * (L - x) * (20 - t) / (100 - x * t);
        }

        public void calcular()
        {

            vecAnterior = new double[4];
            vecActual = new double[4];

            controlador.xGraficoEuler = new List<double>();
            controlador.yGraficoEuler = new List<double>();



            //inicializo
            vecAnterior[0] = t0;
            vecAnterior[1] = Q0;
            vecAnterior[2] = h*func(vecAnterior[0]);
            vecAnterior[3] = vecAnterior[2] + vecAnterior[1];

            iteraciones.Add(vecAnterior);
            controlador.xGraficoEuler.Add(vecAnterior[0]);
            controlador.yGraficoEuler.Add(vecAnterior[1]);


            while (vecAnterior[0]< tLimite)
            {
                vecActual = new double[4];

                vecActual[0] = vecAnterior[0] + h;
                vecActual[1] = vecAnterior[3];
                vecActual[2] = h*func(vecAnterior[0]);
                vecActual[3] = vecActual[2] + vecActual[1];

                iteraciones.Add(vecActual);
                controlador.xGraficoEuler.Add(vecActual[0]);
                controlador.yGraficoEuler.Add(vecActual[1]);

                vecAnterior = vecActual;                
            }

            controlador.solEuler = Math.Round(vecAnterior[1],4).ToString();
            controlador.setCalculosEuler(iteraciones);
        }



        public EstrategiaEuler(Controlador controlador)
        {
            this.controlador = controlador;

            h = controlador.getH();
            lambda = controlador.getLambda();
            A = controlador.getA();
            L = controlador.getL();
            x = controlador.getX();
            t0 = controlador.getT0();
            Q0 = controlador.getQ0();
            tLimite = controlador.getTLimite();

        }
    }
}
