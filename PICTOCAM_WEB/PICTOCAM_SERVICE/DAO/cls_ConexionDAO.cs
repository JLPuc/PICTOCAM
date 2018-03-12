using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PICTOCAM_SERVICE.DAO
{

    public class cls_ConexionDAO
    {
        //Variable para la conexión a la BD
        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommand cmd;
        DataSet dts;

        //Método para crear la conexión
        public SqlConnection conexionBD()
        {
            string sql = "Data source =LAPTOP-CU6A815G; Initial Catalog=PICTOCAM; User ID=sa;Password=123456";
            // string sql = "Server=tcp:pictocam.database.windows.net,1433;Initial Catalog=PICTOCAM;Persist Security Info=False;User ID=cam_admin;Password=Ultragointer23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return con = new SqlConnection(sql);
        }

        //Método para abrir la conexión
        public void abrirCon()
        {
            con.Open();
        }

        //Método para cerrar la conexión
        public void cerrarCon()
        {
            con.Close();
        }

        //Método para ejecutar comandos
        public int executeSQL(string comando)
        {
            string comm = comando;

            adp = new SqlDataAdapter();
            cmd = new SqlCommand();
            cmd.Connection = conexionBD();
            abrirCon();
            cmd.CommandText = comm;

            int id = cmd.ExecuteNonQuery();
            cerrarCon();

            if (id <= 0)
            {
                return 0;
            }
            return 1;
        }

        /*Método para llenar una tabla virtual con consultas
         * 
         * 
         * Inserte el código aquí
         * 
         */

        public DataSet TablaDS(string sql)
        {
            SqlDataAdapter dat = new SqlDataAdapter(sql, conexionBD());
            DataSet TablaNueva = new DataSet();
            dat.Fill(TablaNueva);
            return TablaNueva;
        }
    }
}