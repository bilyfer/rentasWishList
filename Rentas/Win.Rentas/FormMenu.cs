using System;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: "
                    + Program.UsuarioLogueado.Nombre;

                if (Program.UsuarioLogueado.TipoUsuario == "Usuarios caja")
                {
                    productosToolStripMenuItem.Visible = false;
                    clientesToolStripMenuItem.Visible = false;
                    rentarToolStripMenuItem.Visible = true;
                    facturaToolStripMenuItem.Visible = true;
                    administracionDeUsuariosToolStripMenuItem.Visible = false;
                    reporteDeProductosToolStripMenuItem.Visible = false;
                    reporteDeClientesToolStripMenuItem.Visible = false;
                    reporteDeRentasToolStripMenuItem.Visible = true;
                    reporteDeFacturasToolStripMenuItem.Visible = true;
                }

                if (Program.UsuarioLogueado.TipoUsuario == "Usuarios Ventas")
                {
                    productosToolStripMenuItem.Visible = false;
                    clientesToolStripMenuItem.Visible = true;
                    rentarToolStripMenuItem.Visible = false;
                    facturaToolStripMenuItem.Visible = false;
                    administracionDeUsuariosToolStripMenuItem.Visible = false;
                    reporteDeProductosToolStripMenuItem.Visible = false;
                    reporteDeClientesToolStripMenuItem.Visible = true;
                    reporteDeRentasToolStripMenuItem.Visible = false;
                    reporteDeFacturasToolStripMenuItem.Visible = false;
                }

                if (Program.UsuarioLogueado.TipoUsuario == "Administradores")
                {
                    productosToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    rentarToolStripMenuItem.Visible = true;
                    facturaToolStripMenuItem.Visible = true;
                    administracionDeUsuariosToolStripMenuItem.Visible = true;
                    reporteDeProductosToolStripMenuItem.Visible = true;
                    reporteDeClientesToolStripMenuItem.Visible = true;
                    reporteDeRentasToolStripMenuItem.Visible = true;
                    reporteDeFacturasToolStripMenuItem.Visible = true;
                }

            } else
            {
                Application.Exit();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRentas = new FormRentas();
            formRentas.MdiParent = this;
            formRentas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }

        private void administracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUsuarios();
            form.MdiParent = this;
            form.Show();
        }
    }
}
