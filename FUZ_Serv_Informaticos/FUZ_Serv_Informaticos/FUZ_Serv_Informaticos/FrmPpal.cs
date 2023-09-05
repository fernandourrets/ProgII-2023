using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUZ_Serv_Informaticos
{
    public partial class frmPpal : Form
    {
        public frmPpal()
        {
            InitializeComponent();
        }

     

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea abandonar la aplicacion???", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void nuevoPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTecnica tecnica = new frmTecnica();

            tecnica.ShowDialog();
            tecnica.Dispose();


        }

        private void buscarClienteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmBuscarClientes bc = new frmBuscarClientes();

            bc.ShowDialog();
            bc.Dispose();
        }

        private void altaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarClientes ac = new frmAgregarClientes();

            ac.ShowDialog();
            ac.Dispose();
        }

        private void buscarPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPresupuesto bp = new frmBuscarPresupuesto();

            bp.ShowDialog();
            bp.Dispose();
        }
    }
}
