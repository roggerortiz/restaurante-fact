using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using MySql.Data.MySqlClient;
using System.Data;
using InitialDLL;
using LogDLL;
using ISGStructures;

namespace Controlador
{
    public class MesaController : Controller
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT mesas.* FROM mesas ORDER BY mesas.numero ASC", this.Conexion);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Listar Mesas:" + ex);

                //Console.WriteLine("Error al Listar Mesas: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return dt;
        }

        public Int32 Cantidad()
        {
            Int32 cantidad = 0;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("SELECT COUNT(mesas.id) FROM mesas", this.Conexion);
                cantidad = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Cantidad Mesas:" + ex);

                //Console.WriteLine("Error al Obtener la Cantidad de Mesas: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return cantidad;
        }

        public Boolean Actualizar(Int32 numero, String estado)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("UPDATE mesas SET estado = @estado WHERE numero = @numero", this.Conexion);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@estado", estado);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Actualizar Mesas:" + ex);

                //Console.WriteLine("Error al Actualizar Mesa: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }

        public Int32 Libres()
        {
            Int32 libres = 0;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("SELECT COUNT(mesas.id) FROM mesas WHERE mesas.estado = 'Libre'", this.Conexion);
                libres = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Mesas Libres:" + ex);

                //Console.WriteLine("Error al Obtener la Cantidad de Mesas: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return libres;
        }

        public Int32 Ocupadas()
        {
            Int32 ocupadas = 0;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("SELECT COUNT(mesas.id) FROM mesas WHERE mesas.estado = 'Ocupada'", this.Conexion);
                ocupadas = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Mesas Ocupadas:" + ex);

                //Console.WriteLine("Error al Obtener la Cantidad de Mesas: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return ocupadas;
        }

        public Int32 Reservadas()
        {
            Int32 reservadas = 0;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("SELECT COUNT(mesas.id) FROM mesas WHERE mesas.estado = 'Reservada'", this.Conexion);
                reservadas = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Mesas Reservadas:" + ex);

                //Console.WriteLine("Error al Obtener la Cantidad de Mesas: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return reservadas;
        }

        public Boolean Registrar(Mesa mesa)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("INSERT INTO mesas(numero) VALUES(@numero)", this.Conexion);
                command.Parameters.AddWithValue("@numero", mesa.Numero);
                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Registrar Mesas:" + ex);

                //Console.WriteLine("Error al Registrar Mesa: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }

        public Boolean EliminarVarias(Int32 numero)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("DELETE FROM mesas WHERE numero >= @numero", this.Conexion);
                command.Parameters.AddWithValue("@numero", numero);
                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Eliminar Mesas:" + ex);

                //Console.WriteLine("Error al Registrar Mesa: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }
    }
}
