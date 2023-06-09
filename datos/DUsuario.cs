﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using Asistencias.logica;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using Asistencias.presentacion;

namespace Asistencias.datos
{
    public class DUsuario
    {
        public bool insertarUsuario(LUsuario parametros)
        {
			try
			{

                CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("insertarUsuario", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", parametros.nombres);
				cmd.Parameters.AddWithValue("@login", parametros.login);
				cmd.Parameters.AddWithValue("@password",parametros.password);
				cmd.Parameters.AddWithValue("@icono", parametros.icono);
				cmd.Parameters.AddWithValue("@estado","ACTIVO");
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex )
			{
				MessageBox.Show( ex.Message );
				Console.WriteLine( ex.Message );
				return false;
				
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
        }
		public void mostrarUsuarios(ref DataTable dt)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlDataAdapter da = new SqlDataAdapter("Select * from Usuario", CONEXIONMAESTRA.conexionDB);
				da.Fill(dt);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace );
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();

			}
		}
        
		public void obtenerIdUsuario(ref int idUsuario,string login)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("obtenerIdUsuario",CONEXIONMAESTRA.conexionDB);
				cmd.CommandType=CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Login",login);
				idUsuario =Convert.ToInt32( cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
		public void verificarUsuarios(ref string indicador)
		{
			try
			{
				int IdUser;
				CONEXIONMAESTRA.abrir();
				SqlCommand da = new SqlCommand("Select idUsuario from Usuario", CONEXIONMAESTRA.conexionDB);
				IdUser = Convert.ToInt32(da.ExecuteScalar());
				CONEXIONMAESTRA.cerrar();
				indicador = "Correcto";
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
				MessageBox.Show(ex.StackTrace);
				indicador = "Incorrecto";
			}
		}

		public void validarUsuarios(LUsuario parametros,ref int id)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("validarUsuario", CONEXIONMAESTRA.conexionDB);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Password ", parametros.password);
				cmd.Parameters.AddWithValue("@Login", parametros.login);
				id= Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				id = 0;
				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
            }
		}
        public bool editar_Usuarios(LUsuario parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_Usuarios", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.idUsuario);
                cmd.Parameters.AddWithValue("@NombresApellidos", parametros.nombres);
                cmd.Parameters.AddWithValue("@Login", parametros.login);
                cmd.Parameters.AddWithValue("@Password", parametros.password);
                cmd.Parameters.AddWithValue("@Icono", parametros.icono);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public bool restaurar_Usuario(LUsuario parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_usuario", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.idUsuario);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public bool eliminarUsuarios(LUsuario parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_usuarios", CONEXIONMAESTRA.conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", parametros.idUsuario);
                cmd.Parameters.AddWithValue("@login", parametros.login);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public void buscarUsuarios(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarUsuarios", CONEXIONMAESTRA.conexionDB);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
