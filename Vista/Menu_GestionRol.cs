using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using ReaLTaiizor.Controls;

namespace Vista
{
    public partial class Menu_GestionRol : Form
    {
        BLL_Usuario usuarioBll;
        public Menu_GestionRol()
        {
            InitializeComponent();
        }

        private void Menu_GestionRol_Load(object sender, EventArgs e)
        {
            usuarioBll = new BLL_Usuario();
            Mostrar(poisonDataGridView1, usuarioBll.ObtenerTodosLosUsuarios());
        }
        private void Mostrar(PoisonDataGridView pDv, object datos)
        {
            pDv.DataSource = null; pDv.DataSource = datos;
        }
    }
}
