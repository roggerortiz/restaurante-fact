using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ProductoController : Controller
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand("SELECT productos.*, categorias.nombre FROM productos INNER JOIN categorias on categorias.id = productos.categoria_id ORDER BY categorias.nombre ASC, productos.nombre ASC", this.Conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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

                SqlCommand command = new SqlCommand("INSERT INTO productos(nombre, precio_costo, precio_venta, categoria_id) VALUES(@nombre, @precioCosto, @precioVenta, @categoriaId)", this.Conexion);
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

                SqlCommand command = new SqlCommand("UPDATE productos SET nombre = @nombre, precio_costo = @precioCosto, precio_venta = @precioVenta, categoria_id = @categoriaId WHERE id = @id", this.Conexion);
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

                SqlCommand command = new SqlCommand("DELETE FROM productos WHERE id = @id", this.Conexion);
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
