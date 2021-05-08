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
        private Form _principal;
        private List<Persona> _personas;
        public Form1()  //dejar Form1 lo menos modificado posible
        {
            //_principal = new Form1();
            
            _personas = new List<Persona>();
            InitializeComponent();
        }

        //private string Display (Persona p)
        //{
        //    return $"{apellido}, {nombre}";
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Cargo formulario");
            CargarListas();
        }
        private void CargarListas()
        {
            CodigoDescripcion seleccion = new CodigoDescripcion(0, "Seleccione");
            CodigoDescripcion soltero = new CodigoDescripcion(1, "Soltero");
            CodigoDescripcion casado = new CodigoDescripcion(2, "Casado");
            List<CodigoDescripcion> lst = new List<CodigoDescripcion>();
            lst.Add(seleccion);
            lst.Add(soltero);
            lst.Add(casado);
            this.comboBox1.DataSource = lst;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.ValueMember = "Cod";

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
            Persona p = new Persona(txtNombre.Text, txtApellido.Text, comboBox1.SelectedValue.ToString(), chkActivo.Checked);
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
            if (comboBox1.SelectedIndex == 0)
            {
                throw new Exception("Seleccione un estado civil.");
            }
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 5)
            {
                MessageBox.Show("Hago algo");
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
