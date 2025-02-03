using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carta));
            this.panel2 = new System.Windows.Forms.Panel();
            this.atk = new System.Windows.Forms.TextBox();
            this.def = new System.Windows.Forms.TextBox();
            this.set = new System.Windows.Forms.TextBox();
            this.ilustracion = new System.Windows.Forms.PictureBox();
            this.atributo = new System.Windows.Forms.PictureBox();
            this.editar = new System.Windows.Forms.Button();
            this.tipomons = new System.Windows.Forms.TextBox();
            this.panelnivel = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tipo = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributo)).BeginInit();
            this.panelnivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.atk);
            this.panel2.Controls.Add(this.def);
            this.panel2.Location = new System.Drawing.Point(119, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 29);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // atk
            // 
            this.atk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(197)))));
            this.atk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.atk.Location = new System.Drawing.Point(3, -2);
            this.atk.Name = "atk";
            this.atk.ReadOnly = true;
            this.atk.Size = new System.Drawing.Size(68, 13);
            this.atk.TabIndex = 4;
            this.atk.Text = "ATK";
            // 
            // def
            // 
            this.def.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(197)))));
            this.def.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.def.Location = new System.Drawing.Point(76, -2);
            this.def.Name = "def";
            this.def.ReadOnly = true;
            this.def.Size = new System.Drawing.Size(68, 13);
            this.def.TabIndex = 5;
            this.def.Text = "DEF";
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(147)))), ((int)(((byte)(71)))));
            this.set.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set.Location = new System.Drawing.Point(196, 322);
            this.set.Name = "set";
            this.set.ReadOnly = true;
            this.set.Size = new System.Drawing.Size(67, 13);
            this.set.TabIndex = 11;
            // 
            // ilustracion
            // 
            this.ilustracion.ErrorImage = global::SerializableYugi.Properties.Resources.DEFAULTerror;
            this.ilustracion.Image = global::SerializableYugi.Properties.Resources.DEFAULTerror;
            this.ilustracion.InitialImage = global::SerializableYugi.Properties.Resources.DEFAULTerror;
            this.ilustracion.Location = new System.Drawing.Point(36, 83);
            this.ilustracion.Name = "ilustracion";
            this.ilustracion.Size = new System.Drawing.Size(212, 233);
            this.ilustracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ilustracion.TabIndex = 10;
            this.ilustracion.TabStop = false;
            // 
            // atributo
            // 
            this.atributo.BackColor = System.Drawing.Color.Transparent;
            this.atributo.Location = new System.Drawing.Point(239, 25);
            this.atributo.Name = "atributo";
            this.atributo.Size = new System.Drawing.Size(20, 20);
            this.atributo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atributo.TabIndex = 2;
            this.atributo.TabStop = false;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(12, 425);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(66, 20);
            this.editar.TabIndex = 12;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tipomons
            // 
            this.tipomons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(197)))));
            this.tipomons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipomons.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tipomons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipomons.Location = new System.Drawing.Point(23, 336);
            this.tipomons.Name = "tipomons";
            this.tipomons.ReadOnly = true;
            this.tipomons.Size = new System.Drawing.Size(133, 13);
            this.tipomons.TabIndex = 6;
            this.tipomons.Visible = false;
            // 
            // panelnivel
            // 
            this.panelnivel.BackColor = System.Drawing.Color.Transparent;
            this.panelnivel.Controls.Add(this.pictureBox12);
            this.panelnivel.Controls.Add(this.pictureBox9);
            this.panelnivel.Controls.Add(this.pictureBox11);
            this.panelnivel.Controls.Add(this.pictureBox8);
            this.panelnivel.Controls.Add(this.pictureBox3);
            this.panelnivel.Controls.Add(this.pictureBox6);
            this.panelnivel.Controls.Add(this.pictureBox10);
            this.panelnivel.Controls.Add(this.pictureBox7);
            this.panelnivel.Controls.Add(this.pictureBox5);
            this.panelnivel.Controls.Add(this.pictureBox2);
            this.panelnivel.Controls.Add(this.pictureBox1);
            this.panelnivel.Controls.Add(this.pictureBox4);
            this.panelnivel.Location = new System.Drawing.Point(18, 54);
            this.panelnivel.Name = "panelnivel";
            this.panelnivel.Size = new System.Drawing.Size(246, 20);
            this.panelnivel.TabIndex = 14;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(223, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(15, 15);
            this.pictureBox12.TabIndex = 17;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "0";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(183, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 15);
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "2";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(203, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(15, 15);
            this.pictureBox11.TabIndex = 16;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "1";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(143, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 15);
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "4";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(123, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "5";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(103, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "6";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(163, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(15, 15);
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "3";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(63, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 15);
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "8";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "11";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(83, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "10";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(43, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "9";
            // 
            // tipo
            // 
            this.tipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipo.Location = new System.Drawing.Point(36, 80);
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Size = new System.Drawing.Size(105, 13);
            this.tipo.TabIndex = 8;
            this.tipo.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(220)))), ((int)(((byte)(197)))));
            this.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcion.Location = new System.Drawing.Point(23, 347);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcion.Size = new System.Drawing.Size(257, 56);
            this.descripcion.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(147)))), ((int)(((byte)(71)))));
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(23, 24);
            this.nombre.Margin = new System.Windows.Forms.Padding(0);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(213, 13);
            this.nombre.TabIndex = 13;
            this.nombre.WordWrap = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox13.Location = new System.Drawing.Point(22, 407);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(240, 1);
            this.pictureBox13.TabIndex = 15;
            this.pictureBox13.TabStop = false;
            // 
            // Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.panelnivel);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.set);
            this.Controls.Add(this.tipomons);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.ilustracion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.atributo);
            this.Controls.Add(this.descripcion);
            this.DoubleBuffered = true;
            this.Name = "Carta";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Carta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributo)).EndInit();
            this.panelnivel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox atributo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ilustracion;
        private System.Windows.Forms.TextBox set;
        private System.Windows.Forms.Button editar;
        private TextBox atk;
        private TextBox def;
        private TextBox tipomons;
        private Panel panelnivel;
        private PictureBox pictureBox12;
        private PictureBox pictureBox9;
        private PictureBox pictureBox11;
        private PictureBox pictureBox8;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox10;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private TextBox tipo;
        private TextBox descripcion;
        private TextBox nombre;
        private PictureBox pictureBox13;
    }
}