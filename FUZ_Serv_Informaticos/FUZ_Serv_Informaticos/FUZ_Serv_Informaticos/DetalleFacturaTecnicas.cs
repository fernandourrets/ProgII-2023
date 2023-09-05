using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUZ_Serv_Informaticos
{
    class DetalleFacturaTecnicas
    {

        
        int detalleEquipo,estadoEquipo;
        bool garantia;
        string falla,nroSerie;
        Tecnicas tec;
        

        public DetalleFacturaTecnicas(string nroSerie, int detalleEquipo, int estadoEquipo, bool garantia, string falla, Tecnicas tec)
        {
            NroSerie = nroSerie;
            DetalleEquipo = detalleEquipo;
            EstadoEquipo = estadoEquipo;
            Garantia = garantia;
            Falla = falla;
            Tec = tec;
            
            
        }

        public bool Garantia { get => garantia; set => garantia = value; }       
        public string Falla { get => falla; set => falla = value; }
        public int DetalleEquipo { get => detalleEquipo; set => detalleEquipo = value; }       
        public int EstadoEquipo { get => estadoEquipo; set => estadoEquipo = value; }
        internal Tecnicas Tec { get => tec; set => tec = value; }
        public string NroSerie { get => nroSerie; set => nroSerie = value; }
        

    }


    //public double CalcularSubTotal()
    //{
    //    return ;
    //}
}
