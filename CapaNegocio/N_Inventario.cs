using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Inventario
    {
        public string N_login(string usuario, string contraseña)
        {
            D_Inventario login = new D_Inventario();
            string rol = login.D_login(usuario, contraseña); ;

            return rol;
        }

        public DataTable N_listarProductos()
        {
            D_Inventario objDato = new D_Inventario();
            return objDato.D_listarProductos();
        }

        public void N_agregarProducto(E_Producto producto)
        {
            D_Inventario objDatos = new D_Inventario();
            objDatos.D_agregarProducto(producto);
        }

        public void N_eliminarProducto(int idProducto)
        {
            D_Inventario objDatos = new D_Inventario();
            objDatos.D_eliminarProducto(idProducto);
        }

        public void N_modificarProducto(int idProducto, E_Producto producto)
        {
            D_Inventario objDatos = new D_Inventario();
            objDatos.D_modificarProducto(idProducto, producto);
        }

        public DataTable N_seleccionarProducto(string nombre)
        {
            D_Inventario objDato = new D_Inventario();
            return objDato.D_seleccionarProducto(nombre);
        }

        public DataTable N_generarReporte()
        {
            D_Inventario objDato = new D_Inventario();
            return objDato.D_generarReporte();
        }
    }
}
