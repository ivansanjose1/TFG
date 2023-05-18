using System;

namespace SerializableYugi
{

    [Serializable]
    internal class Monstruo : Karta
    {
        string atributo;
        string subtipo;
        string extradeck;
        string arquetipo;
        int atk;
        int def;
        int nivel;
        public Monstruo(string rutaimagen, string nombre, string descripcion, string tipo, string rareza, string set, string soporte, int copias, string atributo, string subtipo, string extradeck, string arquetipo, int atk, int def, int nivel) : base(rutaimagen, nombre, descripcion, tipo, rareza, set, soporte, copias)
        {
            this.Atributo = atributo;
            this.Subtipo = subtipo;
            this.Extradeck = extradeck;
            this.Arquetipo = arquetipo;
            this.Atk = atk;
            this.Def = def;
            this.Nivel = nivel;
        }

        public string Atributo { get => atributo; set => atributo = value; }
        public string Subtipo { get => subtipo; set => subtipo = value; }
        public string Extradeck { get => extradeck; set => extradeck = value; }
        public string Arquetipo { get => arquetipo; set => arquetipo = value; }
        public int Atk { get => atk; set => atk = value; }
        public int Def { get => def; set => def = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }//MONSTRUO

    [Serializable]
    internal class Magica : Karta
    {
        public Magica(string rutaimagen, string nombre, string descripcion, string tipo, string rareza, string set, string soporte, int copias) : base(rutaimagen, nombre, descripcion, tipo, rareza, set, soporte, copias)
        {
        }
    }//MAGICAS
    [Serializable]
    internal class Trampa : Karta
    {
        public Trampa(string rutaimagen, string nombre, string descripcion, string tipo, string rareza, string set, string soporte, int copias) : base(rutaimagen, nombre, descripcion, tipo, rareza, set, soporte, copias)
        {
        }
    }
}
