namespace SerializableYugi
{
    partial class Carta
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.atributo = new System.Windows.Forms.PictureBox();
            this.atk = new System.Windows.Forms.TextBox();
            this.def = new System.Windows.Forms.TextBox();
            this.tipomons = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ilustracion = new System.Windows.Forms.PictureBox();
            this.set = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.atributo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustracion)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(12, 13);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(225, 20);
            this.nombre.TabIndex = 0;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(12, 300);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Size = new System.Drawing.Size(257, 98);
            this.descripcion.TabIndex = 1;
            // 
            // atributo
            // 
            this.atributo.Location = new System.Drawing.Point(246, 1);
            this.atributo.Name = "atributo";
            this.atributo.Size = new System.Drawing.Size(36, 32);
            this.atributo.TabIndex = 2;
            this.atributo.TabStop = false;
            // 
            // atk
            // 
            this.atk.Location = new System.Drawing.Point(3, 6);
            this.atk.Name = "atk";
            this.atk.ReadOnly = true;
            this.atk.Size = new System.Drawing.Size(68, 20);
            this.atk.TabIndex = 4;
            this.atk.Text = "ATK";
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(77, 6);
            this.def.Name = "def";
            this.def.ReadOnly = true;
            this.def.Size = new System.Drawing.Size(68, 20);
            this.def.TabIndex = 5;
            this.def.Text = "DEF";
            // 
            // tipomons
            // 
            this.tipomons.Location = new System.Drawing.Point(12, 274);
            this.tipomons.Name = "tipomons";
            this.tipomons.ReadOnly = true;
            this.tipomons.Size = new System.Drawing.Size(100, 20);
            this.tipomons.TabIndex = 6;
            this.tipomons.Visible = false;
            // 
            // tipo
            // 
            this.tipo.Location = new System.Drawing.Point(159, 39);
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Size = new System.Drawing.Size(105, 20);
            this.tipo.TabIndex = 8;
            this.tipo.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.atk);
            this.panel2.Controls.Add(this.def);
            this.panel2.Location = new System.Drawing.Point(119, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 29);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // ilustracion
            // 
            this.ilustracion.Location = new System.Drawing.Point(30, 70);
            this.ilustracion.Name = "ilustracion";
            this.ilustracion.Size = new System.Drawing.Size(219, 198);
            this.ilustracion.TabIndex = 10;
            this.ilustracion.TabStop = false;
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(196, 274);
            this.set.Name = "set";
            this.set.ReadOnly = true;
            this.set.Size = new System.Drawing.Size(67, 20);
            this.set.TabIndex = 11;
            // 
            // Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.set);
            this.Controls.Add(this.tipomons);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.ilustracion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.atributo);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Name = "Carta";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.atributo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.PictureBox atributo;
        private System.Windows.Forms.TextBox atk;
        private System.Windows.Forms.TextBox def;
        private System.Windows.Forms.TextBox tipomons;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ilustracion;
        private System.Windows.Forms.TextBox set;
    }
}