using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using PICTOCAM_SERVICE.BO;
using PICTOCAM_SERVICE.DAO;
using PICTOCAM_SERVICE.Services;
using System.Data;
using System.Data.SqlClient;

namespace PICTOCAM_SERVICE.DAO
{
    public class Cls_EscuelaDAO
    {
        cls_ConexionDAO obj_conexion = new cls_ConexionDAO();

        public DataSet ConsultarEscuela(object obj)
        {
            cls_EscuelaBO evento = (BO.cls_EscuelaBO)obj;
            obj_conexion = new cls_ConexionDAO();
            string sql;
            sql = "SELECT* FROM ESCUELA";
            return obj_conexion.TablaDS(sql);
        }

        public int AgregarEscuela(object obj)
        {
            SqlCommand cmd = new SqlCommand();
            cls_EscuelaBO escuela = (BO.cls_EscuelaBO)obj;
            cmd.CommandText = "ESCUELAALT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Par_CLAVE", SqlDbType.VarChar).Value = escuela.ClaveEsc;
            cmd.Parameters.Add("@Par_HISTORIA", SqlDbType.VarChar).Value = escuela.Historia;
            cmd.Parameters.Add("@Par_MISION", SqlDbType.VarChar).Value = escuela.Mision;
            cmd.Parameters.Add("@Par_VISION", SqlDbType.VarChar).Value = escuela.Vision;
            cmd.Parameters.Add("@Par_IMAGEN", SqlDbType.VarChar).Value = escuela.Imagen;
            cmd.Parameters.Add("@Par_DIRECCION", SqlDbType.VarChar).Value = escuela.Direccion;
            cmd.Parameters.Add("@Par_USUARIO", SqlDbType.VarChar).Value = "kiara10@outlook.com";
            return obj_conexion.executeSQL(cmd);

        }
        public int ActualizarEscuela(object obj)
        {
            SqlCommand cmd = new SqlCommand();
            clsEscuelaModel escuela = (BO.clsEscuelaModel)obj;
            cmd.CommandText = "ESCUELAACT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Par_CLAVE", SqlDbType.VarChar).Value = escuela.Cls_EscuelaBO.ClaveEsc;
            cmd.Parameters.Add("@Par_HISTORIA", SqlDbType.VarChar).Value = escuela.Cls_EscuelaBO.Historia;
            cmd.Parameters.Add("@Par_MISION", SqlDbType.VarChar).Value = escuela.Cls_EscuelaBO.Mision;
            cmd.Parameters.Add("@Par_VISION", SqlDbType.VarChar).Value = escuela.Cls_EscuelaBO.Vision;
            cmd.Parameters.Add("@Par_IMAGEN", SqlDbType.VarChar).Value = "imagen";
            return obj_conexion.executeSQL(cmd);

        }

        public int EliminarEscuela(object Id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM escuela  WHERE CLAVE = @Par_CLAVE";
            cmd.Parameters.Add("@Par_CLAVE", SqlDbType.Int).Value = Id;

            return obj_conexion.executeSQL(cmd);
        }

        public DataSet ConsultarInformacioEscuela(object obj)
        {
            cls_EscuelaBO escuelBo = (BO.cls_EscuelaBO)obj;
            obj_conexion = new cls_ConexionDAO();
            string sql;
            sql = "EXEC ESCUELACON 0" +escuelBo.ClaveEsc;
            return obj_conexion.TablaDS(sql);
        }


          public List<cls_EscuelaBO> lista()
        {
            try
            {
                obj_conexion.conexionBD();
                obj_conexion.abrirCon();
                IList<cls_EscuelaBO> EmpList = SqlMapper.Query<cls_EscuelaBO>(
                                  obj_conexion.con, "ESCUELACON").ToList();
                obj_conexion.cerrarCon();
                return EmpList.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

}
