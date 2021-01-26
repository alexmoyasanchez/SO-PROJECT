namespace WindowsFormsApplication1
{
    partial class InterfazCluedo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazCluedo));
            this.ListaArmas = new System.Windows.Forms.CheckedListBox();
            this.ListaPersonajes = new System.Windows.Forms.CheckedListBox();
            this.tirardadoslbl = new System.Windows.Forms.Label();
            this.TirarDados = new System.Windows.Forms.Button();
            this.desplazamniento = new System.Windows.Forms.Label();
            this.ListaHabitaciones = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.preguntar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.acusacionfinal = new System.Windows.Forms.Button();
            this.movimientos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Mipersonaje = new System.Windows.Forms.Label();
            this.turno = new System.Windows.Forms.TextBox();
            this.turnode = new System.Windows.Forms.Label();
            this.personaje1 = new System.Windows.Forms.PictureBox();
            this.ficha_marron = new System.Windows.Forms.PictureBox();
            this.ficha_verde = new System.Windows.Forms.PictureBox();
            this.ficha_azul = new System.Windows.Forms.PictureBox();
            this.ficha_lila = new System.Windows.Forms.PictureBox();
            this.ficha_granate = new System.Windows.Forms.PictureBox();
            this.ficha_dorada = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mover_abajo = new System.Windows.Forms.Button();
            this.mover_derecha = new System.Windows.Forms.Button();
            this.mover_arriba = new System.Windows.Forms.Button();
            this.mover_izquierda = new System.Windows.Forms.Button();
            this.dado2 = new System.Windows.Forms.PictureBox();
            this.dado1 = new System.Windows.Forms.PictureBox();
            this.pasarturno = new System.Windows.Forms.Button();
            this.vficha = new System.Windows.Forms.TextBox();
            this.ldx = new System.Windows.Forms.TextBox();
            this.ldy = new System.Windows.Forms.TextBox();
            this.llx = new System.Windows.Forms.TextBox();
            this.lly = new System.Windows.Forms.TextBox();
            this.lgx = new System.Windows.Forms.TextBox();
            this.lgy = new System.Windows.Forms.TextBox();
            this.lax = new System.Windows.Forms.TextBox();
            this.lay = new System.Windows.Forms.TextBox();
            this.lvx = new System.Windows.Forms.TextBox();
            this.lvy = new System.Windows.Forms.TextBox();
            this.lmx = new System.Windows.Forms.TextBox();
            this.lmy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personaje1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_marron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_azul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_lila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_granate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_dorada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaArmas
            // 
            this.ListaArmas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListaArmas.FormattingEnabled = true;
            this.ListaArmas.Items.AddRange(new object[] {
            "Puñal",
            "Candelabro",
            "Pistola",
            "Cuerda",
            "Tuberia de plomo",
            "Herramienta"});
            this.ListaArmas.Location = new System.Drawing.Point(421, 146);
            this.ListaArmas.Name = "ListaArmas";
            this.ListaArmas.Size = new System.Drawing.Size(109, 94);
            this.ListaArmas.TabIndex = 4;
            // 
            // ListaPersonajes
            // 
            this.ListaPersonajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListaPersonajes.FormattingEnabled = true;
            this.ListaPersonajes.Items.AddRange(new object[] {
            "Coronel Rubio",
            "Profesor Mora",
            "Padre Prado",
            "Sra. Celeste",
            "Sra. Escarlata",
            "Sra. Blanco"});
            this.ListaPersonajes.Location = new System.Drawing.Point(421, 29);
            this.ListaPersonajes.Name = "ListaPersonajes";
            this.ListaPersonajes.Size = new System.Drawing.Size(109, 94);
            this.ListaPersonajes.TabIndex = 5;
            // 
            // tirardadoslbl
            // 
            this.tirardadoslbl.AutoSize = true;
            this.tirardadoslbl.BackColor = System.Drawing.Color.Olive;
            this.tirardadoslbl.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tirardadoslbl.Location = new System.Drawing.Point(569, 9);
            this.tirardadoslbl.Name = "tirardadoslbl";
            this.tirardadoslbl.Size = new System.Drawing.Size(92, 21);
            this.tirardadoslbl.TabIndex = 23;
            this.tirardadoslbl.Text = "Tirar dados";
            // 
            // TirarDados
            // 
            this.TirarDados.BackColor = System.Drawing.Color.DarkKhaki;
            this.TirarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TirarDados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TirarDados.Location = new System.Drawing.Point(590, 99);
            this.TirarDados.Name = "TirarDados";
            this.TirarDados.Size = new System.Drawing.Size(75, 30);
            this.TirarDados.TabIndex = 24;
            this.TirarDados.Text = "TIRAR";
            this.TirarDados.UseVisualStyleBackColor = false;
            this.TirarDados.Click += new System.EventHandler(this.TirarDados_Click);
            // 
            // desplazamniento
            // 
            this.desplazamniento.AutoSize = true;
            this.desplazamniento.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desplazamniento.Location = new System.Drawing.Point(713, 9);
            this.desplazamniento.Name = "desplazamniento";
            this.desplazamniento.Size = new System.Drawing.Size(126, 21);
            this.desplazamniento.TabIndex = 27;
            this.desplazamniento.Text = "Desplazamiento";
            // 
            // ListaHabitaciones
            // 
            this.ListaHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListaHabitaciones.FormattingEnabled = true;
            this.ListaHabitaciones.Items.AddRange(new object[] {
            "Vestíbulo",
            "Salón",
            "Comedor",
            "Cocina",
            "Sala de música",
            "Conservatorio",
            "Sala de billar",
            "Biblioteca",
            "Estudio"});
            this.ListaHabitaciones.Location = new System.Drawing.Point(421, 263);
            this.ListaHabitaciones.Name = "ListaHabitaciones";
            this.ListaHabitaciones.Size = new System.Drawing.Size(109, 139);
            this.ListaHabitaciones.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(418, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "HABITACIONES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(418, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "ASESINO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(418, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "ARMAS";
            // 
            // preguntar
            // 
            this.preguntar.BackColor = System.Drawing.Color.Gold;
            this.preguntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preguntar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preguntar.Location = new System.Drawing.Point(731, 221);
            this.preguntar.Name = "preguntar";
            this.preguntar.Size = new System.Drawing.Size(111, 39);
            this.preguntar.TabIndex = 39;
            this.preguntar.Text = "PREGUNTAR";
            this.preguntar.UseVisualStyleBackColor = false;
            this.preguntar.Click += new System.EventHandler(this.preguntar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(727, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Preguntar a los otros jugadores sus pistas";
            // 
            // acusacionfinal
            // 
            this.acusacionfinal.BackColor = System.Drawing.Color.Red;
            this.acusacionfinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acusacionfinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acusacionfinal.Location = new System.Drawing.Point(884, 221);
            this.acusacionfinal.Name = "acusacionfinal";
            this.acusacionfinal.Size = new System.Drawing.Size(162, 39);
            this.acusacionfinal.TabIndex = 52;
            this.acusacionfinal.Text = "ACUSACIÓN FINAL";
            this.acusacionfinal.UseVisualStyleBackColor = false;
            this.acusacionfinal.Click += new System.EventHandler(this.acusacionfinal_Click);
            // 
            // movimientos
            // 
            this.movimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientos.Location = new System.Drawing.Point(944, 44);
            this.movimientos.Name = "movimientos";
            this.movimientos.Size = new System.Drawing.Size(50, 49);
            this.movimientos.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(873, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 21);
            this.label12.TabIndex = 61;
            this.label12.Text = "Movimientos restantes";
            // 
            // Mipersonaje
            // 
            this.Mipersonaje.AutoSize = true;
            this.Mipersonaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Mipersonaje.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mipersonaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mipersonaje.Location = new System.Drawing.Point(570, 157);
            this.Mipersonaje.Name = "Mipersonaje";
            this.Mipersonaje.Size = new System.Drawing.Size(99, 17);
            this.Mipersonaje.TabIndex = 72;
            this.Mipersonaje.Text = "MI PERSONAJE";
            // 
            // turno
            // 
            this.turno.Location = new System.Drawing.Point(765, 324);
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(100, 20);
            this.turno.TabIndex = 73;
            // 
            // turnode
            // 
            this.turnode.AutoSize = true;
            this.turnode.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnode.Location = new System.Drawing.Point(645, 321);
            this.turnode.Name = "turnode";
            this.turnode.Size = new System.Drawing.Size(95, 21);
            this.turnode.TabIndex = 74;
            this.turnode.Text = "TURNO DE :";
            // 
            // personaje1
            // 
            this.personaje1.Image = global::WindowsFormsApplication1.Properties.Resources.clue___mrs__peacock___fan_art_by_virtualbarata_d5oa5fu;
            this.personaje1.Location = new System.Drawing.Point(572, 188);
            this.personaje1.Name = "personaje1";
            this.personaje1.Size = new System.Drawing.Size(97, 108);
            this.personaje1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personaje1.TabIndex = 62;
            this.personaje1.TabStop = false;
            // 
            // ficha_marron
            // 
            this.ficha_marron.Location = new System.Drawing.Point(231, 385);
            this.ficha_marron.Name = "ficha_marron";
            this.ficha_marron.Size = new System.Drawing.Size(10, 10);
            this.ficha_marron.TabIndex = 59;
            this.ficha_marron.TabStop = false;
            // 
            // ficha_verde
            // 
            this.ficha_verde.Location = new System.Drawing.Point(156, 385);
            this.ficha_verde.Name = "ficha_verde";
            this.ficha_verde.Size = new System.Drawing.Size(10, 10);
            this.ficha_verde.TabIndex = 58;
            this.ficha_verde.TabStop = false;
            // 
            // ficha_azul
            // 
            this.ficha_azul.Location = new System.Drawing.Point(21, 295);
            this.ficha_azul.Name = "ficha_azul";
            this.ficha_azul.Size = new System.Drawing.Size(10, 10);
            this.ficha_azul.TabIndex = 57;
            this.ficha_azul.TabStop = false;
            // 
            // ficha_lila
            // 
            this.ficha_lila.Location = new System.Drawing.Point(21, 100);
            this.ficha_lila.Name = "ficha_lila";
            this.ficha_lila.Size = new System.Drawing.Size(10, 10);
            this.ficha_lila.TabIndex = 56;
            this.ficha_lila.TabStop = false;
            this.ficha_lila.Tag = "";
            // 
            // ficha_granate
            // 
            this.ficha_granate.Image = ((System.Drawing.Image)(resources.GetObject("ficha_granate.Image")));
            this.ficha_granate.Location = new System.Drawing.Point(261, 25);
            this.ficha_granate.Name = "ficha_granate";
            this.ficha_granate.Size = new System.Drawing.Size(10, 10);
            this.ficha_granate.TabIndex = 55;
            this.ficha_granate.TabStop = false;
            // 
            // ficha_dorada
            // 
            this.ficha_dorada.Image = ((System.Drawing.Image)(resources.GetObject("ficha_dorada.Image")));
            this.ficha_dorada.Location = new System.Drawing.Point(366, 130);
            this.ficha_dorada.Name = "ficha_dorada";
            this.ficha_dorada.Size = new System.Drawing.Size(10, 10);
            this.ficha_dorada.TabIndex = 54;
            this.ficha_dorada.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.TABLERO24;
            this.pictureBox3.Location = new System.Drawing.Point(12, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 411);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // mover_abajo
            // 
            this.mover_abajo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mover_abajo.BackgroundImage")));
            this.mover_abajo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mover_abajo.Location = new System.Drawing.Point(765, 89);
            this.mover_abajo.Name = "mover_abajo";
            this.mover_abajo.Size = new System.Drawing.Size(50, 50);
            this.mover_abajo.TabIndex = 31;
            this.mover_abajo.UseVisualStyleBackColor = true;
            this.mover_abajo.Click += new System.EventHandler(this.mover_abajo_Click_1);
            // 
            // mover_derecha
            // 
            this.mover_derecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mover_derecha.BackgroundImage")));
            this.mover_derecha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mover_derecha.Location = new System.Drawing.Point(821, 89);
            this.mover_derecha.Name = "mover_derecha";
            this.mover_derecha.Size = new System.Drawing.Size(50, 50);
            this.mover_derecha.TabIndex = 30;
            this.mover_derecha.UseVisualStyleBackColor = true;
            this.mover_derecha.Click += new System.EventHandler(this.mover_derecha_Click_1);
            // 
            // mover_arriba
            // 
            this.mover_arriba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mover_arriba.BackgroundImage")));
            this.mover_arriba.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mover_arriba.Location = new System.Drawing.Point(765, 33);
            this.mover_arriba.Name = "mover_arriba";
            this.mover_arriba.Size = new System.Drawing.Size(50, 50);
            this.mover_arriba.TabIndex = 29;
            this.mover_arriba.UseVisualStyleBackColor = true;
            this.mover_arriba.Click += new System.EventHandler(this.mover_arriba_Click_1);
            // 
            // mover_izquierda
            // 
            this.mover_izquierda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mover_izquierda.BackgroundImage")));
            this.mover_izquierda.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mover_izquierda.Location = new System.Drawing.Point(709, 89);
            this.mover_izquierda.Name = "mover_izquierda";
            this.mover_izquierda.Size = new System.Drawing.Size(50, 50);
            this.mover_izquierda.TabIndex = 28;
            this.mover_izquierda.UseVisualStyleBackColor = true;
            this.mover_izquierda.Click += new System.EventHandler(this.mover_izquierda_Click_1);
            // 
            // dado2
            // 
            this.dado2.Image = global::WindowsFormsApplication1.Properties.Resources._6;
            this.dado2.Location = new System.Drawing.Point(631, 40);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(53, 53);
            this.dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dado2.TabIndex = 26;
            this.dado2.TabStop = false;
            // 
            // dado1
            // 
            this.dado1.Image = global::WindowsFormsApplication1.Properties.Resources._6;
            this.dado1.Location = new System.Drawing.Point(573, 40);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(52, 53);
            this.dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dado1.TabIndex = 25;
            this.dado1.TabStop = false;
            // 
            // pasarturno
            // 
            this.pasarturno.BackColor = System.Drawing.Color.Gold;
            this.pasarturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasarturno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasarturno.Location = new System.Drawing.Point(912, 305);
            this.pasarturno.Name = "pasarturno";
            this.pasarturno.Size = new System.Drawing.Size(111, 39);
            this.pasarturno.TabIndex = 75;
            this.pasarturno.Text = "PASAR TURNO";
            this.pasarturno.UseVisualStyleBackColor = false;
            this.pasarturno.Click += new System.EventHandler(this.pasarturno_Click);
            // 
            // vficha
            // 
            this.vficha.Location = new System.Drawing.Point(455, 419);
            this.vficha.Name = "vficha";
            this.vficha.Size = new System.Drawing.Size(25, 20);
            this.vficha.TabIndex = 76;
            this.vficha.Visible = false;
            // 
            // ldx
            // 
            this.ldx.Location = new System.Drawing.Point(455, 445);
            this.ldx.Name = "ldx";
            this.ldx.Size = new System.Drawing.Size(25, 20);
            this.ldx.TabIndex = 78;
            this.ldx.Text = "366";
            this.ldx.Visible = false;
            // 
            // ldy
            // 
            this.ldy.Location = new System.Drawing.Point(455, 471);
            this.ldy.Name = "ldy";
            this.ldy.Size = new System.Drawing.Size(25, 20);
            this.ldy.TabIndex = 79;
            this.ldy.Text = "130";
            this.ldy.Visible = false;
            // 
            // llx
            // 
            this.llx.Location = new System.Drawing.Point(486, 419);
            this.llx.Name = "llx";
            this.llx.Size = new System.Drawing.Size(25, 20);
            this.llx.TabIndex = 80;
            this.llx.Text = "21";
            this.llx.Visible = false;
            // 
            // lly
            // 
            this.lly.Location = new System.Drawing.Point(486, 445);
            this.lly.Name = "lly";
            this.lly.Size = new System.Drawing.Size(25, 20);
            this.lly.TabIndex = 81;
            this.lly.Text = "100";
            this.lly.Visible = false;
            // 
            // lgx
            // 
            this.lgx.Location = new System.Drawing.Point(486, 471);
            this.lgx.Name = "lgx";
            this.lgx.Size = new System.Drawing.Size(25, 20);
            this.lgx.TabIndex = 82;
            this.lgx.Text = "261";
            this.lgx.Visible = false;
            // 
            // lgy
            // 
            this.lgy.Location = new System.Drawing.Point(517, 419);
            this.lgy.Name = "lgy";
            this.lgy.Size = new System.Drawing.Size(25, 20);
            this.lgy.TabIndex = 83;
            this.lgy.Text = "25";
            this.lgy.Visible = false;
            // 
            // lax
            // 
            this.lax.Location = new System.Drawing.Point(517, 445);
            this.lax.Name = "lax";
            this.lax.Size = new System.Drawing.Size(25, 20);
            this.lax.TabIndex = 84;
            this.lax.Text = "21";
            this.lax.Visible = false;
            // 
            // lay
            // 
            this.lay.Location = new System.Drawing.Point(517, 471);
            this.lay.Name = "lay";
            this.lay.Size = new System.Drawing.Size(25, 20);
            this.lay.TabIndex = 85;
            this.lay.Text = "295";
            this.lay.Visible = false;
            // 
            // lvx
            // 
            this.lvx.Location = new System.Drawing.Point(548, 419);
            this.lvx.Name = "lvx";
            this.lvx.Size = new System.Drawing.Size(25, 20);
            this.lvx.TabIndex = 86;
            this.lvx.Text = "156";
            this.lvx.Visible = false;
            // 
            // lvy
            // 
            this.lvy.Location = new System.Drawing.Point(548, 445);
            this.lvy.Name = "lvy";
            this.lvy.Size = new System.Drawing.Size(25, 20);
            this.lvy.TabIndex = 87;
            this.lvy.Text = "385";
            this.lvy.Visible = false;
            // 
            // lmx
            // 
            this.lmx.Location = new System.Drawing.Point(548, 471);
            this.lmx.Name = "lmx";
            this.lmx.Size = new System.Drawing.Size(25, 20);
            this.lmx.TabIndex = 88;
            this.lmx.Text = "231";
            this.lmx.Visible = false;
            // 
            // lmy
            // 
            this.lmy.Location = new System.Drawing.Point(579, 419);
            this.lmy.Name = "lmy";
            this.lmy.Size = new System.Drawing.Size(25, 20);
            this.lmy.TabIndex = 89;
            this.lmy.Text = "385";
            this.lmy.Visible = false;
            // 
            // InterfazCluedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1058, 526);
            this.Controls.Add(this.lmy);
            this.Controls.Add(this.lmx);
            this.Controls.Add(this.lvy);
            this.Controls.Add(this.lvx);
            this.Controls.Add(this.lay);
            this.Controls.Add(this.lax);
            this.Controls.Add(this.lgy);
            this.Controls.Add(this.lgx);
            this.Controls.Add(this.lly);
            this.Controls.Add(this.llx);
            this.Controls.Add(this.ldy);
            this.Controls.Add(this.ldx);
            this.Controls.Add(this.vficha);
            this.Controls.Add(this.pasarturno);
            this.Controls.Add(this.turnode);
            this.Controls.Add(this.turno);
            this.Controls.Add(this.Mipersonaje);
            this.Controls.Add(this.personaje1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.movimientos);
            this.Controls.Add(this.ficha_marron);
            this.Controls.Add(this.ficha_verde);
            this.Controls.Add(this.ficha_azul);
            this.Controls.Add(this.ficha_lila);
            this.Controls.Add(this.ficha_granate);
            this.Controls.Add(this.ficha_dorada);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.acusacionfinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preguntar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaHabitaciones);
            this.Controls.Add(this.mover_abajo);
            this.Controls.Add(this.mover_derecha);
            this.Controls.Add(this.mover_arriba);
            this.Controls.Add(this.mover_izquierda);
            this.Controls.Add(this.desplazamniento);
            this.Controls.Add(this.dado2);
            this.Controls.Add(this.dado1);
            this.Controls.Add(this.TirarDados);
            this.Controls.Add(this.tirardadoslbl);
            this.Controls.Add(this.ListaPersonajes);
            this.Controls.Add(this.ListaArmas);
            this.Name = "InterfazCluedo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfazCluedo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaje1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_marron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_azul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_lila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_granate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha_dorada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ListaArmas;
        private System.Windows.Forms.CheckedListBox ListaPersonajes;
        private System.Windows.Forms.Label tirardadoslbl;
        private System.Windows.Forms.Button TirarDados;
        private System.Windows.Forms.PictureBox dado1;
        private System.Windows.Forms.PictureBox dado2;
        private System.Windows.Forms.Label desplazamniento;
        private System.Windows.Forms.Button mover_izquierda;
        private System.Windows.Forms.Button mover_arriba;
        private System.Windows.Forms.Button mover_derecha;
        private System.Windows.Forms.Button mover_abajo;
        private System.Windows.Forms.CheckedListBox ListaHabitaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button preguntar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acusacionfinal;
        private System.Windows.Forms.PictureBox ficha_dorada;
        private System.Windows.Forms.PictureBox ficha_granate;
        private System.Windows.Forms.PictureBox ficha_lila;
        private System.Windows.Forms.PictureBox ficha_azul;
        private System.Windows.Forms.PictureBox ficha_verde;
        private System.Windows.Forms.PictureBox ficha_marron;
        private System.Windows.Forms.TextBox movimientos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox personaje1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Mipersonaje;
        private System.Windows.Forms.TextBox turno;
        private System.Windows.Forms.Label turnode;
        private System.Windows.Forms.Button pasarturno;
        private System.Windows.Forms.TextBox vficha;
        private System.Windows.Forms.TextBox ldx;
        private System.Windows.Forms.TextBox ldy;
        private System.Windows.Forms.TextBox llx;
        private System.Windows.Forms.TextBox lly;
        private System.Windows.Forms.TextBox lgx;
        private System.Windows.Forms.TextBox lgy;
        private System.Windows.Forms.TextBox lax;
        private System.Windows.Forms.TextBox lay;
        private System.Windows.Forms.TextBox lvx;
        private System.Windows.Forms.TextBox lvy;
        private System.Windows.Forms.TextBox lmx;
        private System.Windows.Forms.TextBox lmy;

    }
}

