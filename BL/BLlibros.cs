using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class librosBL
    {
        public static int InsertLibros(LibroEL Entidad)
        {
            return DalLibro.InsertLibros(Entidad);
        }
        public static int UpdateLibros(LibroEL Entidad)
        {
            return DalLibro.UpdateLibros(Entidad);
        }
        public static int DeleteLibros(LibroEL Entidad)
        {
            return DalLibro.DeleteLibros(Entidad);
        }

    }
}
