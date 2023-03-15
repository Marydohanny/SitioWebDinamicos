using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;;
using System.Runtime.InteropServices;
using EL;

namespace DAL
{
    public static class DAL_Roles
    {
        //Insert
        public static Roles InsertRoles(Roles Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                Entidad.Activo = true;
                Entidad.FechaRegsitro = DateTime.Now;
                bd.Roles.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        //Update
        public static bool Update(Roles Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var RegistroBD = bd.Roles.Find(Entidad.IdRol);
                RegistroBD.Rol = Entidad.Rol;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
 

        //Delete
        public static bool Delete(Roles Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var RegistroBD = bd.Roles.Find(Entidad.IdRol);
                RegistroBD.Activo = false;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
    }

}
