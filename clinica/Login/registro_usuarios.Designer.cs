namespace clinica.Login
{
    partial class registro_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro_usuarios));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPasos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnDoctor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNumeroJunta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtapellidos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSiguiente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnUsuarios = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaMedicos = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.swEstado = new Bunifu.Framework.UI.BunifuSwitch();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtComentarios = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtContrase = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnDoctor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnUsuarios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 20);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(553, 54);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Hola hemos detectado que no existen configuraciones previas en la base de datos,\r" +
    "\nvamos a configurar la aplicacion.\r\nSiguie los pasos que se te inidican a contin" +
    "uacion.";
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasos.Location = new System.Drawing.Point(19, 95);
            this.lblPasos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(332, 20);
            this.lblPasos.TabIndex = 1;
            this.lblPasos.Text = "Paso 1: Ingresos de la información del medico";
            // 
            // pnDoctor
            // 
            this.pnDoctor.Controls.Add(this.groupBox1);
            this.pnDoctor.Location = new System.Drawing.Point(23, 138);
            this.pnDoctor.Margin = new System.Windows.Forms.Padding(5);
            this.pnDoctor.Name = "pnDoctor";
            this.pnDoctor.Size = new System.Drawing.Size(585, 204);
            this.pnDoctor.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNumeroJunta);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(585, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del medico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCorreo.HintText = "Correo";
            this.txtCorreo.isPassword = false;
            this.txtCorreo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtCorreo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtCorreo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtCorreo.LineThickness = 3;
            this.txtCorreo.Location = new System.Drawing.Point(384, 113);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(174, 44);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "Telefono";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtTelefono.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtTelefono.LineThickness = 3;
            this.txtTelefono.Location = new System.Drawing.Point(195, 113);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(181, 44);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNumeroJunta
            // 
            this.txtNumeroJunta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroJunta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumeroJunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroJunta.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumeroJunta.HintText = "Número de junta";
            this.txtNumeroJunta.isPassword = false;
            this.txtNumeroJunta.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtNumeroJunta.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtNumeroJunta.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtNumeroJunta.LineThickness = 3;
            this.txtNumeroJunta.Location = new System.Drawing.Point(22, 113);
            this.txtNumeroJunta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroJunta.Name = "txtNumeroJunta";
            this.txtNumeroJunta.Size = new System.Drawing.Size(165, 44);
            this.txtNumeroJunta.TabIndex = 8;
            this.txtNumeroJunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtapellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtapellidos.HintForeColor = System.Drawing.Color.Empty;
            this.txtapellidos.HintText = "Apellidos";
            this.txtapellidos.isPassword = false;
            this.txtapellidos.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtapellidos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtapellidos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtapellidos.LineThickness = 3;
            this.txtapellidos.Location = new System.Drawing.Point(302, 37);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(256, 44);
            this.txtapellidos.TabIndex = 7;
            this.txtapellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombres
            // 
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombres.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombres.HintText = "Nombres";
            this.txtNombres.isPassword = false;
            this.txtNombres.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtNombres.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtNombres.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtNombres.LineThickness = 3;
            this.txtNombres.Location = new System.Drawing.Point(22, 37);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(254, 44);
            this.txtNombres.TabIndex = 6;
            this.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.ActiveBorderThickness = 1;
            this.btnSiguiente.ActiveCornerRadius = 20;
            this.btnSiguiente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.btnSiguiente.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnSiguiente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.ButtonText = "Siguiente";
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnSiguiente.IdleBorderThickness = 1;
            this.btnSiguiente.IdleCornerRadius = 20;
            this.btnSiguiente.IdleFillColor = System.Drawing.Color.LavenderBlush;
            this.btnSiguiente.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnSiguiente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnSiguiente.Location = new System.Drawing.Point(488, 389);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(8);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(120, 44);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pnUsuarios
            // 
            this.pnUsuarios.Controls.Add(this.groupBox2);
            this.pnUsuarios.Location = new System.Drawing.Point(23, 140);
            this.pnUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.pnUsuarios.Name = "pnUsuarios";
            this.pnUsuarios.Size = new System.Drawing.Size(585, 239);
            this.pnUsuarios.TabIndex = 6;
            this.pnUsuarios.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaMedicos);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox2.Controls.Add(this.swEstado);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Controls.Add(this.txtComentarios);
            this.groupBox2.Controls.Add(this.fecha);
            this.groupBox2.Controls.Add(this.txtContrase);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(585, 239);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del usuario";
            // 
            // listaMedicos
            // 
            this.listaMedicos.BackColor = System.Drawing.Color.Pink;
            this.listaMedicos.FormattingEnabled = true;
            this.listaMedicos.Location = new System.Drawing.Point(22, 105);
            this.listaMedicos.Name = "listaMedicos";
            this.listaMedicos.Size = new System.Drawing.Size(254, 28);
            this.listaMedicos.TabIndex = 19;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(18, 158);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(103, 20);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Comentarios:";
            // 
            // swEstado
            // 
            this.swEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.swEstado.BorderRadius = 0;
            this.swEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.swEstado.Location = new System.Drawing.Point(404, 194);
            this.swEstado.Name = "swEstado";
            this.swEstado.Oncolor = System.Drawing.Color.Pink;
            this.swEstado.Onoffcolor = System.Drawing.Color.DarkGray;
            this.swEstado.Size = new System.Drawing.Size(51, 19);
            this.swEstado.TabIndex = 17;
            this.swEstado.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.swEstado.Value = true;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(298, 82);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(102, 20);
            this.bunifuCustomLabel7.TabIndex = 16;
            this.bunifuCustomLabel7.Text = "Elija la fecha:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(18, 82);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(119, 20);
            this.bunifuCustomLabel6.TabIndex = 15;
            this.bunifuCustomLabel6.Text = "Elija un medico:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(323, 194);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(64, 20);
            this.bunifuCustomLabel5.TabIndex = 14;
            this.bunifuCustomLabel5.Text = "Inactivo";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(461, 194);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel4.TabIndex = 13;
            this.bunifuCustomLabel4.Text = "Activo";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(298, 158);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(60, 20);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Estado";
            // 
            // txtComentarios
            // 
            this.txtComentarios.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtComentarios.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComentarios.BorderColorMouseHover = System.Drawing.Color.Pink;
            this.txtComentarios.BorderThickness = 3;
            this.txtComentarios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComentarios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComentarios.isPassword = false;
            this.txtComentarios.Location = new System.Drawing.Point(22, 178);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(259, 52);
            this.txtComentarios.TabIndex = 10;
            this.txtComentarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fecha
            // 
            this.fecha.BackColor = System.Drawing.Color.Pink;
            this.fecha.BorderRadius = 0;
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fecha.FormatCustom = null;
            this.fecha.Location = new System.Drawing.Point(302, 105);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(256, 34);
            this.fecha.TabIndex = 9;
            this.fecha.Value = new System.DateTime(2019, 2, 24, 11, 2, 53, 913);
            // 
            // txtContrase
            // 
            this.txtContrase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrase.HintForeColor = System.Drawing.Color.Empty;
            this.txtContrase.HintText = "";
            this.txtContrase.isPassword = true;
            this.txtContrase.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtContrase.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtContrase.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtContrase.LineThickness = 3;
            this.txtContrase.Location = new System.Drawing.Point(302, 24);
            this.txtContrase.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrase.Name = "txtContrase";
            this.txtContrase.Size = new System.Drawing.Size(256, 44);
            this.txtContrase.TabIndex = 7;
            this.txtContrase.Text = "000";
            this.txtContrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Nombre del usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(151)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))));
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(22, 24);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(254, 44);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // error1
            // 
            this.error1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error1.ContainerControl = this;
            // 
            // error2
            // 
            this.error2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error2.ContainerControl = this;
            // 
            // registro_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 444);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pnUsuarios);
            this.Controls.Add(this.pnDoctor);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "registro_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones iniciales";
            this.Load += new System.EventHandler(this.registro_usuarios_Load);
            this.pnDoctor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnUsuarios.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasos;
        private System.Windows.Forms.Panel pnDoctor;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSiguiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumeroJunta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtapellidos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombres;
        private System.Windows.Forms.Panel pnUsuarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContrase;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtComentarios;
        private Bunifu.Framework.UI.BunifuDatepicker fecha;
        private Bunifu.Framework.UI.BunifuSwitch swEstado;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.ErrorProvider error2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox listaMedicos;
    }
}