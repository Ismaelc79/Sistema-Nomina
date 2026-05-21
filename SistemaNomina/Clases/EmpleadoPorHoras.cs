using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina.Clases
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal HorasTrabajadas { get; set; }
        public decimal SueldoPorHora { get; set; }
        public EmpleadoPorHoras(string apellidoPaterno, string numeroSeguroSocial,
        decimal horasTrabajadas, decimal sueldoPorHora, string primerNombre) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            HorasTrabajadas = horasTrabajadas;
            SueldoPorHora = sueldoPorHora;
        }
        public override decimal CalculoPagoSemanal()
        {
            if (HorasTrabajadas <= 40)
            { 
                return HorasTrabajadas * SueldoPorHora;
            }
            else
            {
                return (SueldoPorHora* 40) + (SueldoPorHora* 1.5m + (HorasTrabajadas - 40));
            }
        }
        public override string ObtenerTipoEmpleado()
        {
            return "Empleado por Horas";
        }
    }
}
