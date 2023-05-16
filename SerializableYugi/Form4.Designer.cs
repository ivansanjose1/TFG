namespace SerializableYugi
{
    partial class Form4
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
            this.panelCHK = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelgen = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.set = new System.Windows.Forms.TextBox();
            this.soporte = new System.Windows.Forms.TextBox();
            this.rareza = new System.Windows.Forms.ComboBox();
            this.copias = new System.Windows.Forms.TextBox();
            this.panelmonst = new System.Windows.Forms.Panel();
            this.subtipo = new System.Windows.Forms.ComboBox();
            this.ExtraDeck = new System.Windows.Forms.ComboBox();
            this.atributo = new System.Windows.Forms.ComboBox();
            this.def = new System.Windows.Forms.TextBox();
            this.attk = new System.Windows.Forms.TextBox();
            this.arquetipo = new System.Windows.Forms.TextBox();
            this.niivel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buscada = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.paneletiquetas1 = new System.Windows.Forms.Panel();
            this.paneletiquetas2 = new System.Windows.Forms.Panel();
            this.panelCHK.SuspendLayout();
            this.panelgen.SuspendLayout();
            this.panelmonst.SuspendLayout();
            this.paneletiquetas1.SuspendLayout();
            this.paneletiquetas2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCHK
            // 
            this.panelCHK.BackColor = System.Drawing.Color.Transparent;
            this.panelCHK.Controls.Add(this.checkBox3);
            this.panelCHK.Controls.Add(this.checkBox2);
            this.panelCHK.Controls.Add(this.checkBox1);
            this.panelCHK.Location = new System.Drawing.Point(3, 12);
            this.panelCHK.Name = "panelCHK";
            this.panelCHK.Size = new System.Drawing.Size(321, 18);
            this.panelCHK.TabIndex = 38;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox3.Location = new System.Drawing.Point(232, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Tag = "3";
            this.checkBox3.Text = "Trampas";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(115, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Tag = "2";
            this.checkBox2.Text = "Magicas";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(13, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Tag = "1";
            this.checkBox1.Text = "Monstruos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelgen
            // 
            this.panelgen.BackColor = System.Drawing.Color.Transparent;
            this.panelgen.Controls.Add(this.Nombre);
            this.panelgen.Controls.Add(this.Descripcion);
            this.panelgen.Controls.Add(this.tipo);
            this.panelgen.Controls.Add(this.set);
            this.panelgen.Controls.Add(this.soporte);
            this.panelgen.Controls.Add(this.rareza);
            this.panelgen.Controls.Add(this.copias);
            this.panelgen.Enabled = false;
            this.panelgen.Location = new System.Drawing.Point(93, 53);
            this.panelgen.Name = "panelgen";
            this.panelgen.Size = new System.Drawing.Size(314, 385);
            this.panelgen.TabIndex = 39;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(6, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Size = new System.Drawing.Size(299, 20);
            this.Nombre.TabIndex = 0;
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(6, 45);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Size = new System.Drawing.Size(299, 107);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(6, 170);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(299, 21);
            this.tipo.TabIndex = 18;
            this.tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(6, 216);
            this.set.Name = "set";
            this.set.ReadOnly = true;
            this.set.Size = new System.Drawing.Size(299, 20);
            this.set.TabIndex = 3;
            this.set.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // soporte
            // 
            this.soporte.Location = new System.Drawing.Point(6, 263);
            this.soporte.Name = "soporte";
            this.soporte.ReadOnly = true;
            this.soporte.Size = new System.Drawing.Size(299, 20);
            this.soporte.TabIndex = 4;
            this.soporte.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // rareza
            // 
            this.rareza.FormattingEnabled = true;
            this.rareza.Items.AddRange(new object[] {
            "C",
            "R",
            "SR",
            "UR"});
            this.rareza.Location = new System.Drawing.Point(6, 308);
            this.rareza.Name = "rareza";
            this.rareza.Size = new System.Drawing.Size(299, 21);
            this.rareza.TabIndex = 19;
            this.rareza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
            // 
            // copias
            // 
            this.copias.Location = new System.Drawing.Point(6, 360);
            this.copias.Name = "copias";
            this.copias.ReadOnly = true;
            this.copias.Size = new System.Drawing.Size(299, 20);
            this.copias.TabIndex = 6;
            this.copias.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // panelmonst
            // 
            this.panelmonst.BackColor = System.Drawing.Color.Transparent;
            this.panelmonst.Controls.Add(this.subtipo);
            this.panelmonst.Controls.Add(this.ExtraDeck);
            this.panelmonst.Controls.Add(this.atributo);
            this.panelmonst.Controls.Add(this.def);
            this.panelmonst.Controls.Add(this.attk);
            this.panelmonst.Controls.Add(this.arquetipo);
            this.panelmonst.Controls.Add(this.niivel);
            this.panelmonst.Enabled = false;
            this.panelmonst.Location = new System.Drawing.Point(511, 45);
            this.panelmonst.Name = "panelmonst";
            this.panelmonst.Size = new System.Drawing.Size(277, 293);
            this.panelmonst.TabIndex = 40;
            // 
            // subtipo
            // 
            this.subtipo.FormattingEnabled = true;
            this.subtipo.Items.AddRange(new object[] {
            "Union",
            "Toon",
            "Gemini",
            "Espiritu",
            "Pendulo",
            "Cantante",
            "No"});
            this.subtipo.Location = new System.Drawing.Point(3, 268);
            this.subtipo.Name = "subtipo";
            this.subtipo.Size = new System.Drawing.Size(256, 21);
            this.subtipo.TabIndex = 33;
            this.subtipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
            // 
            // ExtraDeck
            // 
            this.ExtraDeck.FormattingEnabled = true;
            this.ExtraDeck.Items.AddRange(new object[] {
            "Fusion",
            "Sincronia",
            "Xyz",
            "Link",
            "No"});
            this.ExtraDeck.Location = new System.Drawing.Point(3, 51);
            this.ExtraDeck.Name = "ExtraDeck";
            this.ExtraDeck.Size = new System.Drawing.Size(256, 21);
            this.ExtraDeck.TabIndex = 27;
            this.ExtraDeck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
            // 
            // atributo
            // 
            this.atributo.FormattingEnabled = true;
            this.atributo.Items.AddRange(new object[] {
            "Luz",
            "Oscuridad",
            "Tierra",
            "Viento",
            "Agua",
            "Fuego",
            "Divinidad"});
            this.atributo.Location = new System.Drawing.Point(0, 11);
            this.atributo.Name = "atributo";
            this.atributo.Size = new System.Drawing.Size(256, 21);
            this.atributo.TabIndex = 26;
            this.atributo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(3, 224);
            this.def.Name = "def";
            this.def.ReadOnly = true;
            this.def.Size = new System.Drawing.Size(256, 20);
            this.def.TabIndex = 11;
            this.def.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // attk
            // 
            this.attk.Location = new System.Drawing.Point(3, 179);
            this.attk.Name = "attk";
            this.attk.ReadOnly = true;
            this.attk.Size = new System.Drawing.Size(256, 20);
            this.attk.TabIndex = 10;
            this.attk.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // arquetipo
            // 
            this.arquetipo.Location = new System.Drawing.Point(3, 140);
            this.arquetipo.Name = "arquetipo";
            this.arquetipo.ReadOnly = true;
            this.arquetipo.Size = new System.Drawing.Size(256, 20);
            this.arquetipo.TabIndex = 9;
            this.arquetipo.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // niivel
            // 
            this.niivel.Location = new System.Drawing.Point(3, 94);
            this.niivel.Name = "niivel";
            this.niivel.ReadOnly = true;
            this.niivel.Size = new System.Drawing.Size(256, 20);
            this.niivel.TabIndex = 8;
            this.niivel.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(589, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(670, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Listo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buscada
            // 
            this.buscada.Enabled = false;
            this.buscada.Location = new System.Drawing.Point(340, 11);
            this.buscada.Name = "buscada";
            this.buscada.Size = new System.Drawing.Size(243, 20);
            this.buscada.TabIndex = 44;
            this.buscada.Text = "¿Que carta deseas cambiar? (Set)";
            this.buscada.Enter += new System.EventHandler(this.buscada_Enter);
            this.buscada.Leave += new System.EventHandler(this.buscada_Leave);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(521, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Añadir Imagen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(-4, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(38, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(45, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Set";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(22, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Soporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(30, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Rareza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(32, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Copias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(18, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Atributo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(4, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 54;
            this.label9.Text = "ExtraDeck";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(28, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nivel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(11, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 56;
            this.label11.Text = "Arquetipo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(24, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Ataque";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(18, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 58;
            this.label13.Text = "Defensa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(20, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 59;
            this.label14.Text = "Subtipo";
            // 
            // paneletiquetas1
            // 
            this.paneletiquetas1.BackColor = System.Drawing.Color.Transparent;
            this.paneletiquetas1.Controls.Add(this.label5);
            this.paneletiquetas1.Controls.Add(this.label4);
            this.paneletiquetas1.Controls.Add(this.label3);
            this.paneletiquetas1.Controls.Add(this.label1);
            this.paneletiquetas1.Controls.Add(this.label2);
            this.paneletiquetas1.Controls.Add(this.label6);
            this.paneletiquetas1.Controls.Add(this.label7);
            this.paneletiquetas1.Location = new System.Drawing.Point(16, 53);
            this.paneletiquetas1.Name = "paneletiquetas1";
            this.paneletiquetas1.Size = new System.Drawing.Size(71, 381);
            this.paneletiquetas1.TabIndex = 60;
            // 
            // paneletiquetas2
            // 
            this.paneletiquetas2.BackColor = System.Drawing.Color.Transparent;
            this.paneletiquetas2.Controls.Add(this.label14);
            this.paneletiquetas2.Controls.Add(this.label8);
            this.paneletiquetas2.Controls.Add(this.label13);
            this.paneletiquetas2.Controls.Add(this.label9);
            this.paneletiquetas2.Controls.Add(this.label12);
            this.paneletiquetas2.Controls.Add(this.label10);
            this.paneletiquetas2.Controls.Add(this.label11);
            this.paneletiquetas2.Location = new System.Drawing.Point(437, 45);
            this.paneletiquetas2.Name = "paneletiquetas2";
            this.paneletiquetas2.Size = new System.Drawing.Size(71, 285);
            this.paneletiquetas2.TabIndex = 61;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SerializableYugi.Properties.Resources.DUEL_ACADEMY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buscada);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelmonst);
            this.Controls.Add(this.panelgen);
            this.Controls.Add(this.panelCHK);
            this.Controls.Add(this.paneletiquetas1);
            this.Controls.Add(this.paneletiquetas2);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Actualización";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panelCHK.ResumeLayout(false);
            this.panelCHK.PerformLayout();
            this.panelgen.ResumeLayout(false);
            this.panelgen.PerformLayout();
            this.panelmonst.ResumeLayout(false);
            this.panelmonst.PerformLayout();
            this.paneletiquetas1.ResumeLayout(false);
            this.paneletiquetas1.PerformLayout();
            this.paneletiquetas2.ResumeLayout(false);
            this.paneletiquetas2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCHK;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelgen;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox set;
        private System.Windows.Forms.TextBox soporte;
        private System.Windows.Forms.TextBox copias;
        private System.Windows.Forms.Panel panelmonst;
        private System.Windows.Forms.TextBox def;
        private System.Windows.Forms.TextBox attk;
        private System.Windows.Forms.TextBox arquetipo;
        private System.Windows.Forms.TextBox niivel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.ComboBox rareza;
        private System.Windows.Forms.ComboBox subtipo;
        private System.Windows.Forms.ComboBox ExtraDeck;
        private System.Windows.Forms.ComboBox atributo;
        private System.Windows.Forms.TextBox buscada;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel paneletiquetas1;
        private System.Windows.Forms.Panel paneletiquetas2;
    }
}