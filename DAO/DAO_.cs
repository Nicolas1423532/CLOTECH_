using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAO_
    {
        SqlConnection conexion;
        DataSet ds;
        DataTable? dtUsuario, dtProducto, dtCliente, dtProveedor, dtFactura, dtDetalle, dtDevolucion, dtDevolucionDetalle, dtOrdenCompra, dtOrdenCompraDetalle, dtPerfil, dtPermiso, dtPermisoSimple, dtPermisoCompuesto;
        public DataTable DtUsuario { get => dtUsuario; set => dtUsuario = value; }
        public DataTable DtProducto { get => dtProducto; set => dtProducto = value; }
        public DataTable DtCliente { get => dtCliente; set => dtCliente = value; }
        public DataTable DtProveedor { get => dtProveedor; set => dtProveedor = value; }
        public DataTable DtFactura { get => dtFactura; set => dtFactura = value; }
        public DataTable DtDetalle { get => dtDetalle; set => dtDetalle = value; }
        SqlDataAdapter? adapUsuario, adapProducto, adapCliente, adapProveedor, adapFactura, adapDetalle, adapDevolucion, adapDevolucionDetalle, adapOrdenCompra, adapOrdenCompraDetalle, adapPerfil, adapPermiso, adapPermisoSimple, adapPermisoCompuesto;
        SqlCommandBuilder? cmbUsuario, cmbProducto, cmbCliente, cmbProveedor, cmbFactura, cmbDetalle, cmbDevolucion, cmbDevolucionDetalle, cmbOrdenCompra, cmbOrdenCompraDetalle, cmbPerfil, cmbPermiso, cmbPermisoSimple, cmbPermisoCompuesto;
        static DAO_? instancia;
        private DAO_()
        {
            ds = new DataSet();
            dtCliente = new DataTable("Cliente");
            dtUsuario = new DataTable("Usuario");
            dtProveedor = new DataTable("Proveedor");
            dtProducto = new DataTable("Producto");
            dtFactura = new DataTable("Factura");
            dtDetalle = new DataTable("Detalle");
            ds.Tables.AddRange(new DataTable[] { dtCliente, dtUsuario, dtProveedor, dtProducto, dtFactura, dtDetalle });
            conexion = new SqlConnection("Data Source=.;Initial Catalog=CLOTECH;Integrated Security=True;Trust Server Certificate=True");
            adapCliente = new SqlDataAdapter("SELECT * FROM Cliente", conexion);
            adapUsuario = new SqlDataAdapter("SELECT * FROM Usuario", conexion);
            adapProveedor = new SqlDataAdapter("SELECT * FROM Proveedor", conexion);
            adapProducto = new SqlDataAdapter("SELECT * FROM Producto", conexion);
            adapFactura = new SqlDataAdapter("SELECT * FROM Factura", conexion);
            adapDetalle = new SqlDataAdapter("SELECT * FROM Detalle", conexion);
            cmbCliente = new SqlCommandBuilder(adapCliente);
            cmbUsuario = new SqlCommandBuilder(adapUsuario);
            cmbProveedor = new SqlCommandBuilder(adapProveedor);
            cmbProducto = new SqlCommandBuilder(adapProducto);
            cmbFactura = new SqlCommandBuilder(adapFactura);
            cmbDetalle = new SqlCommandBuilder(adapDetalle);
            ActualizarTablas();
            dtCliente.PrimaryKey = new DataColumn[] { dtCliente.Columns[0] };
            dtUsuario.PrimaryKey = new DataColumn[] { dtUsuario.Columns[0] };
            dtProveedor.PrimaryKey = new DataColumn[] { dtProveedor.Columns[0] };
            dtProducto.PrimaryKey = new DataColumn[] { dtProducto.Columns[0] };
            dtFactura.PrimaryKey = new DataColumn[] { dtFactura.Columns[0] };
            dtDetalle.PrimaryKey = new DataColumn[] { dtDetalle.Columns[0] };

        }
        private void ActualizarTablas()
        {
            adapCliente.Fill(dtCliente);
            adapUsuario.Fill(dtUsuario);
            adapProveedor.Fill(dtProveedor);
            adapProducto.Fill(dtProducto);
            adapFactura.Fill(dtFactura);
            adapDetalle.Fill(dtDetalle);
        }
        public void GuardarCambios()
        {
            adapCliente.Update(dtCliente);
            adapUsuario.Update(dtUsuario);
            adapProveedor.Update(dtProveedor);
            adapProducto.Update(dtProducto);
            adapFactura.Update(dtFactura);
            adapDetalle.Update(dtDetalle);
        }
        public static DAO_ ObtenerInstancia()
        {
            if (instancia == null) { instancia = new DAO_(); }
            return instancia;
        }
    }
}
