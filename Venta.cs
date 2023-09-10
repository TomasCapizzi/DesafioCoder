using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCoder
{
    public class Venta
    {
        public int Id { get; private set; }
        public int IdUsuario { get; private set; }
        public string Comentarios { get; set; }

        public Venta() { 
            Id = 0;
            IdUsuario = 0;
            Comentarios = string.Empty;
        }

        public Venta(int id, int idUsuario, string comentarios)
        {
            Id = id;
            IdUsuario = idUsuario;
            Comentarios = comentarios;
        }

    }
}
