using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PICTOCAM_SERVICE.BO;
using System.Data.SqlClient;
using System.Data;

namespace PICTOCAM_SERVICE.DAO
{
    public class cls_AlumnoDAO
    {
        cls_ConexionDAO obj_conexion = new cls_ConexionDAO();

        public int AgregarAlumno(object obj)
        {
            SqlCommand cmd = new SqlCommand();
            cls_AlumnoBO noti = (BO.cls_AlumnoBO)obj;
            cmd.CommandText = "ALUMNOALT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Par_NOMBRE", SqlDbType.VarChar).Value = noti.Nombre;
            cmd.Parameters.Add("@Par_APATERNO", SqlDbType.VarChar).Value = noti.APaterno;
            cmd.Parameters.Add("@Par_AMATERNO", SqlDbType.VarChar).Value = noti.AMaterno;
            cmd.Parameters.Add("@Par_FECHA_NAC", SqlDbType.Date).Value = noti.FechaNac1;
            cmd.Parameters.Add("@Par_TELEFONO_p", SqlDbType.Int).Value = noti.Numero;  
            cmd.Parameters.Add("@Par_FOTO", SqlDbType.VarChar).Value = noti.Imagen;
            cmd.Parameters.Add("@Par_GRUPO", SqlDbType.Int).Value = noti.Grupo;
            cmd.Parameters.Add("@Par_USUARIO", SqlDbType.VarChar).Value = noti.Usuario_FK;
            return obj_conexion.executeSQL(cmd);
        }
    }
}