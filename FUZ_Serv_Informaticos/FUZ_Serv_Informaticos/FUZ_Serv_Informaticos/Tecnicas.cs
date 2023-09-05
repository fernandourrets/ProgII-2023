using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FUZ_Serv_Informaticos
{


    

    internal class  Tecnicas
    {

        double acu = 0;

        //Variables

        int idEquipo;
        string equipo;
        double precioTecnica;


        //Propiedades

        
        public string Equipo { get => equipo; set => equipo = value; }
        
        public double PrecioTecnica { get => precioTecnica; set => precioTecnica = value; }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }



        //Constructor


        public Tecnicas()
        {
            idEquipo = 0;
            equipo = null;
            precioTecnica = 0;
        }

        public Tecnicas(int idEquipo, string equipo, double precioTecnica)
        {
            IdEquipo = idEquipo;
            Equipo = equipo;
            PrecioTecnica = precioTecnica;
        }



    }
}
