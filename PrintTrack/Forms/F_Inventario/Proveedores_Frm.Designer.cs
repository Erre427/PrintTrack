namespace PrintTrack.Forms.F_Inventario
{
    partial class Proveedores_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores_Frm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.btnGuardar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNuevo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Archivar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCambios = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bunifuLabel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 76);
            this.panel2.TabIndex = 1;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeight = 40;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedor,
            this.Nombre,
            this.Telefono,
            this.Cargar,
            this.Archivar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProveedores.EnableHeadersVisualStyles = false;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 104);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProveedores.RowHeadersWidth = 40;
            this.dgvProveedores.RowTemplate.Height = 40;
            this.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.Size = new System.Drawing.Size(544, 354);
            this.dgvProveedores.TabIndex = 2;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(99, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(211, 50);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Proveedores";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintTrack.Properties.Resources.empleado__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(25, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel2.Location = new System.Drawing.Point(25, 25);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(55, 20);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "Nombre";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel3.Location = new System.Drawing.Point(25, 97);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(59, 20);
            this.bunifuLabel3.TabIndex = 6;
            this.bunifuLabel3.Text = "Telefono";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(25, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(162, 26);
            this.txtTelefono.TabIndex = 5;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel4.Location = new System.Drawing.Point(25, 166);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(45, 20);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "Correo";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(25, 192);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(254, 26);
            this.txtCorreo.TabIndex = 7;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel5.Location = new System.Drawing.Point(25, 232);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(63, 20);
            this.bunifuLabel5.TabIndex = 10;
            this.bunifuLabel5.Text = "Direccion";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(25, 258);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(329, 81);
            this.txtDireccion.TabIndex = 9;
            // 
            // pnDatos
            // 
            this.pnDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDatos.Controls.Add(this.btnCambios);
            this.pnDatos.Controls.Add(this.btnGuardar);
            this.pnDatos.Controls.Add(this.txtDireccion);
            this.pnDatos.Controls.Add(this.txtNombre);
            this.pnDatos.Controls.Add(this.bunifuLabel2);
            this.pnDatos.Controls.Add(this.bunifuLabel5);
            this.pnDatos.Controls.Add(this.txtTelefono);
            this.pnDatos.Controls.Add(this.bunifuLabel3);
            this.pnDatos.Controls.Add(this.bunifuLabel4);
            this.pnDatos.Controls.Add(this.txtCorreo);
            this.pnDatos.Location = new System.Drawing.Point(608, 28);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(396, 430);
            this.pnDatos.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AllowAnimations = true;
            this.btnGuardar.AllowMouseEffects = true;
            this.btnGuardar.AllowToggling = false;
            this.btnGuardar.AnimationSpeed = 200;
            this.btnGuardar.AutoGenerateColors = false;
            this.btnGuardar.AutoRoundBorders = false;
            this.btnGuardar.AutoSizeLeftIcon = true;
            this.btnGuardar.AutoSizeRightIcon = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.ButtonText = "Registrar Nuevo";
            this.btnGuardar.ButtonTextMarginLeft = 0;
            this.btnGuardar.ColorContrastOnClick = 45;
            this.btnGuardar.ColorContrastOnHover = 45;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnGuardar.CustomizableEdges = borderEdges2;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGuardar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGuardar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.IconLeftPadding = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.btnGuardar.IconMarginLeft = 11;
            this.btnGuardar.IconPadding = 10;
            this.btnGuardar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.IdleBorderRadius = 10;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.IdleIconLeftImage = null;
            this.btnGuardar.IdleIconRightImage = null;
            this.btnGuardar.IndicateFocus = false;
            this.btnGuardar.Location = new System.Drawing.Point(104, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardar.OnDisabledState.BorderRadius = 10;
            this.btnGuardar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.OnDisabledState.BorderThickness = 1;
            this.btnGuardar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGuardar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGuardar.OnDisabledState.IconLeftImage = null;
            this.btnGuardar.OnDisabledState.IconRightImage = null;
            this.btnGuardar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGuardar.onHoverState.BorderRadius = 10;
            this.btnGuardar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.onHoverState.BorderThickness = 1;
            this.btnGuardar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGuardar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.onHoverState.IconLeftImage = null;
            this.btnGuardar.onHoverState.IconRightImage = null;
            this.btnGuardar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.OnIdleState.BorderRadius = 10;
            this.btnGuardar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.OnIdleState.BorderThickness = 1;
            this.btnGuardar.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnIdleState.IconLeftImage = null;
            this.btnGuardar.OnIdleState.IconRightImage = null;
            this.btnGuardar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGuardar.OnPressedState.BorderRadius = 10;
            this.btnGuardar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.OnPressedState.BorderThickness = 1;
            this.btnGuardar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGuardar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnPressedState.IconLeftImage = null;
            this.btnGuardar.OnPressedState.IconRightImage = null;
            this.btnGuardar.Size = new System.Drawing.Size(175, 50);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.TextMarginLeft = 0;
            this.btnGuardar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGuardar.UseDefaultRadiusAndThickness = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AllowAnimations = true;
            this.btnNuevo.AllowMouseEffects = true;
            this.btnNuevo.AllowToggling = false;
            this.btnNuevo.AnimationSpeed = 200;
            this.btnNuevo.AutoGenerateColors = false;
            this.btnNuevo.AutoRoundBorders = false;
            this.btnNuevo.AutoSizeLeftIcon = true;
            this.btnNuevo.AutoSizeRightIcon = true;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.ButtonTextMarginLeft = 0;
            this.btnNuevo.ColorContrastOnClick = 45;
            this.btnNuevo.ColorContrastOnHover = 45;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnNuevo.CustomizableEdges = borderEdges3;
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNuevo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNuevo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNuevo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.IconLeftPadding = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.btnNuevo.IconMarginLeft = 11;
            this.btnNuevo.IconPadding = 10;
            this.btnNuevo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNuevo.IconSize = 25;
            this.btnNuevo.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.IdleBorderRadius = 10;
            this.btnNuevo.IdleBorderThickness = 1;
            this.btnNuevo.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevo.IdleIconLeftImage = null;
            this.btnNuevo.IdleIconRightImage = null;
            this.btnNuevo.IndicateFocus = false;
            this.btnNuevo.Location = new System.Drawing.Point(368, 38);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNuevo.OnDisabledState.BorderRadius = 10;
            this.btnNuevo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.OnDisabledState.BorderThickness = 1;
            this.btnNuevo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNuevo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNuevo.OnDisabledState.IconLeftImage = null;
            this.btnNuevo.OnDisabledState.IconRightImage = null;
            this.btnNuevo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNuevo.onHoverState.BorderRadius = 10;
            this.btnNuevo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.onHoverState.BorderThickness = 1;
            this.btnNuevo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNuevo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.onHoverState.IconLeftImage = null;
            this.btnNuevo.onHoverState.IconRightImage = null;
            this.btnNuevo.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.OnIdleState.BorderRadius = 10;
            this.btnNuevo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.OnIdleState.BorderThickness = 1;
            this.btnNuevo.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnIdleState.IconLeftImage = null;
            this.btnNuevo.OnIdleState.IconRightImage = null;
            this.btnNuevo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNuevo.OnPressedState.BorderRadius = 10;
            this.btnNuevo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevo.OnPressedState.BorderThickness = 1;
            this.btnNuevo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNuevo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnPressedState.IconLeftImage = null;
            this.btnNuevo.OnPressedState.IconRightImage = null;
            this.btnNuevo.Size = new System.Drawing.Size(119, 50);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.TextMarginLeft = 0;
            this.btnNuevo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNuevo.UseDefaultRadiusAndThickness = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // idProveedor
            // 
            this.idProveedor.DataPropertyName = "idProveedor";
            this.idProveedor.HeaderText = "id";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idProveedor.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 57.44501F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.FillWeight = 57.44501F;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cargar
            // 
            this.Cargar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            this.Cargar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cargar.FillWeight = 57.44501F;
            this.Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cargar.HeaderText = "";
            this.Cargar.Name = "Cargar";
            this.Cargar.ReadOnly = true;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseColumnTextForButtonValue = true;
            this.Cargar.Width = 80;
            // 
            // Archivar
            // 
            this.Archivar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Archivar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Archivar.FillWeight = 57.44501F;
            this.Archivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Archivar.HeaderText = "";
            this.Archivar.Name = "Archivar";
            this.Archivar.ReadOnly = true;
            this.Archivar.Text = "Archivar";
            this.Archivar.UseColumnTextForButtonValue = true;
            this.Archivar.Width = 80;
            // 
            // btnCambios
            // 
            this.btnCambios.AllowAnimations = true;
            this.btnCambios.AllowMouseEffects = true;
            this.btnCambios.AllowToggling = false;
            this.btnCambios.AnimationSpeed = 200;
            this.btnCambios.AutoGenerateColors = false;
            this.btnCambios.AutoRoundBorders = false;
            this.btnCambios.AutoSizeLeftIcon = true;
            this.btnCambios.AutoSizeRightIcon = true;
            this.btnCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnCambios.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnCambios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambios.BackgroundImage")));
            this.btnCambios.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCambios.ButtonText = "Guardar Cambios";
            this.btnCambios.ButtonTextMarginLeft = 0;
            this.btnCambios.ColorContrastOnClick = 45;
            this.btnCambios.ColorContrastOnHover = 45;
            this.btnCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCambios.CustomizableEdges = borderEdges1;
            this.btnCambios.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCambios.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCambios.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCambios.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCambios.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCambios.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCambios.ForeColor = System.Drawing.Color.White;
            this.btnCambios.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambios.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambios.IconLeftPadding = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.btnCambios.IconMarginLeft = 11;
            this.btnCambios.IconPadding = 10;
            this.btnCambios.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambios.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambios.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCambios.IconSize = 25;
            this.btnCambios.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCambios.IdleBorderRadius = 10;
            this.btnCambios.IdleBorderThickness = 1;
            this.btnCambios.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnCambios.IdleIconLeftImage = null;
            this.btnCambios.IdleIconRightImage = null;
            this.btnCambios.IndicateFocus = false;
            this.btnCambios.Location = new System.Drawing.Point(104, 359);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCambios.OnDisabledState.BorderRadius = 10;
            this.btnCambios.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCambios.OnDisabledState.BorderThickness = 1;
            this.btnCambios.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCambios.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCambios.OnDisabledState.IconLeftImage = null;
            this.btnCambios.OnDisabledState.IconRightImage = null;
            this.btnCambios.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCambios.onHoverState.BorderRadius = 10;
            this.btnCambios.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCambios.onHoverState.BorderThickness = 1;
            this.btnCambios.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCambios.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCambios.onHoverState.IconLeftImage = null;
            this.btnCambios.onHoverState.IconRightImage = null;
            this.btnCambios.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCambios.OnIdleState.BorderRadius = 10;
            this.btnCambios.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCambios.OnIdleState.BorderThickness = 1;
            this.btnCambios.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCambios.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCambios.OnIdleState.IconLeftImage = null;
            this.btnCambios.OnIdleState.IconRightImage = null;
            this.btnCambios.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCambios.OnPressedState.BorderRadius = 10;
            this.btnCambios.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCambios.OnPressedState.BorderThickness = 1;
            this.btnCambios.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCambios.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCambios.OnPressedState.IconLeftImage = null;
            this.btnCambios.OnPressedState.IconRightImage = null;
            this.btnCambios.Size = new System.Drawing.Size(175, 50);
            this.btnCambios.TabIndex = 21;
            this.btnCambios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCambios.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCambios.TextMarginLeft = 0;
            this.btnCambios.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCambios.UseDefaultRadiusAndThickness = true;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // Proveedores_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1042, 482);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnDatos);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Proveedores_Frm";
            this.Text = "Proveedores_Frm";
            this.Load += new System.EventHandler(this.Proveedores_Frm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.TextBox txtTelefono;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.TextBox txtCorreo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel pnDatos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGuardar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewButtonColumn Cargar;
        private System.Windows.Forms.DataGridViewButtonColumn Archivar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCambios;
    }
}