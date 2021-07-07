using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Controlador controlador;
        public Form1()
        {
            controlador = new Controlador(this);
            InitializeComponent();

            Chart1.Series[0].Name = "Euler";
            Chart1.Series[0].BorderWidth = 3;
            Chart1.Series.Add("RS");
            Chart1.Series[1].BorderWidth = 3;
            Chart1.Series.Add("P-C");
            Chart1.Series[2].BorderWidth = 3;
            Chart1.Series.Add("Analitico");
            Chart1.Series[3].BorderWidth = 3;



            Chart1.ChartAreas[0].AxisY.Interval = 1000;
            Chart1.ChartAreas[0].AxisX.Interval = 2;



        }

        //**********************************//
        //************ BOTONES ************//
        //**********************************//

        private void button1_Click(object sender, EventArgs e)
        {
            cargarValores();
            lblIteraciones.Text = Math.Round((controlador.getTLimite() / controlador.getH())).ToString();
            //controlador.calcular();

            lblSolAnalitica.Text = controlador.solAnalitica;
            lblSolEuler.Text = controlador.solEuler;
            lblSolRS.Text = controlador.solRS;
            lblSolPC.Text = controlador.solPC;
            
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            cargarValores();
            lblIteraciones.Text = Math.Round((controlador.getTLimite() / controlador.getH())).ToString();
            controlador.calcular("Euler");

            lblSolEuler.Text = controlador.solEuler;
            btnGrafEuler.Enabled = true;

        }

        private void btnRK_Click(object sender, EventArgs e)
        {
            cargarValores();
            lblIteraciones.Text = Math.Round((controlador.getTLimite() / controlador.getH())).ToString();
            controlador.calcular("R-K");

            lblSolRS.Text = controlador.solRS;
            btnGrafRK.Enabled = true;
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            cargarValores();
            lblIteraciones.Text = Math.Round((controlador.getTLimite() / controlador.getH())).ToString();
            controlador.calcular("P-C");

            lblSolPC.Text = controlador.solPC;
            btnGrafPC.Enabled = true;
        }

        private void btnAnalitica_Click(object sender, EventArgs e)
        {
            cargarValores();
            lblIteraciones.Text = Math.Round((controlador.getTLimite() / controlador.getH())).ToString();
            controlador.calcular("Analitico");

            lblSolAnalitica.Text = controlador.solAnalitica;
            btnGrafAnalitico.Enabled = true;
        }

        private void cargarValores()
        {
            this.controlador.h = Convert.ToDouble(this.txtH.Text);
            this.controlador.setTLimite(Convert.ToDouble(this.txtTFinal.Text));
        }


        //**********************************//
        //************ GRILLAS ************//
        //**********************************//

        public void cargarGrillaEuler()
        {
            int count = 0;
            dgvEuler.DataSource = controlador.getCalculosEuler().Select(x => new { i = count++, Property1 = x[0], Property2 = x[1], Property3 = x[2], Property4 = x[3] }).ToList();

            dgvEuler.Columns[1].HeaderText = "t [segundos]";
            dgvEuler.Columns[2].HeaderText = "Q(i)";
            dgvEuler.Columns[3].HeaderText = "h*Q'(t)";
            dgvEuler.Columns[4].HeaderText = "Q(i+1)";
        }


        public void cargarGrillaRS()
        {
            int count = 0;
            dgvRS.DataSource = controlador.getCalculosRS().Select(x => new { i = count++, Property1 = x[0], Property2 = x[1], Property3 = x[2], Property4 = x[3], Property5 = x[4], Property6 = x[5], Property7 = x[6] }).ToList();

            dgvRS.Columns[1].HeaderText = "t [segundos]";
            dgvRS.Columns[2].HeaderText = "Qi";
            dgvRS.Columns[3].HeaderText = "K1";
            dgvRS.Columns[4].HeaderText = "K2";
            dgvRS.Columns[5].HeaderText = "K3";
            dgvRS.Columns[6].HeaderText = "K4";
            dgvRS.Columns[7].HeaderText = "Qi+1";

        }

        public void cargarGrillaPC()
        {
            int count = 0;
            dgvPC.DataSource = controlador.getCalculosPC().Select(x => new { i = count++, t = x[0], Q = x[1], Yp = x[2], Yq = x[3] }).ToList();

            dgvPC.Columns[1].HeaderText = "t [segundos]";
            dgvPC.Columns[2].HeaderText = "Q(t)";
            dgvPC.Columns[3].HeaderText = "Yp";
            dgvPC.Columns[4].HeaderText = "Yc";

        }

        //**********************************//
        //************ GRAFICOS ************//
        //**********************************//

        public void cargarGraficoEuler()
        {
            //Chart1.Series[0].Points.Clear();
            Chart1.Series[0].LegendText = "Euler";
            Chart1.Series[0].ChartType = SeriesChartType.Line;
            Chart1.Series[0].Points.DataBindXY(controlador.xGraficoEuler.ToArray(), controlador.yGraficoEuler.ToArray());

        }

        public void cargarGraficoRS()
        {
            //Chart1.Series[1].Points.Clear();
            Chart1.Series[1].LegendText = "RS";
            Chart1.Series[1].ChartType = SeriesChartType.Line;
            Chart1.Series[1].Points.DataBindXY(controlador.xGraficoRK.ToArray(), controlador.yGraficoRS.ToArray());
        }

        public void cargarGraficoPC()
        {
            //Chart1.Series[2].Points.Clear();
            Chart1.Series[2].LegendText = "P-C";
            Chart1.Series[2].ChartType = SeriesChartType.Line;
            Chart1.Series[2].Points.DataBindXY(controlador.xGraficoPC.ToArray(), controlador.yGraficoPC.ToArray());
        }


        public void cargarGraficoAnalitico()
        {
            //Chart1.Series[3].Points.Clear();
            Chart1.Series[3].LegendText = "Analitico";
            Chart1.Series[3].ChartType = SeriesChartType.Line;
            Chart1.Series[3].Points.DataBindXY(controlador.xGraficoAN.ToArray(), controlador.yGraficoAN.ToArray());
        }

        private void btnGrafEuler_Click(object sender, EventArgs e)
        {
            cargarGraficoEuler();
        }

        private void btnGrafRK_Click(object sender, EventArgs e)
        {
            cargarGraficoRS();
        }

        private void btnGrafPC_Click(object sender, EventArgs e)
        {
            cargarGraficoPC();
        }

        private void btnGrafAnalitico_Click(object sender, EventArgs e)
        {
            cargarGraficoAnalitico();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Chart1.Series[0].Points.Clear();
            Chart1.Series[1].Points.Clear();
            Chart1.Series[2].Points.Clear();
            Chart1.Series[3].Points.Clear();

        }
    }
}
