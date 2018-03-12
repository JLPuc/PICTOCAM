using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PICTOCAM_WEB.DAO;
using PICTOCAM_WEB.Models;
using Dapper;

namespace PICTOCAM_WEB.DAO
{
    public class MenuDAO
    {
        cls_conexion objConexion;
        public MenuDAO()
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
                    objConexion.con, "").ToList();
                return EmpList.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Agregar(cls_Menu objetoMenu)
        {
            try
            {
                DynamicParameters objParameters = new DynamicParameters();
                objParameters.Add("@LUNES",objetoMenu.Lunes);
                objParameters.Add("@MARTES", objetoMenu.Martes);
                objParameters.Add("MIERCOLES", objetoMenu.Miercoles);
                objParameters.Add("@JUEVES", objetoMenu.Jueves);
                objParameters.Add("@VIERNES", objetoMenu.Viernes);
                objParameters.Add("@FECHA_INI",objetoMenu.Fecha_ini);
                objParameters.Add("@FECHA_FIN", objetoMenu.Fecha_fin);
                objParameters.Add("@USUARIO", objetoMenu.Usuario);

                objConexion.conexionBD();
                objConexion.con.Execute("SENTENCI DE PROCEDURE", objParameters,commandType: CommandType.StoredProcedure);
                objConexion.cerrarCon();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Actualizar(cls_Menu objetomenu)
        {
            try
            {
                DynamicParameters objetoparameters = new DynamicParameters();
                objetoparameters.Add("ID",objetomenu.Id);
                objetoparameters.Add("@MARTES", objetomenu.Martes);
                objetoparameters.Add("MIERCOLES", objetomenu.Miercoles);
                objetoparameters.Add("@JUEVES", objetomenu.Jueves);
                objetoparameters.Add("@VIERNES", objetomenu.Viernes);
                objetoparameters.Add("@FECHA_INI", objetomenu.Fecha_ini);
                objetoparameters.Add("@FECHA_FIN",objetomenu.Fecha_fin);
                objetoparameters.Add("@USUARIO", objetomenu.Usuario);


                objConexion.conexionBD();
                objConexion.con.Execute("SENTENCI DE PROCEDURE", objetoparameters, commandType: CommandType.StoredProcedure);
                objConexion.cerrarCon();



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Eliminar(int id)
        {

            try
            {

                DynamicParameters objetoparametro = new DynamicParameters();
                objetoparametro.Add("ID", id);
                objConexion.conexionBD();
                objConexion.abrirCon();
                objConexion.con.Execute("ELIMINAR--store", objetoparametro, commandType: CommandType.StoredProcedure);
                objConexion.cerrarCon();
                return true;

            }
            catch (Exception)
            {

                //Log error as per your need 
                throw;
            }


        }

    }
}