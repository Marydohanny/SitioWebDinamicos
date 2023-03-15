using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class usuarioBL
    {
        public static int InsertUsuarios(usuario Entidad)
        {
            return DAL_usuarios.InsertUsuarios(Entidad);
        }
        public static int UpdateUsuarios(usuario Entidad)
        {
            return DAL_usuarios.UpdateUsuarios(Entidad);
        }
        public static int DeleteUsuarios(usuario Entidad)
        {
            return DAL_usuarios.DeleteUsuarios(Entidad);
        }
    }
}
