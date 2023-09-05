using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUZ_Serv_Informaticos
{
    class FacturaTecnicas
    {

        bool realizarPago;
        int idFacturaTecnica,formaPago;
        DateTime fechaFacturaTecnica;
        double presupuesto, descuento;
        List<DetalleFacturaTecnicas> detalleFT;
        string cliente;




        public int IdFacturaTecnica { get => idFacturaTecnica; set => idFacturaTecnica = value; }
        public DateTime FechaFacturaTecnica { get => fechaFacturaTecnica; set => fechaFacturaTecnica = value; }
        public double Presupuesto { get => presupuesto; set => presupuesto = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        internal List<DetalleFacturaTecnicas> DetalleFT { get => detalleFT; set => detalleFT = value; }
        public bool RealizarPago { get => realizarPago; set => realizarPago = value; }
        public int FormaPago { get => formaPago; set => formaPago = value; }
        public string Cliente { get => cliente; set => cliente = value; }

        public FacturaTecnicas()
        {
            DetalleFT = new List<DetalleFacturaTecnicas>();
        }



        public void AgregarDetalle(DetalleFacturaTecnicas detFac)
        {
            DetalleFT.Add(detFac);
        }



        public void QuitarDetalle(int posicion)
        {
            DetalleFT.RemoveAt(posicion);
        }



        //public double CalcularTotal()
        //{
           

        //    return
        //}



    }
}
