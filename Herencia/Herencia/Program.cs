﻿using System;
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
            sw.WriteLine("Usuario : " + cli.IdCliente + " " + cli.Nombes + " " + cli.Apellidos + ", Colonia : " + cli.Colonia + ", Direccion : " + cli.Colonia + ", RFC : " + cli.RFC);
            sw.Close();
            Console.WriteLine("Usuario : " + cli.IdCliente + " "+cli.Nombes +" " + cli.Apellidos +", Colonia : " + cli.Colonia + ", Direccion : " + cli.Colonia + ", RFC : " + cli.RFC);
            Console.ReadKey();
            //comment
        }
    }
}
