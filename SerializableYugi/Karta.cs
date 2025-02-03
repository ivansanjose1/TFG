using System;

namespace SerializableYugi
{
    [Serializable]
    public class Karta
    {
        string rutaimagen;
        string nombre;
        string descripcion;
        string tipo;
        string rareza;
        string set;
        string soporte;
        int copias;

        public Karta(string rutaimagen, string nombre, string descripcion, string tipo, string rareza, string set, string soporte, int copias)
        {
            this.rutaimagen = rutaimagen;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.rareza = rareza;
            this.set = set;
            this.soporte = soporte;
            this.copias = copias;
        }

        public string Rutaimagen { get => rutaimagen; set => rutaimagen = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Rareza { get => rareza; set => rareza = value; }
        public string Set { get => set; set => set = value; }
        public string Soporte { get => soporte; set => soporte = value; }
        public int Copias { get => copias; set => copias = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
