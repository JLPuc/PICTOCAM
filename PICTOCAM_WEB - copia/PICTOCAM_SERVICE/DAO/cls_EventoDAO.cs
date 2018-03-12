using PICTOCAM_SERVICE.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PICTOCAM_SERVICE.Services;
using Dapper;

namespace PICTOCAM_SERVICE.DAO
{
    public class cls_EventoDAO
    {
        cls_ConexionDAO obj_conexion = new cls_ConexionDAO();

        public int AgregarEvento(object obj)
        {
            SqlCommand cmd = new SqlCommand();
            clsEventosModel evento = (BO.clsEventosModel)obj;
            cmd.CommandText = "EVENTOALT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Par_IMAGEN", SqlDbType.VarChar).Value = "imagen";
            cmd.Parameters.Add("@Par_TITULO", SqlDbType.VarChar).Value = evento.Cls_EventoBo.Titulo;
            cmd.Parameters.Add("@Par_DESCRIPCION", SqlDbType.VarChar).Value = evento.Cls_EventoBo.Descripcion;
            cmd.Parameters.Add("@Par_CONTENIDO", SqlDbType.VarChar).Value = evento.Cls_EventoBo.Contenido;
            cmd.Parameters.Add("@Par_FECHA", SqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@Par_HORA", SqlDbType.Time).Value = DateTime.Now.TimeOfDay;
            cmd.Parameters.Add("@Par_TIPO", SqlDbType.Int).Value = evento.Cls_EventoBo.Tipo;
            cmd.Parameters.Add("@Par_USUARIO", SqlDbType.VarChar).Value = "kiara10@outlook.com";
            return obj_conexion.executeSQL(cmd);
        }

        public int ActualizarEvento(object obj)
        {
            SqlCommand cmd = new SqlCommand();
            clsEventosModel evento = (BO.clsEventosModel)obj;
            cmd.CommandText = "EVENTOACT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Par_ID", SqlDbType.Int).Value = evento.Cls_EventoBo.Id;
            cmd.Parameters.Add("@Par_IMAGEN", SqlDbType.VarChar).Value = "imagen";
            cmd.Parameters.Add("@Par_TITULO", SqlDbType.VarChar).Value = evento.Cls_EventoBo.Titulo;
            cmd.Parameters.Add("@Par_DESCRIPCION", SqlDbType.VarChar).Value = evento.Cls_EventoBo.Descripcion;
            cmd.Parameters.Add("@Par_CONTENIDO", SqlDbType.VarChar).Value = evento.Cls_EventoBo.Contenido;
            cmd.Parameters.Add("@Par_FECHA", SqlDbType.DateTime).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@Par_HORA", SqlDbType.Time).Value = DateTime.Now.TimeOfDay;
            cmd.Parameters.Add("@Par_TIPO", SqlDbType.Int).Value = evento.Cls_EventoBo.Tipo;
            return obj_conexion.executeSQL(cmd);


        }

        public int EliminarEvento(int Id)
        {
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "DELETE FROM EVENTO  WHERE ID = @Par_ID";
            cmd.Parameters.Add("@Par_ID", SqlDbType.Int).Value = Id;
            
            return obj_conexion.executeSQL(cmd);
        }

        public DataSet ConsutarEventos(object obj)
        {
            cls_EventoBO evento = (BO.cls_EventoBO)obj;
            obj_conexion = new cls_ConexionDAO();
            string sql;
            sql = "EXEC EVENTOCON 8";
            return obj_conexion.TablaDS(sql);
        }

        //public DataTable Eventos()
        //{
        //    cls_EventoBO evento = (BO.cls_EventoBO)obj;
        //    obj_conexion = new cls_ConexionDAO();
        //    string sql = "select *from EVENTO";
        //    SqlDataAdapter mostar = new SqlDataAdapter(sql, obj_conexion.conexionBD());
        //    DataTable tablavirtual = new DataTable();
        //    mostar.Fill(tablavirtual);
        //    return tablavirtual;
      

        //}

        public List<cls_EventoBO> lista()
        {
            try
            {
                obj_conexion.conexionBD();
                obj_conexion.abrirCon();
                IList<cls_EventoBO> EmpList = SqlMapper.Query<cls_EventoBO>(
                                  obj_conexion.con, "EVENTOO").ToList();
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