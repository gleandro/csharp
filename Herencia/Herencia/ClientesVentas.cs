using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class ClientesVentas : Clientes
    {
        private string _RFC;
        private string _Direccion;
        private string _Colonia;

        public string RFC { get => _RFC; set => _RFC = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
    }
}
