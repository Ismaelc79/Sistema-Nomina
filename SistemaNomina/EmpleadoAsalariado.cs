using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina.Clases

public class EmpleadoAsalariado : Empleado

{
	public decimal salarioSemanal{ get; set; };

	public override calcularPagoSemanal()
	{
		return salarioSemanal;
	}
	
}
