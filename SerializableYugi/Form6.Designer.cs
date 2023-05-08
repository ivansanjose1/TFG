namespace SerializableYugi
{
    partial class Form6
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
            this.listBoxBaraja = new System.Windows.Forms.ListBox();
            this.listBoxMonstruos = new System.Windows.Forms.ListBox();
            this.listBoxMagia = new System.Windows.Forms.ListBox();
            this.listBoxTrampas = new System.Windows.Forms.ListBox();
            this.Añadir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.Sugerencia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxBaraja
            // 
            this.listBoxBaraja.FormattingEnabled = true;
            this.listBoxBaraja.Location = new System.Drawing.Point(51, 52);
            this.listBoxBaraja.Name = "listBoxBaraja";
            this.listBoxBaraja.Size = new System.Drawing.Size(482, 251);
            this.listBoxBaraja.TabIndex = 0;
            this.listBoxBaraja.Tag = "";
            this.listBoxBaraja.SelectedIndexChanged += new System.EventHandler(this.listBoxBaraja_SelectedIndexChanged);
            // 
            // listBoxMonstruos
            // 
            this.listBoxMonstruos.FormattingEnabled = true;
            this.listBoxMonstruos.Location = new System.Drawing.Point(584, 52);
            this.listBoxMonstruos.Name = "listBoxMonstruos";
            this.listBoxMonstruos.Size = new System.Drawing.Size(190, 108);
            this.listBoxMonstruos.TabIndex = 1;
            this.listBoxMonstruos.Tag = "1";
            this.listBoxMonstruos.Enter += new System.EventHandler(this.listBoxMonstruos_Enter);
            // 
            // listBoxMagia
            // 
            this.listBoxMagia.FormattingEnabled = true;
            this.listBoxMagia.Location = new System.Drawing.Point(584, 175);
            this.listBoxMagia.Name = "listBoxMagia";
            this.listBoxMagia.Size = new System.Drawing.Size(189, 108);
            this.listBoxMagia.TabIndex = 2;
            this.listBoxMagia.Tag = "2";
            this.listBoxMagia.Enter += new System.EventHandler(this.listBoxMonstruos_Enter);
            // 
            // listBoxTrampas
            // 
            this.listBoxTrampas.FormattingEnabled = true;
            this.listBoxTrampas.Location = new System.Drawing.Point(584, 294);
            this.listBoxTrampas.Name = "listBoxTrampas";
            this.listBoxTrampas.Size = new System.Drawing.Size(189, 108);
            this.listBoxTrampas.TabIndex = 3;
            this.listBoxTrampas.Tag = "3";
            this.listBoxTrampas.Enter += new System.EventHandler(this.listBoxMonstruos_Enter);
            // 
            // Añadir
            // 
            this.Añadir.Location = new System.Drawing.Point(753, 570);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(89, 42);
            this.Añadir.TabIndex = 4;
            this.Añadir.Text = "Añadir";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(51, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(543, 570);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(89, 42);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Sugerencia
            // 
            this.Sugerencia.FormattingEnabled = true;
            this.Sugerencia.Location = new System.Drawing.Point(51, 361);
            this.Sugerencia.Name = "Sugerencia";
            this.Sugerencia.Size = new System.Drawing.Size(482, 108);
            this.Sugerencia.TabIndex = 7;
            this.Sugerencia.Tag = "";
            this.Sugerencia.SelectedIndexChanged += new System.EventHandler(this.Sugerencia_SelectedIndexChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 653);
            this.Controls.Add(this.Sugerencia);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.listBoxTrampas);
            this.Controls.Add(this.listBoxMagia);
            this.Controls.Add(this.listBoxMonstruos);
            this.Controls.Add(this.listBoxBaraja);
            this.Name = "Form6";
            this.Text = "Barajas";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBaraja;
        private System.Windows.Forms.ListBox listBoxMonstruos;
        private System.Windows.Forms.ListBox listBoxMagia;
        private System.Windows.Forms.ListBox listBoxTrampas;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox Sugerencia;
    }
}