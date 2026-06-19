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
        public void ModificarRol(BE_Rol rol)
        {
            DataRow fila = dao.DtRol.Rows.Find(rol.Id_rol);
            if (fila != null)
            {
                fila.ItemArray = new object[] { fila.Field<string>(0), rol.Titulo, rol.Estado };
                dao.GuardarCambios();
            }
        }
        public BE_Familia ObtenerRolDelUsuario(string rolUsuario)
        {
            List<BE_Rol> lstFamilia = new List<BE_Rol>();
            DataRow filaRol = dao.DtRol.AsEnumerable().FirstOrDefault(fila => fila.Field<string>(1) == rolUsuario);
            BE_Familia familiaRaiz = null;

            DataRow[] filasRolXFamilia = filaRol.GetChildRows(dao.RelRolAFamilia);

            foreach (DataRow filaRolXFamilia in filasRolXFamilia)
            {
                string idFamilia = filaRolXFamilia.Field<string>(2);
                DataRow? filaFamilia = dao.DtFamilia.Rows.Find(idFamilia);
                //bool resultado = familiaRaiz.RetornarComponentes().Any(c=>c.Id_rol == idFamilia);
                if (filaFamilia != null/* && resultado != true*/)
                {
                    BE_Familia familia = new BE_Familia(filaFamilia.ItemArray);
                    ArmarHijosRecursivamente(familia, filaFamilia);
                    if (familiaRaiz == null)
                    {
                        familiaRaiz = familia;
                    }
                    else
                    {
                        familiaRaiz.AgregarComponente(familia);
                    }
                }
            }
            return familiaRaiz;
        }
        private void ArmarHijosRecursivamente(BE_Familia padre, DataRow filaFamilia)
        {
            DataRow[] filasPatenteXFamilia = filaFamilia.GetChildRows(dao.RelFamiliaAPatente);

                foreach (DataRow filaPatenteXFamilia in filasPatenteXFamilia)
                {
                    string idPatente = filaPatenteXFamilia.Field<string>(1);

                    DataRow? filaPatente = dao.DtPatente.Rows.Find(idPatente);
                    if (filaPatente != null)
                    {
                        BE_Patente patente = new BE_Patente(filaPatente.ItemArray);
                        padre.AgregarComponente(patente);
                    }
                }
                DataRow[] filasSubFamiliaXFamilia = filaFamilia.GetChildRows(dao.RelFamiliaPadre_A_SubFamilia);

            foreach (DataRow filaSubFamiliaXFamilia in filasSubFamiliaXFamilia)
            {
                string idSubFamilia = filaSubFamiliaXFamilia.Field<string>(2);
                DataRow? filaSubFamilia = dao.DtFamilia.Rows.Find(idSubFamilia);
                if (filaSubFamilia != null)
                {
                    BE_Familia subFamilia = new BE_Familia(filaSubFamilia.ItemArray);
                    ArmarHijosRecursivamente(subFamilia, filaSubFamilia);
                    padre.AgregarComponente(subFamilia);
                }
            }
        }
    }
}
