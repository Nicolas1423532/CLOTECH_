using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Familia : BE_Rol
    {
        string? id_familia;
        string? titulo;
        bool estado;
        List<BE_Rol> componentes = new List<BE_Rol>();
        List<BE_Rol> componentesAux;
        public string Id_familia { get => id_familia; set => id_familia = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public bool Estado { get => estado; set => estado = value; }
        //public void AgregarComponente(BE_Rol componente)
        //{
        //    componentes.Add(componente);
        //}
        public override List<BE_Rol> RetornarComponentes()
        {
            componentesAux = new List<BE_Rol>();
            ObtenerComponentesRecursivamente(componentes);
            return componentesAux;

        }
        private List<BE_Rol> RetornarListaComponentes()=> componentes;
        private void ObtenerComponentesRecursivamente(List<BE_Rol> lista)
        {
           foreach (BE_Rol componente in lista)
            {
                if (componente is BE_Patente patente)
                {
                    componentesAux.Add(patente);
                }
                else
                {
                    ObtenerComponentesRecursivamente((componente as BE_Familia).RetornarListaComponentes());
                }
            }
        }
        public BE_Familia() { }
        public BE_Familia(string idFamilia, string _titulo, bool _estado)
        {
            id_familia = idFamilia;
            titulo = _titulo;
            estado = _estado;
        }
        public BE_Familia(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), Convert.ToBoolean(datos[2]))
        { }
    }
}
