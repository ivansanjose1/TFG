﻿using System;
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
            Fuente.CargarFuente();
            Fuente.LocalizarFuente(this.button1, 20);
            Fuente.LocalizarFuente(this.button2, 20);
            Fuente.LocalizarFuente(this.button3, 20);
        }
    }
}
