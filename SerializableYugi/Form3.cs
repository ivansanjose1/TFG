﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form3 : Form
    {
        public Form3(int iimodo)
        {
            InitializeComponent();
            this.modo = iimodo;
        }
        string[] tipomons = { "Guerrero", "Demonio", "Lanzador de Conjuros", "Máquina", "Bestia", "Bestia Alada", "Guerrero-Bestia", "Pez", "Serpiente Marina", "Aqua", "Reptil", "Dinosaurio", "Dragón", "Hada", "Zombi", "Roca", "Psíquico", "Piro", "Trueno", "Planta", "Insecto", "Wyrm", "Bestia Divina", "Ciberso" };
        string[] tipomags = { "Normal", "Juego Rápido", "Continua", "Equipo", "Campo", "Ritual" };
        string[] tipotraps = { "Normal", "Continua", "Contraefecto" };
        List<Monstruo> listmons = new List<Monstruo>();
        List<Magica> listmagicas = new List<Magica>();
        List<Trampa> listrampa = new List<Trampa>();
        Monstruo mons = null;
        Magica magica = null;
        Trampa trampa = null;
        string archivo = null;
        int modo;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            tipo.Items.Clear();
            switch ((sender as RadioButton).Name) {
                case "Monstruos": HabilitarMonstruos(); archivo = (sender as RadioButton).Name; tipo.Items.AddRange(tipomons); break;
                case "Magicas": HabilitarMagicasYTrampas(); archivo = (sender as RadioButton).Name; tipo.Items.AddRange(tipomags); break;
                case "Trampas": HabilitarMagicasYTrampas(); archivo = (sender as RadioButton).Name; tipo.Items.AddRange(tipotraps); break;
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void HabilitarMonstruos() {
            foreach (Control ct in panel1.Controls) {
                ct.Enabled = true;
            }
        }

        private void HabilitarMagicasYTrampas() {
            nombre.Enabled = true;
            descripcion.Enabled = true;
            soporte.Enabled = true;
            tipo.Enabled = true;
            Nivel.Enabled = false;
            subtipo.Enabled = false;
            extradeck.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            switch (modo) {
                case 1: Buscar_PorTipo(); break;
                case 2: BuscarPorNombre(); break;
                case 3: BuscarEnDescripcion(); break;
                case 4: BuscarArquetipo(); break;
                case 5: BuscarporSubtipo(); break;
                case 6: BuscarporExtraDeck(); break;
                case 7: BuscarPorNivel(); break;
            }

        }

        private void Buscar_PorTipo() {
            switch (archivo)
            {
                case "Monstruos": RellenarListaMonstruos(); break;
                case "Magicas": RellenarListaMagicas(); break;
                case "Trampas": RellenarListaTrampas(); break;
            }//SWITCH
        }//BUSCARPORTIPO
        private void RellenarListaMonstruos() {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                mons = (Monstruo)bf.Deserialize(fs);
                if (mons.get_tipo().Equals(tipo.Text, StringComparison.OrdinalIgnoreCase)) listBox1.Items.Add(mons);
            }
            fs.Close();
        }//RELLENAR

        private void RellenarListaMagicas() {
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    magica = (Magica)bf.Deserialize(fs);
                    if (magica.get_tipo().Equals(tipo.Text, StringComparison.OrdinalIgnoreCase)) listBox1.Items.Add(magica);
                }
                fs.Close();
            }
            catch (Exception) { MessageBox.Show("No tienes una lista de para esta opcion"); }
        }//RELLENARMAGS

        private void RellenarListaTrampas() {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                trampa = (Trampa)bf.Deserialize(fs);
                if (trampa.get_tipo().Equals(tipo.Text, StringComparison.OrdinalIgnoreCase)) listBox1.Items.Add(trampa);
            }
            fs.Close();
        }

        private void BuscarPorNombre() {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            switch (archivo) {
                case "Magicas":

                    while (fs.Position < fs.Length)
                    {
                        magica = (Magica)bf.Deserialize(fs);
                        if (magica.get_nombre().ToLower().Contains(nombre.Text.ToLower())) listBox1.Items.Add(magica);
                    }; break;
                case "Monstruos":
                    while (fs.Position < fs.Length)
                    {
                        mons = (Monstruo)bf.Deserialize(fs);
                        if (mons.get_nombre().ToLower().Contains(nombre.Text.ToLower())) listBox1.Items.Add(mons);
                    }; break;
                case "Trampas":
                    while (fs.Position < fs.Length)
                    {
                        trampa = (Trampa)bf.Deserialize(fs);
                        if (trampa.get_nombre().ToLower().Contains(nombre.Text.ToLower())) listBox1.Items.Add(trampa);
                    }; break;
            }//SWITCH

            fs.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                switch (archivo) {
                    case "Monstruos": MostrarCarta((Monstruo)listBox1.SelectedItem, null, null); break;
                    case "Magicas": MostrarCarta(null, (Magica)listBox1.SelectedItem, null); break;
                    case "Trampas": MostrarCarta(null, null, (Trampa)listBox1.SelectedItem); break;
                }//SWITCH
        }

        public void LimpiarTexto(object sender) {
            if (sender.GetType().Equals(nombre.GetType())) (sender as TextBox).Clear();
        }

        private void BuscarArquetipo() {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            switch (archivo)
            {
                case "Magicas":
                    while (fs.Position < fs.Length)
                    {
                        magica = (Magica)bf.Deserialize(fs);
                        if (magica.get_soporte().ToLower().Contains(soporte.Text.ToLower())) listBox1.Items.Add(magica);
                    }; break;
                case "Monstruos":
                    while (fs.Position < fs.Length)
                    {
                        mons = (Monstruo)bf.Deserialize(fs);
                        if (mons.get_soporte().ToLower().Contains(soporte.Text.ToLower())) listBox1.Items.Add(mons);
                    }; break;
                case "Trampas":
                    while (fs.Position < fs.Length)
                    {
                        trampa = (Trampa)bf.Deserialize(fs);
                        if (trampa.get_soporte().ToLower().Contains(soporte.Text.ToLower())) listBox1.Items.Add(trampa);
                    }; break;
            }//SWITCH

            fs.Close();
        }

        private void nombre_Enter(object sender, EventArgs e)
        {
            LimpiarTexto(sender);
            modo = int.Parse((sender as Control).Tag.ToString());
        }

        private void BuscarEnDescripcion() {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            switch (archivo)
            {
                case "Magicas":
                    while (fs.Position < fs.Length)
                    {
                        magica = (Magica)bf.Deserialize(fs);
                        if (magica.getDescripcion().ToLower().Contains(descripcion.Text.ToLower())) listBox1.Items.Add(magica);
                    }; break;
                case "Monstruos":
                    while (fs.Position < fs.Length)
                    {
                        mons = (Monstruo)bf.Deserialize(fs);
                        if (mons.getDescripcion().ToLower().Contains(descripcion.Text.ToLower())) listBox1.Items.Add(mons);
                    }; break;
                case "Trampas":
                    while (fs.Position < fs.Length)
                    {
                        trampa = (Trampa)bf.Deserialize(fs);
                        if (trampa.getDescripcion().ToLower().Contains(descripcion.Text.ToLower())) listBox1.Items.Add(trampa);
                    }; break;
            }//SWITCH

            fs.Close();
        }//BUSCAR EN DESCRIPCION

        private void BuscarporSubtipo() {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                mons = (Monstruo)bf.Deserialize(fs);
                if (mons.getSubtipo().Equals(subtipo.Text, StringComparison.OrdinalIgnoreCase)) listBox1.Items.Add(mons);
            };
            fs.Close();
        }

        private void BuscarporExtraDeck() {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                mons = (Monstruo)bf.Deserialize(fs);
                if (mons.getExtraDeck().Equals(extradeck.Text, StringComparison.OrdinalIgnoreCase)) listBox1.Items.Add(mons);
            };
            fs.Close();
        }

        private void BuscarPorNivel() {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                mons = (Monstruo)bf.Deserialize(fs);
                if (mons.getNivel().Equals((int)Nivel.Value)) listBox1.Items.Add(mons);
            };
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)//ESTE BOTON ES EL DE LA ACTUALIZACION
        {

        }

        private void MostrarCarta(Monstruo m, Magica ma, Trampa t) {

            Carta cr = null;
            try
            {
                switch (archivo)
                {
                    case "Monstruos":
                        cr = new Carta(m.get_nombre(), m.getDescripcion(), " " + m.get_atk(), " " + m.get_def(), m.get_tipo(), m.get_atributo(), m.get_set());
                        break;
                    case "Magicas":
                        cr = new Carta(ma.get_nombre(), ma.get_tipo(), ma.getDescripcion(), ma.get_rareza());
                        break;
                    case "Trampas":
                        cr = new Carta(t.get_nombre(), t.get_tipo(), t.getDescripcion(), t.get_rareza());
                        break;

                }//SWITCH
                cr.ShowDialog();
            }
            catch (Exception ex) { }             
               
            }
        }
}

