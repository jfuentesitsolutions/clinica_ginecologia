namespace clinica.Login
{
    partial class login_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_inicio));
            this.panel_encabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblRegistro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtcontra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.chkGuarda = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblGuarda = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_encabezado
            // 
            this.panel_encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panel_encabezado.Controls.Add(this.pictureBox1);
            this.panel_encabezado.Controls.Add(this.bunifuCustomLabel2);
            this.panel_encabezado.Controls.Add(this.bunifuCustomLabel1);
            this.panel_encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_encabezado.Location = new System.Drawing.Point(0, 0);
            this.panel_encabezado.Name = "panel_encabezado";
            this.panel_encabezado.Size = new System.Drawing.Size(284, 59);
            this.panel_encabezado.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::clinica.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(249, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(99, 40);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(146, 18);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = " La Sagrada Familia";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(100, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 35);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Clinica";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Ingrese el usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(13, 115);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 44);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.lblRegistro.Location = new System.Drawing.Point(97, 289);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(83, 13);
            this.lblRegistro.TabIndex = 7;
            this.lblRegistro.Text = "Registra usuario";
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::clinica.Properties.Resources.embara2;
            this.pictureBox2.Location = new System.Drawing.Point(3, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.ActiveBorderThickness = 1;
            this.btnIngresar.ActiveCornerRadius = 20;
            this.btnIngresar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.btnIngresar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnIngresar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.ButtonText = "Ingresar";
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnIngresar.IdleBorderThickness = 1;
            this.btnIngresar.IdleCornerRadius = 20;
            this.btnIngresar.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnIngresar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnIngresar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnIngresar.Location = new System.Drawing.Point(49, 243);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(181, 41);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.TabStop = false;
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtcontra
            // 
            this.txtcontra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcontra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontra.HintForeColor = System.Drawing.Color.Empty;
            this.txtcontra.HintText = "";
            this.txtcontra.isPassword = true;
            this.txtcontra.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtcontra.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtcontra.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtcontra.LineThickness = 3;
            this.txtcontra.Location = new System.Drawing.Point(13, 160);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(253, 44);
            this.txtcontra.TabIndex = 9;
            this.txtcontra.Text = "000";
            this.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // chkGuarda
            // 
            this.chkGuarda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.chkGuarda.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.chkGuarda.Checked = false;
            this.chkGuarda.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.chkGuarda.ForeColor = System.Drawing.Color.White;
            this.chkGuarda.Location = new System.Drawing.Point(246, 211);
            this.chkGuarda.Name = "chkGuarda";
            this.chkGuarda.Size = new System.Drawing.Size(20, 20);
            this.chkGuarda.TabIndex = 10;
            // 
            // lblGuarda
            // 
            this.lblGuarda.AutoSize = true;
            this.lblGuarda.Location = new System.Drawing.Point(169, 214);
            this.lblGuarda.Name = "lblGuarda";
            this.lblGuarda.Size = new System.Drawing.Size(74, 13);
            this.lblGuarda.TabIndex = 11;
            this.lblGuarda.Text = "Guardar datos";
            // 
            // login_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.lblGuarda);
            this.Controls.Add(this.chkGuarda);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.panel_encabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_inicio";
            this.Load += new System.EventHandler(this.login_inicio_Load);
            this.panel_encabezado.ResumeLayout(false);
            this.panel_encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_encabezado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIngresar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRegistro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcontra;
        private Bunifu.Framework.UI.BunifuCheckbox chkGuarda;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGuarda;
    }
}