
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvEuler = new System.Windows.Forms.DataGridView();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGrafAnalitico = new System.Windows.Forms.Button();
            this.btnGrafPC = new System.Windows.Forms.Button();
            this.btnGrafRK = new System.Windows.Forms.Button();
            this.btnGrafEuler = new System.Windows.Forms.Button();
            this.btnAnalitica = new System.Windows.Forms.Button();
            this.btnRK = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnEuler = new System.Windows.Forms.Button();
            this.lblSolPC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSolRS = new System.Windows.Forms.Label();
            this.lblSolAnalitica = new System.Windows.Forms.Label();
            this.lblSolEuler = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTFinal = new System.Windows.Forms.TextBox();
            this.txtt0 = new System.Windows.Forms.TextBox();
            this.txtQ0 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.dgvRS = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEuler
            // 
            this.dgvEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEuler.Location = new System.Drawing.Point(6, 6);
            this.dgvEuler.Name = "dgvEuler";
            this.dgvEuler.Size = new System.Drawing.Size(614, 414);
            this.dgvEuler.TabIndex = 0;
            // 
            // Chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(693, 13);
            this.Chart1.Name = "Chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(665, 627);
            this.Chart1.TabIndex = 1;
            this.Chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrafAnalitico);
            this.groupBox1.Controls.Add(this.btnGrafPC);
            this.groupBox1.Controls.Add(this.btnGrafRK);
            this.groupBox1.Controls.Add(this.btnGrafEuler);
            this.groupBox1.Controls.Add(this.btnAnalitica);
            this.groupBox1.Controls.Add(this.btnRK);
            this.groupBox1.Controls.Add(this.btnPC);
            this.groupBox1.Controls.Add(this.btnEuler);
            this.groupBox1.Controls.Add(this.lblSolPC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblIteraciones);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSolRS);
            this.groupBox1.Controls.Add(this.lblSolAnalitica);
            this.groupBox1.Controls.Add(this.lblSolEuler);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTFinal);
            this.groupBox1.Controls.Add(this.txtt0);
            this.groupBox1.Controls.Add(this.txtQ0);
            this.groupBox1.Controls.Add(this.txtH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblH);
            this.groupBox1.Location = new System.Drawing.Point(33, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores iniciales";
            // 
            // btnGrafAnalitico
            // 
            this.btnGrafAnalitico.Enabled = false;
            this.btnGrafAnalitico.Location = new System.Drawing.Point(309, 117);
            this.btnGrafAnalitico.Name = "btnGrafAnalitico";
            this.btnGrafAnalitico.Size = new System.Drawing.Size(55, 23);
            this.btnGrafAnalitico.TabIndex = 34;
            this.btnGrafAnalitico.Text = "Gráfico";
            this.btnGrafAnalitico.UseVisualStyleBackColor = true;
            this.btnGrafAnalitico.Click += new System.EventHandler(this.btnGrafAnalitico_Click);
            // 
            // btnGrafPC
            // 
            this.btnGrafPC.Enabled = false;
            this.btnGrafPC.Location = new System.Drawing.Point(309, 88);
            this.btnGrafPC.Name = "btnGrafPC";
            this.btnGrafPC.Size = new System.Drawing.Size(55, 23);
            this.btnGrafPC.TabIndex = 33;
            this.btnGrafPC.Text = "Gráfico";
            this.btnGrafPC.UseVisualStyleBackColor = true;
            this.btnGrafPC.Click += new System.EventHandler(this.btnGrafPC_Click);
            // 
            // btnGrafRK
            // 
            this.btnGrafRK.Enabled = false;
            this.btnGrafRK.Location = new System.Drawing.Point(309, 59);
            this.btnGrafRK.Name = "btnGrafRK";
            this.btnGrafRK.Size = new System.Drawing.Size(55, 23);
            this.btnGrafRK.TabIndex = 32;
            this.btnGrafRK.Text = "Gráfico";
            this.btnGrafRK.UseVisualStyleBackColor = true;
            this.btnGrafRK.Click += new System.EventHandler(this.btnGrafRK_Click);
            // 
            // btnGrafEuler
            // 
            this.btnGrafEuler.Enabled = false;
            this.btnGrafEuler.Location = new System.Drawing.Point(309, 30);
            this.btnGrafEuler.Name = "btnGrafEuler";
            this.btnGrafEuler.Size = new System.Drawing.Size(55, 23);
            this.btnGrafEuler.TabIndex = 31;
            this.btnGrafEuler.Text = "Gráfico";
            this.btnGrafEuler.UseVisualStyleBackColor = true;
            this.btnGrafEuler.Click += new System.EventHandler(this.btnGrafEuler_Click);
            // 
            // btnAnalitica
            // 
            this.btnAnalitica.Location = new System.Drawing.Point(229, 117);
            this.btnAnalitica.Name = "btnAnalitica";
            this.btnAnalitica.Size = new System.Drawing.Size(57, 23);
            this.btnAnalitica.TabIndex = 30;
            this.btnAnalitica.Text = "Analitica";
            this.btnAnalitica.UseVisualStyleBackColor = true;
            this.btnAnalitica.Click += new System.EventHandler(this.btnAnalitica_Click);
            // 
            // btnRK
            // 
            this.btnRK.Location = new System.Drawing.Point(229, 59);
            this.btnRK.Name = "btnRK";
            this.btnRK.Size = new System.Drawing.Size(57, 23);
            this.btnRK.TabIndex = 29;
            this.btnRK.Text = "R-K";
            this.btnRK.UseVisualStyleBackColor = true;
            this.btnRK.Click += new System.EventHandler(this.btnRK_Click);
            // 
            // btnPC
            // 
            this.btnPC.Location = new System.Drawing.Point(229, 88);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(57, 23);
            this.btnPC.TabIndex = 28;
            this.btnPC.Text = "P-C";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnEuler
            // 
            this.btnEuler.Location = new System.Drawing.Point(229, 30);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Size = new System.Drawing.Size(57, 23);
            this.btnEuler.TabIndex = 27;
            this.btnEuler.Text = "Euler";
            this.btnEuler.UseVisualStyleBackColor = true;
            this.btnEuler.Click += new System.EventHandler(this.btnEuler_Click);
            // 
            // lblSolPC
            // 
            this.lblSolPC.AutoSize = true;
            this.lblSolPC.Location = new System.Drawing.Point(481, 93);
            this.lblSolPC.Name = "lblSolPC";
            this.lblSolPC.Size = new System.Drawing.Size(16, 13);
            this.lblSolPC.TabIndex = 25;
            this.lblSolPC.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Solución P-C";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Location = new System.Drawing.Point(102, 109);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(16, 13);
            this.lblIteraciones.TabIndex = 23;
            this.lblIteraciones.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "N° Iteraciones:";
            // 
            // lblSolRS
            // 
            this.lblSolRS.AutoSize = true;
            this.lblSolRS.Location = new System.Drawing.Point(481, 64);
            this.lblSolRS.Name = "lblSolRS";
            this.lblSolRS.Size = new System.Drawing.Size(16, 13);
            this.lblSolRS.TabIndex = 21;
            this.lblSolRS.Text = "---";
            // 
            // lblSolAnalitica
            // 
            this.lblSolAnalitica.AutoSize = true;
            this.lblSolAnalitica.Location = new System.Drawing.Point(481, 122);
            this.lblSolAnalitica.Name = "lblSolAnalitica";
            this.lblSolAnalitica.Size = new System.Drawing.Size(16, 13);
            this.lblSolAnalitica.TabIndex = 20;
            this.lblSolAnalitica.Text = "---";
            // 
            // lblSolEuler
            // 
            this.lblSolEuler.AutoSize = true;
            this.lblSolEuler.Location = new System.Drawing.Point(481, 35);
            this.lblSolEuler.Name = "lblSolEuler";
            this.lblSolEuler.Size = new System.Drawing.Size(16, 13);
            this.lblSolEuler.TabIndex = 19;
            this.lblSolEuler.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Solución Analítica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Solución R-K:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Solución Euler:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "tf";
            // 
            // txtTFinal
            // 
            this.txtTFinal.Location = new System.Drawing.Point(26, 58);
            this.txtTFinal.Name = "txtTFinal";
            this.txtTFinal.Size = new System.Drawing.Size(56, 20);
            this.txtTFinal.TabIndex = 14;
            this.txtTFinal.Text = "25";
            // 
            // txtt0
            // 
            this.txtt0.Location = new System.Drawing.Point(126, 32);
            this.txtt0.Name = "txtt0";
            this.txtt0.Size = new System.Drawing.Size(56, 20);
            this.txtt0.TabIndex = 13;
            this.txtt0.Text = "0";
            // 
            // txtQ0
            // 
            this.txtQ0.Location = new System.Drawing.Point(126, 58);
            this.txtQ0.Name = "txtQ0";
            this.txtQ0.Size = new System.Drawing.Size(56, 20);
            this.txtQ0.TabIndex = 12;
            this.txtQ0.Text = "0";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(26, 32);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(56, 20);
            this.txtH.TabIndex = 7;
            this.txtH.Text = "0,01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "t0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Q0";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(7, 35);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(13, 13);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "h";
            // 
            // dgvRS
            // 
            this.dgvRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRS.Location = new System.Drawing.Point(3, 6);
            this.dgvRS.Name = "dgvRS";
            this.dgvRS.Size = new System.Drawing.Size(617, 414);
            this.dgvRS.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(33, 192);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 500);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEuler);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Euler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 474);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Runge-Kutta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvPC);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 474);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Predictor-Corrector";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvPC
            // 
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Location = new System.Drawing.Point(7, 7);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.Size = new System.Drawing.Size(613, 413);
            this.dgvPC.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(693, 646);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 23);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEuler;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtt0;
        private System.Windows.Forms.TextBox txtQ0;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTFinal;
        private System.Windows.Forms.DataGridView dgvRS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSolRS;
        private System.Windows.Forms.Label lblSolAnalitica;
        private System.Windows.Forms.Label lblSolEuler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSolPC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRK;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Button btnGrafAnalitico;
        private System.Windows.Forms.Button btnGrafPC;
        private System.Windows.Forms.Button btnGrafRK;
        private System.Windows.Forms.Button btnGrafEuler;
        private System.Windows.Forms.Button btnAnalitica;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

