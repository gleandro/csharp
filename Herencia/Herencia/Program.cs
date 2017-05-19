using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesVentas cli = new ClientesVentas();
            cli.IdCliente = 1;
            cli.Nombes = "Giancarlo";
            cli.Apellidos = "Leandro";
            cli.Colonia = "Colonia1";
            cli.Direccion = "Direccion1";
            cli.RFC = "RFC1";
            StreamWriter sw = new StreamWriter(@"E:\TXT\log.txt",true);
            String cadena = Console.ReadLine();
            if (cadena == "1")
            {
                sw.WriteLine("Usuario : " + cli.IdCliente + " " + cli.Nombes + " " + cli.Apellidos + ", Colonia : " + cli.Colonia + ", Direccion : " + cli.Colonia + ", RFC : " + cli.RFC);
                sw.Close();
            }
            else
            {
                Console.WriteLine("Usuario : " + cli.IdCliente + " " + cli.Nombes + " " + cli.Apellidos + ", Colonia : " + cli.Colonia + ", Direccion : " + cli.Colonia + ", RFC : " + cli.RFC);
            }
            
            
            
            //comment
        }
    }
}
