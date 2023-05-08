﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerializableYugi
{
    public partial class Form6 : Form
    {
        ArrayList<Monstruo> monstruos = new ArrayList<Monstruo>();
        Monstruo monstruo = null;
        Magica magica = null;
        Trampa trampa = null;
        int focuslistbox = 0;
        int limite_Cartas= 60;


        public Form6()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Monstrar_monstruos();
            Monstrar_magicas();
        }

        private void Monstrar_monstruos()
        {
            FileStream fs = new FileStream("Monstruos", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                monstruo = (Monstruo)bf.Deserialize(fs);
                listBoxMonstruos.Items.Add(monstruo);
            }
            fs.Close();
        }

        private void Monstrar_magicas()
        {
            FileStream fs = new FileStream("Magicas", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                magica = (Magica)bf.Deserialize(fs);
                listBoxMagia.Items.Add(magica);

            }
            fs.Close();
        }

        private void Monstrar_trampas()
        {
            FileStream fs = new FileStream("Trampas", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                trampa = (Trampa)bf.Deserialize(fs);
                listBoxTrampas.Items.Add(trampa);

            }
            fs.Close();
        }

        private void AnnnadirBaraja()
        {
            switch (focuslistbox)
            {
                case 1:
                    listBoxBaraja.Items.Add(listBoxMonstruos.SelectedItem);
                    Posibles_Sugerencias((Monstruo)listBoxMonstruos.SelectedItem);
                    break;
                case 2:
                    listBoxBaraja.Items.Add(listBoxMagia.SelectedItem);
                    break;
                case 3:
                    listBoxBaraja.Items.Add(listBoxTrampas.SelectedItem);
                    break;
            }

        }
        private void Comprobador_Cartas()
        {
            int total_Cartas_Actualers = listBoxBaraja.Items.Count;
            if (total_Cartas_Actualers >= limite_Cartas + 1)
            {
                MessageBox.Show("Has llegado al limite");
                listBoxMonstruos.Enabled = false;
                listBoxMagia.Enabled = false;
                listBoxTrampas.Enabled = false;
            }
            else
            {
                textBox1.Text = limite_Cartas + "/" + total_Cartas_Actualers;
                listBoxMonstruos.Enabled = true;
                listBoxMagia.Enabled = true;
                listBoxTrampas.Enabled = true;

            }
        }

        private void listBoxMonstruos_Enter(object sender, EventArgs e)
        {
            switch (int.Parse((string)(sender as ListBox).Tag))
            {
                case 1:
                    focuslistbox = 1;
                    break;
                case 2:
                    focuslistbox = 2;
                    break;
                case 3:
                    focuslistbox = 3;
                    break;
            }

        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                Añadir_Click(sender, e);//llama al evento click del boton
            }
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            
            AnnnadirBaraja();
            Comprobador_Cartas();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listBoxBaraja.Items.Remove(listBoxBaraja.SelectedItem);
            Comprobador_Cartas();
        }

        private void Posibles_Sugerencias(Monstruo iimonstruo)
        {

            FileStream fsMonstruos = new FileStream("Monstruos", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fsMonstruos.Position < fsMonstruos.Length)
            {
                monstruo = (Monstruo)bf.Deserialize(fsMonstruos);

                if (iimonstruo.get_nombre().ToLower().Contains(monstruo.get_soporte().ToLower())&&monstruo.get_soporte()!=""&& monstruo.get_soporte().ToLower()!= "no")
                {
                    if (!ComprobarSugerencias(monstruo, null, 1)) Sugerencia.Items.Add(monstruo);
                }

            }
            fsMonstruos.Close();

            FileStream fsMagicas = new FileStream("Magicas", FileMode.Open);

            while (fsMagicas.Position < fsMagicas.Length)
            {
                magica = (Magica)bf.Deserialize(fsMagicas);
                if (iimonstruo.get_nombre().ToLower().Contains(magica.get_soporte().ToLower()) && magica.get_soporte() != "" && magica.get_soporte().ToLower() != "no")
                {
                    if(!ComprobarSugerencias(null, magica, 2)) Sugerencia.Items.Add(magica);
                }

            }
            fsMagicas.Close();

            try
            {
                FileStream fsTrampas = new FileStream("Trampas", FileMode.Open);
                while (fsTrampas.Position < fsTrampas.Length)
                {
                    trampa = (Trampa)bf.Deserialize(fsTrampas);
                    if (trampa.get_soporte() == iimonstruo.get_arquetipo())
                    {
                        Sugerencia.Items.Add(trampa);
                    }

                }
                fsTrampas.Close();
            }catch(Exception e){ }
           


        }





        private void listBoxBaraja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sugerencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ComprobarSugerencias(Monstruo iimonstruo, Magica iimagica, int indicador) {
            bool encontrado = false;
            switch (indicador) {
                case 1:
                    for (int i = 0; i < Sugerencia.Items.Count; i++)
                    {
                        if (iimonstruo.GetType() == Sugerencia.Items[i].GetType() && iimonstruo.get_nombre() == (Sugerencia.Items[i] as Monstruo).get_nombre()) encontrado = true;
                    }
                    break;
                
                case 2:
                    for (int i = 0; i < Sugerencia.Items.Count; i++)
                    {
                        if (iimagica.GetType()==Sugerencia.Items[i].GetType()&&iimagica.get_nombre() == (Sugerencia.Items[i] as Magica).get_nombre()) encontrado = true;
                    }
                    break;

            }
            return encontrado;

        }
    }
}
