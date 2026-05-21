using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina.Clases
{
    public class EmpleadoAsalariadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }
        public decimal SalarioBase { get; set; }

        public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial,
        decimal ventasBrutas, decimal tarifaComision, decimal salarioBase): base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            this.VentasBrutas = ventasBrutas;
            this.TarifaComision = tarifaComision;
            this.SalarioBase = salarioBase;
        }

        public override decimal CalculoPagoSemanal()
        {
            return ((VentasBrutas * TarifaComision) + SalarioBase 
             + (SalarioBase*0.10m));
        }

        public override string ObtenerTipoEmpleado()
        {
            return "Empleado Asalariado por Comisión";
        }
    }
}
