using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaNomina.Clases
{

    public abstract class Empleado

    {
         public string PrimerNombre { get; set; }
         public string ApellidoPaterno { get; set; }
         public string NumeroSeguroSocial { get; set; }
        public Empleado(string primerNombre, string apellidoPaterno, string
            numeroSeguroSocial)
        {
            this.PrimerNombre= primerNombre;
            this.ApellidoPaterno= apellidoPaterno;
            this.NumeroSeguroSocial= numeroSeguroSocial;
            
        }      
        public abstract decimal CalculoPagoSemanal();

        public abstract string ObtenerTipoEmpleado();



    }
}
