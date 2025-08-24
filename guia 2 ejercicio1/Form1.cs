using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos FormDatos = new Datos();
            if (FormDatos.ShowDialog() == DialogResult.OK)
            {
                int Dni = Convert.ToInt32(FormDatos.tbDni.Text);
                string Nombre = FormDatos.tbNombre.Text;
                Persona nueva = new Persona(Dni, Nombre);
                if (Servicio.AgregarPersona(nueva)
                    {

                    MessageBox.Show("Se agrego la Persona");
                }
                else {
                    MessageBox.Show("No se agrego la persona");
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }
    } 
}
