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
    public partial class FrmListaClientes : Form
    {
        private List<Persona> _personas;
        public FrmListaClientes()
        {
            //this.Owner = Form1;
            _personas = new List<Persona>();
            InitializeComponent();
        }
        public FrmListaClientes(Form frm, List<Persona> lista)
        {
            this.Owner = frm;
            _personas = lista;
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Owner.Show();
            this.Close();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            CargarLista();
        }
        
        private void CargarLista()
        {
            lstClientes.DataSource = null; //esto es para evitar un bug que a veces ocurre
            lstClientes.DataSource = _personas;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            lstClientes.DataSource = null; //esto es para evitar un bug que a veces ocurre
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.DataSource != null)
            {

            Persona seleccionada = (Persona)lstClientes.SelectedValue;
            seleccionada.Activo = false;
            MessageBox.Show(seleccionada.ToString());
            //MessageBox.Show(lstClientes.SelectedValue.ToString()); //esto es para mostrar el objeto completo
            }
        }
    }
}
