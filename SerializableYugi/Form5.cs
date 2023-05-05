using System;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Carta : Form
    {
        public Carta(string iinombre, string iidescripcion, string iiatk, string iidef, string iitipomons, string iiatributo, string iiset, string iiruta)
        {
            InitializeComponent();
            nombre.Text = iinombre;
            tipomons.Text = iitipomons;
            descripcion.Text = iidescripcion;
            atk.Text += iiatk;
            def.Text += iidef;
            set.Text = iiset;
            tipomons.Visible = true;
            panel2.Visible = true;
            ilustracion.ImageLocation = iiruta;
            switch (iiatributo)
            {
                case "Luz": atributo.Image = Properties.Resources.LIGHT; break;
                case "Oscuridad": atributo.Image = Properties.Resources.DARK; break;
                case "Viento": atributo.Image = Properties.Resources.WIND; break;
                case "Tierra": atributo.Image = Properties.Resources.EARTH; break;
                case "Fuego": atributo.Image = Properties.Resources.FIRE; break;
                case "Agua": atributo.Image = Properties.Resources.WATER; break;

            }
        }//CONSTRUCTOR

        public Carta(string iinombre, string iitipo, string iidescripcion, string iiset, string iiruta)
        {
            InitializeComponent();
            nombre.Text = iinombre;
            tipo.Text = iitipo;
            descripcion.Text = iidescripcion;
            set.Text = iiset;
            tipo.Visible = true;
            ilustracion.ImageLocation = iiruta;
        }//CONSTRUCTOR2

        private void Carta_Load(object sender, EventArgs e)
        {
            Fuente.CargarFuente();
            Fuente.LocalizarFuente(this.nombre, 8);
            Fuente.LocalizarFuente(this.descripcion, 8);
            Fuente.LocalizarFuente(atk, 8);
            Fuente.LocalizarFuente(def, 8);
            Fuente.LocalizarFuente(set, 8);
            Fuente.LocalizarFuente(tipomons, 6);
            Fuente.LocalizarFuente(tipo, 8);
        }
    }
}
