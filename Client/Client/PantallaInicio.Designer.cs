namespace WindowsFormsApplication1
{
    partial class PantallaInicio
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CrearCuenta = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.PorcentajeGanadas = new System.Windows.Forms.Button();
            this.PartidasGanadas = new System.Windows.Forms.Button();
            this.PartidasJugadas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirAmigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAmigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAmigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Conectar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(167, 35);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(167, 81);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.HotPink;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // CrearCuenta
            // 
            this.CrearCuenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrearCuenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCuenta.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.CrearCuenta.Location = new System.Drawing.Point(178, 122);
            this.CrearCuenta.Name = "CrearCuenta";
            this.CrearCuenta.Size = new System.Drawing.Size(67, 47);
            this.CrearCuenta.TabIndex = 4;
            this.CrearCuenta.Text = "CREAR CUENTA";
            this.CrearCuenta.UseVisualStyleBackColor = false;
            this.CrearCuenta.Click += new System.EventHandler(this.CrearCuenta_Click);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.IniciarSesion.Location = new System.Drawing.Point(72, 122);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(67, 47);
            this.IniciarSesion.TabIndex = 5;
            this.IniciarSesion.Text = "INICIAR SESIÓN";
            this.IniciarSesion.UseVisualStyleBackColor = false;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // PorcentajeGanadas
            // 
            this.PorcentajeGanadas.Location = new System.Drawing.Point(12, 194);
            this.PorcentajeGanadas.Name = "PorcentajeGanadas";
            this.PorcentajeGanadas.Size = new System.Drawing.Size(139, 24);
            this.PorcentajeGanadas.TabIndex = 7;
            this.PorcentajeGanadas.Text = "Porcentaje ganadas";
            this.PorcentajeGanadas.UseVisualStyleBackColor = true;
            this.PorcentajeGanadas.Click += new System.EventHandler(this.PorcentajeGanadas_Click);
            // 
            // PartidasGanadas
            // 
            this.PartidasGanadas.Location = new System.Drawing.Point(161, 194);
            this.PartidasGanadas.Name = "PartidasGanadas";
            this.PartidasGanadas.Size = new System.Drawing.Size(139, 24);
            this.PartidasGanadas.TabIndex = 8;
            this.PartidasGanadas.Text = "Partidas Ganadas";
            this.PartidasGanadas.UseVisualStyleBackColor = true;
            this.PartidasGanadas.Click += new System.EventHandler(this.PartidasGanadas_Click);
            // 
            // PartidasJugadas
            // 
            this.PartidasJugadas.Location = new System.Drawing.Point(12, 224);
            this.PartidasJugadas.Name = "PartidasJugadas";
            this.PartidasJugadas.Size = new System.Drawing.Size(139, 24);
            this.PartidasJugadas.TabIndex = 10;
            this.PartidasJugadas.Text = "Partidas Jugadas";
            this.PartidasJugadas.UseVisualStyleBackColor = true;
            this.PartidasJugadas.Click += new System.EventHandler(this.PartidasJugadas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 171);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.amigosToolStripMenuItem,
            this.chatToolStripMenuItem,
            this.jugarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(476, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(81, 307);
            this.menu.TabIndex = 12;
            this.menu.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // amigosToolStripMenuItem
            // 
            this.amigosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirAmigoToolStripMenuItem,
            this.verAmigosToolStripMenuItem,
            this.eliminarAmigoToolStripMenuItem});
            this.amigosToolStripMenuItem.Name = "amigosToolStripMenuItem";
            this.amigosToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.amigosToolStripMenuItem.Text = "Amigos";
            // 
            // añadirAmigoToolStripMenuItem
            // 
            this.añadirAmigoToolStripMenuItem.Name = "añadirAmigoToolStripMenuItem";
            this.añadirAmigoToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.añadirAmigoToolStripMenuItem.Text = "Añadir amigo";
            // 
            // verAmigosToolStripMenuItem
            // 
            this.verAmigosToolStripMenuItem.Name = "verAmigosToolStripMenuItem";
            this.verAmigosToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.verAmigosToolStripMenuItem.Text = "Ver amigos";
            this.verAmigosToolStripMenuItem.Click += new System.EventHandler(this.verAmigosToolStripMenuItem_Click);
            // 
            // eliminarAmigoToolStripMenuItem
            // 
            this.eliminarAmigoToolStripMenuItem.Name = "eliminarAmigoToolStripMenuItem";
            this.eliminarAmigoToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.eliminarAmigoToolStripMenuItem.Text = "Eliminar amigo";
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.chatToolStripMenuItem.Text = "Chat";
            // 
            // jugarToolStripMenuItem
            // 
            this.jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            this.jugarToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.jugarToolStripMenuItem.Text = "Jugar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(344, 216);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(75, 23);
            this.Conectar.TabIndex = 13;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(143, 193);
            this.dataGridView1.TabIndex = 14;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 307);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartidasJugadas);
            this.Controls.Add(this.PartidasGanadas);
            this.Controls.Add(this.PorcentajeGanadas);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.CrearCuenta);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "PantallaInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CrearCuenta;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Button PorcentajeGanadas;
        private System.Windows.Forms.Button PartidasGanadas;
        private System.Windows.Forms.Button PartidasJugadas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirAmigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAmigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAmigosToolStripMenuItem;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

