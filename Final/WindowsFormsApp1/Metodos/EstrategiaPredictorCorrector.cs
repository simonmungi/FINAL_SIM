using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Metodos
{
    class EstrategiaPredictorCorrector : IEstrategia
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
            EstrategiaRK RS = new EstrategiaRK(controlador);

            vecAnterior = new double[4];
            vecActual = new double[4];

            controlador.xGraficoPC = new List<double>();
            controlador.yGraficoPC = new List<double>();


            //xi=0 yi=0

            //yp = y + (h/24)*(55*func(xi)-59*func(xi-1)+37*func(xi-2)-9*func(xi-3))

            //yc = y + (h/24)*(9*func(xi+1)+19*func(xi)-5*func(xi-1)+func(xi-2))


            //valores iniciales

            
            double[] iniciales = RS.calcular(4);

            double y3 = iniciales[3];//y 
            double y2 = iniciales[2]; 
            double y1 = iniciales[1]; 
            double y = iniciales[0];

            controlador.yGraficoPC.Add(y);
            controlador.yGraficoPC.Add(y1);
            controlador.yGraficoPC.Add(y2);
            controlador.yGraficoPC.Add(y3);


            double xi3 = 0;//x(i-3)
            double xi2 = h;//x(i-2)
            double xi1 = h * 2;//x(i-1)
            double xi = h * 3; //xi

            controlador.xGraficoPC.Add(xi3);
            controlador.xGraficoPC.Add(xi2);
            controlador.xGraficoPC.Add(xi1);
            controlador.xGraficoPC.Add(xi);

            iteraciones.Add(new double[]{ xi3, y, 0, 0, 0, 0, 0});
            iteraciones.Add(new double[] { xi2, y1, 0, 0, 0, 0, 0 });
            iteraciones.Add(new double[] { xi1,y2, 0, 0, 0, 0, 0 });

            vecActual[0] = xi;
            vecActual[1] = y3;
            //yp
            vecActual[2] = y3 + (h / 24) * (55 * func(xi) - 59 * func(xi1) + 37 * func(xi2) - 9 * func(xi3));
            //yc
            vecActual[3] = y3 + (h / 24) * (9 * func(xi + h) + 19 * func(xi) - 5 * func(xi1) + func(xi2));

            iteraciones.Add(vecActual);
            controlador.xGraficoPC.Add(vecActual[0]);
            controlador.yGraficoPC.Add(vecActual[1]);

            vecAnterior = vecActual;

            
            while (vecAnterior[0] < tLimite)
            {
                vecActual = new double[4];

                vecActual[0] = vecAnterior[0] + h;
                vecActual[1] = vecAnterior[3];
                //yp
                vecActual[2] = vecActual[1] + (h / 24) * (55 * func(vecActual[0]) - 59 * func(vecActual[0]-h) + 37 * func(vecActual[0] - h*2) - 9 * func(vecActual[0] - h*3));
                //yc
                vecActual[3] = vecActual[1] + (h / 24) * (9 * func(vecActual[0] + h) + 19 * func(vecActual[0]) - 5 * func(vecActual[0] - h) + func(vecActual[0] - h*2));


                iteraciones.Add(vecActual);
                controlador.xGraficoPC.Add(vecActual[0]);
                controlador.yGraficoPC.Add(vecActual[1]);

                vecAnterior = vecActual;
            }

            controlador.solPC = Math.Round(vecAnterior[1],4).ToString();
            controlador.setCalculosPC(iteraciones);
        }



        public EstrategiaPredictorCorrector(Controlador controlador)
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
