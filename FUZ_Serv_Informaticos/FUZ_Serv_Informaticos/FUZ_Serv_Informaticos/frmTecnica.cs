using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace FUZ_Serv_Informaticos
{

   

    public  partial class frmTecnica : Form
    {
        
       

        MetodosDB metDB = new MetodosDB();

        FacturaTecnicas facTec = new FacturaTecnicas();



        public  frmTecnica()
        {
            InitializeComponent();

            

            
            


        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            
            frmBuscarClientes bc = new frmBuscarClientes();


            //this.Hide();
            //this.Dispose();

            //this.Close();

            // this.Enabled = false;


            
            
            
            bc.ShowDialog();

            

            //this.Close();

            //bc.Show();

            //bc.Dispose();



        }

        

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }




        public void HabilitarBtnBuscarCliente()
        {
            if (string.IsNullOrEmpty(lblNomCliente.Text))
            {
                btnBuscarCliente.Enabled = true;
                
            }
            else
            {
                btnBuscarCliente.Enabled = false;

                
            }
        }

        

     

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            frmBuscarProductos bp = new frmBuscarProductos();
            bp.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(lblNomCliente.Text))
            {
                MessageBox.Show("Seleccione un Cliente por favor...", "!!!Atencion!!!");

               

                timer1.Start();
                timer1.Enabled = true;

                    
            }

            if (lblNomCliente.Text!="")
            {
                if (string.IsNullOrEmpty(this.txtNroSerie.Text) || string.IsNullOrEmpty(cmbBuscarEquipo.Text))
                {
                    MessageBox.Show("Complete todos los campos por favor...", "!!!Atencion!!!");
                }

                else
                {

                    int n = dgvPresupuesto.Rows.Add();


                    metDB.CargarComboDGV(this.dgvPresupuesto, n, "select detalleEquipo from DetalleEquipo", 3);

                    metDB.CargarComboDGV(this.dgvPresupuesto, n, "select estadoEquipo from EstadoEquipo", 6);



                    DataRowView item = (DataRowView)cmbBuscarEquipo.SelectedItem;


/*--------------------------------------------------------------------------------------------------------------------------------*/ // Saco valores de Tecnica

                    int id_equipo = Convert.ToInt32(item.Row.ItemArray[0]);
                    string equi = item.Row.ItemArray[1].ToString();
                    double precio = Convert.ToInt32(item.Row.ItemArray[2]);



                    dgvPresupuesto.Rows[n].Cells[0].Value = id_equipo;

                    dgvPresupuesto.Rows[n].Cells["Equipo_a_Reparar"].Value = equi;
                    
                    dgvPresupuesto.Rows[n].Cells[4].Value = "$ "+precio;

                                      
                    Tecnicas tec = new Tecnicas(id_equipo, equi, precio);

/*-----------------------------------------------------------------------------------------------------------------------------------*/ // Saco valores de DetalleTecnica

                    dgvPresupuesto.Rows[n].Cells[2].Value = txtNroSerie.Text;

                    string nroSerie = dgvPresupuesto.Rows[n].Cells[2].Value.ToString();

                    


                    int detEqui = Convert.ToInt32(dgvPresupuesto.Rows[n].Cells[3].Value);

                    int estEqui= Convert.ToInt32(dgvPresupuesto.Rows[n].Cells[6].Value);

                    bool garan= Convert.ToBoolean(dgvPresupuesto.Rows[n].Cells[5].Value);

                    string nomCli = lblNomCliente.Text;

                    //double subTot = Convert.ToDouble(lblprecioSubTotal.Text);


                    DetalleFacturaTecnicas detFac = new DetalleFacturaTecnicas(this.txtNroSerie.Text, detEqui, estEqui, garan, this.txtFallas.Text, tec);



                    facTec.AgregarDetalle(detFac);
                    facTec.Cliente = lblNomCliente.Text;
                    facTec.Descuento = Convert.ToDouble(txtDescuento.Text);
                    facTec.FormaPago = cmbFormaPago.SelectedIndex+1;
                    facTec.Presupuesto = Convert.ToDouble(txtTotPresup.Text);
                    facTec.RealizarPago = hScrollBarCancelacion.Enabled = false;
                    facTec.FechaFacturaTecnica = Convert.ToDateTime(txtfecha.Text);
                    
                    // A la idFacturaTecnica la creo para cuando tenga que buscar facturas se me asigne el nro de factura???
                    


                    //subtotal += precio;


                    //lblprecioSubTotal.Text = subtot.ToString();







                    cmbBuscarEquipo.SelectedIndex = -1;
                    txtNroSerie.Clear();

                    

                   
                }
            }

                
        }



        
        // Quita Equipos del DataGridView y de los objetos creados!!!

        private void dgvPresupuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPresupuesto.CurrentCell.ColumnIndex == 10)
            {
                
                    dgvPresupuesto.Rows.Remove(dgvPresupuesto.CurrentRow);

                    facTec.QuitarDetalle(dgvPresupuesto.CurrentRow.Index); //Si elimino la ultima fila del datagridview luego de agregar equipos se rompe todo!!!
                
            }

             
        }





        // Avisa con colores parpadeando cuando se quiere llenar el form Tecnica pero no se eligio cliente previamente!!!

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            int one = rand.Next(0, 200);
            int two = rand.Next(0, 200);
            int three = rand.Next(0, 200);
            int four = rand.Next(0, 200);


            btnBuscarCliente.ForeColor = Color.FromArgb(one, two, three, four);


        }




        // BOTON REGISTRAR PRESUPUESTO

        private void btnRegistrarPresupuesto_Click(object sender, EventArgs e)
        {
            // faltan validaciones ifffff
            
            metDB.RegistrarPresupuesto(facTec);
        }




        /*--------------------------------------------------------------------------------------------------------------------------------------------------------*/



        // LOADDDDDDDDDDDDDDDDDDDDDDDDDDDDD




        private void frmTecnica_Load(object sender, EventArgs e)
        {


            

            MetodosDB.SeleccionarCmb(this.cmbBuscarEquipo, "select id_tecnica, equipo, precio_tecnica from Tecnicas order by equipo asc", "equipo", "id_tecnica");



            cmbBuscarEquipo.SelectedIndex = -1;

            lblProxNro.Text = MetodosDB.ProxNroCliente().ToString();

            txtfecha.Text = DateTime.Now.ToShortDateString();






            MetodosDB.SeleccionarCmb(cmbFormaPago, "select id_formaPAgo, formaPago from FormaPagos", "formaPago","id_formaPago");


            cmbFormaPago.SelectedIndex = -1;




        }

        

       

        
    }
}




