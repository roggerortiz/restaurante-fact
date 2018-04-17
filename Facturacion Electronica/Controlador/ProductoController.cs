using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class ProductoController : Controller
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT productos.*, categorias.nombre FROM productos INNER JOIN categorias on categorias.id = productos.categoria_id ORDER BY categorias.nombre ASC, productos.nombre ASC", this.Conexion);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Listar Productos: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return dt;
        }

        public Boolean Registrar(Producto producto)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("INSERT INTO productos(nombre, precio_costo, precio_venta, categoria_id) VALUES(@nombre, @precioCosto, @precioVenta, @categoriaId)", this.Conexion);
                command.Parameters.AddWithValue("@nombre", producto.Nombre);
                command.Parameters.AddWithValue("@precioCosto", producto.PrecioCosto);
                command.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@categoriaId", producto.CategoriaID);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Registrar Producto: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }

        public Boolean Actualizar(Producto producto)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("UPDATE productos SET nombre = @nombre, precio_costo = @precioCosto, precio_venta = @precioVenta, categoria_id = @categoriaId WHERE id = @id", this.Conexion);
                command.Parameters.AddWithValue("@id", producto.ID);
                command.Parameters.AddWithValue("@nombre", producto.Nombre);
                command.Parameters.AddWithValue("@precioCosto", producto.PrecioCosto);
                command.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@categoriaId", producto.CategoriaID);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Actualizar Producto: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }

        public Boolean Eliminar(Int32 id)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("DELETE FROM productos WHERE id = @id", this.Conexion);
                command.Parameters.AddWithValue("@id", id);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Eliminar Producto: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }
    }
}
