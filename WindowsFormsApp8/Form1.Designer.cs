
namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.T = new System.Windows.Forms.NumericUpDown();
            this.Lambda = new System.Windows.Forms.NumericUpDown();
            this.Mu = new System.Windows.Forms.NumericUpDown();
            this.Operators = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Operators)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(315, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1034, 494);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.DockedToChartArea = "ChartArea1";
            title1.Name = "Frequancy";
            title1.Text = "Frequancy";
            title2.DockedToChartArea = "ChartArea2";
            title2.Name = "Statisctic";
            title2.Text = "Statisctic";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(35, 114);
            this.N.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 22);
            this.N.TabIndex = 1;
            this.N.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(35, 174);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(120, 22);
            this.T.TabIndex = 2;
            this.T.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Lambda
            // 
            this.Lambda.DecimalPlaces = 2;
            this.Lambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Lambda.Location = new System.Drawing.Point(35, 232);
            this.Lambda.Name = "Lambda";
            this.Lambda.Size = new System.Drawing.Size(120, 22);
            this.Lambda.TabIndex = 3;
            this.Lambda.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // Mu
            // 
            this.Mu.DecimalPlaces = 2;
            this.Mu.Location = new System.Drawing.Point(35, 288);
            this.Mu.Name = "Mu";
            this.Mu.Size = new System.Drawing.Size(120, 22);
            this.Mu.TabIndex = 4;
            this.Mu.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // Operators
            // 
            this.Operators.Location = new System.Drawing.Point(35, 372);
            this.Operators.Name = "Operators";
            this.Operators.Size = new System.Drawing.Size(120, 22);
            this.Operators.TabIndex = 5;
            this.Operators.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(35, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(143, 76);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "λ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "μ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "NumersOfOperators";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 518);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Operators);
            this.Controls.Add(this.Mu);
            this.Controls.Add(this.Lambda);
            this.Controls.Add(this.T);
            this.Controls.Add(this.N);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Operators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.NumericUpDown T;
        private System.Windows.Forms.NumericUpDown Lambda;
        private System.Windows.Forms.NumericUpDown Mu;
        private System.Windows.Forms.NumericUpDown Operators;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

