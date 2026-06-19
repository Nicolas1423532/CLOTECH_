using BE;
using SERVICIO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu_Principal : Form
    {
        BLL_Usuario usuarioBll;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void skyButton1_Click(object sender, EventArgs e)
        {
            Menu_Administracion menuAdmin = new Menu_Administracion();
            menuAdmin.Show();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            usuarioBll = new BLL_Usuario();
            BE_Familia rolActual = SERVICIO_SesionUsuario.ObtenerInstancia().FamiliaActual;
            BE_Usuario usuarioActual = SERVICIO_SesionUsuario.ObtenerInstancia().UsuarioActual;
            if (SERVICIO_SesionUsuario.ObtenerInstancia().FamiliaActual != null)
            {
                List<BE_Rol> patentes = SERVICIO_SesionUsuario.ObtenerInstancia().FamiliaActual.RetornarComponentes();
                ValidarPermisosUI(this.Controls, patentes);
            }
            dungeonHeaderLabel1.Text = $"Bienvenido: {usuarioActual.Nombre} {usuarioActual.Apellido}";
            //else
            //{
            //    // Bloqueo total por seguridad si no hay nadie logueado
            //    DeshabilitarTodoElSistema();
            //}
        }
        private void ValidarPermisosUI(Control.ControlCollection controles, List<BE_Rol> patentesUsuario)
        {
            foreach (Control c in controles)
            {
                // 1. Si el control tiene un Tag asignado, procedemos a validar
                if (c.Tag != null && !string.IsNullOrEmpty(c.Tag.ToString()))
                {
                    string patenteRequerida = c.Tag.ToString();

                    // 2. Buscamos mediante LINQ si alguna de las patentes del usuario coincide con el Tag
                    bool tieneAcceso = patentesUsuario.Any(p => p.Titulo == patenteRequerida);

                    // 3. Aplicamos la seguridad (podés usar .Enabled o .Visible según prefieras)
                    c.Visible = tieneAcceso;
                    // c.Visible = tieneAcceso; // Descomenta esta si preferís ocultar el botón por completo
                }

                //4.RECURSIVIDAD DE UI: Si el control es un contenedor(un Panel, GroupBox o TabControl),
                // volvemos a llamar al método para revisar los botones que están adentro de él.
                if (c.Controls.Count > 0)
                {
                    ValidarPermisosUI(c.Controls, patentesUsuario);
                }
            }
        }
        private void skyButton3_Click(object sender, EventArgs e)
        {
            Menu_Venta menuVenta = new Menu_Venta();
            menuVenta.Show();
        }
        private void skyButton4_Click(object sender, EventArgs e)
        {

        }
        private void skyButton6_Click(object sender, EventArgs e)
        {
            bool resultado = MessageBox.Show("¿Desea cerrar la sesion?", "Cierre de Sesión", MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
            usuarioBll.Log_Out(resultado);
            Application.Exit();
        }

        private void skyButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
