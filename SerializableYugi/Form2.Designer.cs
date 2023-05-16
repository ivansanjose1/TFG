namespace SerializableYugi
{
    partial class Form2
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.set = new System.Windows.Forms.TextBox();
            this.soporte = new System.Windows.Forms.TextBox();
            this.copias = new System.Windows.Forms.TextBox();
            this.niivel = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.attk = new System.Windows.Forms.TextBox();
            this.def = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.rareza = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Nivel = new System.Windows.Forms.Label();
            this.arquetipo = new System.Windows.Forms.Label();
            this.atk = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.atributo = new System.Windows.Forms.ComboBox();
            this.ExtraDeck = new System.Windows.Forms.ComboBox();
            this.labelcopias = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.subtipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelmonst = new System.Windows.Forms.Panel();
            this.panelmons2 = new System.Windows.Forms.Panel();
            this.panelCHK = new System.Windows.Forms.Panel();
            this.panelgen = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.paneletiquetas1 = new System.Windows.Forms.Panel();
            this.panelmonst.SuspendLayout();
            this.panelmons2.SuspendLayout();
            this.panelCHK.SuspendLayout();
            this.panelgen.SuspendLayout();
            this.paneletiquetas1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(6, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(299, 20);
            this.Nombre.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(6, 45);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(299, 107);
            this.Descripcion.TabIndex = 1;
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(6, 216);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(299, 20);
            this.set.TabIndex = 3;
            // 
            // soporte
            // 
            this.soporte.Location = new System.Drawing.Point(6, 263);
            this.soporte.Name = "soporte";
            this.soporte.Size = new System.Drawing.Size(299, 20);
            this.soporte.TabIndex = 4;
            this.soporte.Text = "No";
            // 
            // copias
            // 
            this.copias.Location = new System.Drawing.Point(6, 360);
            this.copias.Name = "copias";
            this.copias.Size = new System.Drawing.Size(299, 20);
            this.copias.TabIndex = 6;
            this.copias.Text = "1";
            this.copias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.copias_KeyPress);
            // 
            // niivel
            // 
            this.niivel.Location = new System.Drawing.Point(10, 99);
            this.niivel.Name = "niivel";
            this.niivel.Size = new System.Drawing.Size(256, 20);
            this.niivel.TabIndex = 8;
            this.niivel.Text = "1";
            this.niivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.copias_KeyPress);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(10, 131);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(256, 20);
            this.textBox10.TabIndex = 9;
            // 
            // attk
            // 
            this.attk.Location = new System.Drawing.Point(10, 168);
            this.attk.Name = "attk";
            this.attk.Size = new System.Drawing.Size(256, 20);
            this.attk.TabIndex = 10;
            this.attk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.copias_KeyPress);
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(10, 207);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(256, 20);
            this.def.TabIndex = 11;
            this.def.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.copias_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(43, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Set";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(22, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Soporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(25, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rareza";
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
            this.rareza.Text = "C";
            this.rareza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Atributo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(-3, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "ExtraDeck";
            // 
            // Nivel
            // 
            this.Nivel.AutoSize = true;
            this.Nivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nivel.Location = new System.Drawing.Point(23, 101);
            this.Nivel.Name = "Nivel";
            this.Nivel.Size = new System.Drawing.Size(33, 15);
            this.Nivel.TabIndex = 22;
            this.Nivel.Text = "Nivel";
            // 
            // arquetipo
            // 
            this.arquetipo.AutoSize = true;
            this.arquetipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arquetipo.ForeColor = System.Drawing.SystemColors.Control;
            this.arquetipo.Location = new System.Drawing.Point(2, 128);
            this.arquetipo.Name = "arquetipo";
            this.arquetipo.Size = new System.Drawing.Size(54, 15);
            this.arquetipo.TabIndex = 23;
            this.arquetipo.Text = "Arquetipo";
            // 
            // atk
            // 
            this.atk.AutoSize = true;
            this.atk.BackColor = System.Drawing.Color.Black;
            this.atk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.atk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.atk.Location = new System.Drawing.Point(31, 165);
            this.atk.Name = "atk";
            this.atk.Size = new System.Drawing.Size(25, 15);
            this.atk.TabIndex = 24;
            this.atk.Text = "Atk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(30, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Def";
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
            this.atributo.Location = new System.Drawing.Point(10, 19);
            this.atributo.Name = "atributo";
            this.atributo.Size = new System.Drawing.Size(256, 21);
            this.atributo.TabIndex = 26;
            this.atributo.Text = "Luz";
            this.atributo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
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
            this.ExtraDeck.Location = new System.Drawing.Point(10, 61);
            this.ExtraDeck.Name = "ExtraDeck";
            this.ExtraDeck.Size = new System.Drawing.Size(256, 21);
            this.ExtraDeck.TabIndex = 27;
            this.ExtraDeck.Text = "No";
            this.ExtraDeck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
            // 
            // labelcopias
            // 
            this.labelcopias.AutoSize = true;
            this.labelcopias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelcopias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelcopias.Location = new System.Drawing.Point(27, 360);
            this.labelcopias.Name = "labelcopias";
            this.labelcopias.Size = new System.Drawing.Size(41, 15);
            this.labelcopias.TabIndex = 28;
            this.labelcopias.Text = "Copias";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(523, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "DALE!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Black;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox3.Location = new System.Drawing.Point(232, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Tag = "3";
            this.checkBox3.Text = "Trampas";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.subtipo.Location = new System.Drawing.Point(10, 244);
            this.subtipo.Name = "subtipo";
            this.subtipo.Size = new System.Drawing.Size(256, 21);
            this.subtipo.TabIndex = 33;
            this.subtipo.Text = "No";
            this.subtipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(13, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Subtipo";
            // 
            // panelmonst
            // 
            this.panelmonst.BackColor = System.Drawing.Color.Transparent;
            this.panelmonst.Controls.Add(this.subtipo);
            this.panelmonst.Controls.Add(this.ExtraDeck);
            this.panelmonst.Controls.Add(this.atributo);
            this.panelmonst.Controls.Add(this.def);
            this.panelmonst.Controls.Add(this.attk);
            this.panelmonst.Controls.Add(this.textBox10);
            this.panelmonst.Controls.Add(this.niivel);
            this.panelmonst.Enabled = false;
            this.panelmonst.Location = new System.Drawing.Point(523, 16);
            this.panelmonst.Name = "panelmonst";
            this.panelmonst.Size = new System.Drawing.Size(277, 281);
            this.panelmonst.TabIndex = 35;
            // 
            // panelmons2
            // 
            this.panelmons2.BackColor = System.Drawing.Color.Transparent;
            this.panelmons2.Controls.Add(this.label9);
            this.panelmons2.Controls.Add(this.label12);
            this.panelmons2.Controls.Add(this.atk);
            this.panelmons2.Controls.Add(this.arquetipo);
            this.panelmons2.Controls.Add(this.Nivel);
            this.panelmons2.Controls.Add(this.label8);
            this.panelmons2.Controls.Add(this.label7);
            this.panelmons2.Location = new System.Drawing.Point(447, 19);
            this.panelmons2.Name = "panelmons2";
            this.panelmons2.Size = new System.Drawing.Size(76, 262);
            this.panelmons2.TabIndex = 36;
            // 
            // panelCHK
            // 
            this.panelCHK.BackColor = System.Drawing.Color.Transparent;
            this.panelCHK.Controls.Add(this.checkBox3);
            this.panelCHK.Controls.Add(this.checkBox2);
            this.panelCHK.Controls.Add(this.checkBox1);
            this.panelCHK.Location = new System.Drawing.Point(74, 12);
            this.panelCHK.Name = "panelCHK";
            this.panelCHK.Size = new System.Drawing.Size(321, 18);
            this.panelCHK.TabIndex = 37;
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
            this.panelgen.Location = new System.Drawing.Point(81, 35);
            this.panelgen.Name = "panelgen";
            this.panelgen.Size = new System.Drawing.Size(314, 395);
            this.panelgen.TabIndex = 38;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(604, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Añadir Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paneletiquetas1
            // 
            this.paneletiquetas1.BackColor = System.Drawing.Color.Transparent;
            this.paneletiquetas1.Controls.Add(this.label1);
            this.paneletiquetas1.Controls.Add(this.label2);
            this.paneletiquetas1.Controls.Add(this.label3);
            this.paneletiquetas1.Controls.Add(this.label4);
            this.paneletiquetas1.Controls.Add(this.label5);
            this.paneletiquetas1.Controls.Add(this.label6);
            this.paneletiquetas1.Controls.Add(this.labelcopias);
            this.paneletiquetas1.Location = new System.Drawing.Point(1, 35);
            this.paneletiquetas1.Name = "paneletiquetas1";
            this.paneletiquetas1.Size = new System.Drawing.Size(80, 395);
            this.paneletiquetas1.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SerializableYugi.Properties.Resources.DUEL_ACADEMY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneletiquetas1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelCHK);
            this.Controls.Add(this.panelmons2);
            this.Controls.Add(this.panelmonst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelgen);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = " Añadir Cartas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelmonst.ResumeLayout(false);
            this.panelmonst.PerformLayout();
            this.panelmons2.ResumeLayout(false);
            this.panelmons2.PerformLayout();
            this.panelCHK.ResumeLayout(false);
            this.panelCHK.PerformLayout();
            this.panelgen.ResumeLayout(false);
            this.panelgen.PerformLayout();
            this.paneletiquetas1.ResumeLayout(false);
            this.paneletiquetas1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox set;
        private System.Windows.Forms.TextBox soporte;
        private System.Windows.Forms.TextBox copias;
        private System.Windows.Forms.TextBox niivel;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox attk;
        private System.Windows.Forms.TextBox def;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.ComboBox rareza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Nivel;
        private System.Windows.Forms.Label arquetipo;
        private System.Windows.Forms.Label atk;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox atributo;
        private System.Windows.Forms.ComboBox ExtraDeck;
        private System.Windows.Forms.Label labelcopias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox subtipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelmonst;
        private System.Windows.Forms.Panel panelmons2;
        private System.Windows.Forms.Panel panelCHK;
        private System.Windows.Forms.Panel panelgen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel paneletiquetas1;
    }
}