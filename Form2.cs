using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form2 : Form
    {
        ArrayList<Monstruo> monstruos = new ArrayList<Monstruo>();
        string archivo = null;
        Monstruo monstruo = null;
        Magica magica = null;
        Trampa trampa = null;
        string rutadeimagen = "";
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
                button1.Location = new System.Drawing.Point(392, 36);
                button2.Location = new System.Drawing.Point(480, 36);
                tipo.Text = "Normal";
            }
            else
            {
                panelmons2.Visible = true;
                panelmonst.Visible = true;
                button1.Location = new System.Drawing.Point(523, 303);
                button2.Location = new System.Drawing.Point(604, 303);
                tipo.Text = "Guerrero";
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
                panelmonst.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                panelmonst.Enabled = true;
                panelgen.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }

        }//METODO CHECKED CHANGE

        private void RellenarTipos(object sender)
        {
            tipo.Items.Clear();
            switch (int.Parse((string)(sender as Control).Tag))
            {
                case 1: tipo.Items.AddRange(Formulario.get_tipomons()); break;
                case 2: tipo.Items.AddRange(Formulario.get_tipomags()); break;
                case 3: tipo.Items.AddRange(Formulario.get_tipotraps()); break;
            }
        }
        private void RellenarMonstruo()
        {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            monstruo = new Monstruo(
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
                textBox10.Text,
                int.Parse(attk.Text.Trim()),
                int.Parse(def.Text.Trim()),
                int.Parse(niivel.Text.Trim())
                );
            bf.Serialize(fs, monstruo);
            fs.Close();
        }

        private void RellenarMagica()
        {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            magica = new Magica(
                rutadeimagen,
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

        private void RellenarTrampa()
        {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            trampa = new Trampa(
                rutadeimagen,
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
            if (ValidarInsercion() == true)
            {
                if (VerificarExistencia() == true) MessageBox.Show("Ya tienes una carta con ese codigo");
                else
                {
                    switch (archivo)
                    {
                        case "Monstruos": RellenarMonstruo(); break;
                        case "Magicas": RellenarMagica(); break;
                        case "Trampas": RellenarTrampa(); break;
                    }
                    MessageBox.Show("Tu carta ha sido guardada con éxito");
                    rutadeimagen = "";
                }
                foreach (Control c in panelgen.Controls)
                {
                    c.Text = "";
                }
                foreach (Control c in panelmonst.Controls)
                {
                    c.Text = "";
                }
            }
            else MessageBox.Show("No es conveniente dejar campos vacíos");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Fuente.CargarFuente();
            Fuente.LocalizarFuente(panelCHK, 9);
            Fuente.LocalizarFuente(paneletiquetas1, 9);
            Fuente.LocalizarFuente(panelgen, 9);
            Fuente.LocalizarFuente(panelmonst, 9);
            Fuente.LocalizarFuente(panelmons2, 9);
            Fuente.LocalizarFuente(button1, 9);
            Fuente.LocalizarFuente(button2, 9);
            this.Icon = Properties.Resources.SLIFERPIXELART;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            rutadeimagen = openFileDialog1.FileName;
        }

        private void copias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private bool ValidarInsercion()
        {
            bool validado = true;
            if (checkBox1.Checked == true)
            {
                foreach (Control c in panelgen.Controls)
                {
                    if (c.Text == "") validado = false;
                }
                foreach (Control c in panelmonst.Controls)
                {
                    if (c.Text == "") validado = false;
                }
            }//IF
            else if (checkBox2.Checked == true || checkBox3.Checked == true)
            {
                foreach (Control c in panelgen.Controls)
                {
                    if (c.Text == "") validado = false;
                }
            }
            return validado;

        }

        private bool VerificarExistencia()
        {
            bool existe = false;
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                while (!existe && fs.Position < fs.Length)
                {
                    Karta k = (Karta)bf.Deserialize(fs);
                    if (k.Set.ToLower() == set.Text.ToLower()) existe = true;
                }
                fs.Close();
            }
            catch (Exception) { }
            return existe;
        }
    }

}
