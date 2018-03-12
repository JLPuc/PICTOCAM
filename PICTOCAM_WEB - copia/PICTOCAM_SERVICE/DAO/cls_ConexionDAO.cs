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
       public SqlConnection con;
        

        //Método para crear la conexión
        public SqlConnection conexionBD()
        {
            string sql = "Data source =.; Initial Catalog=PICTOCAM; Integrated Security=True";
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
        public int executeSQL(SqlCommand Command)
        {
            try
            {
                SqlCommand cmd = Command;
                cmd.Connection = conexionBD();
                abrirCon();
                int acuse = cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
            }
            finally
            {
                cerrarCon();
            }
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