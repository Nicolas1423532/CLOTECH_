using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using ORM;
using SERVICIO;
namespace BLL
{
    public class BLL_Usuario
    {
        ORM_Usuario ormUsuario;
        public BLL_Usuario()
        {
            ormUsuario = new ORM_Usuario();
        }
        public void AgregarUsuario(BE_Usuario usuario)
        {
            ormUsuario.AgregarUsuario(usuario);
        }
        public void ModificarUsuario(BE_Usuario usuario)
        {
            ormUsuario.ModificarUsuario(usuario);
        }
        public List<object> ObtenerTodosLosUsuarios()
        {
            return (from u in ormUsuario.ObtenerTodosLosUsuarios()
                    select new
                    {
                        Id_usuario = u.Id_usuario,
                        Nombre = u.Nombre,
                        Apellido = u.Apellido,
                        Dni = u.Dni,
                        Edad = u.Edad,
                        Email = u.Email,
                        Contraseña = u.Contraseña,
                        Rol = u.Rol,
                        Activo = u.Activo
                    }).ToList<object>();
        }
        public bool Log_In(string email, string contraseña)
        {
            bool resultado = false;
            if (string.IsNullOrEmpty(contraseña)) { throw new Exception("El texto a cifrar no puede ser nulo o vacío."); }
            BE_Usuario usuario = ormUsuario.ObtenerUsuarioPorEmail(email);
            string contraseñaEncriptada = SERVICIO_Criptografia.Encriptar(contraseña);
            if(usuario.Contraseña == contraseñaEncriptada)
            {
                SERVICIO_SesionUsuario.ObtenerInstancia().UsuarioActual = usuario;
                resultado = true;
            }
            return resultado;
        }
    }
}
