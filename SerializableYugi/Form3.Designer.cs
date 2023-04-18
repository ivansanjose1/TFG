namespace SerializableYugi
{
    partial class Form3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.soporte = new System.Windows.Forms.TextBox();
            this.Monstruos = new System.Windows.Forms.RadioButton();
            this.Magicas = new System.Windows.Forms.RadioButton();
            this.Trampas = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nivel = new System.Windows.Forms.NumericUpDown();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.subtipo = new System.Windows.Forms.ComboBox();
            this.extradeck = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(394, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(15, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(218, 20);
            this.nombre.TabIndex = 3;
            this.nombre.Tag = "2";
            this.nombre.Text = "Buscar por nombre";
            this.nombre.Enter += new System.EventHandler(this.nombre_Enter);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(15, 42);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(218, 20);
            this.descripcion.TabIndex = 4;
            this.descripcion.Tag = "3";
            this.descripcion.Text = "Buscar en la descripcion";
            this.descripcion.Enter += new System.EventHandler(this.nombre_Enter);
            // 
            // soporte
            // 
            this.soporte.Location = new System.Drawing.Point(15, 122);
            this.soporte.Name = "soporte";
            this.soporte.Size = new System.Drawing.Size(218, 20);
            this.soporte.TabIndex = 7;
            this.soporte.Tag = "4";
            this.soporte.Text = "Buscar por soporte";
            this.soporte.Enter += new System.EventHandler(this.nombre_Enter);
            // 
            // Monstruos
            // 
            this.Monstruos.AutoSize = true;
            this.Monstruos.Location = new System.Drawing.Point(28, 4);
            this.Monstruos.Name = "Monstruos";
            this.Monstruos.Size = new System.Drawing.Size(74, 17);
            this.Monstruos.TabIndex = 9;
            this.Monstruos.TabStop = true;
            this.Monstruos.Text = "Monstruos";
            this.Monstruos.UseVisualStyleBackColor = true;
            this.Monstruos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Magicas
            // 
            this.Magicas.AutoSize = true;
            this.Magicas.Location = new System.Drawing.Point(119, 4);
            this.Magicas.Name = "Magicas";
            this.Magicas.Size = new System.Drawing.Size(65, 17);
            this.Magicas.TabIndex = 10;
            this.Magicas.TabStop = true;
            this.Magicas.Text = "Magicas";
            this.Magicas.UseVisualStyleBackColor = true;
            this.Magicas.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Trampas
            // 
            this.Trampas.AutoSize = true;
            this.Trampas.Location = new System.Drawing.Point(210, 4);
            this.Trampas.Name = "Trampas";
            this.Trampas.Size = new System.Drawing.Size(66, 17);
            this.Trampas.TabIndex = 11;
            this.Trampas.TabStop = true;
            this.Trampas.Text = "Trampas";
            this.Trampas.UseVisualStyleBackColor = true;
            this.Trampas.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Nivel);
            this.panel1.Controls.Add(this.tipo);
            this.panel1.Controls.Add(this.subtipo);
            this.panel1.Controls.Add(this.extradeck);
            this.panel1.Controls.Add(this.soporte);
            this.panel1.Controls.Add(this.descripcion);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 346);
            this.panel1.TabIndex = 12;
            // 
            // Nivel
            // 
            this.Nivel.Location = new System.Drawing.Point(15, 164);
            this.Nivel.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Nivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nivel.Name = "Nivel";
            this.Nivel.Size = new System.Drawing.Size(218, 20);
            this.Nivel.TabIndex = 14;
            this.Nivel.Tag = "7";
            this.Nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nivel.Enter += new System.EventHandler(this.nombre_Enter);
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(15, 80);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(218, 21);
            this.tipo.TabIndex = 14;
            this.tipo.Tag = "1";
            this.tipo.Text = "Buscar por tipo";
            this.tipo.Enter += new System.EventHandler(this.nombre_Enter);
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
            this.subtipo.Location = new System.Drawing.Point(15, 246);
            this.subtipo.Name = "subtipo";
            this.subtipo.Size = new System.Drawing.Size(218, 21);
            this.subtipo.TabIndex = 15;
            this.subtipo.Tag = "5";
            this.subtipo.Text = "Buscar por subtipo";
            this.subtipo.Enter += new System.EventHandler(this.nombre_Enter);
            // 
            // extradeck
            // 
            this.extradeck.FormattingEnabled = true;
            this.extradeck.Items.AddRange(new object[] {
            "Fusion",
            "Sincronia",
            "Xyz",
            "Link",
            "No"});
            this.extradeck.Location = new System.Drawing.Point(14, 205);
            this.extradeck.Name = "extradeck";
            this.extradeck.Size = new System.Drawing.Size(219, 21);
            this.extradeck.TabIndex = 14;
            this.extradeck.Tag = "6";
            this.extradeck.Text = "Buscar por ExtraDeck";
            this.extradeck.Enter += new System.EventHandler(this.nombre_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "DALE!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Trampas);
            this.Controls.Add(this.Magicas);
            this.Controls.Add(this.Monstruos);
            this.Controls.Add(this.listBox1);
            this.Name = "Form3";
            this.Text = "Consultar Cartas";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox soporte;
        private System.Windows.Forms.RadioButton Monstruos;
        private System.Windows.Forms.RadioButton Magicas;
        private System.Windows.Forms.RadioButton Trampas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.ComboBox subtipo;
        private System.Windows.Forms.ComboBox extradeck;
        private System.Windows.Forms.NumericUpDown Nivel;
    }
}