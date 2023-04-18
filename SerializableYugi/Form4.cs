using System;
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
using static System.Net.Mime.MediaTypeNames;

namespace SerializableYugi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] tipomons = { "Guerrero", "Demonio", "Lanzador de Conjuros", "Máquina", "Bestia", "Bestia Alada", "Guerrero-Bestia", "Pez", "Serpiente Marina", "Aqua", "Reptil", "Dinosaurio", "Dragón", "Hada", "Zombi", "Roca", "Psíquico", "Piro", "Trueno", "Planta", "Insecto", "Wyrm", "Bestia Divina", "Ciberso" };
        string[] tipomags = { "Normal", "Juego Rápido", "Continua", "Equipo", "Campo", "Ritual" };
        string[] tipotraps = { "Normal", "Continua", "Contraefecto" };
        string archivo = null;
        Monstruo mons = null;
        Magica magica = null;
        Trampa trampa = null;
        string codigobusc = "";
        List<Magica> mags = new List<Magica>();
        List<Monstruo> monst = new List<Monstruo>();
        List<Trampa> tramp = new List<Trampa>();
        private void RellenarTipos(object sender)
        {
            tipo.Items.Clear();
            switch (int.Parse((string)(sender as Control).Tag))
            {
                case 1: tipo.Items.AddRange(tipomons); archivo = "Monstruos"; break;
                case 2: tipo.Items.AddRange(tipomags); archivo = "Magicas"; break;
                case 3: tipo.Items.AddRange(tipotraps); archivo = "Trampas"; break;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            panelgen.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            buscada.Enabled=true;
            panelmonst.Enabled=true;
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
            }
        }//CHCKED CHANGED

        private void tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BuscarCartas()
        {
            FileStream fs = new FileStream(archivo, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            switch (archivo)
            {
                case "Magicas":
                    while ((fs.Position < fs.Length))
                    {
                        magica = (Magica)bf.Deserialize(fs);
                        if (magica.get_rareza().ToLower().Contains(codigobusc.ToLower()))
                        {
                            Nombre.Text = magica.get_nombre();
                            Descripcion.Text = magica.getDescripcion();
                            tipo.Text = magica.get_tipo();
                            rareza.Text = magica.get_set();
                            soporte.Text = magica.get_soporte();
                            set.Text = magica.get_rareza();
                            copias.Text = "" + magica.get_copias();
                        }//IF;
                        else OmitirActualizado(magica, null, null);
                    };
                    break;
                case "Monstruos":
                    while ((fs.Position < fs.Length))
                    {
                        mons = (Monstruo)bf.Deserialize(fs);
                        if (mons.get_set().ToLower().Contains(codigobusc.ToLower()))
                        {
                            Nombre.Text = mons.get_nombre();
                            Descripcion.Text = mons.getDescripcion();
                            tipo.Text = mons.get_tipo();
                            set.Text = mons.get_set();
                            soporte.Text = mons.get_soporte();
                            rareza.Text = mons.get_rareza();
                            copias.Text = "" + mons.get_copias();
                            atributo.Text = mons.get_atributo();
                            attk.Text = mons.get_atk() + "";
                            def.Text = mons.get_def() + "";
                            ExtraDeck.Text = mons.getExtraDeck();
                            subtipo.Text = mons.getSubtipo();
                            textBox10.Text = mons.getArquetipo();
                            niivel.Text = mons.getNivel()+"";

                        }
                        else OmitirActualizado(null, mons, null);
                    }; 
                    break;
                case "Trampas":
                    while ((fs.Position < fs.Length))
                    {
                        trampa = (Trampa)bf.Deserialize(fs);
                        if (trampa.get_nombre().ToLower().Contains(codigobusc.ToLower()))
                        {
                            Nombre.Text = trampa.get_nombre();
                            Descripcion.Text = trampa.getDescripcion();
                            tipo.Text = trampa.get_tipo();
                            rareza.Text = trampa.get_set();
                            soporte.Text = trampa.get_soporte();
                            set.Text = trampa.get_rareza();
                            copias.Text = "" + trampa.get_copias();
                        }
                       // else bf.Serialize(fs, trampa);
                    }; break;
            }//SWITCH
            fs.Close();
            ConvertirArrayEnFichero();

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            switch (archivo)
            {
                case "Magicas":
                    bf.Serialize(fs, new Magica(
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
                Nombre.Text,
                Descripcion.Text,
                tipo.Text,
                atributo.Text,
                subtipo.Text,
                ExtraDeck.Text,
                textBox10.Text,
                rareza.Text,
                set.Text,
                soporte.Text,
                int.Parse(attk.Text.Trim()),
                int.Parse(def.Text.Trim()),
                int.Parse(niivel.Text.Trim()),
                int.Parse(copias.Text.Trim())
                ));
                    break;
                case "Trampas":
                    bf.Serialize(fs, new Trampa(
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

        }

        private void OmitirActualizado(Magica iimags, Monstruo iimons, Trampa iitramp) {
            switch (archivo)
            {
                case "Magicas":
                    mags.Add(iimags);
                    break;
                case "Monstruos":
                    monst.Add(iimons);
                    break;
                case "Trampas":
                    tramp.Add(iitramp);
                    break;
            }//SWITCH
        }//OMITIR

        private void ConvertirArrayEnFichero() {
            FileStream fs = new FileStream(archivo, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            switch (archivo)
            {
                case "Magicas":
                    for(int i=0; i<mags.Count; i++)
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
    }
}
