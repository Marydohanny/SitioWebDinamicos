using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class editorialBL
    {
        public static int InsertEditorial(editorial Entidad)
        {
            return editorialDAL.InsertEditorial(Entidad);
        }
        public static int UpdateEditorial(editorial Entidad)
        {
            return editorialDAL.UpdateEditorial(Entidad);
        }
        public static int DeleteEditorial(editorial Entidad)
        {
            return editorialDAL.DeleteEditorial(Entidad);
        }

    }
}
