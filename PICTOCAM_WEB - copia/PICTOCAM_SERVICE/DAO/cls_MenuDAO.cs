using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PICTOCAM_SERVICE.BO;
using System.Data;
using Dapper;
namespace PICTOCAM_SERVICE.DAO
{
    public class cls_MenuDAO
    {
        cls_ConexionDAO obj_conexion = new cls_ConexionDAO();

        public int AgregarMenu(object obj)
        {
            SqlCommand cmd = new SqlCommand();
            clsMenuModel menu = (BO.clsMenuModel)obj;
            cmd.CommandText = "MENUALT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Par_LUNES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Lunes;
            cmd.Parameters.Add("@Par_MARTES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Martes;
            cmd.Parameters.Add("@Par_MIERCOLES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Miercoles;
            cmd.Parameters.Add("@Par_JUEVES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Jueves;
            cmd.Parameters.Add("@Par_VIERNES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Viernes;
            cmd.Parameters.Add("@Par_FECHA_INI", SqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@Par_FECHA_FIN", SqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@Par_USUARIO", SqlDbType.VarChar).Value = "Kiara";
            return obj_conexion.executeSQL(cmd);
        }
        public int ActualizarMenu(object obj)
        {
            SqlCommand cmd = new SqlCommand();
            clsMenuModel menu = (BO.clsMenuModel)obj;
            cmd.CommandText = "EVENTOACT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Par_ID", SqlDbType.Int).Value = menu.Cls_MenuBo.Id;
            cmd.Parameters.Add("@Par_LUNES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Lunes;
            cmd.Parameters.Add("@Par_MARTES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Martes;
            cmd.Parameters.Add("@Par_MIERCOLES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Miercoles;
            cmd.Parameters.Add("@Par_JUEVES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Jueves;
            cmd.Parameters.Add("@Par_VIERNES", SqlDbType.VarChar).Value = menu.Cls_MenuBo.Viernes;
            cmd.Parameters.Add("@Par_FECHA_INI", SqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@Par_FECHA_FIN", SqlDbType.Date).Value = DateTime.Now.Date;
            return obj_conexion.executeSQL(cmd);
        }

        public int EliminarMenu(int Id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM MENU  WHERE ID = @Par_ID";
            cmd.Parameters.Add("@Par_ID", SqlDbType.Int).Value = Id;

            return obj_conexion.executeSQL(cmd);
        }


        public DataSet ConsutarMenu(object obj)
        {
            cls_MenuBO menu = (BO.cls_MenuBO)obj;
            obj_conexion = new cls_ConexionDAO();
            string sql;
            sql = "EVENTOCON";
            return obj_conexion.TablaDS(sql);
        }
        public List<cls_MenuBO> lista()
        {
            try
            {
                obj_conexion.conexionBD();
                obj_conexion.abrirCon();
                IList<cls_MenuBO> EmpList = SqlMapper.Query<cls_MenuBO>(
                                  obj_conexion.con, "EVENTOCON").ToList();
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