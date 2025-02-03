using SerializableYugi.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Carta : Form
    {

        int tipocarta = 0;
        string extradeck;
        public Carta(string iinombre, string iidescripcion, string iiatk, string iidef, string iitipomons, string iiatributo, string iiset, string iiruta, int iitipocarta, string iirareza, int iicopias, string iiextradeck, int iinivel)
        {
            InitializeComponent();
            tipocarta = iitipocarta;
            nombre.Text = iinombre.ToUpper();
            tipomons.Text = "[" + iitipomons + "]";
            descripcion.Text = iidescripcion;
            atk.Text += "/"+iiatk;
            def.Text += "/"+iidef;
            set.Text = iiset;
            extradeck = iiextradeck;
            tipomons.Visible = true;
            panel2.Visible = true;
            ilustracion.ImageLocation = iiruta;
            this.Text = "Nº de copias: " + iicopias + " - " + iirareza;
            switch (iiatributo)
            {
                case "Luz": atributo.Image = Properties.Resources.LIGHT; break;
                case "Oscuridad": atributo.Image = Properties.Resources.DARK; break;
                case "Viento": atributo.Image = Properties.Resources.WIND; break;
                case "Tierra": atributo.Image = Properties.Resources.EARTH; break;
                case "Fuego": atributo.Image = Properties.Resources.FIRE; break;
                case "Agua": atributo.Image = Properties.Resources.WATER; break;
                case "Divinidad": atributo.Image = Properties.Resources.DIVINE; break;

            }

            switch (iiextradeck)
            {
                case "Fusion":  this.BackgroundImage = Resources.fusion; 
                                nombre.BackColor = Color.FromArgb(132,63,145); 
                                descripcion.BackColor=Color.FromArgb(211,190,218); 
                                atk.BackColor=Color.FromArgb(211, 190, 218); 
                                def.BackColor = Color.FromArgb(211, 190, 218); 
                                tipomons.BackColor = Color.FromArgb(211, 190, 218); 
                                set.BackColor = Color.FromArgb(132, 63, 145); 
                                break;
                
                case "Sincronia":  this.BackgroundImage = Resources.SYNCHRONY;
                                   nombre.BackColor = Color.FromArgb(228, 227, 226);
                                   descripcion.BackColor = Color.FromArgb(228, 227, 226);
                                   atk.BackColor = Color.FromArgb(228, 227, 226);
                                   def.BackColor = Color.FromArgb(228, 227, 226);
                                   tipomons.BackColor = Color.FromArgb(228, 227, 226);
                                   set.BackColor = Color.FromArgb(228, 227, 226);
                                   break;
                
                case "Xyz": this.BackgroundImage = Resources.XYZ;
                            nombre.BackColor = Color.FromArgb(9, 10, 11);
                            nombre.ForeColor = Color.White;
                            descripcion.BackColor = Color.FromArgb(226, 226, 225);
                            atk.BackColor = Color.FromArgb(226, 226, 225);
                            def.BackColor = Color.FromArgb(226, 226, 225);
                            tipomons.BackColor = Color.FromArgb(226, 226, 225);
                            set.BackColor = Color.FromArgb(9, 10, 11);
                            set.ForeColor = Color.White;
                            break;
                case "Link":    this.BackgroundImage = Resources.LINK;
                                nombre.BackColor = Color.FromArgb(13, 91, 152);
                                descripcion.BackColor = Color.FromArgb(198, 211, 234);
                                atk.BackColor = Color.FromArgb(198, 211, 234);
                                def.BackColor = Color.FromArgb(198, 211, 234);
                                tipomons.BackColor = Color.FromArgb(198, 211, 234);
                                set.BackColor = Color.FromArgb(13, 91, 152);
                                def.Text = "LINK - " + iinivel;
                                break;
            }
            if(iiextradeck!="Link") RellenarNiveles(iinivel, iiextradeck);
        }//CONSTRUCTOR

        public Carta(string iinombre, string iitipo, string iidescripcion, string iiset, string iiruta, int iitipocarta, string iirareza, int iicopias)
        {
            InitializeComponent();
            tipocarta = iitipocarta;
            nombre.Text = iinombre.ToUpper();
            tipo.Text = iitipo;
            descripcion.Text = iidescripcion;
            set.Text = iiset;
            tipo.Visible = true;
            ilustracion.ImageLocation = iiruta;
            this.Controls.Remove(panelnivel);
            tipo.Location = new System.Drawing.Point(158, 54);
            this.Text = "Nº de copias: " + iicopias + " - " + iirareza;
            switch (iitipocarta)
            {
                case 2: atributo.Image = Properties.Resources.SPELL; 
                                         this.BackgroundImage = Resources.SPELL_CARD;                                          descripcion.BackColor = Color.Gainsboro; 
                                         nombre.BackColor = Color.FromArgb(37, 140, 124);
                                         tipo.BackColor = Color.FromArgb(37, 140, 124);
                                         descripcion.BackColor = Color.FromArgb(178, 203, 197);
                                         set.BackColor = Color.FromArgb(37, 140, 124);
                                         pictureBox13.Visible = false;
                                         break;
                case 3: atributo.Image = Properties.Resources.TRAP; 
                                         this.BackgroundImage = Resources.TRAP_CARD;
                                         descripcion.BackColor = Color.FromArgb(224, 192, 208);
                                         nombre.BackColor = Color.FromArgb(169, 47, 116);
                                         tipo.BackColor = Color.FromArgb(169, 47, 116);
                                         set.BackColor = Color.FromArgb(169, 47, 116);
                                         pictureBox13.Visible = false;
                                         break;
            }
        }//CONSTRUCTOR2

        private void Carta_Load(object sender, EventArgs e)
        {
            Fuente.LocalizarFuenteNombre(this.nombre, 12);
            Fuente.LocalizarFuenteDesc(this.descripcion, 8);
            Fuente.LocalizarFuente(atk, 8);
            Fuente.LocalizarFuente(def, 8);
            Fuente.LocalizarFuente(set, 7);
            Fuente.LocalizarFuente(tipomons, 7);
            Fuente.LocalizarFuente(tipo, 8);
            Fuente.LocalizarFuente(editar, 8);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 fr4 = null;
            switch (tipocarta)
            {
                case 1:
                    fr4 = new Form4(set.Text, 1);
                    break;
                case 2:
                    fr4 = new Form4(set.Text, 2);
                    break;
                case 3:
                    fr4 = new Form4(set.Text, 3);
                    break;
            }
            fr4.Show();
        }//BUTTON1

        public void RellenarNiveles(int iinivel, string iiextrad)
        {
            foreach (PictureBox pb in panelnivel.Controls)
            {
                if (int.Parse(pb.Tag + "") < iinivel && iiextrad!="Xyz") pb.BackgroundImage = Resources.nivestrella;
                else
                    if(iiextrad=="Xyz" && int.Parse(pb.Tag + "") < iinivel) pb.BackgroundImage = Resources.rankstar;
            }//FOREACH
        }//RELLENAR NIVELES
    }//CLASS

}//NAMESPACE