using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SerializableYugi
{

    [Serializable]
    internal class Monstruo
    {
        string nombre;
        string descripcion;
        string tipo;
        string atributo;
        string subtipo;
        string extradeck;
        string arquetipo;
        string rareza;
        string set;
        string soporte;
        int atk;
        int def;
        int nivel;
        int copias;
        public Monstruo(string nombre, string descripcion, string tipo, string atributo, string subtipo, string extradeck, string arquetipo, string rareza, string set, string soporte, int atk, int def, int nivel, int copias)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.atributo = atributo;
            this.subtipo = subtipo;
            this.extradeck = extradeck;
            this.arquetipo = arquetipo;
            this.rareza = rareza;
            this.set = set;
            this.soporte = soporte;
            this.atk = atk;
            this.def = def;
            this.nivel = nivel;
            this.copias = copias;
        }
        public string get_nombre() {
            return nombre;
        }

        public string get_set() {
            return set;
        }
        public string get_soporte() {
            return soporte;
        }
        public string get_tipo() {
            return tipo;
        }

        public string getDescripcion() {
            return descripcion;
        }

        public string getArquetipo() {
            return soporte;
        }

        public string getSubtipo() {
            return subtipo;
        }

        public string getExtraDeck() {
            return extradeck;
        }

        public int getNivel() {
            return nivel;
        }

        public string get_atributo() {
            return atributo;
        }

        public string get_arquetipo() {
            return arquetipo;
        }

        public int get_atk() {
            return atk;
        }

        public int get_def() {
            return def;
        }
        public override String ToString()
        {

            return this.nombre;
        }

        public string get_rareza()
        {
            return rareza;
        }

        public int get_copias() {
            return copias;
        }
    }//MOnstruo
    [Serializable]
    internal class Magica {
        string nombre;
        string descripcion;
        string tipo;
        string rareza;
        string set;
        string soporte;
        int copias;

        public Magica(string nombre, string descripcion, string tipo, string set, string rareza, string soporte, int copias)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.rareza = rareza;
            this.set = set;
            this.soporte = soporte;
            this.copias = copias;
        }
        public string get_nombre() {
            return nombre;
        }

        public int get_copias()
        {
            return copias;
        }

        public string get_set()
        {
            return set;
        }
        public string get_soporte() {
            return soporte;
        }
        public string get_tipo() {
            return tipo;
        }

        public string getDescripcion()
        {
            return descripcion;
        }
        public override String ToString()
        {

            return this.nombre;
        }

        public string get_rareza()
        {
            return rareza;
        }
    }//MAGICAS
    [Serializable]
    internal class Trampa {
        string nombre;
        string descripcion;
        string tipo;
        string rareza;
        string set;
        string soporte;
        int copias;

        public Trampa(string nombre, string descripcion, string tipo, string set, string rareza, string soporte, int copias)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.rareza = rareza;
            this.set = set;
            this.soporte = soporte;
            this.copias = copias;
        }
        public string get_nombre()
        {
            return nombre;
        }
        public int get_copias()
        {
            return copias;
        }

        public string get_rareza() {
            return rareza;
        }

        public string get_set()
        {
            return set;
        }
        public string get_soporte()
        {
            return soporte;
        }
        public string get_tipo()
        {
            return tipo;
        }

        public string getDescripcion()
        {
            return descripcion;
        }
        public override String ToString() {

            return this.nombre;
        }

       

    }
}
