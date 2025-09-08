using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyrLunaAgendaDeContactosGUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Contacto = txtContacto.Text;
            int Numero = Convert.ToInt32(mskNumero.Text);
            lstRegistro.Items.Add(Contacto + " - " + Numero);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mskNumero.Text = "";
            txtContacto.Focus();
        }
    }
}
