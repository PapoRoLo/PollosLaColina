using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PollosLaColina.Common
{
    class Constants
    {
        public static string DBconnection = @"Data Source=PollosLaColina.db;Version=3;New=True;Compress=True;";

        public static string ConsultaProv = "select * from Proveedores";
        public static string ConsultaClient = "select * from Clientes";

    }
}
