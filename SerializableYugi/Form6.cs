using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form6 : Form
    {
        int focuslistbox = 0;
        int limite_Cartas = 60;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.EXODIA;
            Thread t = new Thread(new ThreadStart(Monstrar_monstruos));
            Thread t2 = new Thread(new ThreadStart(Monstrar_magicas));
            Thread t3 = new Thread(new ThreadStart(Monstrar_trampas));
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
            t.Start();
            t2.Start();
            t3.Start();
        }

        public void Monstrar_monstruos()
        {
            Invoke(new Action(() =>
            {
                try
                {
                    FileStream fs = new FileStream("Monstruos", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    while (fs.Position < fs.Length)
                    {
                        Monstruo monstruo = (Monstruo)bf.Deserialize(fs);
                        listBoxMonstruos.Items.Add(monstruo);
                    }
                    fs.Close();
                }
                catch (FileNotFoundException) { }
            }));
        }
        public void Monstrar_magicas()
        {
            Invoke(new Action(() =>
            {
                try
                {
                    FileStream fs = new FileStream("Magicas", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    while (fs.Position < fs.Length)
                    {
                        Magica magica = (Magica)bf.Deserialize(fs);
                        listBoxMagia.Items.Add(magica);

                    }
                    fs.Close();
                }
                catch (FileNotFoundException) { }
            }));
        }
        private void Monstrar_trampas()
        {
            Invoke(new Action(() =>
            {
                try
                {
                    FileStream fs = new FileStream("Trampas", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    while (fs.Position < fs.Length)
                    {
                        Trampa trampa = (Trampa)bf.Deserialize(fs);
                        listBoxTrampas.Items.Add(trampa);

                    }
                    fs.Close();
                }
                catch (FileNotFoundException) { }
            }));
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
                label2.Text = listBoxBaraja.Items.Count + "/" + limite_Cartas;
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
            var t = new Thread(() => SugerirMonstruos(iimonstruo));
            t.Start();
            var t2 = new Thread(() => SugerirMagicas(iimonstruo));
            t2.Start();
            var t3 = new Thread(() => SugerirTrampas(iimonstruo));
            t3.Start();
        }
        private bool ComprobarSugerencias(Karta k, int indicador)
        {
            bool encontrado = false;
            switch (indicador)
            {
                case 1:
                    for (int i = 0; i < Sugerencia.Items.Count; i++)
                    {
                        if ((Sugerencia.Items[i] is Monstruo) && k.Nombre == (Sugerencia.Items[i] as Monstruo).Nombre) encontrado = true;
                    }
                    break;

                case 2:
                    for (int i = 0; i < Sugerencia.Items.Count; i++)
                    {
                        if ((Sugerencia.Items[i] is Magica) && k.Nombre == (Sugerencia.Items[i] as Magica).Nombre) encontrado = true;
                    }
                    break;

                case 3:
                    for (int i = 0; i < Sugerencia.Items.Count; i++)
                    {
                        if ((Sugerencia.Items[i] is Trampa) && k.Nombre == (Sugerencia.Items[i] as Trampa).Nombre) encontrado = true;
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
            else
            {
                var vent = saveFileDialog1.ShowDialog();
                if (vent == DialogResult.OK)
                {
                    string archivo = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(archivo);
                    for (int i = 0; i < listBoxBaraja.Items.Count; i++)
                    {
                        sw.Write(listBoxBaraja.Items[i] + "\n");
                    }
                    sw.Close();
                }
            }
        }

        private void SugerirMonstruos(Monstruo iimons)
        {
            try
            {
                FileStream fsMonstruos = new FileStream("Monstruos", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fsMonstruos.Position < fsMonstruos.Length)
                {
                    Monstruo monstruo = (Monstruo)bf.Deserialize(fsMonstruos);

                    if (iimons.Nombre.ToLower().Contains(monstruo.Soporte.ToLower()) && monstruo.Soporte != "" && monstruo.Soporte.ToLower() != "no")
                    {
                        Invoke(new Action(() =>
                        {
                            if (!ComprobarSugerencias(monstruo, 1)) Sugerencia.Items.Add(monstruo);
                        }));
                    }
                }
                fsMonstruos.Close();
            }
            catch (Exception) { }
        }

        private void SugerirMagicas(Monstruo iimons)
        {
            try
            {
                FileStream fsMagicas = new FileStream("Magicas", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fsMagicas.Position < fsMagicas.Length)
                {
                    Magica magica = (Magica)bf.Deserialize(fsMagicas);
                    if (iimons.Nombre.ToLower().Contains(magica.Soporte.ToLower()) && magica.Soporte != "" && magica.Soporte.ToLower() != "no")
                    {
                        Invoke(new Action(() =>
                        {
                            if (!ComprobarSugerencias(magica, 2)) Sugerencia.Items.Add(magica);
                        }));
                    }

                }
                fsMagicas.Close();
            }
            catch (Exception) { }
        }

        private void SugerirTrampas(Monstruo iimons)
        {
            try
            {
                FileStream fsTrampas = new FileStream("Trampas", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fsTrampas.Position < fsTrampas.Length)
                {
                    Trampa trampa = (Trampa)bf.Deserialize(fsTrampas);
                    if (iimons.Nombre.ToLower().Contains(trampa.Soporte.ToLower()) && trampa.Soporte != "" && trampa.Soporte.ToLower() != "no")
                    {
                        Invoke(new Action(() =>
                        {
                            if (!ComprobarSugerencias(trampa, 3)) Sugerencia.Items.Add(trampa);
                        }));
                    }
                }
                fsTrampas.Close();
            }
            catch (Exception) { }
        }
    }
}
