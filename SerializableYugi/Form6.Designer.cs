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
            this.Anhadir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.Sugerencia = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBaraja
            // 
            this.listBoxBaraja.FormattingEnabled = true;
            this.listBoxBaraja.Location = new System.Drawing.Point(12, 52);
            this.listBoxBaraja.Name = "listBoxBaraja";
            this.listBoxBaraja.Size = new System.Drawing.Size(482, 251);
            this.listBoxBaraja.TabIndex = 0;
            this.listBoxBaraja.Tag = "";
            // 
            // listBoxMonstruos
            // 
            this.listBoxMonstruos.FormattingEnabled = true;
            this.listBoxMonstruos.Location = new System.Drawing.Point(500, 52);
            this.listBoxMonstruos.Name = "listBoxMonstruos";
            this.listBoxMonstruos.Size = new System.Drawing.Size(224, 108);
            this.listBoxMonstruos.TabIndex = 1;
            this.listBoxMonstruos.Tag = "1";
            this.listBoxMonstruos.Enter += new System.EventHandler(this.listBoxMonstruos_Enter);
            // 
            // listBoxMagia
            // 
            this.listBoxMagia.FormattingEnabled = true;
            this.listBoxMagia.Location = new System.Drawing.Point(501, 195);
            this.listBoxMagia.Name = "listBoxMagia";
            this.listBoxMagia.Size = new System.Drawing.Size(223, 108);
            this.listBoxMagia.TabIndex = 2;
            this.listBoxMagia.Tag = "2";
            this.listBoxMagia.Enter += new System.EventHandler(this.listBoxMonstruos_Enter);
            // 
            // listBoxTrampas
            // 
            this.listBoxTrampas.FormattingEnabled = true;
            this.listBoxTrampas.Location = new System.Drawing.Point(500, 322);
            this.listBoxTrampas.Name = "listBoxTrampas";
            this.listBoxTrampas.Size = new System.Drawing.Size(224, 108);
            this.listBoxTrampas.TabIndex = 3;
            this.listBoxTrampas.Tag = "3";
            this.listBoxTrampas.Enter += new System.EventHandler(this.listBoxMonstruos_Enter);
            // 
            // Anhadir
            // 
            this.Anhadir.Location = new System.Drawing.Point(730, 36);
            this.Anhadir.Name = "Anhadir";
            this.Anhadir.Size = new System.Drawing.Size(89, 24);
            this.Anhadir.TabIndex = 4;
            this.Anhadir.Text = "Añadir";
            this.Anhadir.UseVisualStyleBackColor = true;
            this.Anhadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(730, 66);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(89, 28);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Sugerencia
            // 
            this.Sugerencia.FormattingEnabled = true;
            this.Sugerencia.Location = new System.Drawing.Point(12, 322);
            this.Sugerencia.Name = "Sugerencia";
            this.Sugerencia.Size = new System.Drawing.Size(482, 108);
            this.Sugerencia.TabIndex = 7;
            this.Sugerencia.Tag = "4";
            this.Sugerencia.DoubleClick += new System.EventHandler(this.Sugerencia_DoubleClick);
            this.Sugerencia.Enter += new System.EventHandler(this.listBoxMonstruos_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quizá te interese añadir esta/s:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número de cartas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "Baraja.txt";
            this.saveFileDialog1.Title = "Guardar Baraja";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SerializableYugi.Properties.Resources.DUEL_ACADEMY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sugerencia);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.Anhadir);
            this.Controls.Add(this.listBoxTrampas);
            this.Controls.Add(this.listBoxMagia);
            this.Controls.Add(this.listBoxMonstruos);
            this.Controls.Add(this.listBoxBaraja);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Button Anhadir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox Sugerencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}