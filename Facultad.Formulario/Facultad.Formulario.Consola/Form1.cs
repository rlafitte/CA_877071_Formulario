using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios.Libreria;

namespace Facultad.Formulario.Consola
{
    public partial class Form1 : Form //esta es la otra partial class. Todos los form que declaremos son heredados de Form
    {
        public Form1()  //dejar Form1 lo menos modificado posible
        {
            InitializeComponent();
        }

        //private string Display (Persona p)
        //{
        //    return $"{apellido}, {nombre}";
        //}
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
            Persona p = new Persona(txtNombre.Text, txtApellido.Text);
            MessageBox.Show(p.ToString());
            Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
        private void Validar()
        {
            if (txtNombre.Text == string.Empty && txtApellido.Text == string.Empty)
            {
                throw new Exception("Nombre y apellido no pueden estar vacíos");
            }
            if (txtNombre.Text == string.Empty)
            {
                throw new Exception("Nombre no puede estar vacío");
            }
            if (txtApellido.Text == string.Empty)
            {
                throw new Exception("Apellido no puede estar vacío");
            }
        }
    }
}
