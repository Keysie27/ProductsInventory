using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class P_Login : Form
    {
        private static P_Login instancia;

        private P_Login()
        {
            InitializeComponent();
        }

        public static P_Login obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new P_Login();
            }

            return instancia;
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {

            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            N_Inventario login = new N_Inventario();
            string rol = login.N_login(usuario, contraseña);

            if (rol == "administrador" || rol == "general")
            {
                P_Inventario formInventario = new P_Inventario(rol, usuario);
                formInventario.Show();
                this.Hide();

                textBoxUsuario.Text = string.Empty;
                textBoxContraseña.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Información inválida.");
            }
        }
    }
}
