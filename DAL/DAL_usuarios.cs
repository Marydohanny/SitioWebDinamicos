using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
namespace DAL
{
    public static class DAL_usuarios
    {

        public static int InsertUsuarios(usuario Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("InsertUsuarios", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", Entidad.IdUsuario);
                cmd.Parameters.AddWithValue("@NombreCompleto ", Entidad.NombreCompleto);
                cmd.Parameters.AddWithValue("@Correo", Entidad.Correo);
                cmd.Parameters.AddWithValue("@UserName ", Entidad.UserName);
                cmd.Parameters.AddWithValue("@Password", Entidad.Password);
                cmd.Parameters.AddWithValue("@Bloqueado ", Entidad.Bloqueado);
                cmd.Parameters.AddWithValue("@IntentosFallidos", Entidad.IntentosFallidos);
                cmd.Parameters.AddWithValue("@IdRol", Entidad.IdRol);
                cmd.Parameters.AddWithValue("@Activo ", Entidad.Activo);
                cmd.Parameters.AddWithValue("@IdUsuarioRegistra", Entidad.IdUsuarioRegistra);
                cmd.Parameters.AddWithValue("@FechaRegistro ", Entidad.FechaRegistro);
                cmd.Parameters.AddWithValue("@IdUsuarioActualiza ", Entidad.IdUsuarioActualiza);
                cmd.Parameters.AddWithValue("@FechaActualizacion ", Entidad.FechaActualizacion);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int UpdateUsuarios(usuario Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("UpdateUsuarios", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", Entidad.IdUsuario);
                cmd.Parameters.AddWithValue("@NombreCompleto ", Entidad.NombreCompleto);
                cmd.Parameters.AddWithValue("@Correo", Entidad.Correo);
                cmd.Parameters.AddWithValue("@UserName ", Entidad.UserName);
                cmd.Parameters.AddWithValue("@Password", Entidad.Password);
                cmd.Parameters.AddWithValue("@Bloqueado ", Entidad.Bloqueado);
                cmd.Parameters.AddWithValue("@IntentosFallidos", Entidad.IntentosFallidos);
                cmd.Parameters.AddWithValue("@IdRol", Entidad.IdRol);
                cmd.Parameters.AddWithValue("@Activo ", Entidad.Activo);
                cmd.Parameters.AddWithValue("@IdUsuarioRegistra", Entidad.IdUsuarioRegistra);
                cmd.Parameters.AddWithValue("@FechaRegistro ", Entidad.FechaRegistro);
                cmd.Parameters.AddWithValue("@IdUsuarioActualiza ", Entidad.IdUsuarioActualiza);
                cmd.Parameters.AddWithValue("@FechaActualizacion ", Entidad.FechaActualizacion);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int DeleteUsuarios(usuario Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("DeleteUsuarios", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", Entidad.IdUsuario);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


    }
}
