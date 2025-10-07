namespace PrintTrack.Forms
{
    partial class MenuFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.btnDashBoard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnConfiguracion = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPerfil = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProductos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClientes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCaja = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrarSesionBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.plecaInfo = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plecaInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(190, 31);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1160, 714);
            this.panelContenedor.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu.Controls.Add(this.btnDashBoard);
            this.menu.Controls.Add(this.btnConfiguracion);
            this.menu.Controls.Add(this.btnPerfil);
            this.menu.Controls.Add(this.btnProductos);
            this.menu.Controls.Add(this.btnClientes);
            this.menu.Controls.Add(this.btnCaja);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Controls.Add(this.cerrarSesionBtn);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(190, 745);
            this.menu.TabIndex = 1;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.AllowAnimations = true;
            this.btnDashBoard.AllowMouseEffects = true;
            this.btnDashBoard.AllowToggling = false;
            this.btnDashBoard.AnimationSpeed = 200;
            this.btnDashBoard.AutoGenerateColors = false;
            this.btnDashBoard.AutoRoundBorders = false;
            this.btnDashBoard.AutoSizeLeftIcon = true;
            this.btnDashBoard.AutoSizeRightIcon = true;
            this.btnDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnDashBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.BackgroundImage")));
            this.btnDashBoard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.ButtonText = "Dashboard";
            this.btnDashBoard.ButtonTextMarginLeft = 0;
            this.btnDashBoard.ColorContrastOnClick = 45;
            this.btnDashBoard.ColorContrastOnHover = 45;
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDashBoard.CustomizableEdges = borderEdges1;
            this.btnDashBoard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashBoard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashBoard.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashBoard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashBoard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDashBoard.IconMarginLeft = 11;
            this.btnDashBoard.IconPadding = 10;
            this.btnDashBoard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashBoard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashBoard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashBoard.IconSize = 25;
            this.btnDashBoard.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDashBoard.IdleBorderRadius = 1;
            this.btnDashBoard.IdleBorderThickness = 1;
            this.btnDashBoard.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnDashBoard.IdleIconLeftImage = global::PrintTrack.Properties.Resources.icons8_tablero_100;
            this.btnDashBoard.IdleIconRightImage = null;
            this.btnDashBoard.IndicateFocus = false;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 137);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashBoard.OnDisabledState.BorderRadius = 1;
            this.btnDashBoard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.OnDisabledState.BorderThickness = 1;
            this.btnDashBoard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashBoard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashBoard.OnDisabledState.IconLeftImage = null;
            this.btnDashBoard.OnDisabledState.IconRightImage = null;
            this.btnDashBoard.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDashBoard.onHoverState.BorderRadius = 1;
            this.btnDashBoard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.onHoverState.BorderThickness = 1;
            this.btnDashBoard.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDashBoard.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.onHoverState.IconLeftImage = null;
            this.btnDashBoard.onHoverState.IconRightImage = null;
            this.btnDashBoard.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDashBoard.OnIdleState.BorderRadius = 1;
            this.btnDashBoard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.OnIdleState.BorderThickness = 1;
            this.btnDashBoard.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDashBoard.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.OnIdleState.IconLeftImage = global::PrintTrack.Properties.Resources.icons8_tablero_100;
            this.btnDashBoard.OnIdleState.IconRightImage = null;
            this.btnDashBoard.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDashBoard.OnPressedState.BorderRadius = 1;
            this.btnDashBoard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashBoard.OnPressedState.BorderThickness = 1;
            this.btnDashBoard.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDashBoard.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.OnPressedState.IconLeftImage = null;
            this.btnDashBoard.OnPressedState.IconRightImage = null;
            this.btnDashBoard.Size = new System.Drawing.Size(190, 54);
            this.btnDashBoard.TabIndex = 14;
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashBoard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashBoard.TextMarginLeft = 0;
            this.btnDashBoard.TextPadding = new System.Windows.Forms.Padding(30, -1, 0, 0);
            this.btnDashBoard.UseDefaultRadiusAndThickness = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.AllowAnimations = true;
            this.btnConfiguracion.AllowMouseEffects = true;
            this.btnConfiguracion.AllowToggling = false;
            this.btnConfiguracion.AnimationSpeed = 200;
            this.btnConfiguracion.AutoGenerateColors = false;
            this.btnConfiguracion.AutoRoundBorders = false;
            this.btnConfiguracion.AutoSizeLeftIcon = true;
            this.btnConfiguracion.AutoSizeRightIcon = true;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.BackgroundImage")));
            this.btnConfiguracion.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfiguracion.ButtonText = "Configuracion";
            this.btnConfiguracion.ButtonTextMarginLeft = 0;
            this.btnConfiguracion.ColorContrastOnClick = 45;
            this.btnConfiguracion.ColorContrastOnHover = 45;
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnConfiguracion.CustomizableEdges = borderEdges2;
            this.btnConfiguracion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfiguracion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfiguracion.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfiguracion.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfiguracion.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfiguracion.IconMarginLeft = 11;
            this.btnConfiguracion.IconPadding = 10;
            this.btnConfiguracion.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracion.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfiguracion.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfiguracion.IconSize = 25;
            this.btnConfiguracion.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConfiguracion.IdleBorderRadius = 1;
            this.btnConfiguracion.IdleBorderThickness = 1;
            this.btnConfiguracion.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnConfiguracion.IdleIconLeftImage = null;
            this.btnConfiguracion.IdleIconRightImage = null;
            this.btnConfiguracion.IndicateFocus = false;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 437);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfiguracion.OnDisabledState.BorderRadius = 1;
            this.btnConfiguracion.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfiguracion.OnDisabledState.BorderThickness = 1;
            this.btnConfiguracion.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfiguracion.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfiguracion.OnDisabledState.IconLeftImage = null;
            this.btnConfiguracion.OnDisabledState.IconRightImage = null;
            this.btnConfiguracion.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfiguracion.onHoverState.BorderRadius = 1;
            this.btnConfiguracion.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfiguracion.onHoverState.BorderThickness = 1;
            this.btnConfiguracion.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfiguracion.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.onHoverState.IconLeftImage = null;
            this.btnConfiguracion.onHoverState.IconRightImage = null;
            this.btnConfiguracion.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConfiguracion.OnIdleState.BorderRadius = 1;
            this.btnConfiguracion.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfiguracion.OnIdleState.BorderThickness = 1;
            this.btnConfiguracion.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnConfiguracion.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.OnIdleState.IconLeftImage = null;
            this.btnConfiguracion.OnIdleState.IconRightImage = null;
            this.btnConfiguracion.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfiguracion.OnPressedState.BorderRadius = 1;
            this.btnConfiguracion.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfiguracion.OnPressedState.BorderThickness = 1;
            this.btnConfiguracion.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfiguracion.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.OnPressedState.IconLeftImage = null;
            this.btnConfiguracion.OnPressedState.IconRightImage = null;
            this.btnConfiguracion.Size = new System.Drawing.Size(189, 54);
            this.btnConfiguracion.TabIndex = 13;
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfiguracion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfiguracion.TextMarginLeft = 0;
            this.btnConfiguracion.TextPadding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConfiguracion.UseDefaultRadiusAndThickness = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.AllowAnimations = true;
            this.btnPerfil.AllowMouseEffects = true;
            this.btnPerfil.AllowToggling = false;
            this.btnPerfil.AnimationSpeed = 200;
            this.btnPerfil.AutoGenerateColors = false;
            this.btnPerfil.AutoRoundBorders = false;
            this.btnPerfil.AutoSizeLeftIcon = true;
            this.btnPerfil.AutoSizeRightIcon = true;
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerfil.ButtonText = "Perfil";
            this.btnPerfil.ButtonTextMarginLeft = 0;
            this.btnPerfil.ColorContrastOnClick = 45;
            this.btnPerfil.ColorContrastOnHover = 45;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnPerfil.CustomizableEdges = borderEdges3;
            this.btnPerfil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPerfil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPerfil.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPerfil.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPerfil.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPerfil.IconMarginLeft = 11;
            this.btnPerfil.IconPadding = 10;
            this.btnPerfil.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfil.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPerfil.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPerfil.IconSize = 25;
            this.btnPerfil.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPerfil.IdleBorderRadius = 1;
            this.btnPerfil.IdleBorderThickness = 1;
            this.btnPerfil.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.IdleIconLeftImage = null;
            this.btnPerfil.IdleIconRightImage = null;
            this.btnPerfil.IndicateFocus = false;
            this.btnPerfil.Location = new System.Drawing.Point(0, 377);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPerfil.OnDisabledState.BorderRadius = 1;
            this.btnPerfil.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerfil.OnDisabledState.BorderThickness = 1;
            this.btnPerfil.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPerfil.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPerfil.OnDisabledState.IconLeftImage = null;
            this.btnPerfil.OnDisabledState.IconRightImage = null;
            this.btnPerfil.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPerfil.onHoverState.BorderRadius = 1;
            this.btnPerfil.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerfil.onHoverState.BorderThickness = 1;
            this.btnPerfil.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPerfil.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.onHoverState.IconLeftImage = null;
            this.btnPerfil.onHoverState.IconRightImage = null;
            this.btnPerfil.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPerfil.OnIdleState.BorderRadius = 1;
            this.btnPerfil.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerfil.OnIdleState.BorderThickness = 1;
            this.btnPerfil.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.OnIdleState.IconLeftImage = null;
            this.btnPerfil.OnIdleState.IconRightImage = null;
            this.btnPerfil.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPerfil.OnPressedState.BorderRadius = 1;
            this.btnPerfil.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPerfil.OnPressedState.BorderThickness = 1;
            this.btnPerfil.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPerfil.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.OnPressedState.IconLeftImage = null;
            this.btnPerfil.OnPressedState.IconRightImage = null;
            this.btnPerfil.Size = new System.Drawing.Size(189, 54);
            this.btnPerfil.TabIndex = 12;
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPerfil.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPerfil.TextMarginLeft = 0;
            this.btnPerfil.TextPadding = new System.Windows.Forms.Padding(53, 0, 0, 0);
            this.btnPerfil.UseDefaultRadiusAndThickness = true;
            // 
            // btnProductos
            // 
            this.btnProductos.AllowAnimations = true;
            this.btnProductos.AllowMouseEffects = true;
            this.btnProductos.AllowToggling = false;
            this.btnProductos.AnimationSpeed = 200;
            this.btnProductos.AutoGenerateColors = false;
            this.btnProductos.AutoRoundBorders = false;
            this.btnProductos.AutoSizeLeftIcon = true;
            this.btnProductos.AutoSizeRightIcon = true;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.BackgroundImage")));
            this.btnProductos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.ButtonText = "Productos";
            this.btnProductos.ButtonTextMarginLeft = 0;
            this.btnProductos.ColorContrastOnClick = 45;
            this.btnProductos.ColorContrastOnHover = 45;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnProductos.CustomizableEdges = borderEdges4;
            this.btnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProductos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProductos.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProductos.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProductos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProductos.IconMarginLeft = 11;
            this.btnProductos.IconPadding = 10;
            this.btnProductos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProductos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProductos.IconSize = 25;
            this.btnProductos.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnProductos.IdleBorderRadius = 1;
            this.btnProductos.IdleBorderThickness = 1;
            this.btnProductos.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnProductos.IdleIconLeftImage = null;
            this.btnProductos.IdleIconRightImage = null;
            this.btnProductos.IndicateFocus = false;
            this.btnProductos.Location = new System.Drawing.Point(0, 317);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProductos.OnDisabledState.BorderRadius = 1;
            this.btnProductos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnDisabledState.BorderThickness = 1;
            this.btnProductos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProductos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProductos.OnDisabledState.IconLeftImage = null;
            this.btnProductos.OnDisabledState.IconRightImage = null;
            this.btnProductos.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnProductos.onHoverState.BorderRadius = 1;
            this.btnProductos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.onHoverState.BorderThickness = 1;
            this.btnProductos.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnProductos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.onHoverState.IconLeftImage = null;
            this.btnProductos.onHoverState.IconRightImage = null;
            this.btnProductos.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnProductos.OnIdleState.BorderRadius = 1;
            this.btnProductos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnIdleState.BorderThickness = 1;
            this.btnProductos.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnProductos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.OnIdleState.IconLeftImage = null;
            this.btnProductos.OnIdleState.IconRightImage = null;
            this.btnProductos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnProductos.OnPressedState.BorderRadius = 1;
            this.btnProductos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnPressedState.BorderThickness = 1;
            this.btnProductos.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnProductos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.OnPressedState.IconLeftImage = null;
            this.btnProductos.OnPressedState.IconRightImage = null;
            this.btnProductos.Size = new System.Drawing.Size(189, 54);
            this.btnProductos.TabIndex = 11;
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProductos.TextMarginLeft = 0;
            this.btnProductos.TextPadding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnProductos.UseDefaultRadiusAndThickness = true;
            // 
            // btnClientes
            // 
            this.btnClientes.AllowAnimations = true;
            this.btnClientes.AllowMouseEffects = true;
            this.btnClientes.AllowToggling = false;
            this.btnClientes.AnimationSpeed = 200;
            this.btnClientes.AutoGenerateColors = false;
            this.btnClientes.AutoRoundBorders = false;
            this.btnClientes.AutoSizeLeftIcon = true;
            this.btnClientes.AutoSizeRightIcon = true;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.ButtonTextMarginLeft = 0;
            this.btnClientes.ColorContrastOnClick = 45;
            this.btnClientes.ColorContrastOnHover = 45;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnClientes.CustomizableEdges = borderEdges5;
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClientes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClientes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClientes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClientes.IconMarginLeft = 11;
            this.btnClientes.IconPadding = 10;
            this.btnClientes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClientes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClientes.IconSize = 25;
            this.btnClientes.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.IdleBorderRadius = 1;
            this.btnClientes.IdleBorderThickness = 1;
            this.btnClientes.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnClientes.IdleIconLeftImage = null;
            this.btnClientes.IdleIconRightImage = null;
            this.btnClientes.IndicateFocus = false;
            this.btnClientes.Location = new System.Drawing.Point(0, 257);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClientes.OnDisabledState.BorderRadius = 1;
            this.btnClientes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnDisabledState.BorderThickness = 1;
            this.btnClientes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClientes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClientes.OnDisabledState.IconLeftImage = null;
            this.btnClientes.OnDisabledState.IconRightImage = null;
            this.btnClientes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClientes.onHoverState.BorderRadius = 1;
            this.btnClientes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.onHoverState.BorderThickness = 1;
            this.btnClientes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClientes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.onHoverState.IconLeftImage = null;
            this.btnClientes.onHoverState.IconRightImage = null;
            this.btnClientes.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.OnIdleState.BorderRadius = 1;
            this.btnClientes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnIdleState.BorderThickness = 1;
            this.btnClientes.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnClientes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.OnIdleState.IconLeftImage = null;
            this.btnClientes.OnIdleState.IconRightImage = null;
            this.btnClientes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClientes.OnPressedState.BorderRadius = 1;
            this.btnClientes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnPressedState.BorderThickness = 1;
            this.btnClientes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClientes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.OnPressedState.IconLeftImage = null;
            this.btnClientes.OnPressedState.IconRightImage = null;
            this.btnClientes.Size = new System.Drawing.Size(189, 54);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClientes.TextMarginLeft = 0;
            this.btnClientes.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnClientes.UseDefaultRadiusAndThickness = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.AllowAnimations = true;
            this.btnCaja.AllowMouseEffects = true;
            this.btnCaja.AllowToggling = false;
            this.btnCaja.AnimationSpeed = 200;
            this.btnCaja.AutoGenerateColors = false;
            this.btnCaja.AutoRoundBorders = false;
            this.btnCaja.AutoSizeLeftIcon = true;
            this.btnCaja.AutoSizeRightIcon = true;
            this.btnCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCaja.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnCaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCaja.BackgroundImage")));
            this.btnCaja.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCaja.ButtonText = "Caja";
            this.btnCaja.ButtonTextMarginLeft = 0;
            this.btnCaja.ColorContrastOnClick = 45;
            this.btnCaja.ColorContrastOnHover = 45;
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnCaja.CustomizableEdges = borderEdges6;
            this.btnCaja.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCaja.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCaja.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCaja.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCaja.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCaja.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaja.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCaja.IconMarginLeft = 11;
            this.btnCaja.IconPadding = 10;
            this.btnCaja.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaja.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaja.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCaja.IconSize = 25;
            this.btnCaja.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCaja.IdleBorderRadius = 1;
            this.btnCaja.IdleBorderThickness = 1;
            this.btnCaja.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnCaja.IdleIconLeftImage = null;
            this.btnCaja.IdleIconRightImage = null;
            this.btnCaja.IndicateFocus = false;
            this.btnCaja.Location = new System.Drawing.Point(0, 197);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCaja.OnDisabledState.BorderRadius = 1;
            this.btnCaja.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCaja.OnDisabledState.BorderThickness = 1;
            this.btnCaja.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCaja.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCaja.OnDisabledState.IconLeftImage = null;
            this.btnCaja.OnDisabledState.IconRightImage = null;
            this.btnCaja.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCaja.onHoverState.BorderRadius = 1;
            this.btnCaja.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCaja.onHoverState.BorderThickness = 1;
            this.btnCaja.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCaja.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCaja.onHoverState.IconLeftImage = null;
            this.btnCaja.onHoverState.IconRightImage = null;
            this.btnCaja.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCaja.OnIdleState.BorderRadius = 1;
            this.btnCaja.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCaja.OnIdleState.BorderThickness = 1;
            this.btnCaja.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCaja.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCaja.OnIdleState.IconLeftImage = null;
            this.btnCaja.OnIdleState.IconRightImage = null;
            this.btnCaja.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCaja.OnPressedState.BorderRadius = 1;
            this.btnCaja.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCaja.OnPressedState.BorderThickness = 1;
            this.btnCaja.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCaja.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCaja.OnPressedState.IconLeftImage = null;
            this.btnCaja.OnPressedState.IconRightImage = null;
            this.btnCaja.Size = new System.Drawing.Size(189, 54);
            this.btnCaja.TabIndex = 9;
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCaja.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCaja.TextMarginLeft = 0;
            this.btnCaja.TextPadding = new System.Windows.Forms.Padding(55, -1, 0, 0);
            this.btnCaja.UseDefaultRadiusAndThickness = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintTrack.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cerrarSesionBtn
            // 
            this.cerrarSesionBtn.ActiveBorderThickness = 1;
            this.cerrarSesionBtn.ActiveCornerRadius = 20;
            this.cerrarSesionBtn.ActiveFillColor = System.Drawing.Color.Red;
            this.cerrarSesionBtn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.cerrarSesionBtn.ActiveLineColor = System.Drawing.Color.Red;
            this.cerrarSesionBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.cerrarSesionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrarSesionBtn.BackgroundImage")));
            this.cerrarSesionBtn.ButtonText = "Cerrar Sesion";
            this.cerrarSesionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarSesionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionBtn.ForeColor = System.Drawing.Color.Red;
            this.cerrarSesionBtn.IdleBorderThickness = 1;
            this.cerrarSesionBtn.IdleCornerRadius = 20;
            this.cerrarSesionBtn.IdleFillColor = System.Drawing.Color.White;
            this.cerrarSesionBtn.IdleForecolor = System.Drawing.Color.Red;
            this.cerrarSesionBtn.IdleLineColor = System.Drawing.Color.Red;
            this.cerrarSesionBtn.Location = new System.Drawing.Point(9, 691);
            this.cerrarSesionBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cerrarSesionBtn.Name = "cerrarSesionBtn";
            this.cerrarSesionBtn.Size = new System.Drawing.Size(173, 40);
            this.cerrarSesionBtn.TabIndex = 8;
            this.cerrarSesionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cerrarSesionBtn.Click += new System.EventHandler(this.cerrarSesionBtn_Click);
            // 
            // plecaInfo
            // 
            this.plecaInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plecaInfo.Controls.Add(this.lblHora);
            this.plecaInfo.Controls.Add(this.lblDia);
            this.plecaInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plecaInfo.Location = new System.Drawing.Point(190, 0);
            this.plecaInfo.Name = "plecaInfo";
            this.plecaInfo.Size = new System.Drawing.Size(1160, 31);
            this.plecaInfo.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1067, 6);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(71, 19);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "hh:mm:ss";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(19, 6);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(109, 19);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia, mes y Año";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 745);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.plecaInfo);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintTrack - Punto de Venta 2025";
            this.Load += new System.EventHandler(this.MenuFrm_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plecaInfo.ResumeLayout(false);
            this.plecaInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuThinButton2 cerrarSesionBtn;
        private System.Windows.Forms.Panel menu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCaja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProductos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClientes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfiguracion;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPerfil;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashBoard;
        private System.Windows.Forms.Panel plecaInfo;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}