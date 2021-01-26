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
            this.components = new System.ComponentModel.Container();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PorcentajeGanadas = new System.Windows.Forms.Button();
            this.PartidasGanadas = new System.Windows.Forms.Button();
            this.PartidasJugadas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Conectar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.mensajechat = new System.Windows.Forms.TextBox();
            this.enviarchat = new System.Windows.Forms.Button();
            this.chat = new System.Windows.Forms.TextBox();
            this.invitarButton = new System.Windows.Forms.Button();
            this.empezar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textotitulo = new System.Windows.Forms.Label();
            this.j1 = new System.Windows.Forms.CheckBox();
            this.j2 = new System.Windows.Forms.CheckBox();
            this.j3 = new System.Windows.Forms.CheckBox();
            this.j4 = new System.Windows.Forms.CheckBox();
            this.j5 = new System.Windows.Forms.CheckBox();
            this.j6 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(167, 35);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 0;
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
            this.salirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(873, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(59, 356);
            this.menu.TabIndex = 12;
            this.menu.Text = "menuStrip1";
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
            this.Conectar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Conectar.Location = new System.Drawing.Point(50, 137);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(217, 23);
            this.Conectar.TabIndex = 13;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = false;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(143, 193);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.HotPink;
            this.fondo.Location = new System.Drawing.Point(466, 12);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(323, 193);
            this.fondo.TabIndex = 20;
            this.fondo.TabStop = false;
            // 
            // mensajechat
            // 
            this.mensajechat.Location = new System.Drawing.Point(478, 167);
            this.mensajechat.Name = "mensajechat";
            this.mensajechat.Size = new System.Drawing.Size(267, 20);
            this.mensajechat.TabIndex = 24;
            // 
            // enviarchat
            // 
            this.enviarchat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enviarchat.Location = new System.Drawing.Point(751, 166);
            this.enviarchat.Name = "enviarchat";
            this.enviarchat.Size = new System.Drawing.Size(28, 23);
            this.enviarchat.TabIndex = 25;
            this.enviarchat.Text = "E";
            this.enviarchat.UseVisualStyleBackColor = false;
            this.enviarchat.Click += new System.EventHandler(this.enviarchat_Click);
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(478, 23);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(301, 137);
            this.chat.TabIndex = 26;
            // 
            // invitarButton
            // 
            this.invitarButton.Location = new System.Drawing.Point(308, 211);
            this.invitarButton.Name = "invitarButton";
            this.invitarButton.Size = new System.Drawing.Size(143, 24);
            this.invitarButton.TabIndex = 27;
            this.invitarButton.Text = "Invitar";
            this.invitarButton.UseVisualStyleBackColor = true;
            this.invitarButton.Click += new System.EventHandler(this.invitarButton_Click);
            // 
            // empezar
            // 
            this.empezar.Location = new System.Drawing.Point(556, 323);
            this.empezar.Name = "empezar";
            this.empezar.Size = new System.Drawing.Size(131, 21);
            this.empezar.TabIndex = 29;
            this.empezar.Text = "EMPEZAR PARTIDA";
            this.empezar.UseVisualStyleBackColor = true;
            this.empezar.Click += new System.EventHandler(this.empezar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(466, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 171);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // textotitulo
            // 
            this.textotitulo.AutoSize = true;
            this.textotitulo.Location = new System.Drawing.Point(553, 224);
            this.textotitulo.Name = "textotitulo";
            this.textotitulo.Size = new System.Drawing.Size(134, 13);
            this.textotitulo.TabIndex = 31;
            this.textotitulo.Text = "JUGADORES INVITADOS";
            // 
            // j1
            // 
            this.j1.AutoSize = true;
            this.j1.BackColor = System.Drawing.Color.Transparent;
            this.j1.Location = new System.Drawing.Point(514, 247);
            this.j1.Name = "j1";
            this.j1.Size = new System.Drawing.Size(93, 17);
            this.j1.TabIndex = 38;
            this.j1.Text = "Jugador vacio";
            this.j1.UseVisualStyleBackColor = false;
            // 
            // j2
            // 
            this.j2.AutoSize = true;
            this.j2.Location = new System.Drawing.Point(514, 270);
            this.j2.Name = "j2";
            this.j2.Size = new System.Drawing.Size(93, 17);
            this.j2.TabIndex = 39;
            this.j2.Text = "Jugador vacio";
            this.j2.UseVisualStyleBackColor = true;
            // 
            // j3
            // 
            this.j3.AutoSize = true;
            this.j3.Location = new System.Drawing.Point(514, 293);
            this.j3.Name = "j3";
            this.j3.Size = new System.Drawing.Size(93, 17);
            this.j3.TabIndex = 40;
            this.j3.Text = "Jugador vacio";
            this.j3.UseVisualStyleBackColor = true;
            // 
            // j4
            // 
            this.j4.AutoSize = true;
            this.j4.Location = new System.Drawing.Point(634, 247);
            this.j4.Name = "j4";
            this.j4.Size = new System.Drawing.Size(93, 17);
            this.j4.TabIndex = 41;
            this.j4.Text = "Jugador vacio";
            this.j4.UseVisualStyleBackColor = true;
            // 
            // j5
            // 
            this.j5.AutoSize = true;
            this.j5.Location = new System.Drawing.Point(634, 270);
            this.j5.Name = "j5";
            this.j5.Size = new System.Drawing.Size(93, 17);
            this.j5.TabIndex = 42;
            this.j5.Text = "Jugador vacio";
            this.j5.UseVisualStyleBackColor = true;
            // 
            // j6
            // 
            this.j6.AutoSize = true;
            this.j6.Location = new System.Drawing.Point(634, 293);
            this.j6.Name = "j6";
            this.j6.Size = new System.Drawing.Size(93, 17);
            this.j6.TabIndex = 43;
            this.j6.Text = "Jugador vacio";
            this.j6.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 356);
            this.Controls.Add(this.j6);
            this.Controls.Add(this.j5);
            this.Controls.Add(this.j4);
            this.Controls.Add(this.j3);
            this.Controls.Add(this.j2);
            this.Controls.Add(this.j1);
            this.Controls.Add(this.textotitulo);
            this.Controls.Add(this.empezar);
            this.Controls.Add(this.invitarButton);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.enviarchat);
            this.Controls.Add(this.mensajechat);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartidasJugadas);
            this.Controls.Add(this.PartidasGanadas);
            this.Controls.Add(this.PorcentajeGanadas);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menu;
            this.Name = "PantallaInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PorcentajeGanadas;
        private System.Windows.Forms.Button PartidasGanadas;
        private System.Windows.Forms.Button PartidasJugadas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.TextBox mensajechat;
        private System.Windows.Forms.Button enviarchat;
        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.Button invitarButton;
        private System.Windows.Forms.Button empezar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label textotitulo;
        private System.Windows.Forms.CheckBox j1;
        private System.Windows.Forms.CheckBox j2;
        private System.Windows.Forms.CheckBox j3;
        private System.Windows.Forms.CheckBox j4;
        private System.Windows.Forms.CheckBox j5;
        private System.Windows.Forms.CheckBox j6;
        private System.Windows.Forms.Timer timer1;
    }
}

