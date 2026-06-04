using BE;
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
using ReaLTaiizor.Controls;
using Microsoft.VisualBasic;

namespace Vista
{
    public partial class Menu_Venta : Form
    {
        BLL_Cliente bllCliente;
        public Menu_Venta()
        {
            InitializeComponent();
        }

        private void Menu_Venta_Load(object sender, EventArgs e)
        {
            bllCliente = new BLL_Cliente();
            foreach (var  pD in this.Controls)
            {
                if (pD is ReaLTaiizor.Controls.PoisonDataGridView)
                {
                    (pD as ReaLTaiizor.Controls.PoisonDataGridView).MultiSelect = false;
                    (pD as ReaLTaiizor.Controls.PoisonDataGridView).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            Mostrar(poisonDataGridView1, bllCliente.ObtenerTodosLosClientes());
        }
        private void Mostrar(PoisonDataGridView pD, object datos)
        {
            pD.DataSource = null;
            pD.DataSource = datos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idCliente = Interaction.InputBox("Ingrese el ID del cliente");
            string nombre = Interaction.InputBox("Ingrese el nombre del cliente");
            string apellido = Interaction.InputBox("Ingrese el apellido del cliente");
            int dni = Convert.ToInt32(Interaction.InputBox("Ingrese el DNI del cliente"));

            BE_Cliente cliente = new BE_Cliente(idCliente, nombre, apellido, dni);
            bllCliente.AgregarCliente(cliente);
            Mostrar(poisonDataGridView1, bllCliente.ObtenerTodosLosClientes());
        }
    }
}
