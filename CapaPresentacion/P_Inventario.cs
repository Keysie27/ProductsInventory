using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Inventario : Form
    {
        public int idProducto = 0;
        public string rol = string.Empty;
        public string usuario = string.Empty;

        public P_Inventario(string rol, string usuario)
        {
            InitializeComponent();
            P_listarProductos();
            this.rol = rol;
            this.usuario = usuario;

            switch (rol)
            {
                case "administrador":
                    buttonModificar.Enabled = true;
                    buttonEliminar.Enabled = true;
                    break;
                case "general":
                    buttonModificar.Enabled = false;
                    buttonEliminar.Enabled = false;
                break;
            }
        }

        public void P_listarProductos()
        {
            N_Inventario objNegocio = new N_Inventario();

            DataTable dt = objNegocio.N_listarProductos();
            dataGridViewProductos.DataSource = dt;
        }

        public void P_limpiar()
        {
            textBoxNombre.Text = string.Empty;
            textBoxDescripcion.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            textBoxCantidadStock.Text = string.Empty;
            textBoxBuscarProducto.Text = string.Empty;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            E_Producto producto = new E_Producto();
            producto.Nombre = textBoxNombre.Text;
            producto.Descripcion = textBoxDescripcion.Text;
            producto.Precio = float.Parse(textBoxPrecio.Text);
            producto.CantidadStock = int.Parse(textBoxCantidadStock.Text);

            N_Inventario objNegocio = new N_Inventario();
            objNegocio.N_agregarProducto(producto);

            P_listarProductos();

            P_limpiar();

            MessageBox.Show("Producto agregado.");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                N_Inventario objNegocio = new N_Inventario();
                objNegocio.N_eliminarProducto(idProducto);

                P_listarProductos();

                P_limpiar();

                MessageBox.Show("Producto eliminado.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Producto no eliminado.", "Eliminación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                idProducto = Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["idProducto"].Value);
                string nombre = dataGridViewProductos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                string descripcion = dataGridViewProductos.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                string precio = dataGridViewProductos.Rows[e.RowIndex].Cells["precio"].Value.ToString();
                string cantidadStock = dataGridViewProductos.Rows[e.RowIndex].Cells["cantidadStock"].Value.ToString();

                textBoxNombre.Text = nombre;
                textBoxDescripcion.Text = descripcion;
                textBoxPrecio.Text = precio;
                textBoxCantidadStock.Text = cantidadStock;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            P_limpiar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar este producto?", "Confirmación de Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                E_Producto producto = new E_Producto();
                producto.Nombre = textBoxNombre.Text;
                producto.Descripcion = textBoxDescripcion.Text;
                producto.Precio = float.Parse(textBoxPrecio.Text);
                producto.CantidadStock = int.Parse(textBoxCantidadStock.Text);

                N_Inventario objNegocio = new N_Inventario();
                objNegocio.N_modificarProducto(idProducto, producto);

                P_listarProductos();

                P_limpiar();

                MessageBox.Show("Producto modificado.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Producto no modificado.", "Modificación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBoxBuscarProducto.Text;

            N_Inventario objNegocio = new N_Inventario();

            DataTable dt = objNegocio.N_seleccionarProducto(nombre);
            dataGridViewProductos.DataSource = dt;
        }

        private void buttonGenerarReporte_Click(object sender, EventArgs e)
        {
            P_Reporte formReporte = new P_Reporte(usuario);

            formReporte.Show();
        }

        private void P_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            P_Login.obtenerInstancia().Show();
        }
    }
}
