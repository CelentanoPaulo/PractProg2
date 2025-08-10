using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(File.Exists("data.dat"))
            {
                FileStream fs=new FileStream("data.dat",FileMode.Open,FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                miSistema=(Sistema)bf.Deserialize(fs);
                fs.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs=new FileStream("data.dat",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, miSistema);
            fs.Close();
        }
    }
}
