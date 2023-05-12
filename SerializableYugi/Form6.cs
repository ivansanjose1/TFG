using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form6 : Form
    {
        ArrayList<Monstruo> monstruos = new ArrayList<Monstruo>();
        Monstruo monstruo = null;
        Magica magica = null;
        Trampa trampa = null;
        int focuslistbox = 0;
        int limite_Cartas = 60;


        public Form6()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Monstrar_monstruos();
            Monstrar_magicas();
            Monstrar_trampas();
            Fuente.CargarFuente();
            Fuente.LocalizarFuente(this.buttonEliminar, 8);
            Fuente.LocalizarFuente(this.Anhadir, 8);
            Fuente.LocalizarFuente(this.listBoxBaraja, 8);
            Fuente.LocalizarFuente(this.Sugerencia, 8);
            Fuente.LocalizarFuente(label1, 8);
            Fuente.LocalizarFuente(listBoxMagia, 8);
            Fuente.LocalizarFuente(listBoxMonstruos, 8);
            Fuente.LocalizarFuente(listBoxTrampas, 8);
            Fuente.LocalizarFuente(label2, 8);
            Fuente.LocalizarFuente(button1, 8);
            Fuente.LocalizarFuente(button2, 8);
        }

        private void Monstrar_monstruos()
        {
            try
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
            catch (FileNotFoundException) { }
        }

        private void Monstrar_magicas()
        {
            try
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
            catch (FileNotFoundException) { }
        }

        private void Monstrar_trampas()
        {
            try
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
            catch (FileNotFoundException) { }
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
                case 4:
                    listBoxBaraja.Items.Add(Sugerencia.SelectedItem);
                    break;
            }

        }
        private void Comprobador_Cartas()
        {
            if (listBoxBaraja.Items.Count >= limite_Cartas + 1)
            {
                MessageBox.Show("Has llegado al limite");
                listBoxMonstruos.Enabled = false;
                listBoxMagia.Enabled = false;
                listBoxTrampas.Enabled = false;
            }
            else
            {
                label2.Text=listBoxBaraja.Items.Count + "/" + limite_Cartas;
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
                case 4:
                    focuslistbox = 4;
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

                if (iimonstruo.get_nombre().ToLower().Contains(monstruo.get_soporte().ToLower()) && monstruo.get_soporte() != "" && monstruo.get_soporte().ToLower() != "no")
                {
                    if (!ComprobarSugerencias(monstruo, null, null, 1)) Sugerencia.Items.Add(monstruo);
                }

            }
            fsMonstruos.Close();

            FileStream fsMagicas = new FileStream("Magicas", FileMode.Open);

            while (fsMagicas.Position < fsMagicas.Length)
            {
                magica = (Magica)bf.Deserialize(fsMagicas);
                if (iimonstruo.get_nombre().ToLower().Contains(magica.get_soporte().ToLower()) && magica.get_soporte() != "" && magica.get_soporte().ToLower() != "no")
                {
                    if (!ComprobarSugerencias(null, magica, null, 2)) Sugerencia.Items.Add(magica);
                }

            }
            fsMagicas.Close();

            try
            {
                FileStream fsTrampas = new FileStream("Trampas", FileMode.Open);
                while (fsTrampas.Position < fsTrampas.Length)
                {
                    trampa = (Trampa)bf.Deserialize(fsTrampas);
                    if (iimonstruo.get_nombre().ToLower().Contains(trampa.get_soporte().ToLower()) && trampa.get_soporte() != "" && trampa.get_soporte().ToLower() != "no")
                    {
                        if (!ComprobarSugerencias(null, null, trampa, 3)) Sugerencia.Items.Add(trampa);
                    }

                }
                fsTrampas.Close();
            }
            catch (Exception e) { }



        }


        private void listBoxBaraja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sugerencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ComprobarSugerencias(Monstruo iimonstruo, Magica iimagica, Trampa iitrampa, int indicador)
        {
            bool encontrado = false;
            switch (indicador)
            {
                case 1:
                    for (int i = 0; i < Sugerencia.Items.Count; i++)
                    {
                        if (iimonstruo.GetType() == Sugerencia.Items[i].GetType() && iimonstruo.get_nombre() == (Sugerencia.Items[i] as Monstruo).get_nombre()) encontrado = true;
                    }
                    break;

                case 2:
                    for (int i = 0; i < Sugerencia.Items.Count; i++)
                    {
                        if (iimagica.GetType() == Sugerencia.Items[i].GetType() && iimagica.get_nombre() == (Sugerencia.Items[i] as Magica).get_nombre()) encontrado = true;
                    }
                    break;

                case 3:
                    for (int i = 0; i < Sugerencia.Items.Count; i++)
                    {
                        if (iitrampa.GetType() == Sugerencia.Items[i].GetType() && iitrampa.get_nombre() == (Sugerencia.Items[i] as Trampa).get_nombre()) encontrado = true;
                    }
                    break;
            }
            return encontrado;

        }

        private void Sugerencia_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBoxBaraja.Items.Add(Sugerencia.SelectedItem);
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxBaraja.Items.Clear();
            Sugerencia.Items.Clear();
            label2.Text = "0/60";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxBaraja.Items.Count < 40)
            {
                MessageBox.Show("Aun no tienes 40 cartas");
            }
            else {
               var vent=saveFileDialog1.ShowDialog();
                if (vent == DialogResult.OK)
                {
                    string archivo = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(archivo);
                    for (int i = 0; i<listBoxBaraja.Items.Count; i++) {
                        sw.Write(listBoxBaraja.Items[i]+"\n");
                    }
                    sw.Close();
                }
            }
        }
    }
}
