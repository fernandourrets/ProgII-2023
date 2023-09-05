using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace FUZ_Serv_Informaticos
{
      class  MetodosDB
    {

        double acuSubTot;


        // Metodo para registrar clientes a la base de datos!!!

        public static void RegistrarClientes(/*int numCliente, */Clientes cli)
        {

            try
            {



                SqlConnection conexion = new SqlConnection();

                SqlCommand comando = new SqlCommand();

                conexion.ConnectionString = "Data Source=SERVER;Initial Catalog=Servicios_Informaticos;Integrated Security=True";

                conexion.Open();

                comando.Connection = conexion;

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.CommandText = "AgregarClientes";



                comando.Parameters.AddWithValue("@apellido", cli.Pers.Apellido);
                comando.Parameters.AddWithValue("@nombre", cli.Pers.Nombre);
                comando.Parameters.AddWithValue("@domicilio", cli.Pers.Domicilio);
                comando.Parameters.AddWithValue("@nroDomicilio", cli.Pers.NroDomicilio);
                comando.Parameters.AddWithValue("@id_barrio", cli.Pers.Barrio);

                comando.Parameters.AddWithValue("@id_tipoDni", cli.Pers.TipoDni);
                comando.Parameters.AddWithValue("@nro_tipoDni", cli.Pers.NroDni);
                comando.Parameters.AddWithValue("@nroTelefono", cli.Pers.NroTel);
                comando.Parameters.AddWithValue("@nroCliente", cli.NumeroCliente);




                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente registrado satisfactoriamente a la base de datos!!!");

            }



            catch (Exception ex)
            {

                MessageBox.Show("Error en la conexion a la base de datos...ERROR al registrar Cliente", ex.ToString());
            }

        }



        // Metodo para mostrar el proximo numero de cliente!!!

        public static int ProxNroCliente()
        {


            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();


            conexion.ConnectionString = "Data Source=SERVER;Initial Catalog=Servicios_Informaticos;Integrated Security=True";

            conexion.Open();

            comando.Connection = conexion;

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "sp_proximo_id";

            SqlParameter parametro = new SqlParameter("@next", SqlDbType.Int);

            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);

            comando.ExecuteNonQuery();

            conexion.Close();


            int ultimoNro = Convert.ToInt32(parametro.Value);



            return ultimoNro;



        }


        //Metodo para cargar combobox que muestra los equipos para seleccionarlos y luego cargarlos en el DatagridView en el form Tecnica y Metodo para cargar las formas de pago en el form Metodos!!!!
        
        public static void SeleccionarCmb(ComboBox cmb, string cadena, string dm, string vm)
        {


            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();


            conexion.ConnectionString = "Data Source=SERVER;Initial Catalog=Servicios_Informaticos;Integrated Security=True";

            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = cadena;

            DataTable tabla = new DataTable();

            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            cmb.DataSource = tabla;
            cmb.DisplayMember = dm;
            cmb.ValueMember = vm;



        }




        //Metodo para buscar clientes, seleccionar los combobox Barrio y Tipo Dni en form buscar Clientes y buscar comboBox del datagridview


        public static DataTable BuscarTablas(string cadena)
        {


            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();


            conexion.ConnectionString = "Data Source=SERVER;Initial Catalog=Servicios_Informaticos;Integrated Security=True";

            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = cadena;

            DataTable tabla = new DataTable();

            tabla.Load(comando.ExecuteReader());

            conexion.Close();


            return tabla;


        }



        //Metodo para registrar transaccion tabla maestro detalle...FacturaTecnica con detalle facturaTecnica!!!

        public void RegistrarPresupuesto(FacturaTecnicas facTec)
        {

            //bool resultado = true;

            //SqlTransaction t = null;

            SqlConnection conexion = new SqlConnection();


            //try
            //{

                //SqlConnection conexion = new SqlConnection();

                SqlCommand comando = new SqlCommand();

               // t = conexion.BeginTransaction();

                conexion.ConnectionString = "Data Source=SERVER;Initial Catalog=Servicios_Informaticos;Integrated Security=True";

                conexion.Open();

                comando.Connection = conexion;

               // comando.Transaction = t;

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.CommandText = "RegistrarPresupuesto";



            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@id_facturaTecnica";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);

            comando.Parameters.AddWithValue("@fechaFacturaTecnica", facTec.FechaFacturaTecnica);

                comando.Parameters.AddWithValue("@descuento", facTec.Descuento);

                comando.Parameters.AddWithValue("@presupuesto", facTec.Presupuesto);

                comando.Parameters.AddWithValue("@id_Pago", facTec.FormaPago); //Me da error en la relacion de las tablas Factura Tecnicas con Forma Pagos, la relacion PK-FK esta bien

                comando.Parameters.AddWithValue("@id_cliente", 18/*facTec.Cliente*/); // No se como hacer para que me registre el id cliente !!!

                comando.Parameters.AddWithValue("@id_realizarPago", facTec.RealizarPago);

                



               

                 

            comando.ExecuteNonQuery();


               int presupuesoNro = Convert.ToInt32(parametro.Value);

                int detalleNro = 1;


                SqlCommand comandoDetalle;

                foreach (DetalleFacturaTecnicas dft in facTec.DetalleFT)
                {
                    comandoDetalle = new SqlCommand();
                    comandoDetalle.Connection = conexion;
                    comandoDetalle.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoDetalle.CommandText = "RegistrarDetallePresupuesto";

                    comandoDetalle.Parameters.AddWithValue("@id_tecnica", presupuesoNro);
                    comandoDetalle.Parameters.AddWithValue("@id_detalleFactura", detalleNro);
                    comandoDetalle.Parameters.AddWithValue("@falla", dft.Falla);
                    comandoDetalle.Parameters.AddWithValue("@id_estadoEquipo", dft.EstadoEquipo);
                    comandoDetalle.Parameters.AddWithValue("@garantia", dft.Garantia);
                    comandoDetalle.Parameters.AddWithValue("@id_detalleEquipo", dft.DetalleEquipo);
                    comandoDetalle.Parameters.AddWithValue("@id_producto", dft.Tec.IdEquipo);



                    comando.ExecuteNonQuery();


                    detalleNro++;


                }

                //t.Commit();



                MessageBox.Show("Equipo registrado satisfactoriamente a la base de datos!!!");

                

            //}



            //catch (Exception ex)
            //{
            //    if (t != null)

            //        t.Rollback();

            //    resultado = false;

            //    MessageBox.Show("Error en la conexion a la base de datos...ERROR al registrar el Equipo", ex.ToString());

               
            //}

            //finally
            //{
            //    if (conexion != null && conexion.State == ConnectionState.Open)

                    conexion.Close();
            //}

            
            //return resultado;

        
           

        }

        






      

        //Carga el comboBox Detalles Equipo y Estado Equipo a equipos de Tecnica en el data grid view!!!

        public void CargarComboDGV(DataGridView data, int n, string cadena, int celdaNro) 
        {



            DataTable dgv = MetodosDB.BuscarTablas(cadena);



            ArrayList ComboDgv = new ArrayList();


            foreach (DataRow item in dgv.Rows)
            {
                ComboDgv.Add(item[0]); //es 0 porque en el Select pido solo traer la columna detalleEquipo!!!!
                                       //ComboDgv.Add(item["detalleEquipo"]); es lo mismo que arriba





                var Celda = new DataGridViewComboBoxCell();

                Celda.DataSource = ComboDgv;

                data.Rows[n].Cells[celdaNro] = Celda;
                
                
            }

            

        }



    }



}
