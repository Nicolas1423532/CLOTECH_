using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class BE_Familia
    {
        string? id_familia;
        string? titulo;
        bool estado;
        public string Id_familia { get => id_familia; set => id_familia = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
