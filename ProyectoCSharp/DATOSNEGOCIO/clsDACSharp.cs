using ProyectoCSharp.CONEXION;
using ProyectoCSharp.ENTIDADESNEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCSharp.DATOSNEGOCIO
{
    public class clsDACSharp
    {
        public bool tblProfesiones_Insertar(clsBEProfesiones ObjBEProfesiones)
        {
            try
            {
                clsConexion.Abrir();
                SqlCommand BD = new SqlCommand("spProfesiones_Insertar", clsConexion.Conectar);
                BD.CommandType = CommandType.StoredProcedure;
                BD.Parameters.AddWithValue("@Profesion", ObjBEProfesiones.Profesion);
                BD.Parameters.AddWithValue("@Sueldo", ObjBEProfesiones.Sueldo);
                BD.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public void tblProfesiones_Buscar(ref DataTable dt, string Buscador)
        {
            try
            {
                clsConexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("spProfesiones_Buscar", clsConexion.Conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscador", Buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public bool tblProfesiones_Editar(clsBEProfesiones ObjBEProfesiones)
        {
            try
            {
                clsConexion.Abrir();
                SqlCommand BD = new SqlCommand("spProfesiones_Editar", clsConexion.Conectar);
                BD.CommandType = CommandType.StoredProcedure;
                BD.Parameters.AddWithValue("@IDProfesion", ObjBEProfesiones.ID_Profesion);
                BD.Parameters.AddWithValue("@Profesion", ObjBEProfesiones.Profesion);
                BD.Parameters.AddWithValue("@Sueldo", ObjBEProfesiones.Sueldo);
                BD.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public bool tblUsuarios_Insertar(clsBEUsuarios ObjBEUsuarios)
        {
            try
            {
                clsConexion.Abrir();
                SqlCommand BD = new SqlCommand("spUsuarios_Insertar", clsConexion.Conectar);
                BD.CommandType = CommandType.StoredProcedure;
                BD.Parameters.AddWithValue("@Nombres", ObjBEUsuarios.Nombres);
                BD.Parameters.AddWithValue("@Apellidos", ObjBEUsuarios.Apellidos);
                BD.Parameters.AddWithValue("@Identificacion", ObjBEUsuarios.Identificacion);
                BD.Parameters.AddWithValue("@Pais", ObjBEUsuarios.Pais);
                BD.Parameters.AddWithValue("@IDProfesion", ObjBEUsuarios.ID_Profesion);
                BD.Parameters.AddWithValue("@Sueldo", ObjBEUsuarios.Sueldo);
                BD.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public void tblUsuarios_Mostrar(ref DataTable dt, int Desde, int Hasta)
        {
            try
            {
                clsConexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("spUsuarios_Mostrar", clsConexion.Conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", Desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public bool tblUsuarios_Eliminar(clsBEUsuarios ObjBEUsuarios) 
        {
            try
            {
                clsConexion.Abrir();
                SqlCommand BD = new SqlCommand("spUsuarios_Eliminar", clsConexion.Conectar);
                BD.CommandType = CommandType.StoredProcedure;
                BD.Parameters.AddWithValue("@IDUsuario", ObjBEUsuarios.ID_Usuario);
                BD.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public bool Usuarios_Restaurar(clsBEUsuarios ObjBEUsuarios)
        {
            try
            {
                clsConexion.Abrir();
                SqlCommand BD = new SqlCommand("spUsuarios_Restaurar", clsConexion.Conectar);
                BD.CommandType = CommandType.StoredProcedure;
                BD.Parameters.AddWithValue("@IDUsuario", ObjBEUsuarios.ID_Usuario);
                BD.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public bool tblUsuarios_Editar(clsBEUsuarios ObjBEUsuarios)
        {
            try
            {
                clsConexion.Abrir();
                SqlCommand BD = new SqlCommand("spUsuarios_Editar", clsConexion.Conectar);
                BD.CommandType = CommandType.StoredProcedure;
                BD.Parameters.AddWithValue("@IDUsuario", ObjBEUsuarios.ID_Usuario);
                BD.Parameters.AddWithValue("@Nombres", ObjBEUsuarios.Nombres);
                BD.Parameters.AddWithValue("@Apellidos", ObjBEUsuarios.Apellidos);
                BD.Parameters.AddWithValue("@Identificacion", ObjBEUsuarios.Identificacion);
                BD.Parameters.AddWithValue("@Pais", ObjBEUsuarios.Pais);
                BD.Parameters.AddWithValue("@IDProfesion", ObjBEUsuarios.ID_Profesion);
                BD.Parameters.AddWithValue("@Sueldo", ObjBEUsuarios.Sueldo);
                BD.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public void tblUsuarios_Contar(ref int Contador)
        {
            try
            {
                clsConexion.Abrir();
                SqlCommand BD = new SqlCommand("select COUNT(IDUsuario) from Usuarios", clsConexion.Conectar);
                Contador=Convert.ToInt32(BD.ExecuteScalar());
            }
            catch (Exception)
            {

                Contador = 0;
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
        public void tblUsuarios_Buscar(ref DataTable dt, int Desde, int Hasta, string Buscador)
        {
            try
            {
                clsConexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("spUsuarios_Buscar", clsConexion.Conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", Desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta);
                da.SelectCommand.Parameters.AddWithValue("@Buscador", Buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                clsConexion.Cerrar();
            }
        }
    }
}