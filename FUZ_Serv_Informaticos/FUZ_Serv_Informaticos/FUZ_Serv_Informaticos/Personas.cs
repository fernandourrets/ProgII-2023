using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUZ_Serv_Informaticos
{
    public class  Personas
    {
        //Variables

        string nombre,domicilio,apellido;
        int nroDni,nroDomicilio,barrio,tipoDni;
        long nroTel;

       


        //Propiedades

        public string Nombre { get => nombre; set => nombre = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int TipoDni { get => tipoDni; set => tipoDni = value; }
        public int Barrio { get => barrio; set => barrio = value; }
        public int NroDni { get => nroDni; set => nroDni = value; }
        public int NroDomicilio { get => nroDomicilio; set => nroDomicilio = value; }
        public long NroTel { get => nroTel; set => nroTel = value; }

       
        
        
        
        
        
        //Constructor con parametros
        
        public Personas(string nombre, string apellido,string domicilio, int nroDomicilio, int nroDni,int tipoDni, long nroTel,int barrio)
        {
            Nombre = nombre;
            Domicilio = domicilio;
            Apellido = apellido;
            TipoDni = tipoDni;
            Barrio = barrio;
            NroDni = nroDni;
            NroDomicilio = nroDomicilio;
            NroTel = nroTel;
        }



        //Constructor sin parametros

        public Personas()
        {
        }






        


























        //Metodos

        //public string GetEstadoAfip()
        //{
        //    switch (EstadoAfip)
        //    {

        //        case 1: return "MONOTRIBUTISTA";
        //        case 2: return "RESPONSABLE INSCRIPTO";
        //        case 3: return "S.A.S";
        //        case 4: return "S.A";
        //        case 5: return "CONSUMIDOR FINAL";

        //        default: return "Ud. NO ha seleccionado un tipo valido";
        //    }
        //}


        //public string GetSexo()
        //{
        //    switch (Sexo)
        //    {
        //        case 1: return "MASCULINO";
        //        case 2: return "FEMENINO";
        //        case 3: return "OTRO";
        //        default: return "Ud. NO ha seleccionado el sexo";
        //    }
        //}


        //public string GetTipoAfip()
        //{
        //    switch (TipoAfip)
        //    {

        //        case 1: return "DNI";
        //        case 2: return "CUIL";
        //        case 3: return "CUIT";


        //        default: return "Ud. NO ha seleccionado un tipo valido";
        //    }
        //}

        //public string GetDatosPers()
        //{
        //    return
        //        $"Datos de la Persona: \n" +
        //        $"Nombre:{Nombre}\n" +
        //        $"Tipo Estado Afip:{GetEstadoAfip()}\n" +
        //        $"Nro:{NroAfip}\n" +                
        //        $"Tipo Afip:{GetTipoAfip()}\n" +
        //        $"Domicilio: {Domicilio}" +
        //        $"Barrio:{Barrio}";

        //}
    }
}
