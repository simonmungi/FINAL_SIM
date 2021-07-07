using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Metodos;

namespace WindowsFormsApp1
{
    public class Controlador
    {

        //**** VALORES INICIALES ****//

        public Form1 form;

        public string solEuler = "---";
        public string solRS = "---";
        public string solPC = "---";
        public string solAnalitica = "---";


        public double h = 0.01;
        private double lambda = 0.4;
        private double A = 10;
        private double L = 20;
        private double x = 2.5;
        private double t0 = 0;
        private double Q0 = 0;
        private double tLimite = 25;

        public List<double[]> calculosEuler;
        public List<double[]> calculosAN;
        public List<double[]> calculosPC;
        public List<double[]> calculosRS;

        //public List<double> xGrafico;
        public List<double> xGraficoEuler;
        public List<double> xGraficoPC;
        public List<double> xGraficoRK;
        public List<double> xGraficoAN;



        public List<double> yGraficoEuler;
        public List<double> yGraficoRS;
        public List<double> yGraficoPC;
        public List<double> yGraficoAN;




        public void calcular(string metodo)
        {


            switch (metodo)
            {
                case "Euler":
                    IEstrategia euler = new EstrategiaEuler(this);
                    euler.calcular();
                    form.cargarGrillaEuler();
                    break;
                case "R-K":
                    IEstrategia rk = new EstrategiaRK(this);
                    rk.calcular();
                    form.cargarGrillaRS();
                    break;
                case "P-C":
                    IEstrategia pc = new EstrategiaPredictorCorrector(this);
                    pc.calcular();
                    form.cargarGrillaPC();
                    break;
                case "Analitico":
                    EstrategiaAnalitica an = new EstrategiaAnalitica(this);
                    an.calcular();
                    solAnalitica = an.calcular(tLimite).ToString();
                    break;

            }

        }




        public Controlador(Form1 form)
        {
            this.form = form;
        }




        //******** GETTERS y SETTERS ********//

        public double getH()
        {
            return this.h;
        }

        public double getLambda()
        {
            return this.lambda;
        }
        public double getA()
        {
            return this.A;
        }
        public double getL()
        {
            return this.L;
        }
        public double getX()
        {
            return this.x;
        }
        public double getT0()
        {
            return this.t0;
        }
        public double getQ0()
        {
            return this.Q0;
        }

        public double getTLimite()
        {
            return this.tLimite;
        }

        public List<double[]> getCalculosEuler()
        {
            return this.calculosEuler;
        }

        public List<double[]> getCalculosRS()
        {
            return this.calculosRS;
        }
        public List<double[]> getCalculosPC()
        {
            return this.calculosPC;
        }

        public void setH(double h)
        {
            this.h = h;
        }

        public void setLambda(double lambda)
        {
            this.lambda = lambda;
        }
        public void setA(double A)
        {
            this.A = A;
        }
        public void setL(double L)
        {
            this.L = L;
        }
        public void setX(double x)
        {
            this.x = x;
        }
        public void setT0(double t0)
        {
            this.t0 = t0;
        }

        public void setQ0(double q0)
        {
            this.Q0 = q0;
        }

        public void setTLimite(double tLimite)
        {
            this.tLimite = tLimite;
        }


        public void setCalculosEuler(List<double[]> calculos)
        {
            this.calculosEuler = calculos;
        }
        public void setCalculosRS(List<double[]> calculos)
        {
            this.calculosRS = calculos;
        }
        public void setCalculosAN(List<double[]> calculos)
        {
            this.calculosAN = calculos;
        }

        public void setCalculosPC(List<double[]> calculos)
        {
            this.calculosPC = calculos;
        }
    }
}
