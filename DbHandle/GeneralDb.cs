using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLMotos.DbHandle
{
    public class GeneralDb
    {
        public static string Cadena { get; set; }
        public GeneralDb()
        {
        }
        public GeneralDb(string connectionString)
        {
            Cadena = connectionString;
        }
    }
}
