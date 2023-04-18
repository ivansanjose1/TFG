using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Carta : Form
    {
        public Carta(string iinombre, string iidescripcion, string iiatk, string iidef, string iitipomons, string iiatributo, string iiset)
        {
            InitializeComponent();
            nombre.Text = iinombre;
            tipomons.Text = iitipomons;
            descripcion.Text = iidescripcion;
            atk.Text += iiatk;
            def.Text+= iidef;
            set.Text= iiset;
            tipomons.Visible = true;
            panel2.Visible = true;
        }//CONSTRUCTOR

        public Carta(string iinombre, string iitipo, string iidescripcion, string iiset) {
            InitializeComponent();
            nombre.Text = iinombre;
            tipo.Text = iitipo;
            descripcion.Text = iidescripcion;
            set.Text= iiset;
            tipo.Visible = true;
        }//CONSTRUCTOR2

    }
}
