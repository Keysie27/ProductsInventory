using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Inventario
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public string D_login(string usuario, string contraseña) 
        {
            string rol = null;

                conexion.Open();

                using (SqlCommand query = new SqlCommand("sp_login", conexion))
                {
                    query.CommandType = CommandType.StoredProcedure;

                    query.Parameters.AddWithValue("@usuario", usuario);
                    query.Parameters.AddWithValue("@contraseña", contraseña);

                DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query))
                    {
                        adapter.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        rol = dt.Rows[0]["rol"].ToString();
                    }

                conexion.Close();
            }

            return rol;
        }

        public DataTable D_listarProductos()
        {
            conexion.Open();

            SqlCommand query = new SqlCommand("sp_listarProductos", conexion);
            query.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(query);

            DataTable dt = new DataTable();
            da.Fill(dt);

            conexion.Close();

            return dt;
        }

        public void D_agregarProducto(E_Producto producto)
        {
            conexion.Open();

            SqlCommand query = new SqlCommand("sp_agregarProducto", conexion);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("@Nombre", producto.Nombre);
            query.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            query.Parameters.AddWithValue("@Precio", producto.Precio);
            query.Parameters.AddWithValue("@CantidadStock", producto.CantidadStock);

            query.ExecuteNonQuery();

            conexion.Close();
        }

        public void D_eliminarProducto(int idProducto)
        {
            conexion.Open();

            SqlCommand query = new SqlCommand("sp_eliminarProducto", conexion);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("@idProducto", idProducto);

            query.ExecuteNonQuery();

            conexion.Close();
        }

        public void D_modificarProducto(int idProducto, E_Producto producto)
        {
            conexion.Open();

            SqlCommand query = new SqlCommand("sp_modificarContacto", conexion);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("@idProducto", idProducto);
            query.Parameters.AddWithValue("@nombre", producto.Nombre);
            query.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            query.Parameters.AddWithValue("@precio", producto.Precio);
            query.Parameters.AddWithValue("@cantidadStock", producto.CantidadStock);

            query.ExecuteNonQuery();

            conexion.Close();
        }

        public DataTable D_seleccionarProducto(string nombre)
        {
            conexion.Open();

            SqlCommand query = new SqlCommand("sp_seleccionarProducto", conexion);
            query.CommandType = CommandType.StoredProcedure;
            query.Parameters.AddWithValue("@nombre", nombre);

            SqlDataAdapter da = new SqlDataAdapter(query);

            DataTable dt = new DataTable();
            da.Fill(dt);

            conexion.Close();

            return dt;
        }

        public DataTable D_generarReporte()
        {
            conexion.Open();

            SqlCommand query = new SqlCommand("sp_reporteStock", conexion);
            query.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(query);

            DataTable dt = new DataTable();
            da.Fill(dt);

            conexion.Close();

            return dt;
        }
    }
}
