using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIO
{
    public class SERVICIO_SesionUsuario
    {
        BE_Usuario? usuarioActual;
        BE_Familia? familiaActual;
        public BE_Usuario? UsuarioActual { get => usuarioActual; set => usuarioActual = value; }
        public BE_Familia? FamiliaActual { get => familiaActual; set => familiaActual = value; }
        static SERVICIO_SesionUsuario? _instancia;
        private SERVICIO_SesionUsuario() { }
        public static SERVICIO_SesionUsuario ObtenerInstancia()
        {
            if (_instancia == null) { _instancia = new SERVICIO_SesionUsuario(); }
            return _instancia;
        }
    }
}
