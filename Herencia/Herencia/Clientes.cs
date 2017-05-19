using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Clientes
    {
        private int _IdCliente;
        private String _Nombes;
        private String _Apellidos;
        
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string Nombes { get => _Nombes; set => _Nombes = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
    }
}
