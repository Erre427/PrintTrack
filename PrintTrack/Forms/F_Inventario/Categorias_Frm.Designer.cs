namespace PrintTrack.Forms.F_Inventario
{
    partial class Categorias_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias_Frm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnNuevo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 88);
            this.panel1.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(95, 18);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(410, 50);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Categorias de productos";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.btnNuevo.ButtonText = "Nueva Categoria";
            this.btnNuevo.ButtonTextMarginLeft = 0;
            this.btnNuevo.ColorContrastOnClick = 45;
            this.btnNuevo.ColorContrastOnHover = 45;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNuevo.CustomizableEdges = borderEdges1;
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
            this.btnNuevo.Location = new System.Drawing.Point(360, 396);
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
            this.btnNuevo.Size = new System.Drawing.Size(173, 50);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.TextMarginLeft = 0;
            this.btnNuevo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNuevo.UseDefaultRadiusAndThickness = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintTrack.Properties.Resources.categoria;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Detalles});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.Location = new System.Drawing.Point(16, 106);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCategorias.RowHeadersWidth = 40;
            this.dgvCategorias.RowTemplate.Height = 40;
            this.dgvCategorias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.Size = new System.Drawing.Size(517, 276);
            this.dgvCategorias.TabIndex = 22;
            // 
            // id
            // 
            this.id.DataPropertyName = "idCategoria";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCategoria";
            this.Nombre.FillWeight = 57.44501F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Detalles
            // 
            this.Detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            this.Detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.Detalles.FillWeight = 355.33F;
            this.Detalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Detalles.HeaderText = "";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Text = "Detalles";
            this.Detalles.UseColumnTextForButtonValue = true;
            this.Detalles.Width = 80;
            // 
            // Categorias_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 458);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Categorias_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias_Frm";
            this.Load += new System.EventHandler(this.Categorias_Frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNuevo;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
    }
}