using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados empleado = new Empleados();
            empleado.Edad = 20;
            empleado.Nombre = "Giancarlo Leandro";
            empleado.SueldoDiario = 15.5m;
            decimal total = empleado.CalculaSalario(2);
            Console.WriteLine("El Salario Mensual del empleado " + empleado.Nombre);
            Console.WriteLine("es: " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}
