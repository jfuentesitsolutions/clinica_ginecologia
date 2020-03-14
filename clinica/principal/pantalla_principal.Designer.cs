namespace clinica.principal
{
    partial class pantalla_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_principal));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_encabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.btnConfiguraciones = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMedicos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_pacientes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::clinica.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(728, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::clinica.Properties.Resources.embara2;
            this.pictureBox2.Location = new System.Drawing.Point(37, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel_encabezado
            // 
            this.panel_encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panel_encabezado.Controls.Add(this.pictureBox1);
            this.panel_encabezado.Controls.Add(this.lblTitulo);
            this.panel_encabezado.Controls.Add(this.bunifuCustomLabel1);
            this.panel_encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_encabezado.Location = new System.Drawing.Point(169, 0);
            this.panel_encabezado.Name = "panel_encabezado";
            this.panel_encabezado.Size = new System.Drawing.Size(594, 80);
            this.panel_encabezado.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::clinica.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(558, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(8, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 18);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = " La Sagrada Familia";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 35);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Clinica";
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.SystemColors.Control;
            this.panel_lateral.Controls.Add(this.btnConfiguraciones);
            this.panel_lateral.Controls.Add(this.bunifuThinButton24);
            this.panel_lateral.Controls.Add(this.bunifuThinButton23);
            this.panel_lateral.Controls.Add(this.btnMedicos);
            this.panel_lateral.Controls.Add(this.btn_pacientes);
            this.panel_lateral.Controls.Add(this.pictureBox2);
            this.panel_lateral.Controls.Add(this.panel2);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(169, 531);
            this.panel_lateral.TabIndex = 14;
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.ActiveBorderThickness = 1;
            this.btnConfiguraciones.ActiveCornerRadius = 20;
            this.btnConfiguraciones.ActiveFillColor = System.Drawing.Color.Pink;
            this.btnConfiguraciones.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btnConfiguraciones.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnConfiguraciones.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfiguraciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguraciones.BackgroundImage")));
            this.btnConfiguraciones.ButtonText = "Configuraciones";
            this.btnConfiguraciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguraciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguraciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnConfiguraciones.IdleBorderThickness = 1;
            this.btnConfiguraciones.IdleCornerRadius = 20;
            this.btnConfiguraciones.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btnConfiguraciones.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnConfiguraciones.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnConfiguraciones.Location = new System.Drawing.Point(5, 343);
            this.btnConfiguraciones.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Size = new System.Drawing.Size(159, 41);
            this.btnConfiguraciones.TabIndex = 19;
            this.btnConfiguraciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfiguraciones.Click += new System.EventHandler(this.btnConfiguraciones_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Pink;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Consulta";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.bunifuThinButton24.Location = new System.Drawing.Point(5, 292);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(159, 41);
            this.bunifuThinButton24.TabIndex = 18;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Pink;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Citas";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.bunifuThinButton23.Location = new System.Drawing.Point(5, 241);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(159, 41);
            this.bunifuThinButton23.TabIndex = 17;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMedicos
            // 
            this.btnMedicos.ActiveBorderThickness = 1;
            this.btnMedicos.ActiveCornerRadius = 20;
            this.btnMedicos.ActiveFillColor = System.Drawing.Color.Pink;
            this.btnMedicos.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btnMedicos.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnMedicos.BackColor = System.Drawing.SystemColors.Control;
            this.btnMedicos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedicos.BackgroundImage")));
            this.btnMedicos.ButtonText = "Medicos";
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnMedicos.IdleBorderThickness = 1;
            this.btnMedicos.IdleCornerRadius = 20;
            this.btnMedicos.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btnMedicos.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnMedicos.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnMedicos.Location = new System.Drawing.Point(5, 190);
            this.btnMedicos.Margin = new System.Windows.Forms.Padding(5);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(159, 41);
            this.btnMedicos.TabIndex = 16;
            this.btnMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btn_pacientes
            // 
            this.btn_pacientes.ActiveBorderThickness = 1;
            this.btn_pacientes.ActiveCornerRadius = 20;
            this.btn_pacientes.ActiveFillColor = System.Drawing.Color.Pink;
            this.btn_pacientes.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btn_pacientes.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btn_pacientes.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pacientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pacientes.BackgroundImage")));
            this.btn_pacientes.ButtonText = "Pacientes";
            this.btn_pacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pacientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btn_pacientes.IdleBorderThickness = 1;
            this.btn_pacientes.IdleCornerRadius = 20;
            this.btn_pacientes.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_pacientes.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btn_pacientes.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btn_pacientes.Location = new System.Drawing.Point(5, 139);
            this.btn_pacientes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_pacientes.Name = "btn_pacientes";
            this.btn_pacientes.Size = new System.Drawing.Size(159, 41);
            this.btn_pacientes.TabIndex = 15;
            this.btn_pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pacientes.Click += new System.EventHandler(this.btn_pacientes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 80);
            this.panel2.TabIndex = 14;
            // 
            // pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(763, 531);
            this.Controls.Add(this.panel_encabezado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel_lateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pantalla_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pantalla_principal";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pantalla_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_encabezado.ResumeLayout(false);
            this.panel_encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_encabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_pacientes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfiguraciones;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMedicos;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
    }
}