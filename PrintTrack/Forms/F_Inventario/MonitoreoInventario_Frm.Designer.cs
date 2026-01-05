namespace PrintTrack.Forms.F_Inventario
{
    partial class MonitoreoInventario_Frm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoreoInventario_Frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Investigar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuLabel5);
            this.panel1.Controls.Add(this.bunifuLabel4);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Location = new System.Drawing.Point(25, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 268);
            this.panel1.TabIndex = 23;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AllowParentOverrides = false;
            this.lblTitulo.AutoEllipsis = false;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitulo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(25, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(372, 50);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Dashboard Monitoreo";
            this.lblTitulo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitulo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bunifuLabel3);
            this.panel2.Location = new System.Drawing.Point(445, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 268);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.bunifuLabel2);
            this.panel3.Location = new System.Drawing.Point(232, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 300);
            this.panel3.TabIndex = 25;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(10, 9);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(203, 17);
            this.bunifuLabel1.TabIndex = 26;
            this.bunifuLabel1.Text = "Monitoreo Ambiental de almacen";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(10, 13);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(148, 17);
            this.bunifuLabel2.TabIndex = 27;
            this.bunifuLabel2.Text = "Anomalias en Inventario";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(14, 9);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(192, 17);
            this.bunifuLabel3.TabIndex = 27;
            this.bunifuLabel3.Text = "Optimizacion de Stock Sugerida";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(10, 45);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Temperatura";
            series7.YValuesPerPoint = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Humedad";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(361, 157);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuLabel4.Location = new System.Drawing.Point(22, 224);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(132, 17);
            this.bunifuLabel4.TabIndex = 27;
            this.bunifuLabel4.Text = "Ubicación: Almacen-05";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuLabel5.Location = new System.Drawing.Point(195, 224);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(156, 17);
            this.bunifuLabel5.TabIndex = 28;
            this.bunifuLabel5.Text = "Ultima Lectura: 08/12/2025";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Tipo,
            this.Probabilidad,
            this.Investigar});
            this.dataGridView1.Location = new System.Drawing.Point(10, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 247);
            this.dataGridView1.TabIndex = 28;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de Anomalia";
            this.Tipo.Name = "Tipo";
            // 
            // Probabilidad
            // 
            this.Probabilidad.HeaderText = "Probabilidad";
            this.Probabilidad.Name = "Probabilidad";
            // 
            // Investigar
            // 
            this.Investigar.HeaderText = "";
            this.Investigar.Name = "Investigar";
            this.Investigar.Text = "Investigar";
            this.Investigar.UseColumnTextForButtonValue = true;
            // 
            // MonitoreoInventario_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MonitoreoInventario_Frm";
            this.Text = "MonitoreoInventario_Frm";
            this.Load += new System.EventHandler(this.MonitoreoInventario_Frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel lblTitulo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad;
        private System.Windows.Forms.DataGridViewButtonColumn Investigar;
    }
}