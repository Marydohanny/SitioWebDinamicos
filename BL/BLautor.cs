using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BLautor
    {
        public static int InsertAutor(autor Entidad)
        {
            return autorDAL.InsertAutor(Entidad);
        }
        public static int UpdateAutor(autor Entidad)
        {
            return autorDAL.UpdateAutor(Entidad);
        }
        public static int DeleteAutor(autor Entidad)
        {
            return autorDAL.DeleteAutor(Entidad);
        }
    }
}
