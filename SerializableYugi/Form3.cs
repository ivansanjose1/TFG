using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form3 : Form
    {
        public Form3(int iimodo)
        {
            InitializeComponent();
            this.modo = iimodo;
        }//CONSTRUCTOR
        string archivo = null;
        int modo;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            button1.Enabled = true;
            tipo.Items.Clear();
            switch ((sender as RadioButton).Name)
            {
                case "Monstruos": HabilitarMonstruos(); archivo = (sender as RadioButton).Name; tipo.Items.AddRange(Formulario.get_tipomons()); break;
                case "Magicas": HabilitarMagicasYTrampas(); archivo = (sender as RadioButton).Name; tipo.Items.AddRange(Formulario.get_tipomags()); break;
                case "Trampas": HabilitarMagicasYTrampas(); archivo = (sender as RadioButton).Name; tipo.Items.AddRange(Formulario.get_tipotraps()); break;
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.RAPIXELART;
            Fuente.CargarFuente();
            foreach (Control c in panel1.Controls)
            {
                Fuente.LocalizarFuente(c, 8);
            }
            Fuente.LocalizarFuente(listBox1, 9);
            Fuente.LocalizarFuente(Monstruos, 8);
            Fuente.LocalizarFuente(Magicas, 8);
            Fuente.LocalizarFuente(Trampas, 8);
            Fuente.LocalizarFuente(button1, 8);
            Fuente.LocalizarFuente(label1, 8);
        }

        private void HabilitarMonstruos()
        {
            foreach (Control ct in panel1.Controls)
            {
                ct.Enabled = true;
            }
        }

        private void HabilitarMagicasYTrampas()
        {
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
            switch (modo)
            {
                case 1: Buscar_PorTipo(); break;
                case 2: BuscarPorNombre(); break;
                case 3: BuscarEnDescripcion(); break;
                case 4: BuscarArquetipo(); break;
                case 5: BuscarporSubtipo(); break;
                case 6: BuscarporExtraDeck(); break;
                case 7: BuscarPorNivel(); break;
            }
            ReestablecerTextos();
        }

        private void Buscar_PorTipo()
        {
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                switch (archivo)
                {
                    case "Magicas":

                        while (fs.Position < fs.Length)
                        {
                            Magica magica = (Magica)bf.Deserialize(fs);
                            if (magica.Tipo.ToLower().Contains(tipo.Text.ToLower())) listBox1.Items.Add(magica);
                        }; break;
                    case "Monstruos":
                        while (fs.Position < fs.Length)
                        {
                            Monstruo mons = (Monstruo)bf.Deserialize(fs);
                            if (mons.Tipo.ToLower().Contains(tipo.Text.ToLower())) listBox1.Items.Add(mons);
                        }; break;
                    case "Trampas":
                        while (fs.Position < fs.Length)
                        {
                            Trampa trampa = (Trampa)bf.Deserialize(fs);
                            if (trampa.Tipo.ToLower().Contains(tipo.Text.ToLower())) listBox1.Items.Add(trampa);
                        }; break;
                }//SWITCH

                fs.Close();
            }
            catch (FileNotFoundException) { MensajeNotFound(); }
        }//BUSCARPORTIPO

        private void BuscarPorNombre()
        {
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                switch (archivo)
                {
                    case "Magicas":

                        while (fs.Position < fs.Length)
                        {
                            Magica magica = (Magica)bf.Deserialize(fs);
                            if (magica.Nombre.ToLower().Contains(nombre.Text.ToLower())) listBox1.Items.Add(magica);
                        }; break;
                    case "Monstruos":
                        while (fs.Position < fs.Length)
                        {
                            Monstruo mons = (Monstruo)bf.Deserialize(fs);
                            if (mons.Nombre.ToLower().Contains(nombre.Text.ToLower())) listBox1.Items.Add(mons);
                        }; break;
                    case "Trampas":
                        while (fs.Position < fs.Length)
                        {
                            Trampa trampa = (Trampa)bf.Deserialize(fs);
                            if (trampa.Nombre.ToLower().Contains(nombre.Text.ToLower())) listBox1.Items.Add(trampa);
                        }; break;
                }//SWITCH

                fs.Close();
            }
            catch (FileNotFoundException) { MensajeNotFound(); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (archivo)
            {
                case "Monstruos": MostrarCarta((Karta)listBox1.SelectedItem); break;
                case "Magicas": MostrarCarta((Karta)listBox1.SelectedItem); break;
                case "Trampas": MostrarCarta((Karta)listBox1.SelectedItem); break;
            }//SWITCH
        }

        public void LimpiarTexto(object sender)
        {
            if (sender is TextBox) (sender as TextBox).Clear();
        }

        private void BuscarArquetipo()
        {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                switch (archivo)
                {
                    case "Magicas":
                        while (fs.Position < fs.Length)
                        {
                            Magica magica = (Magica)bf.Deserialize(fs);
                            if (magica.Soporte.ToLower().Contains(soporte.Text.ToLower())) listBox1.Items.Add(magica);
                        }; break;
                    case "Monstruos":
                        while (fs.Position < fs.Length)
                        {
                            Monstruo mons = (Monstruo)bf.Deserialize(fs);
                            if (mons.Soporte.ToLower().Contains(soporte.Text.ToLower())) listBox1.Items.Add(mons);
                        }; break;
                    case "Trampas":
                        while (fs.Position < fs.Length)
                        {
                            Trampa trampa = (Trampa)bf.Deserialize(fs);
                            if (trampa.Soporte.ToLower().Contains(soporte.Text.ToLower())) listBox1.Items.Add(trampa);
                        }; break;
                }//SWITCH
            }
            catch (FileNotFoundException) { MensajeNotFound(); }
            fs.Close();
        }

        private void nombre_Enter(object sender, EventArgs e)
        {
            LimpiarTexto(sender);
            modo = int.Parse((sender as Control).Tag.ToString());
        }

        private void BuscarEnDescripcion()
        {
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                switch (archivo)
                {
                    case "Magicas":
                        while (fs.Position < fs.Length)
                        {
                            Magica magica = (Magica)bf.Deserialize(fs);
                            if (magica.Descripcion.ToLower().Contains(descripcion.Text.ToLower())) listBox1.Items.Add(magica);
                        }; break;
                    case "Monstruos":
                        while (fs.Position < fs.Length)
                        {
                            Monstruo mons = (Monstruo)bf.Deserialize(fs);
                            if (mons.Descripcion.ToLower().Contains(descripcion.Text.ToLower())) listBox1.Items.Add(mons);
                        }; break;
                    case "Trampas":
                        while (fs.Position < fs.Length)
                        {
                            Trampa trampa = (Trampa)bf.Deserialize(fs);
                            if (trampa.Descripcion.ToLower().Contains(descripcion.Text.ToLower())) listBox1.Items.Add(trampa);
                        }; break;
                }//SWITCH
                fs.Close();
            }
            catch (FileNotFoundException) { MensajeNotFound(); }
        }//BUSCAR EN DESCRIPCION

        private void BuscarporSubtipo()
        {
            try
            {

                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Monstruo mons = (Monstruo)bf.Deserialize(fs);
                    if (mons.Subtipo.Equals(subtipo.Text, StringComparison.OrdinalIgnoreCase)) listBox1.Items.Add(mons);
                };
                fs.Close();
            }
            catch (FileNotFoundException) { MensajeNotFound(); }
        }

        private void BuscarporExtraDeck()
        {
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Monstruo mons = (Monstruo)bf.Deserialize(fs);
                    if (mons.Extradeck.Equals(extradeck.Text, StringComparison.OrdinalIgnoreCase)) listBox1.Items.Add(mons);
                };
                fs.Close();
            }
            catch (FileNotFoundException) { MensajeNotFound(); }
        }

        private void BuscarPorNivel()
        {
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Monstruo mons = (Monstruo)bf.Deserialize(fs);
                    if (mons.Nivel.Equals((int)Nivel.Value)) listBox1.Items.Add(mons);
                };
                fs.Close();
            }
            catch (FileNotFoundException) { MensajeNotFound(); }
        }
        private void MostrarCarta(Karta k)
        {

            Carta cr = null;
            try
            {
                switch (archivo)
                {
                    case "Monstruos":
                        cr = new Carta((k as Monstruo).Nombre, (k as Monstruo).Descripcion, " " + (k as Monstruo).Atk, " " + (k as Monstruo).Def, (k as Monstruo).Tipo, (k as Monstruo).Atributo, (k as Monstruo).Set, (k as Monstruo).Rutaimagen, 1);
                        break;
                    case "Magicas":
                        cr = new Carta(k.Nombre, k.Tipo, k.Descripcion, k.Set, k.Rutaimagen, 2);
                        break;
                    case "Trampas":
                        cr = new Carta(k.Nombre, k.Tipo, k.Descripcion, k.Set, k.Rutaimagen, 3);
                        break;

                }//SWITCH
                cr.ShowDialog();
            }
            catch (NullReferenceException) { MessageBox.Show("Tienes que clicar sobre una carta"); }

        }

        private void MensajeNotFound()
        {
            MessageBox.Show("Aun no tienes un archivo de " + archivo);
        }

        private void nombre_Leave(object sender, EventArgs e)
        {
            if (!button1.Focused) { (sender as Control).Text = "Buscar por " + (sender as Control).Name; }
        }

        private void ReestablecerTextos()
        {
            foreach (Control c in panel1.Controls)
            {
                c.Text = "Buscar por " + c.Name;
            }
        }

        private void extradeck_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1_Click(this, e); }
        }
    }
}

