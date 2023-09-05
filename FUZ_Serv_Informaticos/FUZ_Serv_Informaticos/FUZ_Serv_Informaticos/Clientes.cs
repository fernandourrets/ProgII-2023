using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUZ_Serv_Informaticos
{

    
    class Clientes //: Personas
    {
        //Variables

        int numeroCliente;

        Personas pers;

       



        


        //Propiedades


        public int NumeroCliente { get => numeroCliente; set => numeroCliente = value; }
        public Personas Pers { get => pers; set => pers = value; }


        public Clientes()//:base()
        {
            NumeroCliente = 0;
            Pers = new Personas();


        }



        //Constructor con parametros


        //public Clientes(int numeroCliente, Personas personas, string nombre, string apellido, string domicilio, int nroDomicilio, int nroDni, string tipoDni, int nroTel, string barrio) : base(nombre, apellido, domicilio, nroDomicilio, nroDni, tipoDni, nroTel, barrio)
        //{
        //    NumeroCliente = numeroCliente;
        //    Pers = personas;
        //}





    }
}
