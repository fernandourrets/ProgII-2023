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
    public partial class frmBuscarClientes : Form
    {

        

        public frmBuscarClientes()
        {
            InitializeComponent();

            

            
            

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {




            

            

            txtBuscarCliente.Select();


            

        }

        private void btnTodosLosClientes_Click(object sender, EventArgs e)
        {


            txtBuscarCliente.Select();


            txtBuscarCliente.Clear();



          

            dgvClientes.DataSource = MetodosDB.BuscarTablas("select c.id_cliente, c.apellido, c.nombre, c.domicilio, c.nro_domicilio, b.barrio, td.tipoDni, c.nro_tipoDni, c.nro_telefono from Clientes c,TipoDni td,Barrios b where c.id_barrio=b.id_barrio and td.id_tipoDni=c.id_tipoDni");

















        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
            
            txtBuscarCliente.Select();

            dgvClientes.DataSource = null;
            
        }

       

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {


            DataView dv = new DataView(MetodosDB.BuscarTablas("select c.id_cliente, c.apellido, c.nombre, c.domicilio, c.nro_domicilio, b.barrio, td.tipoDni, c.nro_tipoDni, c.nro_telefono from Clientes c,TipoDni td,Barrios b where c.id_barrio=b.id_barrio and td.id_tipoDni=c.id_tipoDni"));

            
            dv.RowFilter = String.Format("apellido like '%{0}%'", txtBuscarCliente.Text);
            
            dgvClientes.DataSource = dv;

            





        }



        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            frmTecnica tecnica = new frmTecnica();
            
            
            
            txtNroCliente.Text = dgvClientes.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvClientes.SelectedCells[1].Value.ToString()  + " " + dgvClientes.SelectedCells[2].Value.ToString();
            txtDomicilio.Text = dgvClientes.SelectedCells[3].Value.ToString() + " " + dgvClientes.SelectedCells[4].Value.ToString();
            txtBarrio.Text = dgvClientes.SelectedCells[5].Value.ToString();
            txtTipoDni.Text = dgvClientes.SelectedCells[6].Value.ToString();
            txtNroDni.Text= dgvClientes.SelectedCells[7].Value.ToString();            
            txtTelefono.Text = dgvClientes.SelectedCells[8].Value.ToString();
            

            foreach (Form f in Application.OpenForms)
            {

                if (f.Text == "Servicio Tecnico")
                {

                    
                    //f.Refresh();

                    tecnica.lblNomCliente.Text = txtNombre.Text;
                    
                    this.Dispose();
                    f.Dispose();
                    
                    tecnica.Activate();

                    //this.Hide();
                   //this.Dispose();
                    //f.Dispose();

                   tecnica.HabilitarBtnBuscarCliente();
                    
                   tecnica.ShowDialog();
                    

                    

                    break;



                }
            }






            //tec.Refresh();

            //tec.ShowDialog();

            // tec.Show(frmTecnica.ActiveForm);

            //this.Dispose();

            //tec.ShowDialog();

            //this.Close();

            //this.Dispose();
            //this.Hide();



            

        }

        

        public void Habilitar(bool x)
        {
            btnTodosLosClientes.Enabled = x;
            btnLimpiarBusqueda.Enabled = x;
            txtBuscarCliente.Enabled = x;
            txtBuscarCliente.Select();



        }

     

        private void tabClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabClientes.SelectedTab == tabDgvClientes)
            {
                
                Habilitar(true);
            }

            else
            {
                
                Habilitar(false);
                
            }

            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            frmAgregarClientes nuevoCli = new frmAgregarClientes();

            nuevoCli.ShowDialog();
            nuevoCli.Dispose();

            





        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir???", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(resultado==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }


}
 