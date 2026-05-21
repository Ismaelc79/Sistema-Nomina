using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina

public asbtract class Empleado
	
{
    private string primerNombre { get; set; }, apellidoPaterno{ get; set; }, numeroSeguroSocial { get; set; }
    
    public abstract decimal calculoPagoSemanal();

    public Empleado()
	{

	}

}
