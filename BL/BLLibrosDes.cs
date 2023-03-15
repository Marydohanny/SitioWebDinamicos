using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class LibrosDesBL
    {

        public static int InsertLibroDescargado(librosDes Entidad)
        {
            return LibrosD_escargados_DAL.InsertLibroDescargado(Entidad);
        }
        public static int UpdateLibrosDescargados(librosDes Entidad)
        {
            return LibrosD_escargados_DAL.UpdateLibrosDescargados(Entidad);
        }
        public static int DeleteLibrosDescargado(librosDes Entidad)
        {
            return LibrosD_escargados_DAL.DeleteLibrosDescargado(Entidad);
        }
    }
}
