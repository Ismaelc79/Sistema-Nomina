using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SistemaNomina.Clases;

namespace SistemaNomina
{
    public class Program
    {
        static List<Empleado> empleados = new List<Empleado>();
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();

                Console.WriteLine("+----------Sistema de Nóminas----------+");
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Agregar empleado");
                Console.WriteLine("2. Generar reporte semanal detallado");
                Console.WriteLine("3. Salir");
                Console.WriteLine("*Presione enter luego de elegir la opción*");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEmpleado();
                        break;

                    case "2":
                        GenerarReporte();
                        break;

                    case "3":
                        Console.WriteLine("Pase feliz resto del día!");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        Console.ReadKey();
                        break;
                }

            }

        }

        static void AgregarEmpleado()
        {
            Console.Clear();

            Console.WriteLine("Seleccione tipo de empleado");
            Console.WriteLine("1. Empleado Asalariado");
            Console.WriteLine("2. Empleado Asalariado por Comisión");
            Console.WriteLine("3. Empleado por Comisión");
            Console.WriteLine("4. Empleado por Horas");

            string opcion = Console.ReadLine();

            Console.WriteLine("Introduzca el nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduzca el apellido:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Introduzca NSS:");
            string nss = Console.ReadLine();

            switch (opcion)
            {
                case "1":

                    Console.WriteLine("Introduzca salario semanal:");
                    decimal salario = decimal.Parse(Console.ReadLine());

                    EmpleadoAsalariado empAsalariado =
                        new EmpleadoAsalariado(
                            nombre,
                            apellido,
                            nss,
                            salario);

                    empleados.Add(empAsalariado);

                    Console.WriteLine("Empleado agregado correctamente!");
                    Console.ReadKey();

                    break;

                case "2":

                    Console.WriteLine("Introduzca ventas brutas:");
                    decimal ventas = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca tarifa comisión:");
                    decimal tarifa = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca salario base:");
                    decimal salarioBase = decimal.Parse(Console.ReadLine());

                    EmpleadoAsalariadoPorComision empAsaPorComision =
                        new EmpleadoAsalariadoPorComision(
                            nombre,
                            apellido,
                            nss,
                            ventas,
                            tarifa,
                            salarioBase);

                    empleados.Add(empAsaPorComision);

                    Console.WriteLine("Empleado agregado correctamente!");
                    Console.ReadKey();

                     break;

                    case "3":
                    Console.WriteLine("Introduzca ventas brutas:");
                    decimal ventasB = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca tarifa comsión:");
                    decimal tarifaC = decimal.Parse(Console.ReadLine());

                    EmpleadoPorComision empPorComision = 
                        new EmpleadoPorComision(
                            nombre,
                            apellido,
                            nss,
                            ventasB,
                            tarifaC);

                    empleados.Add(empPorComision);
                    Console.WriteLine("Empleado agregado correctamente!");
                    Console.ReadKey();

                    break;

                case "4":
                    Console.WriteLine("Introduzca sueldo por hora:");
                    decimal sueldoHora=decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca horas trabajadas:");
                    decimal horas = decimal.Parse(Console.ReadLine());

                    EmpleadoPorHoras empPorHoras =
                        new EmpleadoPorHoras(
                            apellido,
                            nss,
                            horas,
                            sueldoHora,
                            nombre);
                    empleados.Add(empPorHoras);
                    Console.WriteLine("Empleado agregado correctamente!");
                    Console.ReadKey();

                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    break;
            }
        }

        static void GenerarReporte()
        {
            Console.Clear();

            Console.WriteLine("------REPORTE SEMANAL------");

            foreach (Empleado emp in empleados)
            {
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Nombre: "
                    + emp.PrimerNombre + " "
                    + emp.ApellidoPaterno);

                Console.WriteLine("NSS: "
                    + emp.NumeroSeguroSocial);

                Console.WriteLine("Tipo de empleado: "
                    + emp.ObtenerTipoEmpleado());

                Console.WriteLine("Pago semanal: "
                    + emp.CalculoPagoSemanal());

                Console.WriteLine("----------------------------------");
            }

            Console.ReadKey();
        }
    }
}
