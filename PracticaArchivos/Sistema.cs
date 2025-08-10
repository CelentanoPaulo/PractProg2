using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArchivos
{
    [Serializable]
    internal class Sistema
    {
        private List<Persona> listaPersona=new List<Persona>(); 
       public void AgregarPersona(Persona p)
        { 
            listaPersona.Add(p);
        }

        public Persona VerPersona(long dni)
        {
            Persona retorno = null;
            foreach (Persona p in listaPersona)
            {
                if (p.Dni == dni)
                {
                    retorno = p;
                }
            }
            return retorno;

        }

        public List<Persona> VerListaPersona()
        {
            return listaPersona;
        }
       
    }
}
