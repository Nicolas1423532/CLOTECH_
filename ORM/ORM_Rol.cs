using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using BE;
namespace ORM
{
    public class ORM_Rol
    {
        DAO_ dao;
        public ORM_Rol()
        {
            dao = DAO_.ObtenerInstancia();
        }
            public void AgregarRol(BE_Rol rol)
            {
                DataRow fila = dao.DtRol.NewRow();
                fila.ItemArray = new object[] { rol.Id_rol, rol.Titulo, rol.Estado };
                dao.DtRol.Rows.Add(fila);
                dao.GuardarCambios();
            }
            public void ModificarRol(BE.BE_Rol rol)
            {
                DataRow fila = dao.DtRol.Rows.Find(rol.Id_rol);
                if (fila != null)
                {
                    fila.ItemArray = new object[] { fila.Field<string>(0), rol.Titulo, rol.Estado };
                    dao.GuardarCambios();
                }
            }
            public List<BE.BE_Rol> ObtenerTodosLosRoles()
            {
                List<BE.BE_Rol> lstRoles = new List<BE.BE_Rol>();
                foreach (DataRow fila in dao.DtRol.Rows)
                {
                    //lstRoles.Add(BE_Rol(fila.ItemArray));
                }
                return lstRoles;
        }
    }
}
