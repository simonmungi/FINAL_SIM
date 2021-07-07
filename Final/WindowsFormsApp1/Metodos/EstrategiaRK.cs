using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Metodos
{
    class EstrategiaRK : IEstrategia
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
            controlador.xGraficoRK = new List<double>();
            controlador.yGraficoRS = new List<double>();

            EstrategiaAnalitica an = new EstrategiaAnalitica(controlador);

            vecAnterior = new double[7];
            vecActual = new double[7];

            //inicializo
            //t
            vecAnterior[0] = t0;
            //Q
            vecAnterior[1] = an.calcular(t0);
            //K1
            vecAnterior[2] = lambda * A * ((100 * (L - x) * (20 - vecAnterior[0])) / (100 - x * vecAnterior[0]));
            //K2
            double aux = vecAnterior[0] + h / 2;
            vecAnterior[3] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
            //K3
            //vecAnterior[4] = vecAnterior[3];
            vecAnterior[4] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
            //K4
            aux = vecAnterior[0] + h;
            vecAnterior[5] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
            //Q(i+1)
            //vecAnterior[6] = vecAnterior[1] + (h / 6) * (vecAnterior[2] + 4*vecAnterior[3]+ vecAnterior[5]);
            vecAnterior[6] = vecAnterior[1] + (h / 6) * (vecAnterior[2] + 2*vecAnterior[3]+ 2*vecAnterior[4] + vecAnterior[5]);


            iteraciones.Add(vecAnterior);
            controlador.xGraficoRK.Add(vecAnterior[0]);
            controlador.yGraficoRS.Add(vecAnterior[1]);

            while (vecActual[0] < tLimite)
            {
                vecActual = new double[7];

                //t
                vecActual[0] = vecAnterior[0] + h;
                
                //Q
                vecActual[1] = vecAnterior[6];
                
                //K1
                vecActual[2] = lambda * A * ((100 * (L - x) * (20 - vecActual[0])) / (100 - x * vecActual[0]));
                
                //K2
                aux = vecActual[0] + h / 2;
                vecActual[3] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));

                //K3
                //vecActual[4] = vecActual[3];
                vecActual[4] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));

                //K4
                aux = vecActual[0] + h;
                vecActual[5] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));

                //Q(i+1)
                //vecActual[6] = vecActual[1] + (h / 6) * (vecActual[2] + 4 * vecActual[3] + vecActual[5]);
                vecActual[6] = vecActual[1] + (h / 6) * (vecActual[2] + 2*vecActual[3] + 2*vecActual[4] + vecActual[5]);

                iteraciones.Add(vecActual);
                controlador.xGraficoRK.Add(vecActual[0]);
                controlador.yGraficoRS.Add(vecActual[1]);
                vecAnterior = vecActual;
            }

            controlador.solRS = Math.Round(vecAnterior[1],4).ToString();
            controlador.setCalculosRS(iteraciones);
           
        }

        // para calcular los de Predictor Corrector
        public double[] calcular(int n)
        {
            double[] resultados = new double[n];

            vecAnterior = new double[7];
            vecActual = new double[7];

            //inicializo
            //t
            vecAnterior[0] = t0;
            //Q
            vecAnterior[1] = Q0;
            //K1
            vecAnterior[2] = lambda * A * ((100 * (L - x) * (20 - vecAnterior[0])) / (100 - x * vecAnterior[0]));
            //K2
            double aux = vecAnterior[0] + h / 2;
            vecAnterior[3] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
            //K3
            //vecAnterior[4] = vecAnterior[3];
            vecAnterior[4] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
            //K4
            aux = vecAnterior[0] + h;
            vecAnterior[5] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
            //Q(i+1)
            //vecAnterior[6] = vecAnterior[1] + (h / 6) * (vecAnterior[2] + 4 * vecAnterior[3] + vecAnterior[5]);
            vecAnterior[6] = vecAnterior[1] + (h / 6) * (vecAnterior[2] + 2 * vecAnterior[3] + 2 * vecAnterior[4] + vecAnterior[5]);


            resultados[0] = vecAnterior[1];

            for(int i =1; i<n;i++)
            {
                vecActual = new double[7];

                //t
                vecActual[0] = vecAnterior[0] + h;
                //Q
                vecActual[1] = vecAnterior[6];
                //K1
                vecActual[2] = lambda * A * ((100 * (L - x) * (20 - vecActual[0])) / (100 - x * vecActual[0]));
                //K2
                aux = vecActual[0] + h / 2;
                vecActual[3] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
                //K3
                //vecActual[4] = vecActual[3];
                vecActual[4] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
                //K4
                aux = vecActual[0] + h;
                vecActual[5] = lambda * A * ((100 * (L - x) * (20 - aux)) / (100 - x * aux));
                //Q(i+1)
                //vecActual[6] = vecActual[1] + (h / 6) * (vecActual[2] + 4 * vecActual[3] + vecActual[5]);
                vecActual[6] = vecActual[1] + (h / 6) * (vecActual[2] + 2 * vecActual[3] + 2 * vecActual[4] + vecActual[5]);



                resultados[i] = vecActual[1];

                vecAnterior = vecActual;
            }


            return resultados;
        }

        public EstrategiaRK(Controlador controlador)
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
