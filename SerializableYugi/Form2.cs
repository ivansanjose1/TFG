﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form2 : Form
    {
        ArrayList<Monstruo> monstruos = new ArrayList<Monstruo>();
        string[] tipomons = { "Guerrero", "Demonio", "Lanzador de Conjuros", "Máquina", "Bestia", "Bestia Alada", "Guerrero-Bestia", "Pez", "Serpiente Marina", "Aqua", "Reptil", "Dinosaurio", "Dragón", "Hada", "Zombi", "Roca", "Psíquico", "Piro", "Trueno", "Planta", "Insecto", "Wyrm", "Bestia Divina", "Ciberso" };
        string[] tipomags = { "Normal", "Juego Rápido", "Continua", "Equipo", "Campo", "Ritual" };
        string[] tipotraps = { "Normal", "Continua", "Contraefecto" };
        string archivo = null;
        Monstruo monstruo = null;
        Magica magica = null;
        Trampa trampa = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool almostdone = false;
            archivo = (sender as CheckBox).Text;
            RellenarTipos(sender);
            if ((sender as CheckBox).Text == "Magicas" || (sender as CheckBox).Text == "Trampas")
            {
                panelmons2.Visible = false;
                panelmonst.Visible = false;
            }
            else {
                panelmons2.Visible = true;
                panelmonst.Visible = true;
            }
            foreach (CheckBox ch in panelCHK.Controls) {
                if (!ch.Checked) ch.Enabled = false;
                else almostdone = true;
            }
            if (almostdone == false)
            {
                foreach (CheckBox ch in panelCHK.Controls)
                {
                    ch.Enabled = true;
                }
                panelgen.Enabled = false;
                panelmonst.Enabled = false;
            }
            else {
                panelmonst.Enabled = true;
                panelgen.Enabled = true;   
                 }
        }//METODO CHECKED CHANGE

        private void RellenarTipos(object sender) {
            tipo.Items.Clear();
            switch (int.Parse((string)(sender as Control).Tag)) {
                case 1: tipo.Items.AddRange(tipomons); break;
                case 2: tipo.Items.AddRange(tipomags); break;
                case 3: tipo.Items.AddRange(tipotraps); break;
            }
        }
        private void RellenarMonstruo()
        {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            monstruo = new Monstruo(
                Nombre.Text,
                Descripcion.Text,
                tipo.Text,
                atributo.Text,
                subtipo.Text,
                ExtraDeck.Text,
                arquetipo.Text,
                rareza.Text,
                set.Text,
                soporte.Text,
                int.Parse(attk.Text.Trim()),
                int.Parse(def.Text.Trim()),
                int.Parse(niivel.Text.Trim()),
                int.Parse(copias.Text.Trim())
                ) ;
            bf.Serialize(fs, monstruo);
            fs.Close();
        }

        private void RellenarMagica() {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            magica = new Magica(
                Nombre.Text,
                Descripcion.Text,
                tipo.Text,
                rareza.Text,
                set.Text,
                soporte.Text,
                int.Parse(copias.Text.Trim())
                );
                bf.Serialize(fs, magica);
            fs.Close();
        }

        private void RellenarTrampa() {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            trampa = new Trampa(
                Nombre.Text,
                Descripcion.Text,
                tipo.Text,
                rareza.Text,
                set.Text,
                soporte.Text,
                int.Parse(copias.Text.Trim())
                );
            bf.Serialize(fs, trampa);
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (archivo) {
                case "Monstruos": RellenarMonstruo(); break;
                case "Magicas":   RellenarMagica();break;
                case "Trampas":   RellenarTrampa();break;
            }
            foreach (Control c in panelgen.Controls) {
                c.Text = "";
            }
            foreach(Control c in panelmonst.Controls)
            {
                c.Text = "";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    
}
