using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class BE_Patente
    {
        string? id_patente;
        string? titulo;
        bool estado;
        public string Id_patente { get => id_patente; set => id_patente = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
