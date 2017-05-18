using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Empleados
    {
        public string Nombre;
        public decimal SueldoDiario;
        public int Edad;

        public Empleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        public decimal CalculaSalario(int dias)
        {
            return SueldoDiario * dias;
        }
    }
}
