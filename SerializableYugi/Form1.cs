using System;
using System.Drawing;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(1);
            fr3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.OBELISKPIXELART;
            Fuente.CargarFuente();
            Fuente.LocalizarFuente(this.button1, 20);
            Fuente.LocalizarFuente(this.button2, 20);
            Fuente.LocalizarFuente(this.button3, 20);
            Fuente.LocalizarFuente(this.button4, 20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            string boton = (sender as Button).Name;
            switch (boton) {
                case "button2":
                    (sender as Button).BringToFront();
                    (sender as Button).Height = 239;
                    (sender as Button).Width = 402;
                    (sender as Button).Location = new Point(50, 20);
                    (sender as Button).BackgroundImage = Properties.Resources.SOGENCOLORPXART;
                    (sender as Button).ForeColor = System.Drawing.Color.CornflowerBlue;
                    break;
                case "button1":
                    (sender as Button).BringToFront();
                    (sender as Button).Height = 239;
                    (sender as Button).Width = 402;
                    (sender as Button).Location = new Point(362, 20);
                    (sender as Button).BackgroundImage = Properties.Resources.MONTANACOLORPXART;
                    (sender as Button).ForeColor = System.Drawing.Color.LightSteelBlue;
                    break;
                case "button3":
                    (sender as Button).BringToFront();
                    (sender as Button).Height = 239;
                    (sender as Button).Width = 402;
                    (sender as Button).Location = new Point(50, 190);
                    (sender as Button).BackgroundImage = Properties.Resources.SPARKCOLORPXART;
                    (sender as Button).ForeColor = System.Drawing.Color.LightGray;
                    break;
                case "button4":
                    (sender as Button).BringToFront();
                    (sender as Button).Height = 239;
                    (sender as Button).Width = 402;
                    (sender as Button).Location = new Point(362, 190);
                    (sender as Button).BackgroundImage = Properties.Resources.YAMICOLORPXART;
                    (sender as Button).ForeColor = System.Drawing.Color.Fuchsia;
                    break;

            }
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            string boton = (sender as Button).Name;
            switch (boton)
            {
                case "button2":
                    (sender as Button).Height = 219;
                    (sender as Button).Width = 382;
                    (sender as Button).Location = new Point(12, 3);
                    (sender as Button).BackgroundImage = Properties.Resources.SOGENBWPXART;
                    (sender as Button).ForeColor = System.Drawing.Color.Black;
                    break;
                case "button1":
                    (sender as Button).Height = 219;
                    (sender as Button).Width = 382;
                    (sender as Button).Location = new Point(400, 3);
                    (sender as Button).BackgroundImage = Properties.Resources.MOUNTAINPXARTBW;
                    (sender as Button).ForeColor = System.Drawing.Color.Black;
                    break;
                case "button3":
                    (sender as Button).Height = 219;
                    (sender as Button).Width = 382;
                    (sender as Button).Location = new Point(12, 228);
                    (sender as Button).BackgroundImage = Properties.Resources.SPARKBWPXART;
                    (sender as Button).ForeColor = System.Drawing.Color.Black;
                    break;
                case "button4":
                    (sender as Button).Height = 219;
                    (sender as Button).Width = 382;
                    (sender as Button).Location = new Point(400, 228);
                    (sender as Button).BackgroundImage = Properties.Resources.YAMIPXARTBW;
                    (sender as Button).ForeColor = System.Drawing.Color.Gray;
                    break;

            }

        }

    }
}
