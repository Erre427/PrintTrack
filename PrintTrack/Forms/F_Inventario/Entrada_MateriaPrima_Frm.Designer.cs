namespace PrintTrack.Forms.F_Inventario
{
    partial class Entrada_MateriaPrima_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada_MateriaPrima_Frm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRecibo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.numCosto = new System.Windows.Forms.NumericUpDown();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 88);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintTrack.Properties.Resources.entrada;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.bunifuLabel1.Size = new System.Drawing.Size(328, 50);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Entrada de material";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtRecibo);
            this.panel2.Controls.Add(this.bunifuLabel3);
            this.panel2.Controls.Add(this.bunifuLabel2);
            this.panel2.Controls.Add(this.numCosto);
            this.panel2.Controls.Add(this.bunifuLabel6);
            this.panel2.Controls.Add(this.numCantidad);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 228);
            this.panel2.TabIndex = 1;
            // 
            // txtRecibo
            // 
            this.txtRecibo.AcceptsReturn = false;
            this.txtRecibo.AcceptsTab = false;
            this.txtRecibo.AnimationSpeed = 200;
            this.txtRecibo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRecibo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRecibo.BackColor = System.Drawing.Color.Transparent;
            this.txtRecibo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtRecibo.BackgroundImage")));
            this.txtRecibo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtRecibo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtRecibo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtRecibo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtRecibo.BorderRadius = 5;
            this.txtRecibo.BorderThickness = 1;
            this.txtRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRecibo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecibo.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtRecibo.DefaultText = "";
            this.txtRecibo.FillColor = System.Drawing.Color.White;
            this.txtRecibo.HideSelection = true;
            this.txtRecibo.IconLeft = null;
            this.txtRecibo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecibo.IconPadding = 10;
            this.txtRecibo.IconRight = null;
            this.txtRecibo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecibo.Lines = new string[0];
            this.txtRecibo.Location = new System.Drawing.Point(100, 162);
            this.txtRecibo.MaxLength = 32767;
            this.txtRecibo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtRecibo.Modified = false;
            this.txtRecibo.Multiline = false;
            this.txtRecibo.Name = "txtRecibo";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRecibo.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtRecibo.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRecibo.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRecibo.OnIdleState = stateProperties4;
            this.txtRecibo.Padding = new System.Windows.Forms.Padding(3);
            this.txtRecibo.PasswordChar = '\0';
            this.txtRecibo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtRecibo.PlaceholderText = "Numero de recibo o factura de compra";
            this.txtRecibo.ReadOnly = false;
            this.txtRecibo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecibo.SelectedText = "";
            this.txtRecibo.SelectionLength = 0;
            this.txtRecibo.SelectionStart = 0;
            this.txtRecibo.ShortcutsEnabled = true;
            this.txtRecibo.Size = new System.Drawing.Size(262, 37);
            this.txtRecibo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtRecibo.TabIndex = 30;
            this.txtRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRecibo.TextMarginBottom = 0;
            this.txtRecibo.TextMarginLeft = 3;
            this.txtRecibo.TextMarginTop = 0;
            this.txtRecibo.TextPlaceholder = "Numero de recibo o factura de compra";
            this.txtRecibo.UseSystemPasswordChar = false;
            this.txtRecibo.WordWrap = true;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(148, 135);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(158, 21);
            this.bunifuLabel3.TabIndex = 29;
            this.bunifuLabel3.Text = "# de Recibo o Factura";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(133, 74);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(203, 21);
            this.bunifuLabel2.TabIndex = 27;
            this.bunifuLabel2.Text = "Costo unitario del producto";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // numCosto
            // 
            this.numCosto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCosto.Location = new System.Drawing.Point(167, 104);
            this.numCosto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCosto.Name = "numCosto";
            this.numCosto.Size = new System.Drawing.Size(120, 23);
            this.numCosto.TabIndex = 26;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel6.Location = new System.Drawing.Point(167, 18);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(125, 21);
            this.bunifuLabel6.TabIndex = 25;
            this.bunifuLabel6.Text = "Cantidad a entrar";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(167, 45);
            this.numCantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 23);
            this.numCantidad.TabIndex = 24;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AllowAnimations = true;
            this.btnRegistrar.AllowMouseEffects = true;
            this.btnRegistrar.AllowToggling = false;
            this.btnRegistrar.AnimationSpeed = 200;
            this.btnRegistrar.AutoGenerateColors = false;
            this.btnRegistrar.AutoRoundBorders = false;
            this.btnRegistrar.AutoSizeLeftIcon = true;
            this.btnRegistrar.AutoSizeRightIcon = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.ButtonText = "Registrar Entrada";
            this.btnRegistrar.ButtonTextMarginLeft = 0;
            this.btnRegistrar.ColorContrastOnClick = 45;
            this.btnRegistrar.ColorContrastOnHover = 45;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRegistrar.CustomizableEdges = borderEdges1;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegistrar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegistrar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegistrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.IconLeftPadding = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.btnRegistrar.IconMarginLeft = 11;
            this.btnRegistrar.IconPadding = 10;
            this.btnRegistrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegistrar.IconSize = 25;
            this.btnRegistrar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrar.IdleBorderRadius = 10;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.IdleIconLeftImage = null;
            this.btnRegistrar.IdleIconRightImage = null;
            this.btnRegistrar.IndicateFocus = false;
            this.btnRegistrar.Location = new System.Drawing.Point(161, 345);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegistrar.OnDisabledState.BorderRadius = 10;
            this.btnRegistrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.OnDisabledState.BorderThickness = 1;
            this.btnRegistrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegistrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegistrar.OnDisabledState.IconLeftImage = null;
            this.btnRegistrar.OnDisabledState.IconRightImage = null;
            this.btnRegistrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRegistrar.onHoverState.BorderRadius = 10;
            this.btnRegistrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.onHoverState.BorderThickness = 1;
            this.btnRegistrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRegistrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.onHoverState.IconLeftImage = null;
            this.btnRegistrar.onHoverState.IconRightImage = null;
            this.btnRegistrar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrar.OnIdleState.BorderRadius = 10;
            this.btnRegistrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.OnIdleState.BorderThickness = 1;
            this.btnRegistrar.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnIdleState.IconLeftImage = null;
            this.btnRegistrar.OnIdleState.IconRightImage = null;
            this.btnRegistrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegistrar.OnPressedState.BorderRadius = 10;
            this.btnRegistrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.OnPressedState.BorderThickness = 1;
            this.btnRegistrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegistrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnPressedState.IconLeftImage = null;
            this.btnRegistrar.OnPressedState.IconRightImage = null;
            this.btnRegistrar.Size = new System.Drawing.Size(173, 50);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.TextMarginLeft = 0;
            this.btnRegistrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.UseDefaultRadiusAndThickness = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Entrada_MateriaPrima_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 407);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Entrada_MateriaPrima_Frm";
            this.Text = "Entrada_MateriaPrima_Frm";
            this.Load += new System.EventHandler(this.Entrada_MateriaPrima_Frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegistrar;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.NumericUpDown numCosto;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuTextBox txtRecibo;
    }
}