using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class comentariosBL
    {
        public static int Insertcomentarios(comentarios Entidad)
        {
            return comentariosDAL.Insertcomentarios(Entidad);
        }
        public static int updadtecomentarios(comentarios Entidad)
        {
            return comentariosDAL.updadtecomentarios(Entidad);
        }
        public static int deletecomentarios(comentarios Entidad)
        {
            return comentariosDAL.deletecomentarios(Entidad);
        }
    }
}
