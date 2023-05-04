using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableYugi
{
    internal class Formulario
    {
        static string[] tipomons = { "Guerrero", "Demonio", "Lanzador de Conjuros", "Máquina", "Bestia", "Bestia Alada", "Guerrero-Bestia", "Pez", "Serpiente Marina", "Aqua", "Reptil", "Dinosaurio", "Dragón", "Hada", "Zombi", "Roca", "Psíquico", "Piro", "Trueno", "Planta", "Insecto", "Wyrm", "Bestia Divina", "Ciberso" };
        static string[] tipomags = { "Normal", "Juego Rápido", "Continua", "Equipo", "Campo", "Ritual" };
        static string[] tipotraps = { "Normal", "Continua", "Contraefecto" };
        public static string[] get_tipomons() { 
            return tipomons;
        }//GETTER_TIPOMONS

        public static string[] get_tipomags()
        {
            return tipomags;
        }
        public static string[] get_tipotraps()
        {
            return tipotraps;
        }


    }
}
