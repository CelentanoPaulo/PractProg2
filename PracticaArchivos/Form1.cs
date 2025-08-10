using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sistema miSistema=new Sistema();
        Persona miPersona;
        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre= tbNombre.Text;
            long dni=Convert.ToInt64(tbDNI.Text);
            miPersona = new Persona(nombre, dni);
            miSistema.AgregarPersona(miPersona);
            
            foreach(Persona p in miSistema.VerListaPersona())
            {
                lbMostrar.Items.Add("Nombre: "+p.Nombre+ " Dni: "+p.Dni);
            }
        }
    }
}
