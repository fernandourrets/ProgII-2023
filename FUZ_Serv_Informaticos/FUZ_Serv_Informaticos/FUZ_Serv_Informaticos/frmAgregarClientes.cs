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
    public partial class frmAgregarClientes : Form
    {

            
        Clientes clientes;
       

        public frmAgregarClientes()
        {
           
            InitializeComponent();

          
        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {
        

            clientes = new Clientes();

            

            btnNuevoCliente.Enabled = false;


            txtApellido.Select();

         

            txtNroCliente.Text = MetodosDB.ProxNroCliente().ToString();


            MetodosDB.SeleccionarCmb(this.cmbTipoDni, "select id_tipoDni, tipoDni from TipoDni", "tipoDni", "id_tipoDni");
            MetodosDB.SeleccionarCmb(this.cmbBarrio, "select id_barrio, barrio from Barrios", "barrio", "id_barrio");

            this.cmbBarrio.SelectedIndex = -1;
            this.cmbTipoDni.SelectedIndex = -1;



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

           
            
            
            
            clientes.NumeroCliente = Int32.Parse(txtNroCliente.Text);                       
            clientes.Pers.Apellido = txtApellido.Text;
            clientes.Pers.Nombre = txtNombre.Text;
            clientes.Pers.Domicilio = txtDomicilio.Text;
            clientes.Pers.NroDomicilio = Int32.Parse(txtNroDomicilio.Text);
            clientes.Pers.TipoDni = cmbTipoDni.SelectedIndex + 1;
            clientes.Pers.NroDni = Int32.Parse(txtNroDni.Text);
            clientes.Pers.NroTel = Int64.Parse(txtTelefono.Text);
            clientes.Pers.Barrio = cmbBarrio.SelectedIndex + 1;

            
            

            DialogResult resultado= MessageBox.Show("Seguro desea registrar el cliente???", "Aviso!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resultado==DialogResult.Yes)
            {
               
                MetodosDB.RegistrarClientes(/*clientes.NumeroCliente, */clientes);
            }

            else { MessageBox.Show("Error!!! Cliente NO registrado","Aviso!!!"); }

            this.Limpiar();
            this.Habilitar(false);

            btnRegistrarCliente.Enabled = false;
            btnNuevoCliente.Enabled = true;

            

        }

        private void AgregarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir???", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
                Close();
            

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Seguro desea borrar todos los datos ingresados???", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Yes)
            {

                this.Limpiar();
            }



        }



        private void Limpiar()
        {
            txtApellido.Clear();
            txtDomicilio.Clear();
            txtNroDni.Clear();
            txtTelefono.Clear();
            cmbBarrio.SelectedIndex = -1;
            
            cmbTipoDni.SelectedIndex = -1;
            btnCancelar.Enabled = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

            this.Habilitar(true);
            clientes = new Clientes();            
            txtNroCliente.Text = MetodosDB.ProxNroCliente().ToString();
            btnRegistrarCliente.Enabled = true;
            btnNuevoCliente.Enabled = false;
            btnCancelar.Enabled = true;

        }



        private void Habilitar(bool x)
        {
            txtApellido.Enabled = x;
            txtDomicilio.Enabled = x;
            txtNroDni.Enabled = x;
            txtNroCliente.Enabled = x;
            txtTelefono.Enabled = x;
            cmbBarrio.Enabled = x;          
            cmbTipoDni.Enabled = x;
        }



    }
}
