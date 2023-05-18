using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string archivo = null;
        string codigobusc = "";
        string rutadeimagen = "";
        List<Magica> mags = new List<Magica>();
        List<Monstruo> monst = new List<Monstruo>();
        List<Trampa> tramp = new List<Trampa>();
        bool guardada = false;
        bool cerradoautomatico = false;
        public Form4(string codigo, int modo)
        {
            InitializeComponent();
            switch (modo)
            {
                case 1:
                    cerradoautomatico = true;
                    checkBox1.Checked = true;
                    button1.Enabled = false;
                    archivo = checkBox1.Text;
                    buscada.Text = codigo;
                    codigobusc = codigo;
                    BuscarCartas();
                    break;
                case 2:
                    cerradoautomatico = true;
                    checkBox2.Checked = true;
                    button1.Enabled = false;
                    archivo = checkBox2.Text;
                    buscada.Text = codigo;
                    codigobusc = codigo;
                    BuscarCartas();
                    break;
                case 3:
                    cerradoautomatico = true;
                    checkBox3.Checked = true;
                    button1.Enabled = false;
                    archivo = checkBox3.Text;
                    buscada.Text = codigo;
                    codigobusc = codigo;
                    BuscarCartas();
                    break;
            }
        }
        private void RellenarTipos(object sender)
        {
            tipo.Items.Clear();
            switch (int.Parse((string)(sender as Control).Tag))
            {
                case 1: tipo.Items.AddRange(Formulario.get_tipomons()); archivo = "Monstruos"; break;
                case 2: tipo.Items.AddRange(Formulario.get_tipomags()); archivo = "Magicas"; break;
                case 3: tipo.Items.AddRange(Formulario.get_tipotraps()); archivo = "Trampas"; break;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panelgen.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            buscada.Enabled = true;
            panelmonst.Enabled = true;
            button3.Enabled = true;
            bool almostdone = false;
            archivo = (sender as CheckBox).Text;
            RellenarTipos(sender);
            if ((sender as CheckBox).Text == "Magicas" || (sender as CheckBox).Text == "Trampas")
            {
                panelmonst.Enabled = false;
            }
            else
            {
                panelmonst.Enabled = true;
            }
            foreach (CheckBox ch in panelCHK.Controls)
            {
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
                button2.Enabled = false;
                button1.Enabled = false;
                buscada.Enabled = false;
                panelmonst.Enabled = false;
                button3.Enabled = false;
            }
        }//CHCKED CHANGED
        private void BuscarCartas()
        {
            mags.Clear();
            monst.Clear();
            tramp.Clear();
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                switch (archivo)
                {
                    case "Magicas":
                        while ((fs.Position < fs.Length))
                        {
                            Magica magica = (Magica)bf.Deserialize(fs);
                            if (magica.Set.ToLower() == (codigobusc.ToLower()))
                            {
                                Nombre.Text = magica.Nombre;
                                Descripcion.Text = magica.Descripcion;
                                tipo.Text = magica.Tipo;
                                set.Text = magica.Set;
                                soporte.Text = magica.Soporte;
                                rareza.Text = magica.Rareza;
                                copias.Text = "" + magica.Copias;
                                rutadeimagen = magica.Rutaimagen;
                            }//IF;
                            else OmitirActualizado(magica);
                        };
                        break;
                    case "Monstruos":
                        while ((fs.Position < fs.Length))
                        {
                            Monstruo mons = (Monstruo)bf.Deserialize(fs);
                            if (mons.Set.ToLower() == (codigobusc.ToLower()))
                            {
                                Nombre.Text = mons.Nombre;
                                Descripcion.Text = mons.Descripcion;
                                tipo.Text = mons.Tipo;
                                set.Text = mons.Set;
                                soporte.Text = mons.Soporte;
                                rareza.Text = mons.Rareza;
                                copias.Text = "" + mons.Copias;
                                atributo.Text = mons.Atributo;
                                attk.Text = mons.Atk + "";
                                def.Text = mons.Def + "";
                                ExtraDeck.Text = mons.Extradeck;
                                subtipo.Text = mons.Subtipo;
                                arquetipo.Text = mons.Arquetipo;
                                niivel.Text = mons.Nivel + "";
                                rutadeimagen = mons.Rutaimagen;
                            }
                            else OmitirActualizado(mons);
                        };
                        break;
                    case "Trampas":
                        while ((fs.Position < fs.Length))
                        {
                            Trampa trampa = (Trampa)bf.Deserialize(fs);
                            if (trampa.Set.ToLower() == (codigobusc.ToLower()))
                            {
                                Nombre.Text = trampa.Nombre;
                                Descripcion.Text = trampa.Descripcion;
                                tipo.Text = trampa.Tipo;
                                set.Text = trampa.Set;
                                soporte.Text = trampa.Soporte;
                                rareza.Text = trampa.Rareza;
                                copias.Text = "" + trampa.Copias;
                                rutadeimagen = trampa.Rutaimagen;
                            }
                            else OmitirActualizado(trampa);
                        };
                        break;
                }//SWITCH
                fs.Close();
                ConvertirArrayEnFichero();
            }
            catch (Exception) { MessageBox.Show("No se encuentra ese codigo"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarCartas();
        }

        private void buscada_Leave(object sender, EventArgs e)
        {
            codigobusc = buscada.Text;
            buscada.Text = "¿Que carta deseas cambiar?";
        }

        private void buscada_Enter(object sender, EventArgs e)
        {
            buscada.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                switch (archivo)
                {
                    case "Magicas":
                        bf.Serialize(fs, new Magica(
                    rutadeimagen,
                    Nombre.Text,
                    Descripcion.Text,
                    tipo.Text,
                    rareza.Text,
                    set.Text,
                    soporte.Text,
                    int.Parse(copias.Text.Trim())
                    ));
                        break;
                    case "Monstruos":
                        bf.Serialize(fs, new Monstruo(
                rutadeimagen,
                Nombre.Text,
                Descripcion.Text,
                tipo.Text,
                rareza.Text,
                set.Text,
                soporte.Text,
                int.Parse(copias.Text.Trim()),
                atributo.Text,
                subtipo.Text,
                ExtraDeck.Text,
                arquetipo.Text,
                int.Parse(attk.Text.Trim()),
                int.Parse(def.Text.Trim()),
                int.Parse(niivel.Text.Trim())
                    ));
                        break;
                    case "Trampas":
                        bf.Serialize(fs, new Trampa(
                    rutadeimagen,
                    Nombre.Text,
                    Descripcion.Text,
                    tipo.Text,
                    rareza.Text,
                    set.Text,
                    soporte.Text,
                    int.Parse(copias.Text.Trim())
                    ));
                        break;
                }//SWITCH          
                fs.Close();
                LimpiarCampos();
                guardada = true;
                MessageBox.Show("Tu carta se ha actualizado con exito");
                if (cerradoautomatico == true) this.Close();
            }
            catch (Exception) { }
        }
        private void OmitirActualizado(Karta k)
        {
            switch (archivo)
            {
                case "Magicas":
                    mags.Add((Magica)k);
                    break;
                case "Monstruos":
                    monst.Add((Monstruo)k);
                    break;
                case "Trampas":
                    tramp.Add((Trampa)k);
                    break;
            }//SWITCH
        }//OMITIR

        private void ConvertirArrayEnFichero()
        {
            FileStream fs = new FileStream(archivo, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            switch (archivo)
            {
                case "Magicas":
                    for (int i = 0; i < mags.Count; i++)
                    {
                        bf.Serialize(fs, mags.ElementAt(i));
                    };
                    fs.Close();
                    break;
                case "Monstruos":
                    for (int i = 0; i < monst.Count; i++)
                    {
                        bf.Serialize(fs, monst.ElementAt(i));
                    };
                    fs.Close();
                    break;
                case "Trampas":
                    for (int i = 0; i < tramp.Count; i++)
                    {
                        bf.Serialize(fs, tramp.ElementAt(i));
                    };
                    fs.Close();
                    break;
            }//SWITCH

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            rutadeimagen = openFileDialog1.FileName;

        }

        private void LimpiarCampos()
        {
            foreach (Control c in panelgen.Controls)
            {
                c.Text = "";
            }

            foreach (Control c in panelmonst.Controls)
            {
                c.Text = "";
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardada == false) button2_Click(sender, e);

        }

        private void tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.KURIBOH;
            Fuente.CargarFuente();
            Fuente.LocalizarFuente(button1, 8);
            Fuente.LocalizarFuente(button2, 8);
            Fuente.LocalizarFuente(button3, 8);
            Fuente.LocalizarFuente(buscada, 8);
            foreach (Control c in paneletiquetas1.Controls)
            {
                Fuente.LocalizarFuente(c, 8);
            }
            foreach (Control c in paneletiquetas2.Controls)
            {
                Fuente.LocalizarFuente(c, 8);
            }

            foreach (Control c in panelCHK.Controls)
            {
                Fuente.LocalizarFuente(c, 8);
            }
            foreach (Control c in panelgen.Controls)
            {
                Fuente.LocalizarFuente(c, 8);
            }

            foreach (Control c in panelmonst.Controls)
            {
                Fuente.LocalizarFuente(c, 8);
            }
        }

        private void Nombre_Click(object sender, EventArgs e)
        {
            (sender as TextBox).ReadOnly = false;
        }
    }
}
