namespace BoolTechInventoryManagementSystem
{
    partial class FinancialsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.selectioncomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthSelect = new System.Windows.Forms.NumericUpDown();
            this.yearSelect = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.getData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.finanaceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.monthSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanaceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // selectioncomboBox
            // 
            resources.ApplyResources(this.selectioncomboBox, "selectioncomboBox");
            this.selectioncomboBox.FormattingEnabled = true;
            this.selectioncomboBox.Items.AddRange(new object[] {
            resources.GetString("selectioncomboBox.Items"),
            resources.GetString("selectioncomboBox.Items1"),
            resources.GetString("selectioncomboBox.Items2")});
            this.selectioncomboBox.Name = "selectioncomboBox";
            this.selectioncomboBox.SelectedIndexChanged += new System.EventHandler(this.selectioncomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // monthSelect
            // 
            resources.ApplyResources(this.monthSelect, "monthSelect");
            this.monthSelect.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthSelect.Name = "monthSelect";
            this.monthSelect.ReadOnly = true;
            this.monthSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearSelect
            // 
            resources.ApplyResources(this.yearSelect, "yearSelect");
            this.yearSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yearSelect.Name = "yearSelect";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // getData
            // 
            resources.ApplyResources(this.getData, "getData");
            this.getData.Name = "getData";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // resultText
            // 
            resources.ApplyResources(this.resultText, "resultText");
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            // 
            // finanaceChart
            // 
            resources.ApplyResources(this.finanaceChart, "finanaceChart");
            chartArea1.Name = "ChartArea1";
            this.finanaceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.finanaceChart.Legends.Add(legend1);
            this.finanaceChart.Name = "finanaceChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Revenu";
            series1.Name = "Chart";
            this.finanaceChart.Series.Add(series1);
            // 
            // FinancialsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.finanaceChart);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearSelect);
            this.Controls.Add(this.monthSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectioncomboBox);
            this.Controls.Add(this.label1);
            this.Name = "FinancialsForm";
            ((System.ComponentModel.ISupportInitialize)(this.monthSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanaceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectioncomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown monthSelect;
        private System.Windows.Forms.NumericUpDown yearSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.DataVisualization.Charting.Chart finanaceChart;
    }
}