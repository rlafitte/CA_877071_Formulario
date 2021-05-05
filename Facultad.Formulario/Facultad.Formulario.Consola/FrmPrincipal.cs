using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad.Formulario.Consola
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Form1 Frm = new Form1();
            Frm.Owner = this;
            Frm.Show();
            this.Hide();
        }
    }
}
