using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PICTOCAM_SERVICE.DAO;
using PICTOCAM_WEB.Models;
using PICTOCAM_WEB.DAO;
using Dapper;


namespace PICTOCAM_SERVICE.DAO
{
    public class cls_MetodologiaDAO
    {
        cls_conexion objConexion;

        public cls_MetodologiaDAO()
        {
            objConexion = new cls_conexion();
        }
        public List<cls_Menu> Lista()
        {
            try
            {
                objConexion.conexionBD();
                objConexion.abrirCon();
                IList<cls_Menu> EmpList = SqlMapper.Query<cls_Menu>(
                    objConexion.con, "AQUI COLOCAR EL STORE DE LISTADOS").ToList();
                return EmpList.ToList();
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Agregar(cls_Metodología objetoMetodologia)
        {
            try
            {
                DynamicParameters objParameters = new DynamicParameters();
                objParameters.Add("@", objetoMetodologia.);
                objParameters.Add("@",objetoMetodologia .);
                objParameters.Add("@", objetoMetodologia.);
                objParameters.Add("@", objetoMetodologia.);
                objParameters.Add("@", objetoMetodologia.);

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}