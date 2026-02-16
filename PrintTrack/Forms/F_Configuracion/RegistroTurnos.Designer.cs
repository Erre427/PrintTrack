namespace PrintTrack.Forms.F_Configuracion
{
    partial class RegistroTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTurnos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState4 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState5 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState6 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.toggleFecha = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.toggleNombre = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dpFiltroFecha = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbFiltroNombre = new Bunifu.UI.WinForms.BunifuDropdown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuShadowPanel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuShadowPanel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1128, 636);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.BorderRadius = 10;
            this.bunifuShadowPanel2.BorderThickness = 1;
            this.bunifuShadowPanel2.Controls.Add(this.dgvTurnos);
            this.bunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(12, 141);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowDepth = 5;
            this.bunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(1120, 522);
            this.bunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel2.TabIndex = 1;
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AllowUserToDeleteRows = false;
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTurnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTurnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTurnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTurnos.ColumnHeadersHeight = 40;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.idRegistro,
            this.Nombre,
            this.FechaInicio,
            this.FechaFin,
            this.TotalHoras});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTurnos.EnableHeadersVisualStyles = false;
            this.dgvTurnos.Location = new System.Drawing.Point(23, 18);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTurnos.RowHeadersWidth = 40;
            this.dgvTurnos.RowTemplate.Height = 40;
            this.dgvTurnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.Size = new System.Drawing.Size(1076, 490);
            this.dgvTurnos.TabIndex = 0;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idUsuario.Visible = false;
            // 
            // idRegistro
            // 
            this.idRegistro.DataPropertyName = "idRegistro";
            this.idRegistro.FillWeight = 57.44501F;
            this.idRegistro.HeaderText = "idRegistro";
            this.idRegistro.Name = "idRegistro";
            this.idRegistro.ReadOnly = true;
            this.idRegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idRegistro.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Usuario";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.FillWeight = 57.44501F;
            this.FechaInicio.HeaderText = "Fecha de Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.FillWeight = 57.44501F;
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalHoras
            // 
            this.TotalHoras.DataPropertyName = "TotalHoras";
            this.TotalHoras.HeaderText = "Horas Trabajadas";
            this.TotalHoras.Name = "TotalHoras";
            this.TotalHoras.ReadOnly = true;
            this.TotalHoras.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 10;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.toggleFecha);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel5);
            this.bunifuShadowPanel1.Controls.Add(this.toggleNombre);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel4);
            this.bunifuShadowPanel1.Controls.Add(this.dpFiltroFecha);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel3);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuShadowPanel1.Controls.Add(this.cmbFiltroNombre);
            this.bunifuShadowPanel1.Controls.Add(this.pictureBox1);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(1077, 123);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // toggleFecha
            // 
            this.toggleFecha.Animation = 5;
            this.toggleFecha.BackColor = System.Drawing.Color.Transparent;
            this.toggleFecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleFecha.BackgroundImage")));
            this.toggleFecha.Checked = false;
            this.toggleFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleFecha.InnerCirclePadding = 3;
            this.toggleFecha.Location = new System.Drawing.Point(947, 24);
            this.toggleFecha.Name = "toggleFecha";
            this.toggleFecha.Size = new System.Drawing.Size(40, 21);
            this.toggleFecha.TabIndex = 11;
            this.toggleFecha.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.DarkGray;
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.DarkGray;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.toggleFecha.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 11;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.toggleFecha.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.toggleFecha.ToggleStateOn = toggleState3;
            this.toggleFecha.Value = false;
            this.toggleFecha.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.toggleFecha_CheckedChanged);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.Location = new System.Drawing.Point(790, 24);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(121, 21);
            this.bunifuLabel5.TabIndex = 10;
            this.bunifuLabel5.Text = "Filtrar por fecha";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // toggleNombre
            // 
            this.toggleNombre.Animation = 5;
            this.toggleNombre.BackColor = System.Drawing.Color.Transparent;
            this.toggleNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleNombre.BackgroundImage")));
            this.toggleNombre.Checked = false;
            this.toggleNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleNombre.InnerCirclePadding = 3;
            this.toggleNombre.Location = new System.Drawing.Point(732, 24);
            this.toggleNombre.Name = "toggleNombre";
            this.toggleNombre.Size = new System.Drawing.Size(40, 21);
            this.toggleNombre.TabIndex = 9;
            this.toggleNombre.ThumbMargin = 3;
            toggleState4.BackColor = System.Drawing.Color.DarkGray;
            toggleState4.BackColorInner = System.Drawing.Color.White;
            toggleState4.BorderColor = System.Drawing.Color.DarkGray;
            toggleState4.BorderColorInner = System.Drawing.Color.White;
            toggleState4.BorderRadius = 17;
            toggleState4.BorderRadiusInner = 11;
            toggleState4.BorderThickness = 1;
            toggleState4.BorderThicknessInner = 1;
            this.toggleNombre.ToggleStateDisabled = toggleState4;
            toggleState5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState5.BackColorInner = System.Drawing.Color.White;
            toggleState5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState5.BorderColorInner = System.Drawing.Color.White;
            toggleState5.BorderRadius = 17;
            toggleState5.BorderRadiusInner = 11;
            toggleState5.BorderThickness = 1;
            toggleState5.BorderThicknessInner = 1;
            this.toggleNombre.ToggleStateOff = toggleState5;
            toggleState6.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState6.BackColorInner = System.Drawing.Color.White;
            toggleState6.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState6.BorderColorInner = System.Drawing.Color.White;
            toggleState6.BorderRadius = 17;
            toggleState6.BorderRadiusInner = 11;
            toggleState6.BorderThickness = 1;
            toggleState6.BorderThicknessInner = 1;
            this.toggleNombre.ToggleStateOn = toggleState6;
            this.toggleNombre.Value = false;
            this.toggleNombre.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.toggleNombre_CheckedChanged);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.Location = new System.Drawing.Point(575, 24);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(139, 21);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "Filtrar por nombre";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dpFiltroFecha
            // 
            this.dpFiltroFecha.BackColor = System.Drawing.Color.Transparent;
            this.dpFiltroFecha.BorderRadius = 1;
            this.dpFiltroFecha.Color = System.Drawing.Color.Silver;
            this.dpFiltroFecha.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpFiltroFecha.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpFiltroFecha.DisabledColor = System.Drawing.Color.Gray;
            this.dpFiltroFecha.DisplayWeekNumbers = false;
            this.dpFiltroFecha.DPHeight = 0;
            this.dpFiltroFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpFiltroFecha.FillDatePicker = false;
            this.dpFiltroFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpFiltroFecha.ForeColor = System.Drawing.Color.Black;
            this.dpFiltroFecha.Icon = ((System.Drawing.Image)(resources.GetObject("dpFiltroFecha.Icon")));
            this.dpFiltroFecha.IconColor = System.Drawing.Color.Gray;
            this.dpFiltroFecha.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpFiltroFecha.LeftTextMargin = 5;
            this.dpFiltroFecha.Location = new System.Drawing.Point(790, 71);
            this.dpFiltroFecha.MinimumSize = new System.Drawing.Size(4, 32);
            this.dpFiltroFecha.Name = "dpFiltroFecha";
            this.dpFiltroFecha.Size = new System.Drawing.Size(220, 32);
            this.dpFiltroFecha.TabIndex = 7;
            this.dpFiltroFecha.ValueChanged += new System.EventHandler(this.dpFiltroFecha_ValueChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuLabel3.Location = new System.Drawing.Point(790, 50);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(33, 17);
            this.bunifuLabel3.TabIndex = 6;
            this.bunifuLabel3.Text = "Fecha";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuLabel2.Location = new System.Drawing.Point(575, 50);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(49, 17);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "Nombre";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmbFiltroNombre
            // 
            this.cmbFiltroNombre.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroNombre.BackgroundColor = System.Drawing.Color.White;
            this.cmbFiltroNombre.BorderColor = System.Drawing.Color.Silver;
            this.cmbFiltroNombre.BorderRadius = 1;
            this.cmbFiltroNombre.Color = System.Drawing.Color.Silver;
            this.cmbFiltroNombre.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbFiltroNombre.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbFiltroNombre.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbFiltroNombre.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbFiltroNombre.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFiltroNombre.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbFiltroNombre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroNombre.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbFiltroNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroNombre.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbFiltroNombre.FillDropDown = true;
            this.cmbFiltroNombre.FillIndicator = false;
            this.cmbFiltroNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFiltroNombre.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroNombre.FormattingEnabled = true;
            this.cmbFiltroNombre.Icon = null;
            this.cmbFiltroNombre.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbFiltroNombre.IndicatorColor = System.Drawing.Color.Gray;
            this.cmbFiltroNombre.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbFiltroNombre.ItemBackColor = System.Drawing.Color.White;
            this.cmbFiltroNombre.ItemBorderColor = System.Drawing.Color.White;
            this.cmbFiltroNombre.ItemForeColor = System.Drawing.Color.Black;
            this.cmbFiltroNombre.ItemHeight = 26;
            this.cmbFiltroNombre.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbFiltroNombre.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbFiltroNombre.ItemTopMargin = 3;
            this.cmbFiltroNombre.Location = new System.Drawing.Point(575, 71);
            this.cmbFiltroNombre.Name = "cmbFiltroNombre";
            this.cmbFiltroNombre.Size = new System.Drawing.Size(197, 32);
            this.cmbFiltroNombre.TabIndex = 3;
            this.cmbFiltroNombre.Text = null;
            this.cmbFiltroNombre.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbFiltroNombre.TextLeftMargin = 5;
            this.cmbFiltroNombre.SelectionChangeCommitted += new System.EventHandler(this.cmbFiltroNombre_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintTrack.Properties.Resources.ausencia__1_;
            this.pictureBox1.Location = new System.Drawing.Point(32, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(138, 37);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(386, 50);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Registro de Asistencias";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // RegistroTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 636);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "RegistroTurnos";
            this.Text = "RegistroTurnos";
            this.Load += new System.EventHandler(this.RegistroTurnos_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel2;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown cmbFiltroNombre;
        private Bunifu.UI.WinForms.BunifuDatePicker dpFiltroFecha;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHoras;
        private Bunifu.UI.WinForms.BunifuToggleSwitch toggleNombre;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuToggleSwitch toggleFecha;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
    }
}