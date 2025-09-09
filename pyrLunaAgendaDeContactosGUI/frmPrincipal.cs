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
        //variables
        string vContacto = "";
        string vNumero = "";
        //vectores
        string[] vecContacto = new string[5];
        string[] vecNumero = new string[5];
        //indice
        int indice = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mskNumero.Text;
            vecContacto[indice] = vContacto;
            vecNumero[indice] = vNumero;
            lstRegistro.Items.Add(vContacto + " - " + vNumero);
            lblCantidad.Text = "Cantidad de contactos: " + lstRegistro.Items.Count.ToString();
            lblFechaYHora.Text = "Fecha y hora: " + DateTime.Now.ToString();
            txtContacto.Text = "";
            mskNumero.Text = "";
            txtContacto.Focus();
            indice++;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mskNumero.Text = "";
            txtContacto.Focus();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "" && mskNumero.Text != "")
            {
                mskNumero.Enabled = true;
            }
            else
            {
                mskNumero.Enabled = false;
            }
        }

        private void mskNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "" && mskNumero.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }
    }
}
