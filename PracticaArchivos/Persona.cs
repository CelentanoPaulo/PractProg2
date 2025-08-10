using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArchivos
{
    [Serializable]
    internal class Persona
    {
        private string nombre;
        private long dni;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public long Dni { get {  return dni; } set {  dni = value; } }

        public Persona (string nombre,long dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        
    }
}
